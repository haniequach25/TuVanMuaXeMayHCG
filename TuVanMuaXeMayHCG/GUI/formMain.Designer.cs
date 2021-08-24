
namespace TuVanMuaXeMayHCG.GUI
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnTuVan = new System.Windows.Forms.Button();
            this.btnLuat = new System.Windows.Forms.Button();
            this.btnLoaiXe = new System.Windows.Forms.Button();
            this.btnHang = new System.Windows.Forms.Button();
            this.btnGiaTien = new System.Windows.Forms.Button();
            this.btnXe = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnKieuDang = new System.Windows.Forms.Button();
            this.btnDoiTuong = new System.Windows.Forms.Button();
            this.panelDesktop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDesktop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Location = new System.Drawing.Point(174, 1);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1173, 660);
            this.panelDesktop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tư vấn mua xe máy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trang chủ";
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.Location = new System.Drawing.Point(-1, -1);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(175, 51);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "TRANG CHỦ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnTuVan
            // 
            this.btnTuVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuVan.Location = new System.Drawing.Point(-1, 56);
            this.btnTuVan.Name = "btnTuVan";
            this.btnTuVan.Size = new System.Drawing.Size(175, 51);
            this.btnTuVan.TabIndex = 2;
            this.btnTuVan.Text = "TƯ VẤN";
            this.btnTuVan.UseVisualStyleBackColor = true;
            this.btnTuVan.Click += new System.EventHandler(this.btnTuVan_Click);
            // 
            // btnLuat
            // 
            this.btnLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuat.Location = new System.Drawing.Point(-1, 113);
            this.btnLuat.Name = "btnLuat";
            this.btnLuat.Size = new System.Drawing.Size(175, 51);
            this.btnLuat.TabIndex = 3;
            this.btnLuat.Text = "LUẬT";
            this.btnLuat.UseVisualStyleBackColor = true;
            this.btnLuat.Click += new System.EventHandler(this.btnLuat_Click);
            // 
            // btnLoaiXe
            // 
            this.btnLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiXe.Location = new System.Drawing.Point(-1, 227);
            this.btnLoaiXe.Name = "btnLoaiXe";
            this.btnLoaiXe.Size = new System.Drawing.Size(175, 51);
            this.btnLoaiXe.TabIndex = 2;
            this.btnLoaiXe.Text = "LOẠI XE";
            this.btnLoaiXe.UseVisualStyleBackColor = true;
            this.btnLoaiXe.Click += new System.EventHandler(this.btnLoaiXe_Click);
            // 
            // btnHang
            // 
            this.btnHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHang.Location = new System.Drawing.Point(-1, 284);
            this.btnHang.Name = "btnHang";
            this.btnHang.Size = new System.Drawing.Size(175, 51);
            this.btnHang.TabIndex = 4;
            this.btnHang.Text = "HÃNG";
            this.btnHang.UseVisualStyleBackColor = true;
            this.btnHang.Click += new System.EventHandler(this.btnHang_Click);
            // 
            // btnGiaTien
            // 
            this.btnGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaTien.Location = new System.Drawing.Point(-1, 341);
            this.btnGiaTien.Name = "btnGiaTien";
            this.btnGiaTien.Size = new System.Drawing.Size(175, 51);
            this.btnGiaTien.TabIndex = 5;
            this.btnGiaTien.Text = "GIÁ TIỀN";
            this.btnGiaTien.UseVisualStyleBackColor = true;
            this.btnGiaTien.Click += new System.EventHandler(this.btnGiaTien_Click);
            // 
            // btnXe
            // 
            this.btnXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXe.Location = new System.Drawing.Point(-1, 170);
            this.btnXe.Name = "btnXe";
            this.btnXe.Size = new System.Drawing.Size(175, 51);
            this.btnXe.TabIndex = 6;
            this.btnXe.Text = "XE";
            this.btnXe.UseVisualStyleBackColor = true;
            this.btnXe.Click += new System.EventHandler(this.btnXe_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnKieuDang);
            this.panelMenu.Controls.Add(this.btnDoiTuong);
            this.panelMenu.Controls.Add(this.btnTrangChu);
            this.panelMenu.Controls.Add(this.btnXe);
            this.panelMenu.Controls.Add(this.btnTuVan);
            this.panelMenu.Controls.Add(this.btnGiaTien);
            this.panelMenu.Controls.Add(this.btnLuat);
            this.panelMenu.Controls.Add(this.btnHang);
            this.panelMenu.Controls.Add(this.btnLoaiXe);
            this.panelMenu.Location = new System.Drawing.Point(0, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(175, 660);
            this.panelMenu.TabIndex = 7;
            // 
            // btnKieuDang
            // 
            this.btnKieuDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKieuDang.Location = new System.Drawing.Point(-1, 455);
            this.btnKieuDang.Name = "btnKieuDang";
            this.btnKieuDang.Size = new System.Drawing.Size(175, 51);
            this.btnKieuDang.TabIndex = 8;
            this.btnKieuDang.Text = "KIỂU DÁNG";
            this.btnKieuDang.UseVisualStyleBackColor = true;
            this.btnKieuDang.Click += new System.EventHandler(this.btnKieuDang_Click);
            // 
            // btnDoiTuong
            // 
            this.btnDoiTuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiTuong.Location = new System.Drawing.Point(-1, 398);
            this.btnDoiTuong.Name = "btnDoiTuong";
            this.btnDoiTuong.Size = new System.Drawing.Size(175, 51);
            this.btnDoiTuong.TabIndex = 7;
            this.btnDoiTuong.Text = "ĐỐI TƯỢNG";
            this.btnDoiTuong.UseVisualStyleBackColor = true;
            this.btnDoiTuong.Click += new System.EventHandler(this.btnDoiTuong_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 661);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelDesktop);
            this.Name = "formMain";
            this.Text = "formMain";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnTuVan;
        private System.Windows.Forms.Button btnLuat;
        private System.Windows.Forms.Button btnLoaiXe;
        private System.Windows.Forms.Button btnHang;
        private System.Windows.Forms.Button btnGiaTien;
        private System.Windows.Forms.Button btnXe;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnKieuDang;
        private System.Windows.Forms.Button btnDoiTuong;
    }
}