namespace BanhKeo_Doan.BaoCaoThongKe.LoiNhuanTheoDonHang
{
    partial class LoiNhuanTheoDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoiNhuanTheoDonHang));
            this.rpLoiNhuan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbDonHang = new System.Windows.Forms.CheckBox();
            this.dateNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dateNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnInLoiNhuan = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpLoiNhuan
            // 
            this.rpLoiNhuan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpLoiNhuan.Location = new System.Drawing.Point(12, 142);
            this.rpLoiNhuan.Name = "rpLoiNhuan";
            this.rpLoiNhuan.ServerReport.BearerToken = null;
            this.rpLoiNhuan.Size = new System.Drawing.Size(776, 296);
            this.rpLoiNhuan.TabIndex = 3;
            // 
            // cbDonHang
            // 
            this.cbDonHang.AutoSize = true;
            this.cbDonHang.Location = new System.Drawing.Point(10, 52);
            this.cbDonHang.Name = "cbDonHang";
            this.cbDonHang.Size = new System.Drawing.Size(103, 17);
            this.cbDonHang.TabIndex = 4;
            this.cbDonHang.Text = "Theo đơn hàng:";
            this.cbDonHang.UseVisualStyleBackColor = true;
            // 
            // dateNgayKT
            // 
            this.dateNgayKT.Location = new System.Drawing.Point(336, 15);
            this.dateNgayKT.Name = "dateNgayKT";
            this.dateNgayKT.Size = new System.Drawing.Size(200, 20);
            this.dateNgayKT.TabIndex = 3;
            // 
            // dateNgayBD
            // 
            this.dateNgayBD.Location = new System.Drawing.Point(65, 14);
            this.dateNgayBD.Name = "dateNgayBD";
            this.dateNgayBD.Size = new System.Drawing.Size(200, 20);
            this.dateNgayBD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày: ";
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Location = new System.Drawing.Point(546, 48);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 50);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnInLoiNhuan
            // 
            this.btnInLoiNhuan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInLoiNhuan.ImageOptions.SvgImage")));
            this.btnInLoiNhuan.Location = new System.Drawing.Point(465, 48);
            this.btnInLoiNhuan.Name = "btnInLoiNhuan";
            this.btnInLoiNhuan.Size = new System.Drawing.Size(75, 50);
            this.btnInLoiNhuan.TabIndex = 9;
            this.btnInLoiNhuan.Text = "In";
            this.btnInLoiNhuan.Click += new System.EventHandler(this.btnInLoiNhuan_Click);
            // 
            // btnXem
            // 
            this.btnXem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXem.ImageOptions.SvgImage")));
            this.btnXem.Location = new System.Drawing.Point(384, 48);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 50);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtMaDonHang);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnInLoiNhuan);
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.cbDonHang);
            this.groupBox1.Controls.Add(this.dateNgayKT);
            this.groupBox1.Controls.Add(this.dateNgayBD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(120, 52);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(228, 20);
            this.txtMaDonHang.TabIndex = 11;
            // 
            // LoiNhuanTheoDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpLoiNhuan);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoiNhuanTheoDonHang";
            this.Text = "LoiNhuanTheoDonHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoiNhuanTheoDonHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rpLoiNhuan;
        private System.Windows.Forms.CheckBox cbDonHang;
        private System.Windows.Forms.DateTimePicker dateNgayKT;
        private System.Windows.Forms.DateTimePicker dateNgayBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnInLoiNhuan;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaDonHang;
    }
}