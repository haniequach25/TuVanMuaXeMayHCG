using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuVanMuaXeMayHCG.BUS;
using TuVanMuaXeMayHCG.DTO;

namespace TuVanMuaXeMayHCG.Utilities
{
    class ForwardChainingUtil
    {
        /// <summary>
        /// Phuong thuc suy dien tien: Tra ve bien trung gian( cac su kien da duoc suy dien)
        /// </summary>
        /// <param name="SAT"></param>
        /// <param name="rulesCopy"></param>
        /// <param name="rules"></param>
        /// <param name="mediate"></param>
        /// <returns>mediate</returns>
        private static List<string> ForwardChaining(Queue<int> SAT, List<LuatDTO> rulesCopy, List<LuatDTO> rules, List<string> mediate)
        {
            FilterSAT(SAT, rulesCopy, mediate);
            //Duyet SAT cho den khi tap SAT rong
            while (SAT.Count != 0)
            {
                // Xet rule dau tien trong tap SAT
                // Lay ra ruleId va xoa khoi hang doi
                var ruleId = SAT.Dequeue();
                // Tim rule theo ruleid
                LuatDTO rule = rules.Find(item => item.Code == ruleId);
                // Neu khong tim duoc rule thì bo qu vong lap nay
                if (rule == null) continue;
                // Them su kien vao bien trung gian
                mediate.Add(rule.RRight);
                // Tim SAT
                FilterSAT(SAT, rulesCopy, mediate);

                if (rulesCopy.Count == 0) break;
            }
            return mediate;
        }

        /// <summary>
        /// Phuong thuc tra ve ket qua cua <b>suy dien tien</b> voi dau vao
        /// la danh sach gia thiet (assumptions)<br/>
        /// <i>Ngay cap nhat : 18/04/2021</i>
        /// </summary>
        /// <param name="assumptions"></param>
        /// <returns></returns>
        public static List<XeDTO> Result(List<string> assumptions)
        {
            // Ket qua
            var result = new List<XeDTO>();
            // Lay tat ca cac luat trong database va toi uu hoa tap luat
            List<LuatDTO> rules = OptimizeRule(LuatBUS.FindAll());

            List<LuatDTO> rulesCopy = new List<LuatDTO>(rules);
            // Lay tat ca cac doi tuong mobile trong database
            var xes = XeBUS.FindAll();
            //-----------------------------------------------------------------------------------------
            //Buoc 1: Gan trung gian bang gia thiet
            List<string> mediate = assumptions;

            //Buoc 2: THuc hien suy dien 
            Queue<int> SAT = new Queue<int>();
            mediate = ForwardChaining(SAT, rulesCopy, rules, mediate);

            //Buoc 3: Kiem tra neu bien trung gian co chua xe thi them vao ket qua
            xes.ForEach(xe =>
            {
                if (mediate.Contains(xe.Code))
                {
                    result.Add(xe);
                }
            });
            return result;
        }

        /// <summary>
        /// Phuong thuc <b>tim tap SAT</b> trong tap luat : <br/>
        /// Tat ca cac su kien trong ve trai cua luat nao thuoc tap trung gian thi se them luat do vao SAT.<br/>
        /// <i>Ngay cap nhat : 18/04/2021</i>
        /// </summary>
        /// <param name="rules"></param>
        /// <param name="mediate"></param>
        /// <returns></returns>
        private static void FilterSAT(Queue<int> SAT, List<LuatDTO> rules, List<string> mediate)
        {
            //var result = new Queue<int>();
            // Tim cac luat tu cuoi 
            for (int i = rules.Count - 1; i >= 0; i--)
            {
                var rule = rules[i];
                // Bien kiem tra xem cac su kien trong luat thu i co nam trong bien trung gian hay khong
                bool isContainAll = true;

                foreach (string left in rule.RLeft)
                {
                    if (!mediate.Contains(left))
                    {
                        isContainAll = false;
                        break;
                    }
                }
                // Neu tat ca su kien cua luat deu nam trong bien trung gian thi them luat day vao SAT
                // Dong thoi xoa luat day khoi tap luat
                if (isContainAll)
                {
                    SAT.Enqueue(rule.Code);
                    rules.Remove(rule);
                }
            }
            //return SAT;
        }




