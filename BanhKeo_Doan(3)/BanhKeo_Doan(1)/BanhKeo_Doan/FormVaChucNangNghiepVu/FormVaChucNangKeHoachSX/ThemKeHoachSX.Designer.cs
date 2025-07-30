namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangKeHoachSX
{
    partial class ThemKeHoachSX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemKeHoachSX));
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemKeHoach = new DevExpress.XtraEditors.SimpleButton();
            this.dateNgayLapKeHoach = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaKeHoach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBoxNhanVien = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet29 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet29();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.nhanVienTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet29TableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet29)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(167, 222);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(232, 20);
            this.txtGhiChu.TabIndex = 161;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 160;
            this.label4.Text = "Ghi chú";
            // 
            // Huy
            // 
            this.Huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Huy.ImageOptions.SvgImage")));
            this.Huy.Location = new System.Drawing.Point(299, 272);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(100, 45);
            this.Huy.TabIndex = 159;
            this.Huy.Text = "Hủy bỏ";
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // btnThemKeHoach
            // 
            this.btnThemKeHoach.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemKeHoach.ImageOptions.SvgImage")));
            this.btnThemKeHoach.Location = new System.Drawing.Point(167, 272);
            this.btnThemKeHoach.Name = "btnThemKeHoach";
            this.btnThemKeHoach.Size = new System.Drawing.Size(100, 45);
            this.btnThemKeHoach.TabIndex = 158;
            this.btnThemKeHoach.Text = "Chấp nhận";
            this.btnThemKeHoach.Click += new System.EventHandler(this.btnThemKeHoach_Click);
            // 
            // dateNgayLapKeHoach
            // 
            this.dateNgayLapKeHoach.Location = new System.Drawing.Point(167, 71);
            this.dateNgayLapKeHoach.Name = "dateNgayLapKeHoach";
            this.dateNgayLapKeHoach.Size = new System.Drawing.Size(232, 20);
            this.dateNgayLapKeHoach.TabIndex = 157;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(167, 184);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(232, 20);
            this.txtTongTien.TabIndex = 156;
            // 
            // txtMaKeHoach
            // 
            this.txtMaKeHoach.Location = new System.Drawing.Point(167, 33);
            this.txtMaKeHoach.Name = "txtMaKeHoach";
            this.txtMaKeHoach.Size = new System.Drawing.Size(232, 20);
            this.txtMaKeHoach.TabIndex = 155;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 154;
            this.label3.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 153;
            this.label2.Text = "Ngày lập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 152;
            this.label1.Text = "Mã kế hoạch sx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 164;
            this.label5.Text = "Nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 162;
            this.label6.Text = "Đơn hàng";
            // 
            // cmbBoxNhanVien
            // 
            this.cmbBoxNhanVien.DataSource = this.nhanVienBindingSource;
            this.cmbBoxNhanVien.DisplayMember = "TenNhanVien";
            this.cmbBoxNhanVien.FormattingEnabled = true;
            this.cmbBoxNhanVien.Location = new System.Drawing.Point(167, 151);
            this.cmbBoxNhanVien.Name = "cmbBoxNhanVien";
            this.cmbBoxNhanVien.Size = new System.Drawing.Size(232, 21);
            this.cmbBoxNhanVien.TabIndex = 166;
            this.cmbBoxNhanVien.ValueMember = "MaNhanVien";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet29;
            // 
            // quanLyBanBanhKeo_DoAnDataSet29
            // 
            this.quanLyBanBanhKeo_DoAnDataSet29.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet29";
            this.quanLyBanBanhKeo_DoAnDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(167, 113);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(232, 20);
            this.txtMaDonHang.TabIndex = 167;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // ThemKeHoachSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 358);
            this.Controls.Add(this.txtMaDonHang);
            this.Controls.Add(this.cmbBoxNhanVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Huy);
            this.Controls.Add(this.btnThemKeHoach);
            this.Controls.Add(this.dateNgayLapKeHoach);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtMaKeHoach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemKeHoachSX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemKeHoachSX";
            this.Load += new System.EventHandler(this.ThemKeHoachSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet29)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton Huy;
        private DevExpress.XtraEditors.SimpleButton btnThemKeHoach;
        private System.Windows.Forms.DateTimePicker dateNgayLapKeHoach;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaKeHoach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBoxNhanVien;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private QuanLyBanBanhKeo_DoAnDataSet29 quanLyBanBanhKeo_DoAnDataSet29;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet29TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}