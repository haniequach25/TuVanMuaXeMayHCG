using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuVanMuaXeMayHCG.DAL;
using TuVanMuaXeMayHCG.DTO;

namespace TuVanMuaXeMayHCG.BUS
{
    class LuatBUS
    {
        private static LuatDAL rulesDAL = new LuatDAL();
        public static List<LuatDTO> FindAll()
        {
            return rulesDAL.FindAll();
        }

        public static LuatDTO FindByID(int id)
        {
            return rulesDAL.FindById(id);
        }
        public static bool Insert(string left, string right)
        {
            return rulesDAL.Insert(left, right);
        }

        public static bool Delete(int id)
        {
            return rulesDAL.Delete(id);
        }
    }
}
