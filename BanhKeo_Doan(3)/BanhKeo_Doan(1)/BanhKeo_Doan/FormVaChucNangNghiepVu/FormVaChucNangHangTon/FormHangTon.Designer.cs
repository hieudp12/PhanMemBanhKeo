namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHangTon
{
    partial class FormHangTon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHangTon));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Huy = new DevExpress.XtraEditors.SimpleButton();
            this.cboTenHangHoa = new System.Windows.Forms.ComboBox();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.chkTheoKho = new System.Windows.Forms.CheckBox();
            this.chkTheoTenHang = new System.Windows.Forms.CheckBox();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemHangTon = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaHangTon = new DevExpress.XtraEditors.SimpleButton();
            this.dgvHangTonKho = new System.Windows.Forms.DataGridView();
            this.quanLyBanBanhKeo_DoAnDataSet35 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet35();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet35TableAdapters.HangHoaTableAdapter();
            this.quanLyBanBanhKeo_DoAnDataSet36 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet36();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet36TableAdapters.KhoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hàng tồn kho đầu kỳ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Huy);
            this.groupBox1.Controls.Add(this.cboTenHangHoa);
            this.groupBox1.Controls.Add(this.cboKho);
            this.groupBox1.Controls.Add(this.chkTheoKho);
            this.groupBox1.Controls.Add(this.chkTheoTenHang);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThemHangTon);
            this.groupBox1.Controls.Add(this.btnSuaHangTon);
            this.groupBox1.Location = new System.Drawing.Point(4, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Huy
            // 
            this.Huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Huy.ImageOptions.SvgImage")));
            this.Huy.Location = new System.Drawing.Point(314, 19);
            this.Huy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(99, 50);
            this.Huy.TabIndex = 26;
            this.Huy.Text = "Đóng";
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // cboTenHangHoa
            // 
            this.cboTenHangHoa.DataSource = this.hangHoaBindingSource;
            this.cboTenHangHoa.DisplayMember = "TenHangHoa";
            this.cboTenHangHoa.FormattingEnabled = true;
            this.cboTenHangHoa.Location = new System.Drawing.Point(660, 24);
            this.cboTenHangHoa.Name = "cboTenHangHoa";
            this.cboTenHangHoa.Size = new System.Drawing.Size(158, 21);
            this.cboTenHangHoa.TabIndex = 25;
            this.cboTenHangHoa.ValueMember = "MaHangHoa";
            this.cboTenHangHoa.SelectedIndexChanged += new System.EventHandler(this.cboTenHangHoa_SelectedIndexChanged);
            // 
            // cboKho
            // 
            this.cboKho.DataSource = this.khoBindingSource;
            this.cboKho.DisplayMember = "TenKho";
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(660, 50);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(158, 21);
            this.cboKho.TabIndex = 25;
            this.cboKho.ValueMember = "MaKho";
            this.cboKho.SelectedIndexChanged += new System.EventHandler(this.cboKho_SelectedIndexChanged);
            // 
            // chkTheoKho
            // 
            this.chkTheoKho.AutoSize = true;
            this.chkTheoKho.Location = new System.Drawing.Point(579, 54);
            this.chkTheoKho.Name = "chkTheoKho";
            this.chkTheoKho.Size = new System.Drawing.Size(45, 17);
            this.chkTheoKho.TabIndex = 23;
            this.chkTheoKho.Text = "Kho";
            this.chkTheoKho.UseVisualStyleBackColor = true;
            this.chkTheoKho.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkTheoTenHang
            // 
            this.chkTheoTenHang.AutoSize = true;
            this.chkTheoTenHang.Location = new System.Drawing.Point(578, 25);
            this.chkTheoTenHang.Name = "chkTheoTenHang";
            this.chkTheoTenHang.Size = new System.Drawing.Size(85, 17);
            this.chkTheoTenHang.TabIndex = 20;
            this.chkTheoTenHang.Text = "Tìm theo tên";
            this.chkTheoTenHang.UseVisualStyleBackColor = true;
            this.chkTheoTenHang.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            // btnThemHangTon
            // 
            this.btnThemHangTon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemHangTon.ImageOptions.SvgImage")));
            this.btnThemHangTon.Location = new System.Drawing.Point(10, 19);
            this.btnThemHangTon.Name = "btnThemHangTon";
            this.btnThemHangTon.Size = new System.Drawing.Size(95, 50);
            this.btnThemHangTon.TabIndex = 17;
            this.btnThemHangTon.Text = "Thêm";
            this.btnThemHangTon.Click += new System.EventHandler(this.btnThemHangTon_Click);
            // 
            // btnSuaHangTon
            // 
            this.btnSuaHangTon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaHangTon.ImageOptions.SvgImage")));
            this.btnSuaHangTon.Location = new System.Drawing.Point(111, 19);
            this.btnSuaHangTon.Name = "btnSuaHangTon";
            this.btnSuaHangTon.Size = new System.Drawing.Size(95, 50);
            this.btnSuaHangTon.TabIndex = 16;
            this.btnSuaHangTon.Text = "Sửa";
            this.btnSuaHangTon.Click += new System.EventHandler(this.btnSuaHangTon_Click);
            // 
            // dgvHangTonKho
            // 
            this.dgvHangTonKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHangTonKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangTonKho.Location = new System.Drawing.Point(4, 146);
            this.dgvHangTonKho.Name = "dgvHangTonKho";
            this.dgvHangTonKho.RowHeadersWidth = 51;
            this.dgvHangTonKho.Size = new System.Drawing.Size(875, 300);
            this.dgvHangTonKho.TabIndex = 3;
            this.dgvHangTonKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangTonKho_CellContentClick);
            this.dgvHangTonKho.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangTonKho_CellDoubleClick);
            // 
            // quanLyBanBanhKeo_DoAnDataSet35
            // 
            this.quanLyBanBanhKeo_DoAnDataSet35.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet35";
            this.quanLyBanBanhKeo_DoAnDataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet35;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyBanBanhKeo_DoAnDataSet36
            // 
            this.quanLyBanBanhKeo_DoAnDataSet36.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet36";
            this.quanLyBanBanhKeo_DoAnDataSet36.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet36;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // FormHangTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.dgvHangTonKho);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormHangTon";
            this.Text = "FormHangTon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHangTon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThemHangTon;
        private DevExpress.XtraEditors.SimpleButton btnSuaHangTon;
        private System.Windows.Forms.CheckBox chkTheoKho;
        private System.Windows.Forms.CheckBox chkTheoTenHang;
        private System.Windows.Forms.DataGridView dgvHangTonKho;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.ComboBox cboTenHangHoa;
        private DevExpress.XtraEditors.SimpleButton Huy;
        private QuanLyBanBanhKeo_DoAnDataSet35 quanLyBanBanhKeo_DoAnDataSet35;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet35TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet36 quanLyBanBanhKeo_DoAnDataSet36;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet36TableAdapters.KhoTableAdapter khoTableAdapter;
    }
}