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

namespace TuVanMuaXeMayHCG.GUI
{
    public partial class formKieuDang : Form
    {
        KieuDangBUS BUS = new KieuDangBUS();
        public formKieuDang()
        {
            InitializeComponent();
        }

        private void formKieuDang_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            dataGridView1.DataSource = BUS.getKieuDang();
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            bool exist = BUS.checkKieuDang(code);
            if (!exist)
            {
                string name = txtName.Text;
                bool check = BUS.insertKieuDang(code, name);
                if (check)
                {
                    MessageBox.Show("Thêm kiểu dáng " + code + " " + name + " thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Đã TỒN TẠI mã kiểu dáng này");
            }
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string name = txtName.Text;
            bool check = BUS.updateKieuDang(code, name);
            if (check)
            {
                MessageBox.Show("Cập nhật kiểu dáng " + code + " thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            DialogResult result = MessageBox.Show("Bạn có chắc muốn XÓA kiểu dáng " + code + " không???", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bool check = BUS.deleteKieuDang(code);
                if (check)
                {
                    MessageBox.Show("Xóa kiểu dáng " + code + " thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
            loadData();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtCode.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
        }
    }
}
