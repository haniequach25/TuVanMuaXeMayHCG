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
    public partial class formLoaiXe : Form
    {
        LoaiXeBUS loaixe = new LoaiXeBUS();
        public formLoaiXe()
        {
            InitializeComponent();
        }

        private void formLoaiXe_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            dataGridView1.DataSource = loaixe.getLoaiXe();
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string name = txtName.Text;
            bool exist = loaixe.checkLoaiXe(code);
            if (!exist)
            {
                bool check = loaixe.insertLoaiXe(code, name);
                if (check)
                {
                    MessageBox.Show("Thêm loại xe " + code + " " + name + " thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Đã TỒN TẠI mã loại xe này");
            }
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string name = txtName.Text;
            bool check = loaixe.updateLoaiXe(code, name);
            if (check)
            {
                MessageBox.Show("Cập nhật loại xe " + code + " thành công!");
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
            DialogResult result = MessageBox.Show("Bạn có chắc muốn XÓA loại xe " + code + " không???", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bool check = loaixe.deleteLoaiXe(code);
                if (check)
                {
                    MessageBox.Show("Xóa loại xe " + code + " thành công!");
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
