namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuNhap
{
    partial class ThemPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemPhieuNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dateNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbLoaiNhap = new System.Windows.Forms.ComboBox();
            this.Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btnChapNhan = new DevExpress.XtraEditors.SimpleButton();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet60 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet60();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet61 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet61();
            this.nhaCungCapTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet60TableAdapters.NhaCungCapTableAdapter();
            this.nhanVienTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet61TableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet61)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày nhập";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhà cung cấp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại nhập";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng tiền";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ghi chú";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nhân viên nhận hàng";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(111, 41);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(232, 20);
            this.txtMaPhieuNhap.TabIndex = 8;
            this.txtMaPhieuNhap.TextChanged += new System.EventHandler(this.txtMaPhieuNhap_TextChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(520, 119);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(209, 20);
            this.txtGhiChu.TabIndex = 10;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(520, 41);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(209, 20);
            this.txtTongTien.TabIndex = 12;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // dateNgayNhap
            // 
            this.dateNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dateNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayNhap.Location = new System.Drawing.Point(111, 78);
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Size = new System.Drawing.Size(232, 20);
            this.dateNgayNhap.TabIndex = 14;
            this.dateNgayNhap.ValueChanged += new System.EventHandler(this.dateNgayNhap_ValueChanged);
            // 
            // cbLoaiNhap
            // 
            this.cbLoaiNhap.FormattingEnabled = true;
            this.cbLoaiNhap.Items.AddRange(new object[] {
            "Nhập TP/BTP",
            "Nhập nguyên liệu"});
            this.cbLoaiNhap.Location = new System.Drawing.Point(111, 112);
            this.cbLoaiNhap.Name = "cbLoaiNhap";
            this.cbLoaiNhap.Size = new System.Drawing.Size(232, 21);
            this.cbLoaiNhap.TabIndex = 15;
            this.cbLoaiNhap.SelectedIndexChanged += new System.EventHandler(this.cbLoaiNhap_SelectedIndexChanged);
            // 
            // Huy
            // 
            this.Huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Huy.ImageOptions.SvgImage")));
            this.Huy.Location = new System.Drawing.Point(432, 202);
            this.Huy.Margin = new System.Windows.Forms.Padding(4);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(124, 56);
            this.Huy.TabIndex = 131;
            this.Huy.Text = "Hủy bỏ";
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChapNhan.ImageOptions.SvgImage")));
            this.btnChapNhan.Location = new System.Drawing.Point(218, 202);
            this.btnChapNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(124, 56);
            this.btnChapNhan.TabIndex = 130;
            this.btnChapNhan.Text = "Chấp nhận";
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // cbNCC
            // 
            this.cbNCC.DataSource = this.nhaCungCapBindingSource;
            this.cbNCC.DisplayMember = "TenNhaCungCap";
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(111, 154);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(232, 21);
            this.cbNCC.TabIndex = 15;
            this.cbNCC.ValueMember = "MaNhaCungCap";
            this.cbNCC.SelectedIndexChanged += new System.EventHandler(this.cbNCC_SelectedIndexChanged);
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet60;
            // 
            // quanLyBanBanhKeo_DoAnDataSet60
            // 
            this.quanLyBanBanhKeo_DoAnDataSet60.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet60";
            this.quanLyBanBanhKeo_DoAnDataSet60.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.DataSource = this.nhanVienBindingSource;
            this.cbNhanVien.DisplayMember = "TenNhanVien";
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(520, 76);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(209, 21);
            this.cbNhanVien.TabIndex = 15;
            this.cbNhanVien.ValueMember = "MaNhanVien";
            this.cbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbNhanVien_SelectedIndexChanged);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet61;
            // 
            // quanLyBanBanhKeo_DoAnDataSet61
            // 
            this.quanLyBanBanhKeo_DoAnDataSet61.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet61";
            this.quanLyBanBanhKeo_DoAnDataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // ThemPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 299);
            this.Controls.Add(this.Huy);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.cbNhanVien);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.cbLoaiNhap);
            this.Controls.Add(this.dateNgayNhap);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtMaPhieuNhap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemPhieuNhap";
            this.Load += new System.EventHandler(this.ThemPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet61)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DateTimePicker dateNgayNhap;
        private System.Windows.Forms.ComboBox cbLoaiNhap;
        private DevExpress.XtraEditors.SimpleButton Huy;
        private DevExpress.XtraEditors.SimpleButton btnChapNhan;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private QuanLyBanBanhKeo_DoAnDataSet60 quanLyBanBanhKeo_DoAnDataSet60;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet60TableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet61 quanLyBanBanhKeo_DoAnDataSet61;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet61TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}