namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHangHoaTrongKho
{
    partial class HangHoaTrongKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangHoaTrongKho));
            this.dataHangHoaTrongKho = new System.Windows.Forms.DataGridView();
            this.cbKho = new System.Windows.Forms.CheckBox();
            this.cbHH = new System.Windows.Forms.CheckBox();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.cmbBoxKho = new System.Windows.Forms.ComboBox();
            this.Huy = new DevExpress.XtraEditors.SimpleButton();
            this.cmbBoxHH = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.cmbBoxLoaiHang = new System.Windows.Forms.ComboBox();
            this.cbLoaiHang = new System.Windows.Forms.CheckBox();
            this.quanLyBanBanhKeo_DoAnDataSet108 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet108();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet108TableAdapters.HangHoaTableAdapter();
            this.quanLyBanBanhKeo_DoAnDataSet109 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet109();
            this.loaiHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiHangTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet109TableAdapters.LoaiHangTableAdapter();
            this.quanLyBanBanhKeo_DoAnDataSet110 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet110();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet110TableAdapters.KhoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataHangHoaTrongKho)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet108)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet109)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet110)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHangHoaTrongKho
            // 
            this.dataHangHoaTrongKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataHangHoaTrongKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHangHoaTrongKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHangHoaTrongKho.Location = new System.Drawing.Point(12, 138);
            this.dataHangHoaTrongKho.Name = "dataHangHoaTrongKho";
            this.dataHangHoaTrongKho.RowHeadersWidth = 51;
            this.dataHangHoaTrongKho.Size = new System.Drawing.Size(988, 300);
            this.dataHangHoaTrongKho.TabIndex = 6;
            this.dataHangHoaTrongKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHangHoaTrongKho_CellClick);
            // 
            // cbKho
            // 
            this.cbKho.AutoSize = true;
            this.cbKho.Location = new System.Drawing.Point(800, 24);
            this.cbKho.Name = "cbKho";
            this.cbKho.Size = new System.Drawing.Size(45, 17);
            this.cbKho.TabIndex = 23;
            this.cbKho.Text = "Kho";
            this.cbKho.UseVisualStyleBackColor = true;
            // 
            // cbHH
            // 
            this.cbHH.AutoSize = true;
            this.cbHH.Location = new System.Drawing.Point(528, 20);
            this.cbHH.Name = "cbHH";
            this.cbHH.Size = new System.Drawing.Size(85, 17);
            this.cbHH.TabIndex = 20;
            this.cbHH.Text = "Tìm theo tên";
            this.cbHH.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Location = new System.Drawing.Point(212, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 50);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemHangTon.ImageOptions.SvgImage")));
            this.btnThem.Location = new System.Drawing.Point(10, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 50);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaHangTon.ImageOptions.SvgImage")));
            this.btnSua.Location = new System.Drawing.Point(111, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 50);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cmbBoxKho
            // 
            this.cmbBoxKho.DataSource = this.khoBindingSource;
            this.cmbBoxKho.DisplayMember = "TenKho";
            this.cmbBoxKho.FormattingEnabled = true;
            this.cmbBoxKho.Location = new System.Drawing.Point(851, 20);
            this.cmbBoxKho.Name = "cmbBoxKho";
            this.cmbBoxKho.Size = new System.Drawing.Size(131, 21);
            this.cmbBoxKho.TabIndex = 25;
            this.cmbBoxKho.ValueMember = "MaKho";
            // 
            // Huy
            // 
            this.Huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Huy.ImageOptions.SvgImage")));
            this.Huy.Location = new System.Drawing.Point(419, 19);
            this.Huy.Margin = new System.Windows.Forms.Padding(4);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(99, 50);
            this.Huy.TabIndex = 26;
            this.Huy.Text = "Đóng";
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // cmbBoxHH
            // 
            this.cmbBoxHH.DataSource = this.hangHoaBindingSource;
            this.cmbBoxHH.DisplayMember = "TenHangHoa";
            this.cmbBoxHH.FormattingEnabled = true;
            this.cmbBoxHH.Location = new System.Drawing.Point(631, 19);
            this.cmbBoxHH.Name = "cmbBoxHH";
            this.cmbBoxHH.Size = new System.Drawing.Size(158, 21);
            this.cmbBoxHH.TabIndex = 25;
            this.cmbBoxHH.ValueMember = "MaHangHoa";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbBoxLoaiHang);
            this.groupBox1.Controls.Add(this.cbLoaiHang);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.Huy);
            this.groupBox1.Controls.Add(this.cmbBoxHH);
            this.groupBox1.Controls.Add(this.cmbBoxKho);
            this.groupBox1.Controls.Add(this.cbKho);
            this.groupBox1.Controls.Add(this.cbHH);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hàng hóa trong kho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTimKiem.ImageOptions.SvgImage")));
            this.btnTimKiem.Location = new System.Drawing.Point(313, 19);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(99, 50);
            this.btnTimKiem.TabIndex = 27;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cmbBoxLoaiHang
            // 
            this.cmbBoxLoaiHang.DataSource = this.loaiHangBindingSource;
            this.cmbBoxLoaiHang.DisplayMember = "TenLoaiHang";
            this.cmbBoxLoaiHang.FormattingEnabled = true;
            this.cmbBoxLoaiHang.Location = new System.Drawing.Point(631, 48);
            this.cmbBoxLoaiHang.Name = "cmbBoxLoaiHang";
            this.cmbBoxLoaiHang.Size = new System.Drawing.Size(158, 21);
            this.cmbBoxLoaiHang.TabIndex = 29;
            this.cmbBoxLoaiHang.ValueMember = "MaLoaiHang";
            // 
            // cbLoaiHang
            // 
            this.cbLoaiHang.AutoSize = true;
            this.cbLoaiHang.Location = new System.Drawing.Point(528, 49);
            this.cbLoaiHang.Name = "cbLoaiHang";
            this.cbLoaiHang.Size = new System.Drawing.Size(97, 17);
            this.cbLoaiHang.TabIndex = 28;
            this.cbLoaiHang.Text = "Theo loại hàng";
            this.cbLoaiHang.UseVisualStyleBackColor = true;
            // 
            // quanLyBanBanhKeo_DoAnDataSet108
            // 
            this.quanLyBanBanhKeo_DoAnDataSet108.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet108";
            this.quanLyBanBanhKeo_DoAnDataSet108.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet108;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyBanBanhKeo_DoAnDataSet109
            // 
            this.quanLyBanBanhKeo_DoAnDataSet109.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet109";
            this.quanLyBanBanhKeo_DoAnDataSet109.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiHangBindingSource
            // 
            this.loaiHangBindingSource.DataMember = "LoaiHang";
            this.loaiHangBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet109;
            // 
            // loaiHangTableAdapter
            // 
            this.loaiHangTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyBanBanhKeo_DoAnDataSet110
            // 
            this.quanLyBanBanhKeo_DoAnDataSet110.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet110";
            this.quanLyBanBanhKeo_DoAnDataSet110.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet110;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // HangHoaTrongKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.dataHangHoaTrongKho);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "HangHoaTrongKho";
            this.Text = "HangHoaTrongKho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HangHoaTrongKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHangHoaTrongKho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet108)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet109)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet110)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataHangHoaTrongKho;
        private System.Windows.Forms.CheckBox cbKho;
        private System.Windows.Forms.CheckBox cbHH;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.ComboBox cmbBoxKho;
        private DevExpress.XtraEditors.SimpleButton Huy;
        private System.Windows.Forms.ComboBox cmbBoxHH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxLoaiHang;
        private System.Windows.Forms.CheckBox cbLoaiHang;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private QuanLyBanBanhKeo_DoAnDataSet108 quanLyBanBanhKeo_DoAnDataSet108;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet108TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet109 quanLyBanBanhKeo_DoAnDataSet109;
        private System.Windows.Forms.BindingSource loaiHangBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet109TableAdapters.LoaiHangTableAdapter loaiHangTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet110 quanLyBanBanhKeo_DoAnDataSet110;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet110TableAdapters.KhoTableAdapter khoTableAdapter;
    }
}