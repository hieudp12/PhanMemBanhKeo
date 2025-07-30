namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatRaSX
{
    partial class SuaHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaHangHoa));
            this.txtGhiChu1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btnChapNhan = new DevExpress.XtraEditors.SimpleButton();
            this.txtThanhTien1 = new System.Windows.Forms.TextBox();
            this.txtGia1 = new System.Windows.Forms.TextBox();
            this.txtSoLuong1 = new System.Windows.Forms.TextBox();
            this.cmbKho1 = new System.Windows.Forms.ComboBox();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet54 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet54();
            this.cmbTenHang1 = new System.Windows.Forms.ComboBox();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet95 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet95();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonViTinh1 = new System.Windows.Forms.TextBox();
            this.khoTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet54TableAdapters.KhoTableAdapter();
            this.hangHoaTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet95TableAdapters.HangHoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet95)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGhiChu1
            // 
            this.txtGhiChu1.Location = new System.Drawing.Point(94, 143);
            this.txtGhiChu1.Name = "txtGhiChu1";
            this.txtGhiChu1.Size = new System.Drawing.Size(486, 20);
            this.txtGhiChu1.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 153;
            this.label1.Text = "Ghi chú";
            // 
            // Huy
            // 
            this.Huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Huy.ImageOptions.SvgImage")));
            this.Huy.Location = new System.Drawing.Point(417, 187);
            this.Huy.Margin = new System.Windows.Forms.Padding(4);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(124, 56);
            this.Huy.TabIndex = 152;
            this.Huy.Text = "Hủy bỏ";
            this.Huy.Click += new System.EventHandler(this.Huy_Click_1);
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChapNhan.ImageOptions.SvgImage")));
            this.btnChapNhan.Location = new System.Drawing.Point(94, 187);
            this.btnChapNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(124, 56);
            this.btnChapNhan.TabIndex = 151;
            this.btnChapNhan.Text = "Chấp nhận";
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // txtThanhTien1
            // 
            this.txtThanhTien1.Location = new System.Drawing.Point(380, 103);
            this.txtThanhTien1.Name = "txtThanhTien1";
            this.txtThanhTien1.ReadOnly = true;
            this.txtThanhTien1.Size = new System.Drawing.Size(200, 20);
            this.txtThanhTien1.TabIndex = 150;
            // 
            // txtGia1
            // 
            this.txtGia1.Location = new System.Drawing.Point(380, 70);
            this.txtGia1.Name = "txtGia1";
            this.txtGia1.ReadOnly = true;
            this.txtGia1.Size = new System.Drawing.Size(200, 20);
            this.txtGia1.TabIndex = 149;
            this.txtGia1.TextChanged += new System.EventHandler(this.txtGia1_TextChanged);
            // 
            // txtSoLuong1
            // 
            this.txtSoLuong1.Location = new System.Drawing.Point(94, 70);
            this.txtSoLuong1.Name = "txtSoLuong1";
            this.txtSoLuong1.Size = new System.Drawing.Size(200, 20);
            this.txtSoLuong1.TabIndex = 148;
            this.txtSoLuong1.TextChanged += new System.EventHandler(this.txtSoLuong1_TextChanged);
            // 
            // cmbKho1
            // 
            this.cmbKho1.DataSource = this.khoBindingSource;
            this.cmbKho1.DisplayMember = "TenKho";
            this.cmbKho1.FormattingEnabled = true;
            this.cmbKho1.Location = new System.Drawing.Point(380, 36);
            this.cmbKho1.Name = "cmbKho1";
            this.cmbKho1.Size = new System.Drawing.Size(200, 21);
            this.cmbKho1.TabIndex = 147;
            this.cmbKho1.ValueMember = "MaKho";
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet54;
            // 
            // quanLyBanBanhKeo_DoAnDataSet54
            // 
            this.quanLyBanBanhKeo_DoAnDataSet54.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet54";
            this.quanLyBanBanhKeo_DoAnDataSet54.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbTenHang1
            // 
            this.cmbTenHang1.DataSource = this.hangHoaBindingSource;
            this.cmbTenHang1.DisplayMember = "TenHangHoa";
            this.cmbTenHang1.Enabled = false;
            this.cmbTenHang1.FormattingEnabled = true;
            this.cmbTenHang1.Location = new System.Drawing.Point(94, 36);
            this.cmbTenHang1.Name = "cmbTenHang1";
            this.cmbTenHang1.Size = new System.Drawing.Size(200, 21);
            this.cmbTenHang1.TabIndex = 146;
            this.cmbTenHang1.ValueMember = "MaHangHoa";
            this.cmbTenHang1.SelectedIndexChanged += new System.EventHandler(this.cmbTenHang1_SelectedIndexChanged);
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet95;
            // 
            // quanLyBanBanhKeo_DoAnDataSet95
            // 
            this.quanLyBanBanhKeo_DoAnDataSet95.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet95";
            this.quanLyBanBanhKeo_DoAnDataSet95.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 145;
            this.label8.Text = "Thành tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 144;
            this.label5.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 143;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 142;
            this.label4.Text = "Kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 141;
            this.label2.Text = "Tên hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 153;
            this.label6.Text = "Đơn vị tính";
            // 
            // txtDonViTinh1
            // 
            this.txtDonViTinh1.Location = new System.Drawing.Point(94, 106);
            this.txtDonViTinh1.Name = "txtDonViTinh1";
            this.txtDonViTinh1.ReadOnly = true;
            this.txtDonViTinh1.Size = new System.Drawing.Size(200, 20);
            this.txtDonViTinh1.TabIndex = 154;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // SuaHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 254);
            this.Controls.Add(this.txtDonViTinh1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGhiChu1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Huy);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.txtThanhTien1);
            this.Controls.Add(this.txtGia1);
            this.Controls.Add(this.txtSoLuong1);
            this.Controls.Add(this.cmbKho1);
            this.Controls.Add(this.cmbTenHang1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "SuaHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaHangHoa";
            this.Load += new System.EventHandler(this.SuaHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet95)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGhiChu1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton Huy;
        private DevExpress.XtraEditors.SimpleButton btnChapNhan;
        private System.Windows.Forms.TextBox txtThanhTien1;
        private System.Windows.Forms.TextBox txtGia1;
        private System.Windows.Forms.TextBox txtSoLuong1;
        private System.Windows.Forms.ComboBox cmbKho1;
        private System.Windows.Forms.ComboBox cmbTenHang1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonViTinh1;
        private QuanLyBanBanhKeo_DoAnDataSet54 quanLyBanBanhKeo_DoAnDataSet54;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet54TableAdapters.KhoTableAdapter khoTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet95 quanLyBanBanhKeo_DoAnDataSet95;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet95TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
    }
}