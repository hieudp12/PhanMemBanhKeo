namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangKeHoachSX
{
    partial class InKeHoachSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InKeHoachSanXuat));
            this.rpKeHoachSX = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnInKeHoach = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpKeHoachSX
            // 
            this.rpKeHoachSX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpKeHoachSX.LocalReport.ReportEmbeddedResource = "BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangDonHang.BaoGiaDonHang.rdlc";
            this.rpKeHoachSX.Location = new System.Drawing.Point(12, 84);
            this.rpKeHoachSX.Name = "rpKeHoachSX";
            this.rpKeHoachSX.ServerReport.BearerToken = null;
            this.rpKeHoachSX.Size = new System.Drawing.Size(776, 354);
            this.rpKeHoachSX.TabIndex = 4;
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Location = new System.Drawing.Point(184, 19);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(172, 41);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnInKeHoach
            // 
            this.btnInKeHoach.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnInKeHoach.Location = new System.Drawing.Point(6, 19);
            this.btnInKeHoach.Name = "btnInKeHoach";
            this.btnInKeHoach.Size = new System.Drawing.Size(172, 41);
            this.btnInKeHoach.TabIndex = 2;
            this.btnInKeHoach.Text = "In kế hoạch sản xuất";
            this.btnInKeHoach.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnInKeHoach);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // InKeHoachSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpKeHoachSX);
            this.Controls.Add(this.groupBox1);
            this.Name = "InKeHoachSanXuat";
            this.Text = "InKeHoachSanXuat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InKeHoachSanXuat_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpKeHoachSX;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnInKeHoach;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}