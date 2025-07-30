namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHoaDonXuatHang
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
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoTienCK = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhanTramCK = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDonGiaSauCK = new System.Windows.Forms.TextBox();
            this.txtDonGiaChuaCK = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cmbBoxHangHoa = new System.Windows.Forms.ComboBox();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet23 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet23();
            this.cmbBoxKho = new System.Windows.Forms.ComboBox();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet24 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet24();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBanBuon = new System.Windows.Forms.CheckBox();
            this.hangHoaTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet23TableAdapters.HangHoaTableAdapter();
            this.khoTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet24TableAdapters.KhoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet24)).BeginInit();
            this.SuspendLayout();
            // 
            // Huy
            // 
            this.Huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Huy.ImageOptions.SvgImage")));
            this.Huy.Location = new System.Drawing.Point(380, 204);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(100, 45);
            this.Huy.TabIndex = 179;
            this.Huy.Text = "Hủy bỏ";
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Location = new System.Drawing.Point(192, 204);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 45);
            this.btnThem.TabIndex = 178;
            this.btnThem.Text = "Chấp nhận";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoTienCK
            // 
            this.txtSoTienCK.Enabled = false;
            this.txtSoTienCK.Location = new System.Drawing.Point(532, 88);
            this.txtSoTienCK.Name = "txtSoTienCK";
            this.txtSoTienCK.Size = new System.Drawing.Size(100, 20);
            this.txtSoTienCK.TabIndex = 177;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(468, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 176;
            this.label12.Text = "Chiết khấu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(432, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 175;
            this.label11.Text = "%";
            // 
            // txtPhanTramCK
            // 
            this.txtPhanTramCK.Location = new System.Drawing.Point(380, 85);
            this.txtPhanTramCK.Name = "txtPhanTramCK";
            this.txtPhanTramCK.Size = new System.Drawing.Size(46, 20);
            this.txtPhanTramCK.TabIndex = 174;
            this.txtPhanTramCK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhanTramCK_KeyPress);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(380, 148);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(252, 20);
            this.txtGhiChu.TabIndex = 173;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(380, 115);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(252, 20);
            this.txtThanhTien.TabIndex = 172;
            // 
            // txtDonGiaSauCK
            // 
            this.txtDonGiaSauCK.Enabled = false;
            this.txtDonGiaSauCK.Location = new System.Drawing.Point(124, 115);
            this.txtDonGiaSauCK.Name = "txtDonGiaSauCK";
            this.txtDonGiaSauCK.Size = new System.Drawing.Size(168, 20);
            this.txtDonGiaSauCK.TabIndex = 171;
            // 
            // txtDonGiaChuaCK
            // 
            this.txtDonGiaChuaCK.Location = new System.Drawing.Point(124, 82);
            this.txtDonGiaChuaCK.Name = "txtDonGiaChuaCK";
            this.txtDonGiaChuaCK.Size = new System.Drawing.Size(168, 20);
            this.txtDonGiaChuaCK.TabIndex = 170;
            this.txtDonGiaChuaCK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaChuaCK_KeyPress);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(124, 53);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(168, 20);
            this.txtSoLuong.TabIndex = 169;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // cmbBoxHangHoa
            // 
            this.cmbBoxHangHoa.DataSource = this.hangHoaBindingSource;
            this.cmbBoxHangHoa.DisplayMember = "TenHangHoa";
            this.cmbBoxHangHoa.FormattingEnabled = true;
            this.cmbBoxHangHoa.Location = new System.Drawing.Point(380, 50);
            this.cmbBoxHangHoa.Name = "cmbBoxHangHoa";
            this.cmbBoxHangHoa.Size = new System.Drawing.Size(252, 21);
            this.cmbBoxHangHoa.TabIndex = 167;
            this.cmbBoxHangHoa.ValueMember = "MaHangHoa";
            this.cmbBoxHangHoa.SelectedIndexChanged += new System.EventHandler(this.cmbBoxHangHoa_SelectedIndexChanged);
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet23;
            // 
            // quanLyBanBanhKeo_DoAnDataSet23
            // 
            this.quanLyBanBanhKeo_DoAnDataSet23.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet23";
            this.quanLyBanBanhKeo_DoAnDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbBoxKho
            // 
            this.cmbBoxKho.DataSource = this.khoBindingSource;
            this.cmbBoxKho.DisplayMember = "TenKho";
            this.cmbBoxKho.FormattingEnabled = true;
            this.cmbBoxKho.Location = new System.Drawing.Point(124, 148);
            this.cmbBoxKho.Name = "cmbBoxKho";
            this.cmbBoxKho.Size = new System.Drawing.Size(168, 21);
            this.cmbBoxKho.TabIndex = 166;
            this.cmbBoxKho.ValueMember = "MaKho";
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet24;
            // 
            // quanLyBanBanhKeo_DoAnDataSet24
            // 
            this.quanLyBanBanhKeo_DoAnDataSet24.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet24";
            this.quanLyBanBanhKeo_DoAnDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 164;
            this.label6.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 163;
            this.label7.Text = "Thành tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 162;
            this.label8.Text = "% Chiết khấu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 160;
            this.label10.Text = "Tên hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 159;
            this.label5.Text = "Kho hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 158;
            this.label4.Text = "Đơn giá sau CK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 157;
            this.label3.Text = "Đơn giá chưa CK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 156;
            this.label2.Text = "Số lượng";
            // 
            // checkBanBuon
            // 
            this.checkBanBuon.AutoSize = true;
            this.checkBanBuon.Location = new System.Drawing.Point(26, 12);
            this.checkBanBuon.Name = "checkBanBuon";
            this.checkBanBuon.Size = new System.Drawing.Size(86, 17);
            this.checkBanBuon.TabIndex = 180;
            this.checkBanBuon.Text = "Là bán buôn";
            this.checkBanBuon.UseVisualStyleBackColor = true;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // ThemHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 277);
            this.Controls.Add(this.checkBanBuon);
            this.Controls.Add(this.Huy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoTienCK);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPhanTramCK);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtDonGiaSauCK);
            this.Controls.Add(this.txtDonGiaChuaCK);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.cmbBoxHangHoa);
            this.Controls.Add(this.cmbBoxKho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ThemHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemHangHoa";
            this.Load += new System.EventHandler(this.ThemHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet24)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Huy;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.TextBox txtSoTienCK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPhanTramCK;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonGiaSauCK;
        private System.Windows.Forms.TextBox txtDonGiaChuaCK;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cmbBoxHangHoa;
        private System.Windows.Forms.ComboBox cmbBoxKho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBanBuon;
        private QuanLyBanBanhKeo_DoAnDataSet23 quanLyBanBanhKeo_DoAnDataSet23;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet23TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet24 quanLyBanBanhKeo_DoAnDataSet24;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet24TableAdapters.KhoTableAdapter khoTableAdapter;
    }
}