        /// <summary>
        /// Phuong thuc <b>toi uu hoa tap luat</b><br/>
        /// <i>Ngay cap nhat : 18/04/2021</i>
        /// </summary>
        /// <param name="rules"></param>
        /// <returns></returns>
        public static List<LuatDTO> OptimizeRule(List<LuatDTO> rules)
        {
            // Loai bo luat du thua
            RemoveRuleRedundant(rules);
            //Loai bo su kien du thua
            RemoveEventRedundant(rules);
            return rules;
        }

        /// <summary>
        /// Phuong thuc <b>xoa su kien du thua</b> trong tap luat: <br/>
        /// Phuong thuc nay se xoa su kien du thua trong tap luat(xet nhưng luat co 2 su lien tro len).
        /// </summary>
        /// <param name="rules"></param>
        private static void RemoveEventRedundant(List<LuatDTO> rules)
        {
            int i = 0;
            var checkRuleTemp = new LuatDTO();
            var SAT = new Queue<int>();
            var rulesCopy = new List<LuatDTO>();
            var mediate = new List<string>();
            // Xet tung luat trong tap luat
            while (i < rules.Count)
            {
                // Buoc 1: Bo qua nhung luat co 1 su kien
                if (rules[i].RLeft.Length == 1)
                {
                    i++;
                    continue;
                }
                rulesCopy.AddRange(rules);
                // Buoc 2: Xet tung luat trong tap luat
                string[] checkRuleLeft = (string[])rules[i].RLeft;

                // Buoc 3: Xet tung su kien trong luat dang xet
                foreach (string eventLeft in checkRuleLeft)
                {
                    // Buoc 3.1: Xoa su kien dang xet ra khoi luat do ta duoc luat moi
                    //checkRuleTemp = rules[i];
                    // Xoa su kien ra khoi rule
                    rules[i].RLeft = rules[i].RLeft.Where(e => e != eventLeft).ToArray();

                    // Buoc 3.2: Thuc hien suy dien tien den khi SAT rong
                    mediate.AddRange(rules[i].RLeft);
                    mediate = ForwardChaining(SAT, rulesCopy, rules, mediate);

                    // Buoc 3.3: Trong ket qua suy dien tien
                    if (!mediate.Contains(eventLeft))
                    {
                        rules[i].RLeft = Append(rules[i].RLeft, eventLeft);
                    }
                    SAT.Clear();
                    mediate.Clear();
                    rulesCopy.Clear();
                }
                i++;
            }
        }

        /// <summary>
        /// Phuong thuc them mot phan tu vao mang(string) mot chieu
        /// </summary>
        /// <param name="array"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        private static string[] Append(string[] array, string item)
        {
            if (array == null)
            {
                return new string[] { item };
            }
            string[] result = new string[array.Length + 1];
            array.CopyTo(result, 0);
            result[array.Length] = item;
            return result;
        }
        /// <summary>
        /// Phuong thuc <b>loai bo luat du thua</b>:<br/>
        /// <i>Ngay cap nhat : 18/04/2021</i>
        /// </summary>
        /// <param name="rules"></param>
        private static void RemoveRuleRedundant(List<LuatDTO> rules)
        {
            int i = 0;
            var checkRule = new LuatDTO();
            var SAT = new Queue<int>();
            var rulesCopy = new List<LuatDTO>();
            var mediate = new List<string>();
            while (i < rules.Count)
            {
                //Buoc 1: Lay luat can xet
                checkRule = rules[i];
                rulesCopy.AddRange(rules);
                rulesCopy.Remove(checkRule);
                // Buoc 2: Ve trái  cua luat dang xet la gia thiet
                mediate.AddRange(checkRule.RLeft);

                foreach (LuatDTO rule in rules)
                {
                    // Bo qua luat dang xet
                    if (rule.Equals(checkRule)) continue;

                    // Buoc 3: Thuc hien suy dien
                    mediate = ForwardChaining(SAT, rulesCopy, rules, mediate);
                }
                // Buoc 4: Neu bien trung gian chua ve phai cua luat dang xet thi xoa luat do ra khoi tap luat.
                if (mediate.Contains(checkRule.RRight.Trim()))
                {
                    rules.RemoveAt(i);
                }
                else
                {
                    i++;
                }
                //
                SAT.Clear();
                mediate.Clear();
                rulesCopy.Clear();
            }
        }
    }
}
