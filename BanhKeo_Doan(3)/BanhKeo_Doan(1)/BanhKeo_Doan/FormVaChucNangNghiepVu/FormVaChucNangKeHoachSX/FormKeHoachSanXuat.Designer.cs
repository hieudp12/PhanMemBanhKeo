namespace BanhKeo_Doan.FormNghiepVu
{
    partial class FormKeHoachSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKeHoachSanXuat));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKeHoachSX = new System.Windows.Forms.TabPage();
            this.dataKeHoachSX = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaKeHoach = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemKeHoachSX = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.dateNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dateNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTKMaKeHoach = new System.Windows.Forms.TextBox();
            this.cbNgay = new System.Windows.Forms.CheckBox();
            this.cbMaKeHoach = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabChiTietKeHoachSX = new System.Windows.Forms.TabPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dataChiTietKeHoachSX = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSuaHangHoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaHangHoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemHangHoa = new DevExpress.XtraEditors.SimpleButton();
            this.dateNgayLapKeHoach = new System.Windows.Forms.DateTimePicker();
            this.txtMaKeHoach = new System.Windows.Forms.TextBox();
            this.cmbBoxNhanVien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.PageDinhLuong = new System.Windows.Forms.TabPage();
            this.dataDinhLuong = new System.Windows.Forms.DataGridView();
            this.quanLyBanBanhKeo_DoAnDataSet99 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet99();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet99TableAdapters.NhanVienTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabKeHoachSX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKeHoachSX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabChiTietKeHoachSX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChiTietKeHoachSX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.PageDinhLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDinhLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet99)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKeHoachSX);
            this.tabControl1.Controls.Add(this.tabChiTietKeHoachSX);
            this.tabControl1.Controls.Add(this.PageDinhLuong);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabKeHoachSX
            // 
            this.tabKeHoachSX.Controls.Add(this.dataKeHoachSX);
            this.tabKeHoachSX.Controls.Add(this.groupBox1);
            this.tabKeHoachSX.Controls.Add(this.label1);
            this.tabKeHoachSX.Location = new System.Drawing.Point(4, 22);
            this.tabKeHoachSX.Name = "tabKeHoachSX";
            this.tabKeHoachSX.Padding = new System.Windows.Forms.Padding(3);
            this.tabKeHoachSX.Size = new System.Drawing.Size(836, 424);
            this.tabKeHoachSX.TabIndex = 0;
            this.tabKeHoachSX.Text = "Kế hoạch sản xuất";
            this.tabKeHoachSX.UseVisualStyleBackColor = true;
            // 
            // dataKeHoachSX
            // 
            this.dataKeHoachSX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataKeHoachSX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataKeHoachSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKeHoachSX.Location = new System.Drawing.Point(6, 174);
            this.dataKeHoachSX.Name = "dataKeHoachSX";
            this.dataKeHoachSX.Size = new System.Drawing.Size(830, 247);
            this.dataKeHoachSX.TabIndex = 2;
            this.dataKeHoachSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKeHoachSX_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Huy);
            this.groupBox1.Controls.Add(this.btnXoaKeHoach);
            this.groupBox1.Controls.Add(this.btnThemKeHoachSX);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.dateNgayKT);
            this.groupBox1.Controls.Add(this.dateNgayBD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTKMaKeHoach);
            this.groupBox1.Controls.Add(this.cbNgay);
            this.groupBox1.Controls.Add(this.cbMaKeHoach);
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // Huy
            // 
            this.Huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Huy.ImageOptions.SvgImage")));
            this.Huy.Location = new System.Drawing.Point(363, 71);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(113, 50);
            this.Huy.TabIndex = 9;
            this.Huy.Text = "Đóng";
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // btnXoaKeHoach
            // 
            this.btnXoaKeHoach.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaKeHoach.ImageOptions.SvgImage")));
            this.btnXoaKeHoach.Location = new System.Drawing.Point(244, 71);
            this.btnXoaKeHoach.Name = "btnXoaKeHoach";
            this.btnXoaKeHoach.Size = new System.Drawing.Size(113, 50);
            this.btnXoaKeHoach.TabIndex = 8;
            this.btnXoaKeHoach.Text = "Xóa";
            this.btnXoaKeHoach.Click += new System.EventHandler(this.btnXoaKeHoach_Click);
            // 
            // btnThemKeHoachSX
            // 
            this.btnThemKeHoachSX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemKeHoachSX.ImageOptions.SvgImage")));
            this.btnThemKeHoachSX.Location = new System.Drawing.Point(125, 71);
            this.btnThemKeHoachSX.Name = "btnThemKeHoachSX";
            this.btnThemKeHoachSX.Size = new System.Drawing.Size(113, 50);
            this.btnThemKeHoachSX.TabIndex = 7;
            this.btnThemKeHoachSX.Text = "Thêm";
            this.btnThemKeHoachSX.Click += new System.EventHandler(this.btnThemKeHoachSX_Click);
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
            // dateNgayKT
            // 
            this.dateNgayKT.Location = new System.Drawing.Point(608, 30);
            this.dateNgayKT.Name = "dateNgayKT";
            this.dateNgayKT.Size = new System.Drawing.Size(200, 20);
            this.dateNgayKT.TabIndex = 5;
            // 
            // dateNgayBD
            // 
            this.dateNgayBD.Location = new System.Drawing.Point(369, 30);
            this.dateNgayBD.Name = "dateNgayBD";
            this.dateNgayBD.Size = new System.Drawing.Size(200, 20);
            this.dateNgayBD.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến";
            // 
            // txtTKMaKeHoach
            // 
            this.txtTKMaKeHoach.Location = new System.Drawing.Point(95, 31);
            this.txtTKMaKeHoach.Name = "txtTKMaKeHoach";
            this.txtTKMaKeHoach.Size = new System.Drawing.Size(183, 20);
            this.txtTKMaKeHoach.TabIndex = 2;
            // 
            // cbNgay
            // 
            this.cbNgay.AutoSize = true;
            this.cbNgay.Location = new System.Drawing.Point(285, 33);
            this.cbNgay.Name = "cbNgay";
            this.cbNgay.Size = new System.Drawing.Size(77, 17);
            this.cbNgay.TabIndex = 1;
            this.cbNgay.Text = "Theo ngày";
            this.cbNgay.UseVisualStyleBackColor = true;
            // 
            // cbMaKeHoach
            // 
            this.cbMaKeHoach.AutoSize = true;
            this.cbMaKeHoach.Location = new System.Drawing.Point(9, 33);
            this.cbMaKeHoach.Name = "cbMaKeHoach";
            this.cbMaKeHoach.Size = new System.Drawing.Size(87, 17);
            this.cbMaKeHoach.TabIndex = 0;
            this.cbMaKeHoach.Text = "Theo số HĐ:";
            this.cbMaKeHoach.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kế hoạch sản xuất";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabChiTietKeHoachSX
            // 
            this.tabChiTietKeHoachSX.Controls.Add(this.panelControl2);
            this.tabChiTietKeHoachSX.Controls.Add(this.groupBox2);
            this.tabChiTietKeHoachSX.Location = new System.Drawing.Point(4, 22);
            this.tabChiTietKeHoachSX.Name = "tabChiTietKeHoachSX";
            this.tabChiTietKeHoachSX.Padding = new System.Windows.Forms.Padding(3);
            this.tabChiTietKeHoachSX.Size = new System.Drawing.Size(836, 424);
            this.tabChiTietKeHoachSX.TabIndex = 1;
            this.tabChiTietKeHoachSX.Text = "Chi tiết kế hoạch sản xuất";
            this.tabChiTietKeHoachSX.UseVisualStyleBackColor = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.dataChiTietKeHoachSX);
            this.panelControl2.Location = new System.Drawing.Point(3, 173);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(827, 245);
            this.panelControl2.TabIndex = 2;
            // 
            // dataChiTietKeHoachSX
            // 
            this.dataChiTietKeHoachSX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataChiTietKeHoachSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChiTietKeHoachSX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataChiTietKeHoachSX.Location = new System.Drawing.Point(2, 2);
            this.dataChiTietKeHoachSX.Name = "dataChiTietKeHoachSX";
            this.dataChiTietKeHoachSX.Size = new System.Drawing.Size(823, 241);
            this.dataChiTietKeHoachSX.TabIndex = 31;
            this.dataChiTietKeHoachSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataChiTietKeHoachSX_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnGhi);
            this.groupBox2.Controls.Add(this.cmbBoxNhanVien);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnSuaHangHoa);
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.btnXoaHangHoa);
            this.groupBox2.Controls.Add(this.btnThemHangHoa);
            this.groupBox2.Controls.Add(this.dateNgayLapKeHoach);
            this.groupBox2.Controls.Add(this.txtMaKeHoach);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 167);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phần gốc";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(365, 75);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(453, 20);
            this.txtGhiChu.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ghi chú";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(635, 38);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(183, 20);
            this.txtTongTien.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngày kế hoạch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Số kế hoạch";
            // 
            // btnSuaHangHoa
            // 
            this.btnSuaHangHoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaHangHoa.ImageOptions.SvgImage")));
            this.btnSuaHangHoa.Location = new System.Drawing.Point(130, 111);
            this.btnSuaHangHoa.Name = "btnSuaHangHoa";
            this.btnSuaHangHoa.Size = new System.Drawing.Size(113, 50);
            this.btnSuaHangHoa.TabIndex = 20;
            this.btnSuaHangHoa.Text = "Sửa";
            this.btnSuaHangHoa.Click += new System.EventHandler(this.btnSuaHangHoa_Click);
            // 
            // btnIn
            // 
            this.btnIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIn.ImageOptions.SvgImage")));
            this.btnIn.Location = new System.Drawing.Point(365, 111);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(113, 50);
            this.btnIn.TabIndex = 19;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoaHangHoa
            // 
            this.btnXoaHangHoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaHangHoa.ImageOptions.SvgImage")));
            this.btnXoaHangHoa.Location = new System.Drawing.Point(246, 111);
            this.btnXoaHangHoa.Name = "btnXoaHangHoa";
            this.btnXoaHangHoa.Size = new System.Drawing.Size(113, 50);
            this.btnXoaHangHoa.TabIndex = 18;
            this.btnXoaHangHoa.Text = "Xóa";
            this.btnXoaHangHoa.Click += new System.EventHandler(this.btnXoaHangHoa_Click);
            // 
            // btnThemHangHoa
            // 
            this.btnThemHangHoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemHangHoa.ImageOptions.SvgImage")));
            this.btnThemHangHoa.Location = new System.Drawing.Point(11, 111);
            this.btnThemHangHoa.Name = "btnThemHangHoa";
            this.btnThemHangHoa.Size = new System.Drawing.Size(113, 50);
            this.btnThemHangHoa.TabIndex = 17;
            this.btnThemHangHoa.Text = "Thêm";
            this.btnThemHangHoa.Click += new System.EventHandler(this.btnThemHangHoa_Click);
            // 
            // dateNgayLapKeHoach
            // 
            this.dateNgayLapKeHoach.Location = new System.Drawing.Point(365, 38);
            this.dateNgayLapKeHoach.Name = "dateNgayLapKeHoach";
            this.dateNgayLapKeHoach.Size = new System.Drawing.Size(200, 20);
            this.dateNgayLapKeHoach.TabIndex = 14;
            // 
            // txtMaKeHoach
            // 
            this.txtMaKeHoach.Location = new System.Drawing.Point(82, 38);
            this.txtMaKeHoach.Name = "txtMaKeHoach";
            this.txtMaKeHoach.Size = new System.Drawing.Size(183, 20);
            this.txtMaKeHoach.TabIndex = 12;
            // 
            // cmbBoxNhanVien
            // 
            this.cmbBoxNhanVien.DataSource = this.nhanVienBindingSource;
            this.cmbBoxNhanVien.DisplayMember = "TenNhanVien";
            this.cmbBoxNhanVien.FormattingEnabled = true;
            this.cmbBoxNhanVien.Location = new System.Drawing.Point(82, 71);
            this.cmbBoxNhanVien.Name = "cmbBoxNhanVien";
            this.cmbBoxNhanVien.Size = new System.Drawing.Size(183, 21);
            this.cmbBoxNhanVien.TabIndex = 33;
            this.cmbBoxNhanVien.ValueMember = "MaNhanVien";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Nhân viên";
            // 
            // btnGhi
            // 
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Location = new System.Drawing.Point(484, 111);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(113, 50);
            this.btnGhi.TabIndex = 34;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // PageDinhLuong
            // 
            this.PageDinhLuong.Controls.Add(this.dataDinhLuong);
            this.PageDinhLuong.Location = new System.Drawing.Point(4, 22);
            this.PageDinhLuong.Name = "PageDinhLuong";
            this.PageDinhLuong.Padding = new System.Windows.Forms.Padding(3);
            this.PageDinhLuong.Size = new System.Drawing.Size(836, 424);
            this.PageDinhLuong.TabIndex = 2;
            this.PageDinhLuong.Text = "Định lượng";
            this.PageDinhLuong.UseVisualStyleBackColor = true;
            // 
            // dataDinhLuong
            // 
            this.dataDinhLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDinhLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDinhLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDinhLuong.Location = new System.Drawing.Point(3, 3);
            this.dataDinhLuong.Name = "dataDinhLuong";
            this.dataDinhLuong.Size = new System.Drawing.Size(830, 418);
            this.dataDinhLuong.TabIndex = 0;
            // 
            // quanLyBanBanhKeo_DoAnDataSet99
            // 
            this.quanLyBanBanhKeo_DoAnDataSet99.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet99";
            this.quanLyBanBanhKeo_DoAnDataSet99.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet99;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // FormKeHoachSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormKeHoachSanXuat";
            this.Text = "FormKeHoachSanXuat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKeHoachSanXuat_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabKeHoachSX.ResumeLayout(false);
            this.tabKeHoachSX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKeHoachSX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabChiTietKeHoachSX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataChiTietKeHoachSX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.PageDinhLuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDinhLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet99)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKeHoachSX;
        private System.Windows.Forms.TabPage tabChiTietKeHoachSX;
        private System.Windows.Forms.DataGridView dataKeHoachSX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbNgay;
        private System.Windows.Forms.CheckBox cbMaKeHoach;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.DateTimePicker dateNgayKT;
        private System.Windows.Forms.DateTimePicker dateNgayBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTKMaKeHoach;
        private DevExpress.XtraEditors.SimpleButton Huy;
        private DevExpress.XtraEditors.SimpleButton btnXoaKeHoach;
        private DevExpress.XtraEditors.SimpleButton btnThemKeHoachSX;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnSuaHangHoa;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnXoaHangHoa;
        private DevExpress.XtraEditors.SimpleButton btnThemHangHoa;
        private System.Windows.Forms.DateTimePicker dateNgayLapKeHoach;
        private System.Windows.Forms.TextBox txtMaKeHoach;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataChiTietKeHoachSX;
        private DevExpress.XtraEditors.SimpleButton btnGhi;
        private System.Windows.Forms.ComboBox cmbBoxNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage PageDinhLuong;
        private System.Windows.Forms.DataGridView dataDinhLuong;
        private QuanLyBanBanhKeo_DoAnDataSet99 quanLyBanBanhKeo_DoAnDataSet99;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet99TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}