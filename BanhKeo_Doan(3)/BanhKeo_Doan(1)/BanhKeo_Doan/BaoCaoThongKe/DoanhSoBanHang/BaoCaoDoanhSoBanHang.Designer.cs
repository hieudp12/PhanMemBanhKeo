namespace BanhKeo_Doan.BaoCaoThongKe.DoanhSoBanHang
{
    partial class BaoCaoDoanhSoBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoDoanhSoBanHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnInDoanhSo = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.cmbBoxKH = new System.Windows.Forms.ComboBox();
            this.cbKhachHang = new System.Windows.Forms.CheckBox();
            this.cmbBoxHangHoa = new System.Windows.Forms.ComboBox();
            this.cbHangHoa = new System.Windows.Forms.CheckBox();
            this.dateNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dateNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rpDoanhSoBanHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyBanBanhKeo_DoAnDataSet33 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet33();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet33TableAdapters.HangHoaTableAdapter();
            this.quanLyBanBanhKeo_DoAnDataSet34 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet34();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet34TableAdapters.KhachHangTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnInDoanhSo);
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.cmbBoxKH);
            this.groupBox1.Controls.Add(this.cbKhachHang);
            this.groupBox1.Controls.Add(this.cmbBoxHangHoa);
            this.groupBox1.Controls.Add(this.cbHangHoa);
            this.groupBox1.Controls.Add(this.dateNgayKT);
            this.groupBox1.Controls.Add(this.dateNgayBD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Location = new System.Drawing.Point(546, 48);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 50);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnInDoanhSo
            // 
            this.btnInDoanhSo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInDoanhSo.ImageOptions.SvgImage")));
            this.btnInDoanhSo.Location = new System.Drawing.Point(465, 48);
            this.btnInDoanhSo.Name = "btnInDoanhSo";
            this.btnInDoanhSo.Size = new System.Drawing.Size(75, 50);
            this.btnInDoanhSo.TabIndex = 9;
            this.btnInDoanhSo.Text = "In";
            this.btnInDoanhSo.Click += new System.EventHandler(this.btnInDoanhSo_Click);
            // 
            // btnXem
            // 
            this.btnXem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXem.ImageOptions.SvgImage")));
            this.btnXem.Location = new System.Drawing.Point(384, 48);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 50);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cmbBoxKH
            // 
            this.cmbBoxKH.DataSource = this.khachHangBindingSource;
            this.cmbBoxKH.DisplayMember = "TenKhachHang";
            this.cmbBoxKH.FormattingEnabled = true;
            this.cmbBoxKH.Location = new System.Drawing.Point(130, 77);
            this.cmbBoxKH.Name = "cmbBoxKH";
            this.cmbBoxKH.Size = new System.Drawing.Size(212, 21);
            this.cmbBoxKH.TabIndex = 7;
            this.cmbBoxKH.ValueMember = "TenKhachHang";
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.AutoSize = true;
            this.cbKhachHang.Location = new System.Drawing.Point(10, 79);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(114, 17);
            this.cbKhachHang.TabIndex = 6;
            this.cbKhachHang.Text = "Theo khách hàng:";
            this.cbKhachHang.UseVisualStyleBackColor = true;
            // 
            // cmbBoxHangHoa
            // 
            this.cmbBoxHangHoa.DataSource = this.hangHoaBindingSource;
            this.cmbBoxHangHoa.DisplayMember = "TenHangHoa";
            this.cmbBoxHangHoa.FormattingEnabled = true;
            this.cmbBoxHangHoa.Location = new System.Drawing.Point(130, 48);
            this.cmbBoxHangHoa.Name = "cmbBoxHangHoa";
            this.cmbBoxHangHoa.Size = new System.Drawing.Size(212, 21);
            this.cmbBoxHangHoa.TabIndex = 5;
            this.cmbBoxHangHoa.ValueMember = "TenHangHoa";
            // 
            // cbHangHoa
            // 
            this.cbHangHoa.AutoSize = true;
            this.cbHangHoa.Location = new System.Drawing.Point(10, 52);
            this.cbHangHoa.Name = "cbHangHoa";
            this.cbHangHoa.Size = new System.Drawing.Size(102, 17);
            this.cbHangHoa.TabIndex = 4;
            this.cbHangHoa.Text = "Theo hàng hóa:";
            this.cbHangHoa.UseVisualStyleBackColor = true;
            // 
            // dateNgayKT
            // 
            this.dateNgayKT.Location = new System.Drawing.Point(336, 15);
            this.dateNgayKT.Name = "dateNgayKT";
            this.dateNgayKT.Size = new System.Drawing.Size(200, 20);
            this.dateNgayKT.TabIndex = 3;
            // 
            // dateNgayBD
            // 
            this.dateNgayBD.Location = new System.Drawing.Point(65, 14);
            this.dateNgayBD.Name = "dateNgayBD";
            this.dateNgayBD.Size = new System.Drawing.Size(200, 20);
            this.dateNgayBD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày: ";
            // 
            // rpDoanhSoBanHang
            // 
            this.rpDoanhSoBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpDoanhSoBanHang.Location = new System.Drawing.Point(12, 142);
            this.rpDoanhSoBanHang.Name = "rpDoanhSoBanHang";
            this.rpDoanhSoBanHang.ServerReport.BearerToken = null;
            this.rpDoanhSoBanHang.Size = new System.Drawing.Size(776, 296);
            this.rpDoanhSoBanHang.TabIndex = 1;
            // 
            // quanLyBanBanhKeo_DoAnDataSet33
            // 
            this.quanLyBanBanhKeo_DoAnDataSet33.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet33";
            this.quanLyBanBanhKeo_DoAnDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet33;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyBanBanhKeo_DoAnDataSet34
            // 
            this.quanLyBanBanhKeo_DoAnDataSet34.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet34";
            this.quanLyBanBanhKeo_DoAnDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet34;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoDoanhSoBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpDoanhSoBanHang);
            this.Controls.Add(this.groupBox1);
            this.Name = "BaoCaoDoanhSoBanHang";
            this.Text = "BaoCaoDoanhSoBanHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaoCaoDoanhSoBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBoxKH;
        private System.Windows.Forms.CheckBox cbKhachHang;
        private System.Windows.Forms.ComboBox cmbBoxHangHoa;
        private System.Windows.Forms.CheckBox cbHangHoa;
        private System.Windows.Forms.DateTimePicker dateNgayKT;
        private System.Windows.Forms.DateTimePicker dateNgayBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnInDoanhSo;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private Microsoft.Reporting.WinForms.ReportViewer rpDoanhSoBanHang;
        private QuanLyBanBanhKeo_DoAnDataSet33 quanLyBanBanhKeo_DoAnDataSet33;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet33TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet34 quanLyBanBanhKeo_DoAnDataSet34;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet34TableAdapters.KhachHangTableAdapter khachHangTableAdapter;
    }
}