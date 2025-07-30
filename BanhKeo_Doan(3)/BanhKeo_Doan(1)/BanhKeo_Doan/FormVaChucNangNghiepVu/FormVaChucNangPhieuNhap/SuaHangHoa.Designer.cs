namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuNhap
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
            this.btnChapNhan = new DevExpress.XtraEditors.SimpleButton();
            this.txtGiaCK1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhanTramCK1 = new System.Windows.Forms.TextBox();
            this.txtGhiChu1 = new System.Windows.Forms.TextBox();
            this.txtThanhTien1 = new System.Windows.Forms.TextBox();
            this.txtGiaSauCK1 = new System.Windows.Forms.TextBox();
            this.txtSoLuongNhap1 = new System.Windows.Forms.TextBox();
            this.txtGiaTruocCK1 = new System.Windows.Forms.TextBox();
            this.cmbTenHang1 = new System.Windows.Forms.ComboBox();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet91 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet91();
            this.cmbKho1 = new System.Windows.Forms.ComboBox();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet41 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet41();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDVT1 = new System.Windows.Forms.TextBox();
            this.khoTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet41TableAdapters.KhoTableAdapter();
            this.hangHoaTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet91TableAdapters.HangHoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet41)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChapNhan.ImageOptions.SvgImage")));
            this.btnChapNhan.Location = new System.Drawing.Point(151, 210);
            this.btnChapNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(124, 56);
            this.btnChapNhan.TabIndex = 151;
            this.btnChapNhan.Text = "Chấp nhận";
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // txtGiaCK1
            // 
            this.txtGiaCK1.Location = new System.Drawing.Point(445, 92);
            this.txtGiaCK1.Name = "txtGiaCK1";
            this.txtGiaCK1.ReadOnly = true;
            this.txtGiaCK1.Size = new System.Drawing.Size(199, 20);
            this.txtGiaCK1.TabIndex = 150;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(344, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 149;
            this.label12.Text = "Giá CK";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(442, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 148;
            // 
            // txtPhanTramCK1
            // 
            this.txtPhanTramCK1.Location = new System.Drawing.Point(446, 61);
            this.txtPhanTramCK1.Name = "txtPhanTramCK1";
            this.txtPhanTramCK1.Size = new System.Drawing.Size(198, 20);
            this.txtPhanTramCK1.TabIndex = 147;
            this.txtPhanTramCK1.TextChanged += new System.EventHandler(this.txtPhanTramCK1_TextChanged);
            // 
            // txtGhiChu1
            // 
            this.txtGhiChu1.Location = new System.Drawing.Point(446, 158);
            this.txtGhiChu1.Name = "txtGhiChu1";
            this.txtGhiChu1.Size = new System.Drawing.Size(198, 20);
            this.txtGhiChu1.TabIndex = 146;
            // 
            // txtThanhTien1
            // 
            this.txtThanhTien1.Location = new System.Drawing.Point(106, 158);
            this.txtThanhTien1.Name = "txtThanhTien1";
            this.txtThanhTien1.ReadOnly = true;
            this.txtThanhTien1.Size = new System.Drawing.Size(198, 20);
            this.txtThanhTien1.TabIndex = 145;
            // 
            // txtGiaSauCK1
            // 
            this.txtGiaSauCK1.Location = new System.Drawing.Point(445, 128);
            this.txtGiaSauCK1.Name = "txtGiaSauCK1";
            this.txtGiaSauCK1.ReadOnly = true;
            this.txtGiaSauCK1.Size = new System.Drawing.Size(198, 20);
            this.txtGiaSauCK1.TabIndex = 144;
            // 
            // txtSoLuongNhap1
            // 
            this.txtSoLuongNhap1.Location = new System.Drawing.Point(106, 93);
            this.txtSoLuongNhap1.Name = "txtSoLuongNhap1";
            this.txtSoLuongNhap1.Size = new System.Drawing.Size(198, 20);
            this.txtSoLuongNhap1.TabIndex = 143;
            this.txtSoLuongNhap1.TextChanged += new System.EventHandler(this.txtSoLuongNhap1_TextChanged);
            // 
            // txtGiaTruocCK1
            // 
            this.txtGiaTruocCK1.Location = new System.Drawing.Point(446, 27);
            this.txtGiaTruocCK1.Name = "txtGiaTruocCK1";
            this.txtGiaTruocCK1.ReadOnly = true;
            this.txtGiaTruocCK1.Size = new System.Drawing.Size(198, 20);
            this.txtGiaTruocCK1.TabIndex = 141;
            // 
            // cmbTenHang1
            // 
            this.cmbTenHang1.DataSource = this.hangHoaBindingSource;
            this.cmbTenHang1.DisplayMember = "TenHangHoa";
            this.cmbTenHang1.Enabled = false;
            this.cmbTenHang1.FormattingEnabled = true;
            this.cmbTenHang1.Location = new System.Drawing.Point(106, 25);
            this.cmbTenHang1.Name = "cmbTenHang1";
            this.cmbTenHang1.Size = new System.Drawing.Size(198, 21);
            this.cmbTenHang1.TabIndex = 140;
            this.cmbTenHang1.ValueMember = "MaHangHoa";
            this.cmbTenHang1.SelectedIndexChanged += new System.EventHandler(this.cmbTenHang1_SelectedIndexChanged);
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet91;
            // 
            // quanLyBanBanhKeo_DoAnDataSet91
            // 
            this.quanLyBanBanhKeo_DoAnDataSet91.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet91";
            this.quanLyBanBanhKeo_DoAnDataSet91.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbKho1
            // 
            this.cmbKho1.DataSource = this.khoBindingSource;
            this.cmbKho1.DisplayMember = "TenKho";
            this.cmbKho1.Enabled = false;
            this.cmbKho1.FormattingEnabled = true;
            this.cmbKho1.Location = new System.Drawing.Point(106, 124);
            this.cmbKho1.Name = "cmbKho1";
            this.cmbKho1.Size = new System.Drawing.Size(198, 21);
            this.cmbKho1.TabIndex = 139;
            this.cmbKho1.ValueMember = "MaKho";
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet41;
            // 
            // quanLyBanBanhKeo_DoAnDataSet41
            // 
            this.quanLyBanBanhKeo_DoAnDataSet41.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet41";
            this.quanLyBanBanhKeo_DoAnDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 138;
            this.label6.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 137;
            this.label7.Text = "Thành tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 136;
            this.label8.Text = "%CK";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 134;
            this.label10.Text = "Tên hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 133;
            this.label5.Text = "Kho hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 132;
            this.label4.Text = "Đơn giá sau CK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 131;
            this.label3.Text = "Đơn giá chưa CK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 130;
            this.label2.Text = "Số lượng nhập";
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Location = new System.Drawing.Point(446, 210);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(124, 56);
            this.btnHuy.TabIndex = 152;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 130;
            this.label1.Text = "Đơn vị tính";
            // 
            // txtDVT1
            // 
            this.txtDVT1.Location = new System.Drawing.Point(106, 61);
            this.txtDVT1.Name = "txtDVT1";
            this.txtDVT1.ReadOnly = true;
            this.txtDVT1.Size = new System.Drawing.Size(198, 20);
            this.txtDVT1.TabIndex = 143;
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
            this.ClientSize = new System.Drawing.Size(718, 277);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.txtGiaCK1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPhanTramCK1);
            this.Controls.Add(this.txtGhiChu1);
            this.Controls.Add(this.txtThanhTien1);
            this.Controls.Add(this.txtGiaSauCK1);
            this.Controls.Add(this.txtDVT1);
            this.Controls.Add(this.txtSoLuongNhap1);
            this.Controls.Add(this.txtGiaTruocCK1);
            this.Controls.Add(this.cmbTenHang1);
            this.Controls.Add(this.cmbKho1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "SuaHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaHangHoa";
            this.Load += new System.EventHandler(this.SuaHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet41)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnChapNhan;
        private System.Windows.Forms.TextBox txtGiaCK1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPhanTramCK1;
        private System.Windows.Forms.TextBox txtGhiChu1;
        private System.Windows.Forms.TextBox txtThanhTien1;
        private System.Windows.Forms.TextBox txtGiaSauCK1;
        private System.Windows.Forms.TextBox txtSoLuongNhap1;
        private System.Windows.Forms.TextBox txtGiaTruocCK1;
        private System.Windows.Forms.ComboBox cmbTenHang1;
        private System.Windows.Forms.ComboBox cmbKho1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDVT1;
        private QuanLyBanBanhKeo_DoAnDataSet41 quanLyBanBanhKeo_DoAnDataSet41;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet41TableAdapters.KhoTableAdapter khoTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet91 quanLyBanBanhKeo_DoAnDataSet91;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet91TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
    }
}