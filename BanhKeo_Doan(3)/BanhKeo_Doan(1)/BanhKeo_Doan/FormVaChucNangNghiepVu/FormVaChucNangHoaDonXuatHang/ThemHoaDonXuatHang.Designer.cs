namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHoaDonXuatHang
{
    partial class ThemHoaDonXuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemHoaDonXuatHang));
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongChuaCK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBoxKH = new System.Windows.Forms.ComboBox();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet21 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet21();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.dateNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhanTramCK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoTienCK = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongSauCK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBoxNV = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet22 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet22();
            this.khachHangTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet21TableAdapters.KhachHangTableAdapter();
            this.nhanVienTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet22TableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet22)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 210;
            this.label8.Text = "Nhân viên bán hàng";
            // 
            // txtTongChuaCK
            // 
            this.txtTongChuaCK.Enabled = false;
            this.txtTongChuaCK.Location = new System.Drawing.Point(522, 23);
            this.txtTongChuaCK.Name = "txtTongChuaCK";
            this.txtTongChuaCK.Size = new System.Drawing.Size(266, 20);
            this.txtTongChuaCK.TabIndex = 209;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 208;
            this.label7.Text = "Tổng chưa CK";
            // 
            // cmbBoxKH
            // 
            this.cmbBoxKH.DataSource = this.khachHangBindingSource;
            this.cmbBoxKH.DisplayMember = "TenKhachHang";
            this.cmbBoxKH.FormattingEnabled = true;
            this.cmbBoxKH.Location = new System.Drawing.Point(130, 93);
            this.cmbBoxKH.Name = "cmbBoxKH";
            this.cmbBoxKH.Size = new System.Drawing.Size(232, 21);
            this.cmbBoxKH.TabIndex = 207;
            this.cmbBoxKH.ValueMember = "MaKhachHang";
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet21;
            // 
            // quanLyBanBanhKeo_DoAnDataSet21
            // 
            this.quanLyBanBanhKeo_DoAnDataSet21.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet21";
            this.quanLyBanBanhKeo_DoAnDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 206;
            this.label6.Text = "Khách hàng";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(130, 23);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(232, 20);
            this.txtMaHD.TabIndex = 205;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 204;
            this.label5.Text = "Mã hóa đơn xuất";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(522, 132);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(266, 20);
            this.txtGhiChu.TabIndex = 203;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 202;
            this.label4.Text = "Ghi chú";
            // 
            // Huy
            // 
            this.Huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Huy.ImageOptions.SvgImage")));
            this.Huy.Location = new System.Drawing.Point(408, 204);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(100, 45);
            this.Huy.TabIndex = 201;
            this.Huy.Text = "Hủy bỏ";
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Location = new System.Drawing.Point(262, 204);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 45);
            this.btnThem.TabIndex = 200;
            this.btnThem.Text = "Chấp nhận";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dateNgayXuat
            // 
            this.dateNgayXuat.Location = new System.Drawing.Point(130, 58);
            this.dateNgayXuat.Name = "dateNgayXuat";
            this.dateNgayXuat.Size = new System.Drawing.Size(232, 20);
            this.dateNgayXuat.TabIndex = 199;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 195;
            this.label2.Text = "Ngày xuất";
            // 
            // txtPhanTramCK
            // 
            this.txtPhanTramCK.Location = new System.Drawing.Point(523, 61);
            this.txtPhanTramCK.Name = "txtPhanTramCK";
            this.txtPhanTramCK.Size = new System.Drawing.Size(33, 20);
            this.txtPhanTramCK.TabIndex = 213;
            this.txtPhanTramCK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhanTramCK_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 212;
            this.label9.Text = "% chiết khấu";
            // 
            // txtSoTienCK
            // 
            this.txtSoTienCK.Enabled = false;
            this.txtSoTienCK.Location = new System.Drawing.Point(661, 61);
            this.txtSoTienCK.Name = "txtSoTienCK";
            this.txtSoTienCK.Size = new System.Drawing.Size(127, 20);
            this.txtSoTienCK.TabIndex = 215;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(562, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 214;
            this.label10.Text = "Số tiền chiết khấu";
            // 
            // txtTongSauCK
            // 
            this.txtTongSauCK.Enabled = false;
            this.txtTongSauCK.Location = new System.Drawing.Point(522, 94);
            this.txtTongSauCK.Name = "txtTongSauCK";
            this.txtTongSauCK.Size = new System.Drawing.Size(266, 20);
            this.txtTongSauCK.TabIndex = 217;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(404, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 216;
            this.label11.Text = "Tổng sau CK";
            // 
            // cmbBoxNV
            // 
            this.cmbBoxNV.DataSource = this.nhanVienBindingSource;
            this.cmbBoxNV.DisplayMember = "TenNhanVien";
            this.cmbBoxNV.FormattingEnabled = true;
            this.cmbBoxNV.Location = new System.Drawing.Point(130, 128);
            this.cmbBoxNV.Name = "cmbBoxNV";
            this.cmbBoxNV.Size = new System.Drawing.Size(232, 21);
            this.cmbBoxNV.TabIndex = 218;
            this.cmbBoxNV.ValueMember = "MaNhanVien";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet22;
            // 
            // quanLyBanBanhKeo_DoAnDataSet22
            // 
            this.quanLyBanBanhKeo_DoAnDataSet22.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet22";
            this.quanLyBanBanhKeo_DoAnDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // ThemHoaDonXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 269);
            this.Controls.Add(this.cmbBoxNV);
            this.Controls.Add(this.txtTongSauCK);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSoTienCK);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPhanTramCK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTongChuaCK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbBoxKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Huy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dateNgayXuat);
            this.Controls.Add(this.label2);
            this.Name = "ThemHoaDonXuatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemHoaDonXuatHang";
            this.Load += new System.EventHandler(this.ThemHoaDonXuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongChuaCK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBoxKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton Huy;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.DateTimePicker dateNgayXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhanTramCK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoTienCK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongSauCK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbBoxNV;
        private QuanLyBanBanhKeo_DoAnDataSet21 quanLyBanBanhKeo_DoAnDataSet21;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet21TableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet22 quanLyBanBanhKeo_DoAnDataSet22;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet22TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}