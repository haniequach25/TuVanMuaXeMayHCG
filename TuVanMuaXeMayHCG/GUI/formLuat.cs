using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuVanMuaXeMayHCG.BUS;
using TuVanMuaXeMayHCG.DTO;

namespace TuVanMuaXeMayHCG.GUI
{
    public partial class formLuat : Form
    {
        LuatDTO luatDTOTemp = null;
        class LuatTMP
        {
            public int Id { get; set; }
            public string Rule { get; set; }
        }
        public formLuat()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            List<LuatTMP> listRule = new List<LuatTMP>();
            //List<string> rules = new List<string>(); 
            LuatBUS.FindAll().ForEach(rule => {
                //rules.Add(string.Join("^",rule.Left)+" -> "+ rule.Right);
                LuatTMP ruleTMP = new LuatTMP();
                ruleTMP.Id = rule.Code;
                ruleTMP.Rule = string.Join("^", rule.RLeft) + " -> " + rule.RRight;
                listRule.Add(ruleTMP);
            });
            //dgvRules.DataSource = rules.Select(x => new { Rule = x }).ToList();
            dataGridView1.DataSource = listRule;
            //this.dgvRules.Columns["Id"].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string left = txtRuleLeft.Text.Trim();
            string right = txtRuleRight.Text.Trim();
            if(LuatBUS.Insert(left, right))
            {
                MessageBox.Show("Thêm luật thành công!", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (luatDTOTemp != null)
            {
                if (LuatBUS.Delete(luatDTOTemp.Code))
                {
                    MessageBox.Show("Xóa luật thành công!", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    luatDTOTemp = null;
                }
            }
            else
            {
                MessageBox.Show("Xóa luật thất bại!", "Thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void formLuat_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int id = int.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString());
            luatDTOTemp = LuatBUS.FindByID(id);
            txtRuleLeft.Text = string.Join("^", luatDTOTemp.RLeft);
            txtRuleRight.Text = luatDTOTemp.RRight.ToString();
        }
    }
}
