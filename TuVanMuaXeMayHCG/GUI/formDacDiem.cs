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
    public partial class formDacDiem : Form
    {
        DacDiemBUS BUS = new DacDiemBUS();
        public formDacDiem()
        {
            InitializeComponent();
        }

        private void formDacDiem_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            dataGridView1.DataSource = BUS.getDacDiem();
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string name = txtName.Text;
            bool exist = BUS.checkDacDiem(code);
            if (!exist)
            {
                bool check = BUS.insertDacDiem(code, name);
                if (check)
                {
                    MessageBox.Show("Thêm đặc điểm " + code + " " + name + " thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Đã TỒN TẠI mã đặc điểm này");
            }
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string name = txtName.Text;
            bool check = BUS.updateDacDiem(code, name);
            if (check)
            {
                MessageBox.Show("Cập nhật đặc điểm " + code + " thành công!");
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
            DialogResult result = MessageBox.Show("Bạn có chắc muốn XÓA đặc điểm " + code + " không???", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bool check = BUS.deleteDacDiem(code);
                if (check)
                {
                    MessageBox.Show("Xóa đặc điểm " + code + " thành công!");
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
