namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatChuyen
{
    partial class FormPhieuXuatChuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuXuatChuyen));
            this.tabPhieuXuatChuyen = new System.Windows.Forms.TabControl();
            this.tabPhieu = new System.Windows.Forms.TabPage();
            this.dgvPhieuXuatChuyen = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.dtmDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtmTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.ckbTheoNgay = new System.Windows.Forms.CheckBox();
            this.ckbMaPhieu = new System.Windows.Forms.CheckBox();
            this.tabChiTiet = new System.Windows.Forms.TabPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvChiTietPhieuXuat = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKho = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSuaHangHoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemHangHoa = new DevExpress.XtraEditors.SimpleButton();
            this.dtmNgayXuatChuyen = new System.Windows.Forms.DateTimePicker();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.txtKho = new System.Windows.Forms.TextBox();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.Huy = new DevExpress.XtraEditors.SimpleButton();
            this.tabPhieuXuatChuyen.SuspendLayout();
            this.tabPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuatChuyen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuXuat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPhieuXuatChuyen
            // 
            this.tabPhieuXuatChuyen.Controls.Add(this.tabPhieu);
            this.tabPhieuXuatChuyen.Controls.Add(this.tabChiTiet);
            this.tabPhieuXuatChuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPhieuXuatChuyen.Location = new System.Drawing.Point(0, 0);
            this.tabPhieuXuatChuyen.Name = "tabPhieuXuatChuyen";
            this.tabPhieuXuatChuyen.SelectedIndex = 0;
            this.tabPhieuXuatChuyen.Size = new System.Drawing.Size(847, 450);
            this.tabPhieuXuatChuyen.TabIndex = 2;
            // 
            // tabPhieu
            // 
            this.tabPhieu.Controls.Add(this.dgvPhieuXuatChuyen);
            this.tabPhieu.Controls.Add(this.groupBox1);
            this.tabPhieu.Location = new System.Drawing.Point(4, 22);
            this.tabPhieu.Name = "tabPhieu";
            this.tabPhieu.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPhieu.Size = new System.Drawing.Size(839, 424);
            this.tabPhieu.TabIndex = 0;
            this.tabPhieu.Text = "Danh sách phiếu xuất chuyển";
            this.tabPhieu.UseVisualStyleBackColor = true;
            // 
            // dgvPhieuXuatChuyen
            // 
            this.dgvPhieuXuatChuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuXuatChuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuXuatChuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuXuatChuyen.Location = new System.Drawing.Point(6, 141);
            this.dgvPhieuXuatChuyen.Name = "dgvPhieuXuatChuyen";
            this.dgvPhieuXuatChuyen.RowHeadersWidth = 51;
            this.dgvPhieuXuatChuyen.Size = new System.Drawing.Size(833, 280);
            this.dgvPhieuXuatChuyen.TabIndex = 2;
            this.dgvPhieuXuatChuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuXuatChuyen_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.dtmDenNgay);
            this.groupBox1.Controls.Add(this.dtmTuNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Controls.Add(this.ckbTheoNgay);
            this.groupBox1.Controls.Add(this.ckbMaPhieu);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Location = new System.Drawing.Point(363, 71);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(113, 50);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Đóng";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Location = new System.Drawing.Point(244, 71);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 50);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Location = new System.Drawing.Point(125, 71);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 50);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThemPhieuXuatChuyen_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTimKiem.ImageOptions.SvgImage")));
            this.btnTimKiem.Location = new System.Drawing.Point(6, 71);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(113, 50);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtmDenNgay
            // 
            this.dtmDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtmDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDenNgay.Location = new System.Drawing.Point(626, 30);
            this.dtmDenNgay.Name = "dtmDenNgay";
            this.dtmDenNgay.Size = new System.Drawing.Size(200, 20);
            this.dtmDenNgay.TabIndex = 5;
            // 
            // dtmTuNgay
            // 
            this.dtmTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtmTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmTuNgay.Location = new System.Drawing.Point(387, 30);
            this.dtmTuNgay.Name = "dtmTuNgay";
            this.dtmTuNgay.Size = new System.Drawing.Size(200, 20);
            this.dtmTuNgay.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(112, 30);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(183, 20);
            this.txtMaPhieu.TabIndex = 2;
            // 
            // ckbTheoNgay
            // 
            this.ckbTheoNgay.AutoSize = true;
            this.ckbTheoNgay.Location = new System.Drawing.Point(301, 33);
            this.ckbTheoNgay.Name = "ckbTheoNgay";
            this.ckbTheoNgay.Size = new System.Drawing.Size(77, 17);
            this.ckbTheoNgay.TabIndex = 1;
            this.ckbTheoNgay.Text = "Theo ngày";
            this.ckbTheoNgay.UseVisualStyleBackColor = true;
            // 
            // ckbMaPhieu
            // 
            this.ckbMaPhieu.AutoSize = true;
            this.ckbMaPhieu.Location = new System.Drawing.Point(9, 33);
            this.ckbMaPhieu.Name = "ckbMaPhieu";
            this.ckbMaPhieu.Size = new System.Drawing.Size(97, 17);
            this.ckbMaPhieu.TabIndex = 0;
            this.ckbMaPhieu.Text = "Theo số phiếu:";
            this.ckbMaPhieu.UseVisualStyleBackColor = true;
            // 
            // tabChiTiet
            // 
            this.tabChiTiet.Controls.Add(this.panelControl2);
            this.tabChiTiet.Controls.Add(this.groupBox2);
            this.tabChiTiet.Location = new System.Drawing.Point(4, 22);
            this.tabChiTiet.Name = "tabChiTiet";
            this.tabChiTiet.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabChiTiet.Size = new System.Drawing.Size(839, 424);
            this.tabChiTiet.TabIndex = 1;
            this.tabChiTiet.Text = "Chi tiết phiếu xuất chuyển";
            this.tabChiTiet.UseVisualStyleBackColor = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.dgvChiTietPhieuXuat);
            this.panelControl2.Location = new System.Drawing.Point(8, 163);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(825, 255);
            this.panelControl2.TabIndex = 2;
            // 
            // dgvChiTietPhieuXuat
            // 
            this.dgvChiTietPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietPhieuXuat.Location = new System.Drawing.Point(2, 2);
            this.dgvChiTietPhieuXuat.Name = "dgvChiTietPhieuXuat";
            this.dgvChiTietPhieuXuat.RowHeadersWidth = 51;
            this.dgvChiTietPhieuXuat.Size = new System.Drawing.Size(821, 251);
            this.dgvChiTietPhieuXuat.TabIndex = 31;
            this.dgvChiTietPhieuXuat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPhieuXuat_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblKho);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnSuaHangHoa);
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.btnXoaChiTiet);
            this.groupBox2.Controls.Add(this.btnThemHangHoa);
            this.groupBox2.Controls.Add(this.dtmNgayXuatChuyen);
            this.groupBox2.Controls.Add(this.txtNhanVien);
            this.groupBox2.Controls.Add(this.txtKho);
            this.groupBox2.Controls.Add(this.txtSoPhieu);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 151);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phần gốc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Nhân viên giao";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(141, 74);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ReadOnly = true;
            this.txtGhiChu.Size = new System.Drawing.Size(606, 20);
            this.txtGhiChu.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ghi chú";
            // 
            // lblKho
            // 
            this.lblKho.AutoSize = true;
            this.lblKho.Location = new System.Drawing.Point(430, 23);
            this.lblKho.Name = "lblKho";
            this.lblKho.Size = new System.Drawing.Size(26, 13);
            this.lblKho.TabIndex = 22;
            this.lblKho.Text = "Kho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngày xuất chuyển";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Số phiếu xuất chuyển";
            // 
            // btnSuaHangHoa
            // 
            this.btnSuaHangHoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaHangHoa.ImageOptions.SvgImage")));
            this.btnSuaHangHoa.Location = new System.Drawing.Point(133, 108);
            this.btnSuaHangHoa.Name = "btnSuaHangHoa";
            this.btnSuaHangHoa.Size = new System.Drawing.Size(113, 35);
            this.btnSuaHangHoa.TabIndex = 20;
            this.btnSuaHangHoa.Text = "Sửa";
            this.btnSuaHangHoa.Click += new System.EventHandler(this.btnSuaHangHoa_Click);
            // 
            // btnIn
            // 
            this.btnIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIn.ImageOptions.SvgImage")));
            this.btnIn.Location = new System.Drawing.Point(371, 108);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(113, 35);
            this.btnIn.TabIndex = 19;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoaChiTiet
            // 
            this.btnXoaChiTiet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaChiTiet.ImageOptions.SvgImage")));
            this.btnXoaChiTiet.Location = new System.Drawing.Point(252, 108);
            this.btnXoaChiTiet.Name = "btnXoaChiTiet";
            this.btnXoaChiTiet.Size = new System.Drawing.Size(113, 35);
            this.btnXoaChiTiet.TabIndex = 18;
            this.btnXoaChiTiet.Text = "Xóa";
            this.btnXoaChiTiet.Click += new System.EventHandler(this.btnXoaChiTiet_Click);
            // 
            // btnThemHangHoa
            // 
            this.btnThemHangHoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemHangHoa.ImageOptions.SvgImage")));
            this.btnThemHangHoa.Location = new System.Drawing.Point(14, 108);
            this.btnThemHangHoa.Name = "btnThemHangHoa";
            this.btnThemHangHoa.Size = new System.Drawing.Size(113, 35);
            this.btnThemHangHoa.TabIndex = 17;
            this.btnThemHangHoa.Text = "Thêm";
            this.btnThemHangHoa.Click += new System.EventHandler(this.btnThemHangHoa_Click);
            // 
            // dtmNgayXuatChuyen
            // 
            this.dtmNgayXuatChuyen.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayXuatChuyen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayXuatChuyen.Location = new System.Drawing.Point(141, 43);
            this.dtmNgayXuatChuyen.Name = "dtmNgayXuatChuyen";
            this.dtmNgayXuatChuyen.Size = new System.Drawing.Size(225, 20);
            this.dtmNgayXuatChuyen.TabIndex = 14;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(522, 47);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(225, 20);
            this.txtNhanVien.TabIndex = 12;
            // 
            // txtKho
            // 
            this.txtKho.Location = new System.Drawing.Point(522, 20);
            this.txtKho.Name = "txtKho";
            this.txtKho.ReadOnly = true;
            this.txtKho.Size = new System.Drawing.Size(225, 20);
            this.txtKho.TabIndex = 12;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(141, 19);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.ReadOnly = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(225, 20);
            this.txtSoPhieu.TabIndex = 12;
            // 
            // Huy
            // 
            this.Huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Huy.ImageOptions.SvgImage")));
            this.Huy.Location = new System.Drawing.Point(484, 87);
            this.Huy.Margin = new System.Windows.Forms.Padding(4);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(151, 62);
            this.Huy.TabIndex = 9;
            this.Huy.Text = "Đóng";
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // FormPhieuXuatChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.tabPhieuXuatChuyen);
            this.Name = "FormPhieuXuatChuyen";
            this.Text = "FormPhieuXuatChuyen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPhieuXuatChuyen_Load);
            this.tabPhieuXuatChuyen.ResumeLayout(false);
            this.tabPhieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuatChuyen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuXuat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabPhieuXuatChuyen;
        private System.Windows.Forms.TabPage tabPhieu;
        private System.Windows.Forms.DataGridView dgvPhieuXuatChuyen;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton Huy;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.DateTimePicker dtmDenNgay;
        private System.Windows.Forms.DateTimePicker dtmTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.CheckBox ckbTheoNgay;
        private System.Windows.Forms.CheckBox ckbMaPhieu;
        private System.Windows.Forms.TabPage tabChiTiet;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuXuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnSuaHangHoa;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnXoaChiTiet;
        private DevExpress.XtraEditors.SimpleButton btnThemHangHoa;
        private System.Windows.Forms.DateTimePicker dtmNgayXuatChuyen;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label lblKho;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.TextBox txtKho;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}