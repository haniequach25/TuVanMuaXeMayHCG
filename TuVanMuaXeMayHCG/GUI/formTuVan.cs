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

            //combobox đối tượng
            cbbDoiTuong.DataSource = DoiTuongBUS.FindAll();
            cbbDoiTuong.ValueMember = "Name";
            cbbDoiTuong.ValueMember = "Name";

            //combobox kiểu dáng
            cbbKieuDang.DataSource = KieuDangBUS.FindAll();
            cbbKieuDang.ValueMember = "Name";
            cbbKieuDang.ValueMember = "Name";

            //combobox đặc điểm
            cbbDacDiem.DataSource = DacDiemBUS.FindAll();
            cbbDacDiem.ValueMember = "Name";
            cbbDacDiem.ValueMember = "Name";
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                var assumption = new List<string>();
                HangDTO brand = (HangDTO)cbbHang.SelectedItem;
                GiaTienDTO price = (GiaTienDTO)cbbGiaTien.SelectedItem;
                LoaiXeDTO type = (LoaiXeDTO)cbbLoaiXe.SelectedItem;
                DoiTuongDTO target = (DoiTuongDTO)cbbDoiTuong.SelectedItem;
                KieuDangDTO style = (KieuDangDTO)cbbKieuDang.SelectedItem;
                DacDiemDTO feature = (DacDiemDTO)cbbDacDiem.SelectedItem;

                if (price.Code == "A00")
                {
                    assumption.Add(target.Code.Trim());
                }
                else
                {
                    assumption.Add(price.Code.Trim());
                }

                if (type.Code == "C00")
                {
                    assumption.Add(style.Code.Trim());
                }
                else
                {
                    assumption.Add(type.Code.Trim());
                }

                if (brand.Code == "B00")
                {
                    assumption.Add(feature.Code.Trim());
                }
                else
                {
                    assumption.Add(brand.Code.Trim());
                }


                if (assumption.Count < 3)
                {
                    throw new Exception("Hãy trả lời cụ thể tối thiểu 3 câu hỏi để chúng tôi tư vấn cho bạn!");
                }

                var xes = ForwardChainingUtil.Result(assumption);

                if (xes.Count == 0)
                {
                    throw new Exception("Không có loại xe phù hợp với mô tả của bạn!");
                }
                else
                {
                    MessageBox.Show("Có " + xes.Count.ToString() + " xe phù hợp với yêu cầu của bạn!");
                    this.dataGridView1.Visible = true;
                    this.dataGridView1.DataSource = xes;
                    this.dataGridView1.Columns["Code"].Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbGiaTien.SelectedValue = "Không rõ";
            cbbHang.SelectedValue = "Không rõ";
            cbbLoaiXe.SelectedValue = "Không rõ";
            cbbDacDiem.SelectedValue = "Không rõ";
            cbbDoiTuong.SelectedValue = "Không rõ";
            cbbKieuDang.SelectedValue = "Không rõ";
        }
    }
}
