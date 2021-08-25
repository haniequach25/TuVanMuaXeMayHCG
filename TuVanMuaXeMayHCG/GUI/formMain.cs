using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuVanMuaXeMayHCG.GUI
{
    public partial class formMain : Form
    {
        private Panel leftBorderbtn;
        private Form currentChildForm;
        public formMain()
        {
            InitializeComponent();
            leftBorderbtn = new Panel();
            panelMenu.Controls.Add(leftBorderbtn);
            panelSubmenu.Visible = false;
            buttonDeco();
            panelDesktop.BackColor = Color.Transparent;
            panelDesktop.BackgroundImage = SetImageOpacity(panelDesktop.BackgroundImage, 0.50F);
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void OpenCurrentForm(Form childForm)
        {
            try
            {
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                }
                currentChildForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                //addChildFormToParentForm
                panelDesktop.Controls.Add(childForm);
                panelDesktop.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch
            {

            }

        }

        private void HideSubmenu()
        {
            if (panelSubmenu.Visible == true)
            {
                panelSubmenu.Visible = false;
            }
        }
        private void ShowSubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                HideSubmenu();
                Submenu.Visible = true;
            }
            else
                Submenu.Visible = false;
        }

        public Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                                                  ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                   0, 0, image.Width, image.Height,
                                   GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        public void buttonDeco()
        {
            btnTrangChu.TabStop = false;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnTuVan.TabStop = false;
            btnTuVan.FlatStyle = FlatStyle.Flat;
            btnTuVan.FlatAppearance.BorderSize = 0;
            btnTuVan.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnQuanLy.TabStop = false;
            btnQuanLy.FlatStyle = FlatStyle.Flat;
            btnQuanLy.FlatAppearance.BorderSize = 0;
            btnQuanLy.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnLuat.TabStop = false;
            btnLuat.FlatStyle = FlatStyle.Flat;
            btnLuat.FlatAppearance.BorderSize = 0;
            btnLuat.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnXe.TabStop = false;
            btnXe.FlatStyle = FlatStyle.Flat;
            btnXe.FlatAppearance.BorderSize = 0;
            btnXe.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnGiaTien.TabStop = false;
            btnGiaTien.FlatStyle = FlatStyle.Flat;
            btnGiaTien.FlatAppearance.BorderSize = 0;
            btnGiaTien.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnHang.TabStop = false;
            btnHang.FlatStyle = FlatStyle.Flat;
            btnHang.FlatAppearance.BorderSize = 0;
            btnHang.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnLoaiXe.TabStop = false;
            btnLoaiXe.FlatStyle = FlatStyle.Flat;
            btnLoaiXe.FlatAppearance.BorderSize = 0;
            btnLoaiXe.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnDoiTuong.TabStop = false;
            btnDoiTuong.FlatStyle = FlatStyle.Flat;
            btnDoiTuong.FlatAppearance.BorderSize = 0;
            btnDoiTuong.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnKieuDang.TabStop = false;
            btnKieuDang.FlatStyle = FlatStyle.Flat;
            btnKieuDang.FlatAppearance.BorderSize = 0;
            btnKieuDang.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnDacDiem.TabStop = false;
            btnDacDiem.FlatStyle = FlatStyle.Flat;
            btnDacDiem.FlatAppearance.BorderSize = 0;
            btnDacDiem.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            try
            {
                if(currentChildForm != null)
                    currentChildForm.Close();
            }
            catch
            {
                
            }
        }

        private void btnTuVan_Click(object sender, EventArgs e)
        {
            OpenCurrentForm(new formTuVan());
        }

        private void btnLuat_Click(object sender, EventArgs e)
        {
            OpenCurrentForm(new formLuat());
        }

        private void btnLoaiXe_Click(object sender, EventArgs e)
        {
            OpenCurrentForm(new formLoaiXe());
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            OpenCurrentForm(new formHang());
        }

        private void btnGiaTien_Click(object sender, EventArgs e)
        {
            OpenCurrentForm(new formGiaTien());
        }

        private void btnXe_Click(object sender, EventArgs e)
        {
            OpenCurrentForm(new formXe());
        }

        private void btnDoiTuong_Click(object sender, EventArgs e)
        {
            OpenCurrentForm(new formDoiTuong());
        }

        private void btnKieuDang_Click(object sender, EventArgs e)
        {
            OpenCurrentForm(new formKieuDang());
        }

        private void btnDacDiem_Click(object sender, EventArgs e)
        {
            OpenCurrentForm(new formDacDiem());
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelSubmenu);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }
    }
}
