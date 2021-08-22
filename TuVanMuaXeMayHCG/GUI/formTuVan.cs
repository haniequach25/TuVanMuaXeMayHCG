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
using TuVanMuaXeMayHCG.Utilities;

namespace TuVanMuaXeMayHCG.GUI
{
    public partial class formTuVan : Form
    {
        DungTichBUS dungtich = new DungTichBUS();
        GiaTienBUS giatien = new GiaTienBUS();
        LoaiXeBUS loaixe = new LoaiXeBUS();
        HangBUS hang = new HangBUS();
        public formTuVan()
        {
            InitializeComponent();
        }

        private void formTuVan_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            loadCombo();
        }
        public void loadCombo()
        {
            //combobox dung tích
            cbbDungTich.DataSource = DungTichBUS.FindAll();
            cbbDungTich.DisplayMember = "Name";
            cbbDungTich.ValueMember = "Name";

            //combobox giá tiền
            cbbGiaTien.DataSource = GiaTienBUS.FindAll();
            cbbGiaTien.ValueMember = "Name";
            cbbGiaTien.ValueMember = "Name";

            //combobox loại xe
            cbbLoaiXe.DataSource = LoaiXeBUS.FindAll();
            cbbLoaiXe.ValueMember = "Name";
            cbbLoaiXe.ValueMember = "Name";

            //combobox hãng
            cbbHang.DataSource = HangBUS.FindAll();
            cbbHang.ValueMember = "Name";
            cbbHang.ValueMember = "Name";
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                var assumption = new List<string>();
                DungTichDTO capacity = (DungTichDTO)cbbDungTich.SelectedItem;
                HangDTO brand = (HangDTO)cbbHang.SelectedItem;
                GiaTienDTO price = (GiaTienDTO)cbbGiaTien.SelectedItem;
                LoaiXeDTO type = (LoaiXeDTO)cbbLoaiXe.SelectedItem;
                if (capacity.Code == "D00")
                {
                    throw new Exception("Dung tích không được để trống");
                }
                else
                {
                    assumption.Add(capacity.Code.Trim());
                }

                if (price.Code == "A00" && type.Code == "C00" && brand.Code != "B00")
                {
                    assumption.Add(brand.Code.Trim());
                }
                if (price.Code != "A00" && type.Code == "C00" && brand.Code == "B00")
                {
                    assumption.Add(price.Code.Trim());
                }
                if (price.Code == "A00" && type.Code != "C00" && brand.Code == "B00")
                {
                    assumption.Add(type.Code.Trim());
                }

                if (assumption.Count < 2)
                {
                    throw new Exception("Không có loại xe phù hợp với mô tả của bạn!");
                }

                var xes = ForwardChainingUtil.Result(assumption);

                if (xes.Count == 0)
                {
                    throw new Exception("Không có loại xe phù hợp với mô tả của bạn!");
                }
                this.dataGridView1.Visible = true;
                this.dataGridView1.DataSource = xes;
                this.dataGridView1.Columns["Code"].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbDungTich.SelectedValue = "Không rõ";
            cbbGiaTien.SelectedValue = "Không rõ";
            cbbHang.SelectedValue = "Không rõ";
            cbbLoaiXe.SelectedValue = "Không rõ";
        }
    }
}
