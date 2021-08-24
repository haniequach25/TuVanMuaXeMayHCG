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
    public partial class formXe : Form
    {
        XeBUS xe = new XeBUS();
        HangBUS hang = new HangBUS();
        LoaiXeBUS loaixe = new LoaiXeBUS();
        public formXe()
        {
            InitializeComponent();
        }

        private void formXe_Load(object sender, EventArgs e)
        {
            loadData();
            loadCombo();
        }
        public void loadData()
        {
            dataGridView1.DataSource = xe.getXe();
        }
        public void loadCombo()
        {
            //load combo Hãng
            cbbBrand.DataSource = hang.getHang();
            cbbBrand.DisplayMember = "Name";
            cbbBrand.ValueMember = "Name";

            //load combo Loại xe
            cbbType.DataSource = loaixe.getLoaiXe();
            cbbType.DisplayMember = "Name";
            cbbType.ValueMember = "Name";

            //load combo Dung tích
            cbbCapacity.Items.Add("97cc");
            cbbCapacity.Items.Add("100cc");
            cbbCapacity.Items.Add("108cc");
            cbbCapacity.Items.Add("110cc");
            cbbCapacity.Items.Add("113cc");
            cbbCapacity.Items.Add("114cc");
            cbbCapacity.Items.Add("115cc");
            cbbCapacity.Items.Add("125cc");
            cbbCapacity.Items.Add("135cc");
            cbbCapacity.Items.Add("150cc");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string code = txtCode.Text.Trim();
                bool exist = xe.checkXe(code);
                if (!exist)
                {
                    string name = txtName.Text;
                    string brand = cbbBrand.SelectedValue.ToString();
                    int price = Int32.Parse(txtPrice.Text);
                    string type = cbbType.SelectedValue.ToString();
                    string capacity = cbbCapacity.SelectedValue.ToString();
                    bool check = xe.insertXe(code, name, brand, price, type, capacity);
                    if (check)
                    {
                        MessageBox.Show("Thêm xe " + code + " " + name + " thành công!");
                        loadData();
                        loadCombo();
                    }
                    else
                    {
                        throw new Exception("Thêm thất bại!");
                    }
                }
                else
                {
                    throw new Exception("Đã TỒN TẠI mã xe này");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string code = txtCode.Text.Trim();

                //check mã xe có trong list không
                bool check1 = xe.checkXe(code);
                if (!check1)
                {
                    throw new Exception("Mã xe này không có");
                }
                string name = txtName.Text;
                string brand = cbbBrand.SelectedValue.ToString();
                int price = Int32.Parse(txtPrice.Text);
                string type = cbbType.SelectedValue.ToString();
                string capacity = cbbCapacity.SelectedValue.ToString();

                //check kết quả update xe
                bool check2 = xe.updateXe(code, name, brand, price, type, capacity);
                if (check2)
                {
                    MessageBox.Show("Cập nhật xe " + code + " thành công!");
                    loadData();
                    loadCombo();
                }
                else
                {
                    throw new Exception("Cập nhật thất bại!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            DialogResult result = MessageBox.Show("Bạn có chắc muốn XÓA loại xe " + code + " không???", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bool check = xe.deleteXe(code);
                if (check)
                {
                    MessageBox.Show("Xóa xe " + code + " thành công!");
                    loadData();
                    loadCombo();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtCode.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            cbbBrand.SelectedValue = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            txtPrice.Text = dataGridView1.Rows[dong].Cells[3].Value.ToString();
            cbbType.SelectedValue = dataGridView1.Rows[dong].Cells[4].Value.ToString();
            cbbCapacity.SelectedValue = dataGridView1.Rows[dong].Cells[5].Value.ToString();
        }
    }
}
