namespace BanhKeo_Doan.Báo_cáo_thống_kê
{
    partial class BaoCaoHangTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoHangTonKho));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rprBaoCaoHangTonKho = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.cmbKho = new System.Windows.Forms.ComboBox();
            this.cmbMatHang = new System.Windows.Forms.ComboBox();
            this.cmbLoaiHang = new System.Windows.Forms.ComboBox();
            this.dtmNgay = new System.Windows.Forms.DateTimePicker();
            this.ckbKho = new System.Windows.Forms.CheckBox();
            this.ckbMatHang = new System.Windows.Forms.CheckBox();
            this.ckbLoai = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.quanLyBanBanhKeo_DoAnDataSet62 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet62();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet62TableAdapters.KhoTableAdapter();
            this.quanLyBanBanhKeo_DoAnDataSet63 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet63();
            this.loaiHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiHangTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet63TableAdapters.LoaiHangTableAdapter();
            this.quanLyBanBanhKeo_DoAnDataSet85 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet85();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet85TableAdapters.HangHoaTableAdapter();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet85)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rprBaoCaoHangTonKho);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(833, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Xem báo cáo hàng tồn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rprBaoCaoHangTonKho
            // 
            this.rprBaoCaoHangTonKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rprBaoCaoHangTonKho.Location = new System.Drawing.Point(2, 104);
            this.rprBaoCaoHangTonKho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rprBaoCaoHangTonKho.Name = "rprBaoCaoHangTonKho";
            this.rprBaoCaoHangTonKho.ServerReport.BearerToken = null;
            this.rprBaoCaoHangTonKho.Size = new System.Drawing.Size(833, 489);
            this.rprBaoCaoHangTonKho.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.cmbKho);
            this.groupBox1.Controls.Add(this.cmbMatHang);
            this.groupBox1.Controls.Add(this.cmbLoaiHang);
            this.groupBox1.Controls.Add(this.dtmNgay);
            this.groupBox1.Controls.Add(this.ckbKho);
            this.groupBox1.Controls.Add(this.ckbMatHang);
            this.groupBox1.Controls.Add(this.ckbLoai);
            this.groupBox1.Location = new System.Drawing.Point(0, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(835, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ngày tồn:";
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(731, 29);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnThoat.Size = new System.Drawing.Size(70, 36);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.AutoSize = true;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(656, 32);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIn.Name = "btnIn";
            this.btnIn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnIn.Size = new System.Drawing.Size(52, 36);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXem
            // 
            this.btnXem.AutoSize = true;
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.Location = new System.Drawing.Point(562, 32);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXem.Name = "btnXem";
            this.btnXem.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnXem.Size = new System.Drawing.Size(62, 36);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cmbKho
            // 
            this.cmbKho.DataSource = this.khoBindingSource;
            this.cmbKho.DisplayMember = "TenKho";
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.Location = new System.Drawing.Point(106, 58);
            this.cmbKho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(158, 21);
            this.cmbKho.TabIndex = 1;
            this.cmbKho.ValueMember = "TenKho";
            // 
            // cmbMatHang
            // 
            this.cmbMatHang.DataSource = this.hangHoaBindingSource;
            this.cmbMatHang.DisplayMember = "TenHangHoa";
            this.cmbMatHang.FormattingEnabled = true;
            this.cmbMatHang.Location = new System.Drawing.Point(356, 58);
            this.cmbMatHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMatHang.Name = "cmbMatHang";
            this.cmbMatHang.Size = new System.Drawing.Size(158, 21);
            this.cmbMatHang.TabIndex = 1;
            this.cmbMatHang.ValueMember = "TenHangHoa";
            // 
            // cmbLoaiHang
            // 
            this.cmbLoaiHang.DataSource = this.loaiHangBindingSource;
            this.cmbLoaiHang.DisplayMember = "TenLoaiHang";
            this.cmbLoaiHang.FormattingEnabled = true;
            this.cmbLoaiHang.Location = new System.Drawing.Point(356, 14);
            this.cmbLoaiHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbLoaiHang.Name = "cmbLoaiHang";
            this.cmbLoaiHang.Size = new System.Drawing.Size(158, 21);
            this.cmbLoaiHang.TabIndex = 1;
            this.cmbLoaiHang.ValueMember = "TenLoaiHang";
            // 
            // dtmNgay
            // 
            this.dtmNgay.CustomFormat = "dd/MM/yyyy";
            this.dtmNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgay.Location = new System.Drawing.Point(106, 14);
            this.dtmNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmNgay.Name = "dtmNgay";
            this.dtmNgay.Size = new System.Drawing.Size(158, 20);
            this.dtmNgay.TabIndex = 1;
            // 
            // ckbKho
            // 
            this.ckbKho.AutoSize = true;
            this.ckbKho.Location = new System.Drawing.Point(16, 61);
            this.ckbKho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbKho.Name = "ckbKho";
            this.ckbKho.Size = new System.Drawing.Size(72, 17);
            this.ckbKho.TabIndex = 0;
            this.ckbKho.Text = "Kho hàng";
            this.ckbKho.UseVisualStyleBackColor = true;
            // 
            // ckbMatHang
            // 
            this.ckbMatHang.AutoSize = true;
            this.ckbMatHang.Location = new System.Drawing.Point(280, 61);
            this.ckbMatHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbMatHang.Name = "ckbMatHang";
            this.ckbMatHang.Size = new System.Drawing.Size(71, 17);
            this.ckbMatHang.TabIndex = 0;
            this.ckbMatHang.Text = "Mặt hàng";
            this.ckbMatHang.UseVisualStyleBackColor = true;
            // 
            // ckbLoai
            // 
            this.ckbLoai.AutoSize = true;
            this.ckbLoai.Location = new System.Drawing.Point(280, 17);
            this.ckbLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbLoai.Name = "ckbLoai";
            this.ckbLoai.Size = new System.Drawing.Size(73, 17);
            this.ckbLoai.TabIndex = 0;
            this.ckbLoai.Text = "Loại hàng";
            this.ckbLoai.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 616);
            this.tabControl1.TabIndex = 0;
            // 
            // quanLyBanBanhKeo_DoAnDataSet62
            // 
            this.quanLyBanBanhKeo_DoAnDataSet62.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet62";
            this.quanLyBanBanhKeo_DoAnDataSet62.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet62;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyBanBanhKeo_DoAnDataSet63
            // 
            this.quanLyBanBanhKeo_DoAnDataSet63.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet63";
            this.quanLyBanBanhKeo_DoAnDataSet63.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiHangBindingSource
            // 
            this.loaiHangBindingSource.DataMember = "LoaiHang";
            this.loaiHangBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet63;
            // 
            // loaiHangTableAdapter
            // 
            this.loaiHangTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyBanBanhKeo_DoAnDataSet85
            // 
            this.quanLyBanBanhKeo_DoAnDataSet85.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet85";
            this.quanLyBanBanhKeo_DoAnDataSet85.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet85;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoHangTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 617);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BaoCaoHangTonKho";
            this.Text = "BaoCaoHangTonKho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaoCaoHangTonKho_Load);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet85)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private System.Windows.Forms.ComboBox cmbKho;
        private System.Windows.Forms.ComboBox cmbMatHang;
        private System.Windows.Forms.ComboBox cmbLoaiHang;
        private System.Windows.Forms.DateTimePicker dtmNgay;
        private System.Windows.Forms.CheckBox ckbKho;
        private System.Windows.Forms.CheckBox ckbMatHang;
        private System.Windows.Forms.CheckBox ckbLoai;
        private System.Windows.Forms.TabControl tabControl1;
        private Microsoft.Reporting.WinForms.ReportViewer rprBaoCaoHangTonKho;
        private System.Windows.Forms.Label label1;
        private QuanLyBanBanhKeo_DoAnDataSet62 quanLyBanBanhKeo_DoAnDataSet62;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet62TableAdapters.KhoTableAdapter khoTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet63 quanLyBanBanhKeo_DoAnDataSet63;
        private System.Windows.Forms.BindingSource loaiHangBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet63TableAdapters.LoaiHangTableAdapter loaiHangTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet85 quanLyBanBanhKeo_DoAnDataSet85;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet85TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
    }
}