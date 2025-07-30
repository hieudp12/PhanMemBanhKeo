namespace BanhKeo_Doan.Báo_cáo_thống_kê
{
    partial class BaoCaoHangNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoHangNhapKho));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rprNhapHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.ckbMatHang = new System.Windows.Forms.CheckBox();
            this.ckbNCC = new System.Windows.Forms.CheckBox();
            this.ckbLoaiHang = new System.Windows.Forms.CheckBox();
            this.cmbMatHang = new System.Windows.Forms.ComboBox();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.cmbLoaiHang = new System.Windows.Forms.ComboBox();
            this.dtmDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.quanLyBanBanhKeo_DoAnDataSet76 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet76();
            this.loaiHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiHangTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet76TableAdapters.LoaiHangTableAdapter();
            this.quanLyBanBanhKeo_DoAnDataSet77 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet77();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet77TableAdapters.NhaCungCapTableAdapter();
            this.quanLyBanBanhKeo_DoAnDataSet78 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet78();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet78TableAdapters.HangHoaTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet77)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet78)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 755);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rprNhapHang);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(812, 729);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Báo cáo hàng nhập kho";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rprNhapHang
            // 
            this.rprNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rprNhapHang.Location = new System.Drawing.Point(5, 107);
            this.rprNhapHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rprNhapHang.Name = "rprNhapHang";
            this.rprNhapHang.ServerReport.BearerToken = null;
            this.rprNhapHang.Size = new System.Drawing.Size(804, 617);
            this.rprNhapHang.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.ckbMatHang);
            this.groupBox1.Controls.Add(this.ckbNCC);
            this.groupBox1.Controls.Add(this.ckbLoaiHang);
            this.groupBox1.Controls.Add(this.cmbMatHang);
            this.groupBox1.Controls.Add(this.cmbNhaCungCap);
            this.groupBox1.Controls.Add(this.cmbLoaiHang);
            this.groupBox1.Controls.Add(this.dtmDenNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtmTuNgay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(804, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnXem
            // 
            this.btnXem.AutoSize = true;
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.Location = new System.Drawing.Point(661, 19);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXem.Name = "btnXem";
            this.btnXem.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnXem.Size = new System.Drawing.Size(62, 36);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(732, 37);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnThoat.Size = new System.Drawing.Size(70, 36);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.AutoSize = true;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(672, 63);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIn.Name = "btnIn";
            this.btnIn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnIn.Size = new System.Drawing.Size(52, 36);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // ckbMatHang
            // 
            this.ckbMatHang.AutoSize = true;
            this.ckbMatHang.Location = new System.Drawing.Point(328, 67);
            this.ckbMatHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbMatHang.Name = "ckbMatHang";
            this.ckbMatHang.Size = new System.Drawing.Size(71, 17);
            this.ckbMatHang.TabIndex = 3;
            this.ckbMatHang.Text = "Mặt hàng";
            this.ckbMatHang.UseVisualStyleBackColor = true;
            // 
            // ckbNCC
            // 
            this.ckbNCC.AutoSize = true;
            this.ckbNCC.Location = new System.Drawing.Point(328, 22);
            this.ckbNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbNCC.Name = "ckbNCC";
            this.ckbNCC.Size = new System.Drawing.Size(94, 17);
            this.ckbNCC.TabIndex = 3;
            this.ckbNCC.Text = "Nhà cung cấp";
            this.ckbNCC.UseVisualStyleBackColor = true;
            // 
            // ckbLoaiHang
            // 
            this.ckbLoaiHang.AutoSize = true;
            this.ckbLoaiHang.Location = new System.Drawing.Point(20, 67);
            this.ckbLoaiHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbLoaiHang.Name = "ckbLoaiHang";
            this.ckbLoaiHang.Size = new System.Drawing.Size(73, 17);
            this.ckbLoaiHang.TabIndex = 3;
            this.ckbLoaiHang.Text = "Loại hàng";
            this.ckbLoaiHang.UseVisualStyleBackColor = true;
            // 
            // cmbMatHang
            // 
            this.cmbMatHang.DataSource = this.hangHoaBindingSource;
            this.cmbMatHang.DisplayMember = "TenHangHoa";
            this.cmbMatHang.FormattingEnabled = true;
            this.cmbMatHang.Location = new System.Drawing.Point(427, 63);
            this.cmbMatHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMatHang.Name = "cmbMatHang";
            this.cmbMatHang.Size = new System.Drawing.Size(216, 21);
            this.cmbMatHang.TabIndex = 2;
            this.cmbMatHang.ValueMember = "TenHangHoa";
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.DataSource = this.nhaCungCapBindingSource;
            this.cmbNhaCungCap.DisplayMember = "TenNhaCungCap";
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(427, 21);
            this.cmbNhaCungCap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(216, 21);
            this.cmbNhaCungCap.TabIndex = 2;
            this.cmbNhaCungCap.ValueMember = "TenNhaCungCap";
            // 
            // cmbLoaiHang
            // 
            this.cmbLoaiHang.DataSource = this.loaiHangBindingSource;
            this.cmbLoaiHang.DisplayMember = "TenLoaiHang";
            this.cmbLoaiHang.FormattingEnabled = true;
            this.cmbLoaiHang.Location = new System.Drawing.Point(109, 63);
            this.cmbLoaiHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbLoaiHang.Name = "cmbLoaiHang";
            this.cmbLoaiHang.Size = new System.Drawing.Size(198, 21);
            this.cmbLoaiHang.TabIndex = 2;
            this.cmbLoaiHang.ValueMember = "TenLoaiHang";
            // 
            // dtmDenNgay
            // 
            this.dtmDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtmDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmDenNgay.Location = new System.Drawing.Point(221, 19);
            this.dtmDenNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmDenNgay.Name = "dtmDenNgay";
            this.dtmDenNgay.Size = new System.Drawing.Size(86, 20);
            this.dtmDenNgay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đến ngày";
            // 
            // dtmTuNgay
            // 
            this.dtmTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtmTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmTuNgay.Location = new System.Drawing.Point(64, 19);
            this.dtmTuNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmTuNgay.Name = "dtmTuNgay";
            this.dtmTuNgay.Size = new System.Drawing.Size(102, 20);
            this.dtmTuNgay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            // 
            // quanLyBanBanhKeo_DoAnDataSet76
            // 
            this.quanLyBanBanhKeo_DoAnDataSet76.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet76";
            this.quanLyBanBanhKeo_DoAnDataSet76.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiHangBindingSource
            // 
            this.loaiHangBindingSource.DataMember = "LoaiHang";
            this.loaiHangBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet76;
            // 
            // loaiHangTableAdapter
            // 
            this.loaiHangTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyBanBanhKeo_DoAnDataSet77
            // 
            this.quanLyBanBanhKeo_DoAnDataSet77.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet77";
            this.quanLyBanBanhKeo_DoAnDataSet77.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet77;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyBanBanhKeo_DoAnDataSet78
            // 
            this.quanLyBanBanhKeo_DoAnDataSet78.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet78";
            this.quanLyBanBanhKeo_DoAnDataSet78.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet78;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoHangNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 754);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BaoCaoHangNhapKho";
            this.Text = "BaoCaoHangNhapKho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaoCaoHangNhapKho_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet77)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet78)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer rprNhapHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private System.Windows.Forms.CheckBox ckbMatHang;
        private System.Windows.Forms.CheckBox ckbNCC;
        private System.Windows.Forms.CheckBox ckbLoaiHang;
        private System.Windows.Forms.ComboBox cmbMatHang;
        private System.Windows.Forms.ComboBox cmbNhaCungCap;
        private System.Windows.Forms.ComboBox cmbLoaiHang;
        private System.Windows.Forms.DateTimePicker dtmDenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmTuNgay;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private QuanLyBanBanhKeo_DoAnDataSet76 quanLyBanBanhKeo_DoAnDataSet76;
        private System.Windows.Forms.BindingSource loaiHangBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet76TableAdapters.LoaiHangTableAdapter loaiHangTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet77 quanLyBanBanhKeo_DoAnDataSet77;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet77TableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet78 quanLyBanBanhKeo_DoAnDataSet78;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet78TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
    }
}