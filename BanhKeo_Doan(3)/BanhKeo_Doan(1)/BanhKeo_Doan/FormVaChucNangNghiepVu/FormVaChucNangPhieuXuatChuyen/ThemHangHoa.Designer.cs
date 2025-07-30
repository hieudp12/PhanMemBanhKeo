namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatChuyen
{
    partial class ThemHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemHangHoa));
            this.Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btnChapNhan = new DevExpress.XtraEditors.SimpleButton();
            this.txtGC = new System.Windows.Forms.TextBox();
            this.cmbHangHoa = new System.Windows.Forms.ComboBox();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet58 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet58();
            this.cmbKhoNhap = new System.Windows.Forms.ComboBox();
            this.khoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet59 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet59();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet48 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet48();
            this.cmbKhoXuat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuongXuat = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.khoTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet48TableAdapters.KhoTableAdapter();
            this.hangHoaTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet58TableAdapters.HangHoaTableAdapter();
            this.khoTableAdapter1 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet59TableAdapters.KhoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet48)).BeginInit();
            this.SuspendLayout();
            // 
            // Huy
            // 
            this.Huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Huy.ImageOptions.SvgImage")));
            this.Huy.Location = new System.Drawing.Point(356, 161);
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
            this.btnChapNhan.Location = new System.Drawing.Point(102, 161);
            this.btnChapNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(124, 56);
            this.btnChapNhan.TabIndex = 168;
            this.btnChapNhan.Text = "Chấp nhận";
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // txtGC
            // 
            this.txtGC.Location = new System.Drawing.Point(356, 116);
            this.txtGC.Name = "txtGC";
            this.txtGC.Size = new System.Drawing.Size(182, 20);
            this.txtGC.TabIndex = 167;
            // 
            // cmbHangHoa
            // 
            this.cmbHangHoa.DataSource = this.hangHoaBindingSource;
            this.cmbHangHoa.DisplayMember = "TenHangHoa";
            this.cmbHangHoa.FormattingEnabled = true;
            this.cmbHangHoa.Location = new System.Drawing.Point(102, 80);
            this.cmbHangHoa.Name = "cmbHangHoa";
            this.cmbHangHoa.Size = new System.Drawing.Size(168, 21);
            this.cmbHangHoa.TabIndex = 164;
            this.cmbHangHoa.ValueMember = "MaHangHoa";
            this.cmbHangHoa.SelectedIndexChanged += new System.EventHandler(this.cmbHangHoa_SelectedIndexChanged);
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet58;
            // 
            // quanLyBanBanhKeo_DoAnDataSet58
            // 
            this.quanLyBanBanhKeo_DoAnDataSet58.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet58";
            this.quanLyBanBanhKeo_DoAnDataSet58.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbKhoNhap
            // 
            this.cmbKhoNhap.DataSource = this.khoBindingSource1;
            this.cmbKhoNhap.DisplayMember = "TenKho";
            this.cmbKhoNhap.FormattingEnabled = true;
            this.cmbKhoNhap.Location = new System.Drawing.Point(358, 47);
            this.cmbKhoNhap.Name = "cmbKhoNhap";
            this.cmbKhoNhap.Size = new System.Drawing.Size(181, 21);
            this.cmbKhoNhap.TabIndex = 163;
            this.cmbKhoNhap.ValueMember = "MaKho";
            // 
            // khoBindingSource1
            // 
            this.khoBindingSource1.DataMember = "Kho";
            this.khoBindingSource1.DataSource = this.quanLyBanBanhKeo_DoAnDataSet59;
            // 
            // quanLyBanBanhKeo_DoAnDataSet59
            // 
            this.quanLyBanBanhKeo_DoAnDataSet59.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet59";
            this.quanLyBanBanhKeo_DoAnDataSet59.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet48;
            // 
            // quanLyBanBanhKeo_DoAnDataSet48
            // 
            this.quanLyBanBanhKeo_DoAnDataSet48.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet48";
            this.quanLyBanBanhKeo_DoAnDataSet48.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbKhoXuat
            // 
            this.cmbKhoXuat.DataSource = this.khoBindingSource;
            this.cmbKhoXuat.DisplayMember = "TenKho";
            this.cmbKhoXuat.FormattingEnabled = true;
            this.cmbKhoXuat.Location = new System.Drawing.Point(102, 47);
            this.cmbKhoXuat.Name = "cmbKhoXuat";
            this.cmbKhoXuat.Size = new System.Drawing.Size(168, 21);
            this.cmbKhoXuat.TabIndex = 161;
            this.cmbKhoXuat.ValueMember = "MaKho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 160;
            this.label6.Text = "Ghi chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 158;
            this.label9.Text = "Tên hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 157;
            this.label10.Text = "Tên kho nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 156;
            this.label5.Text = "Số lượng xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 154;
            this.label1.Text = "Tên kho xuất";
            // 
            // txtSoLuongXuat
            // 
            this.txtSoLuongXuat.Location = new System.Drawing.Point(356, 80);
            this.txtSoLuongXuat.Name = "txtSoLuongXuat";
            this.txtSoLuongXuat.Size = new System.Drawing.Size(182, 20);
            this.txtSoLuongXuat.TabIndex = 167;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(102, 119);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.ReadOnly = true;
            this.txtDonViTinh.Size = new System.Drawing.Size(168, 20);
            this.txtDonViTinh.TabIndex = 167;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 158;
            this.label2.Text = "Đơn vị tính";
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter1
            // 
            this.khoTableAdapter1.ClearBeforeFill = true;
            // 
            // ThemHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 241);
            this.Controls.Add(this.Huy);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.txtSoLuongXuat);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtGC);
            this.Controls.Add(this.cmbHangHoa);
            this.Controls.Add(this.cmbKhoNhap);
            this.Controls.Add(this.cmbKhoXuat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "ThemHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemHangHoa";
            this.Load += new System.EventHandler(this.ThemHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet48)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Huy;
        private DevExpress.XtraEditors.SimpleButton btnChapNhan;
        private System.Windows.Forms.TextBox txtGC;
        private System.Windows.Forms.ComboBox cmbHangHoa;
        private System.Windows.Forms.ComboBox cmbKhoNhap;
        private System.Windows.Forms.ComboBox cmbKhoXuat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuongXuat;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label label2;
        private QuanLyBanBanhKeo_DoAnDataSet48 quanLyBanBanhKeo_DoAnDataSet48;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet48TableAdapters.KhoTableAdapter khoTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet58 quanLyBanBanhKeo_DoAnDataSet58;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet58TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet59 quanLyBanBanhKeo_DoAnDataSet59;
        private System.Windows.Forms.BindingSource khoBindingSource1;
        private QuanLyBanBanhKeo_DoAnDataSet59TableAdapters.KhoTableAdapter khoTableAdapter1;
    }
}