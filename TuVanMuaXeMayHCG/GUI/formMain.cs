using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }
        private void OpenCurrentForm(Form childForm)
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

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void btnDungTich_Click(object sender, EventArgs e)
        {
            OpenCurrentForm(new formDungTich());
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
    }
}
