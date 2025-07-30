namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatRaSX
{
    partial class ThemPhieuXuatRaSX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemPhieuXuatRaSX));
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btnChapNhan = new DevExpress.XtraEditors.SimpleButton();
            this.dtmXuatSX = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPhieuSX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLoaiXuat = new System.Windows.Forms.ComboBox();
            this.cmbKeHoach = new System.Windows.Forms.ComboBox();
            this.keHoachSanXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet51 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet51();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet50 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet50();
            this.nhanVienTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet50TableAdapters.NhanVienTableAdapter();
            this.keHoachSanXuatTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet51TableAdapters.KeHoachSanXuatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.keHoachSanXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet50)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(153, 186);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(232, 20);
            this.txtGhiChu.TabIndex = 171;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 170;
            this.label4.Text = "Ghi chú";
            // 
            // Huy
            // 
            this.Huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Huy.ImageOptions.SvgImage")));
            this.Huy.Location = new System.Drawing.Point(274, 222);
            this.Huy.Margin = new System.Windows.Forms.Padding(4);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(124, 56);
            this.Huy.TabIndex = 169;
            this.Huy.Text = "Hủy bỏ";
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChapNhan.ImageOptions.SvgImage")));
            this.btnChapNhan.Location = new System.Drawing.Point(59, 222);
            this.btnChapNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(124, 56);
            this.btnChapNhan.TabIndex = 168;
            this.btnChapNhan.Text = "Chấp nhận";
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // dtmXuatSX
            // 
            this.dtmXuatSX.CustomFormat = "dd/MM/yyyy";
            this.dtmXuatSX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmXuatSX.Location = new System.Drawing.Point(153, 54);
            this.dtmXuatSX.Name = "dtmXuatSX";
            this.dtmXuatSX.Size = new System.Drawing.Size(232, 20);
            this.dtmXuatSX.TabIndex = 167;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 164;
            this.label3.Text = "Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 163;
            this.label2.Text = "Ngày xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 162;
            this.label1.Text = "Mã kế hoạch sx";
            // 
            // txtMaPhieuSX
            // 
            this.txtMaPhieuSX.Location = new System.Drawing.Point(153, 19);
            this.txtMaPhieuSX.Name = "txtMaPhieuSX";
            this.txtMaPhieuSX.Size = new System.Drawing.Size(232, 20);
            this.txtMaPhieuSX.TabIndex = 173;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 172;
            this.label5.Text = "Mã phiếu xuất ra sx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 174;
            this.label6.Text = "Loại xuất";
            // 
            // cmbLoaiXuat
            // 
            this.cmbLoaiXuat.FormattingEnabled = true;
            this.cmbLoaiXuat.Items.AddRange(new object[] {
            "Xuất nguyên liệu",
            "Xuất bán TP"});
            this.cmbLoaiXuat.Location = new System.Drawing.Point(153, 89);
            this.cmbLoaiXuat.Name = "cmbLoaiXuat";
            this.cmbLoaiXuat.Size = new System.Drawing.Size(232, 21);
            this.cmbLoaiXuat.TabIndex = 175;
            // 
            // cmbKeHoach
            // 
            this.cmbKeHoach.DataSource = this.keHoachSanXuatBindingSource;
            this.cmbKeHoach.DisplayMember = "MaKeHoach";
            this.cmbKeHoach.FormattingEnabled = true;
            this.cmbKeHoach.Location = new System.Drawing.Point(153, 119);
            this.cmbKeHoach.Name = "cmbKeHoach";
            this.cmbKeHoach.Size = new System.Drawing.Size(232, 21);
            this.cmbKeHoach.TabIndex = 175;
            this.cmbKeHoach.ValueMember = "MaKeHoach";
            // 
            // keHoachSanXuatBindingSource
            // 
            this.keHoachSanXuatBindingSource.DataMember = "KeHoachSanXuat";
            this.keHoachSanXuatBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet51;
            // 
            // quanLyBanBanhKeo_DoAnDataSet51
            // 
            this.quanLyBanBanhKeo_DoAnDataSet51.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet51";
            this.quanLyBanBanhKeo_DoAnDataSet51.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.DataSource = this.nhanVienBindingSource;
            this.cmbNhanVien.DisplayMember = "TenNhanVien";
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(153, 149);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(232, 21);
            this.cmbNhanVien.TabIndex = 175;
            this.cmbNhanVien.ValueMember = "MaNhanVien";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet50;
            // 
            // quanLyBanBanhKeo_DoAnDataSet50
            // 
            this.quanLyBanBanhKeo_DoAnDataSet50.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet50";
            this.quanLyBanBanhKeo_DoAnDataSet50.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // keHoachSanXuatTableAdapter
            // 
            this.keHoachSanXuatTableAdapter.ClearBeforeFill = true;
            // 
            // ThemPhieuXuatRaSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 301);
            this.Controls.Add(this.cmbNhanVien);
            this.Controls.Add(this.cmbKeHoach);
            this.Controls.Add(this.cmbLoaiXuat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaPhieuSX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Huy);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.dtmXuatSX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemPhieuXuatRaSX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemPhieuXuatRaSX";
            this.Load += new System.EventHandler(this.ThemPhieuXuatRaSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keHoachSanXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet50)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton Huy;
        private DevExpress.XtraEditors.SimpleButton btnChapNhan;
        private System.Windows.Forms.DateTimePicker dtmXuatSX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhieuSX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLoaiXuat;
        private System.Windows.Forms.ComboBox cmbKeHoach;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private QuanLyBanBanhKeo_DoAnDataSet50 quanLyBanBanhKeo_DoAnDataSet50;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet50TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet51 quanLyBanBanhKeo_DoAnDataSet51;
        private System.Windows.Forms.BindingSource keHoachSanXuatBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet51TableAdapters.KeHoachSanXuatTableAdapter keHoachSanXuatTableAdapter;
    }
}