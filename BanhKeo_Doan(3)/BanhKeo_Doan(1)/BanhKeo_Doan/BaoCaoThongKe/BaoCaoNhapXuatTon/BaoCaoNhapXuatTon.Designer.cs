namespace BanhKeo_Doan.Báo_cáo_thống_kê
{
    partial class BaoCaoNhapXuatTon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoNhapXuatTon));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportNhapXuatTon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.ckbMatHang = new System.Windows.Forms.CheckBox();
            this.ckbLoai = new System.Windows.Forms.CheckBox();
            this.cmbMatHang = new System.Windows.Forms.ComboBox();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.dtmDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rprNhapXuatTon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyBanBanhKeo_DoAnDataSet88 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet88();
            this.loaiHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiHangTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet88TableAdapters.LoaiHangTableAdapter();
            this.quanLyBanBanhKeo_DoAnDataSet89 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet89();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet89TableAdapters.HangHoaTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet88)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet89)).BeginInit();
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
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportNhapXuatTon);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(812, 729);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Báo cáo nhập xuất tồn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportNhapXuatTon
            // 
            this.reportNhapXuatTon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "DataNhapXuatTon";
            this.reportNhapXuatTon.LocalReport.DataSources.Add(reportDataSource3);
            this.reportNhapXuatTon.LocalReport.ReportEmbeddedResource = "BanhKeo_Doan.Báo cáo thống kê.InBaoCaoNhapXuatTon.rdlc";
            this.reportNhapXuatTon.Location = new System.Drawing.Point(5, 110);
            this.reportNhapXuatTon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportNhapXuatTon.Name = "reportNhapXuatTon";
            this.reportNhapXuatTon.ServerReport.BearerToken = null;
            this.reportNhapXuatTon.Size = new System.Drawing.Size(804, 617);
            this.reportNhapXuatTon.TabIndex = 1;
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
            this.groupBox1.Controls.Add(this.ckbLoai);
            this.groupBox1.Controls.Add(this.cmbMatHang);
            this.groupBox1.Controls.Add(this.cmbLoai);
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
            this.btnXem.Location = new System.Drawing.Point(584, 19);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXem.Name = "btnXem";
            this.btnXem.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnXem.Size = new System.Drawing.Size(62, 36);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(715, 19);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnThoat.Size = new System.Drawing.Size(70, 36);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.AutoSize = true;
            this.btnIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.ImageOptions.Image")));
            this.btnIn.Location = new System.Drawing.Point(656, 19);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIn.Name = "btnIn";
            this.btnIn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnIn.Size = new System.Drawing.Size(52, 36);
            this.btnIn.TabIndex = 8;
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
            // ckbLoai
            // 
            this.ckbLoai.AutoSize = true;
            this.ckbLoai.Location = new System.Drawing.Point(20, 67);
            this.ckbLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbLoai.Name = "ckbLoai";
            this.ckbLoai.Size = new System.Drawing.Size(73, 17);
            this.ckbLoai.TabIndex = 3;
            this.ckbLoai.Text = "Loại hàng";
            this.ckbLoai.UseVisualStyleBackColor = true;
            // 
            // cmbMatHang
            // 
            this.cmbMatHang.DataSource = this.hangHoaBindingSource;
            this.cmbMatHang.DisplayMember = "TenHangHoa";
            this.cmbMatHang.FormattingEnabled = true;
            this.cmbMatHang.Location = new System.Drawing.Point(412, 65);
            this.cmbMatHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMatHang.Name = "cmbMatHang";
            this.cmbMatHang.Size = new System.Drawing.Size(216, 21);
            this.cmbMatHang.TabIndex = 2;
            this.cmbMatHang.ValueMember = "TenHangHoa";
            // 
            // cmbLoai
            // 
            this.cmbLoai.DataSource = this.loaiHangBindingSource;
            this.cmbLoai.DisplayMember = "TenLoaiHang";
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Location = new System.Drawing.Point(104, 63);
            this.cmbLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(204, 21);
            this.cmbLoai.TabIndex = 2;
            this.cmbLoai.ValueMember = "TenLoaiHang";
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
            this.dtmTuNgay.Size = new System.Drawing.Size(86, 20);
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
            // rprNhapXuatTon
            // 
            this.rprNhapXuatTon.Location = new System.Drawing.Point(0, 0);
            this.rprNhapXuatTon.Name = "rprNhapXuatTon";
            this.rprNhapXuatTon.ServerReport.BearerToken = null;
            this.rprNhapXuatTon.Size = new System.Drawing.Size(396, 246);
            this.rprNhapXuatTon.TabIndex = 0;
            // 
            // quanLyBanBanhKeo_DoAnDataSet88
            // 
            this.quanLyBanBanhKeo_DoAnDataSet88.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet88";
            this.quanLyBanBanhKeo_DoAnDataSet88.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiHangBindingSource
            // 
            this.loaiHangBindingSource.DataMember = "LoaiHang";
            this.loaiHangBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet88;
            // 
            // loaiHangTableAdapter
            // 
            this.loaiHangTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyBanBanhKeo_DoAnDataSet89
            // 
            this.quanLyBanBanhKeo_DoAnDataSet89.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet89";
            this.quanLyBanBanhKeo_DoAnDataSet89.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet89;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoNhapXuatTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 754);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BaoCaoNhapXuatTon";
            this.Text = "BaoCaoNhapXuatTon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaoCaoNhapXuatTon_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet88)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet89)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer rprNhapXuatTon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbMatHang;
        private System.Windows.Forms.CheckBox ckbLoai;
        private System.Windows.Forms.ComboBox cmbMatHang;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.DateTimePicker dtmDenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmTuNgay;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private Microsoft.Reporting.WinForms.ReportViewer reportNhapXuatTon;
        private QuanLyBanBanhKeo_DoAnDataSet88 quanLyBanBanhKeo_DoAnDataSet88;
        private System.Windows.Forms.BindingSource loaiHangBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet88TableAdapters.LoaiHangTableAdapter loaiHangTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet89 quanLyBanBanhKeo_DoAnDataSet89;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet89TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
    }
}