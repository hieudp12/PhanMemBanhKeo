namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatChuyen
{
    partial class ThemPhieuXuatChuyen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemPhieuXuatChuyen));
            this.Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btnChapNhan = new DevExpress.XtraEditors.SimpleButton();
            this.dtmPhieuNhap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChuPX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNhanVien1 = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet47 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet47();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nhanVienTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet47TableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet47)).BeginInit();
            this.SuspendLayout();
            // 
            // Huy
            // 
            this.Huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Huy.ImageOptions.SvgImage")));
            this.Huy.Location = new System.Drawing.Point(265, 214);
            this.Huy.Margin = new System.Windows.Forms.Padding(4);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(124, 56);
            this.Huy.TabIndex = 149;
            this.Huy.Text = "Hủy bỏ";
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChapNhan.ImageOptions.SvgImage")));
            this.btnChapNhan.Location = new System.Drawing.Point(57, 214);
            this.btnChapNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(124, 56);
            this.btnChapNhan.TabIndex = 148;
            this.btnChapNhan.Text = "Chấp nhận";
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // dtmPhieuNhap
            // 
            this.dtmPhieuNhap.CustomFormat = "dd/MM/yyyy";
            this.dtmPhieuNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmPhieuNhap.Location = new System.Drawing.Point(158, 77);
            this.dtmPhieuNhap.Name = "dtmPhieuNhap";
            this.dtmPhieuNhap.Size = new System.Drawing.Size(232, 20);
            this.dtmPhieuNhap.TabIndex = 146;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 133;
            this.label2.Text = "Ngày xuất chuyển";
            // 
            // txtGhiChuPX
            // 
            this.txtGhiChuPX.Location = new System.Drawing.Point(158, 158);
            this.txtGhiChuPX.Name = "txtGhiChuPX";
            this.txtGhiChuPX.Size = new System.Drawing.Size(232, 20);
            this.txtGhiChuPX.TabIndex = 151;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 150;
            this.label4.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 156;
            this.label7.Text = "Nhân viên giao";
            // 
            // cmbNhanVien1
            // 
            this.cmbNhanVien1.DataSource = this.nhanVienBindingSource;
            this.cmbNhanVien1.DisplayMember = "TenNhanVien";
            this.cmbNhanVien1.FormattingEnabled = true;
            this.cmbNhanVien1.Location = new System.Drawing.Point(158, 115);
            this.cmbNhanVien1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNhanVien1.Name = "cmbNhanVien1";
            this.cmbNhanVien1.Size = new System.Drawing.Size(232, 21);
            this.cmbNhanVien1.TabIndex = 158;
            this.cmbNhanVien1.ValueMember = "MaNhanVien";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet47;
            // 
            // quanLyBanBanhKeo_DoAnDataSet47
            // 
            this.quanLyBanBanhKeo_DoAnDataSet47.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet47";
            this.quanLyBanBanhKeo_DoAnDataSet47.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(158, 41);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(232, 20);
            this.txtMaPhieu.TabIndex = 151;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 150;
            this.label3.Text = "Mã phiếu xuất";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // ThemPhieuXuatChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 302);
            this.Controls.Add(this.cmbNhanVien1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.txtGhiChuPX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Huy);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.dtmPhieuNhap);
            this.Controls.Add(this.label2);
            this.Name = "ThemPhieuXuatChuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemPhieuXuatChuyen";
            this.Load += new System.EventHandler(this.ThemPhieuXuatChuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet47)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Huy;
        private DevExpress.XtraEditors.SimpleButton btnChapNhan;
        private System.Windows.Forms.DateTimePicker dtmPhieuNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhiChuPX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbNhanVien1;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label3;
        private QuanLyBanBanhKeo_DoAnDataSet47 quanLyBanBanhKeo_DoAnDataSet47;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet47TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}