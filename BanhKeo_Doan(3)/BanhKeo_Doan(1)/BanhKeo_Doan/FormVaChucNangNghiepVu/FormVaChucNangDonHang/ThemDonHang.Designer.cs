namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangDonHang
{
    partial class ThemDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemDonHang));
            this.cmbBoxKhachHang = new System.Windows.Forms.ComboBox();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet14 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet14();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemDonHang = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimeNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBoxNhanVien = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet15 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet15();
            this.cbLaDonDatTruoc = new System.Windows.Forms.CheckBox();
            this.dateNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.khachHangTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet14TableAdapters.KhachHangTableAdapter();
            this.nhanVienTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet15TableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxKhachHang
            // 
            this.cmbBoxKhachHang.DataSource = this.khachHangBindingSource;
            this.cmbBoxKhachHang.DisplayMember = "TenKhachHang";
            this.cmbBoxKhachHang.FormattingEnabled = true;
            this.cmbBoxKhachHang.Location = new System.Drawing.Point(170, 155);
            this.cmbBoxKhachHang.Name = "cmbBoxKhachHang";
            this.cmbBoxKhachHang.Size = new System.Drawing.Size(232, 21);
            this.cmbBoxKhachHang.TabIndex = 189;
            this.cmbBoxKhachHang.ValueMember = "MaKhachHang";
            this.cmbBoxKhachHang.SelectedIndexChanged += new System.EventHandler(this.cmbBoxKhachHang_SelectedIndexChanged);
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet14;
            // 
            // quanLyBanBanhKeo_DoAnDataSet14
            // 
            this.quanLyBanBanhKeo_DoAnDataSet14.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet14";
            this.quanLyBanBanhKeo_DoAnDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 188;
            this.label6.Text = "Khách hàng";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(170, 52);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(232, 20);
            this.txtMaDonHang.TabIndex = 187;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 186;
            this.label5.Text = "Mã đơn hàng";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(170, 262);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(232, 20);
            this.txtGhiChu.TabIndex = 185;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 184;
            this.label4.Text = "Ghi chú";
            // 
            // Huy
            // 
            this.Huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Huy.ImageOptions.SvgImage")));
            this.Huy.Location = new System.Drawing.Point(302, 305);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(100, 45);
            this.Huy.TabIndex = 183;
            this.Huy.Text = "Hủy bỏ";
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // btnThemDonHang
            // 
            this.btnThemDonHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemDonHang.ImageOptions.SvgImage")));
            this.btnThemDonHang.Location = new System.Drawing.Point(170, 305);
            this.btnThemDonHang.Name = "btnThemDonHang";
            this.btnThemDonHang.Size = new System.Drawing.Size(100, 45);
            this.btnThemDonHang.TabIndex = 182;
            this.btnThemDonHang.Text = "Chấp nhận";
            this.btnThemDonHang.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // dateTimeNgayLap
            // 
            this.dateTimeNgayLap.Location = new System.Drawing.Point(170, 87);
            this.dateTimeNgayLap.Name = "dateTimeNgayLap";
            this.dateTimeNgayLap.Size = new System.Drawing.Size(232, 20);
            this.dateTimeNgayLap.TabIndex = 181;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 177;
            this.label2.Text = "Ngày lập";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(170, 194);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(232, 20);
            this.txtTongTien.TabIndex = 191;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 190;
            this.label7.Text = "Tổng tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 192;
            this.label8.Text = "Nhân viên bán hàng";
            // 
            // cmbBoxNhanVien
            // 
            this.cmbBoxNhanVien.DataSource = this.nhanVienBindingSource;
            this.cmbBoxNhanVien.DisplayMember = "TenNhanVien";
            this.cmbBoxNhanVien.FormattingEnabled = true;
            this.cmbBoxNhanVien.Location = new System.Drawing.Point(170, 231);
            this.cmbBoxNhanVien.Name = "cmbBoxNhanVien";
            this.cmbBoxNhanVien.Size = new System.Drawing.Size(232, 21);
            this.cmbBoxNhanVien.TabIndex = 193;
            this.cmbBoxNhanVien.ValueMember = "MaNhanVien";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet15;
            // 
            // quanLyBanBanhKeo_DoAnDataSet15
            // 
            this.quanLyBanBanhKeo_DoAnDataSet15.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet15";
            this.quanLyBanBanhKeo_DoAnDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbLaDonDatTruoc
            // 
            this.cbLaDonDatTruoc.AutoSize = true;
            this.cbLaDonDatTruoc.Location = new System.Drawing.Point(55, 13);
            this.cbLaDonDatTruoc.Name = "cbLaDonDatTruoc";
            this.cbLaDonDatTruoc.Size = new System.Drawing.Size(133, 17);
            this.cbLaDonDatTruoc.TabIndex = 194;
            this.cbLaDonDatTruoc.Text = "Là đơn hàng đặt trước";
            this.cbLaDonDatTruoc.UseVisualStyleBackColor = true;
            this.cbLaDonDatTruoc.CheckedChanged += new System.EventHandler(this.cbLaDonDatTruoc_CheckedChanged);
            // 
            // dateNgayGiao
            // 
            this.dateNgayGiao.Enabled = false;
            this.dateNgayGiao.Location = new System.Drawing.Point(170, 121);
            this.dateNgayGiao.Name = "dateNgayGiao";
            this.dateNgayGiao.Size = new System.Drawing.Size(232, 20);
            this.dateNgayGiao.TabIndex = 196;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 195;
            this.label1.Text = "Ngày giao";
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // ThemDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 364);
            this.Controls.Add(this.dateNgayGiao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLaDonDatTruoc);
            this.Controls.Add(this.cmbBoxNhanVien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbBoxKhachHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaDonHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Huy);
            this.Controls.Add(this.btnThemDonHang);
            this.Controls.Add(this.dateTimeNgayLap);
            this.Controls.Add(this.label2);
            this.Name = "ThemDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemDonHang";
            this.Load += new System.EventHandler(this.ThemDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton Huy;
        private DevExpress.XtraEditors.SimpleButton btnThemDonHang;
        private System.Windows.Forms.DateTimePicker dateTimeNgayLap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBoxNhanVien;
        private System.Windows.Forms.CheckBox cbLaDonDatTruoc;
        private System.Windows.Forms.DateTimePicker dateNgayGiao;
        private System.Windows.Forms.Label label1;
        private QuanLyBanBanhKeo_DoAnDataSet14 quanLyBanBanhKeo_DoAnDataSet14;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet14TableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet15 quanLyBanBanhKeo_DoAnDataSet15;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet15TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}