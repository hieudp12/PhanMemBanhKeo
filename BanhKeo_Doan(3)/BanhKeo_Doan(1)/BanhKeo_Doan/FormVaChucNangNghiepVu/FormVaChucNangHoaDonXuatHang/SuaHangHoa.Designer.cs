namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHoaDonXuatHang
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
            this.Huy = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoTienCK = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhanTramCK = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDGsauCK = new System.Windows.Forms.TextBox();
            this.txtDGchuaCK = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cmbBoxHangHoa = new System.Windows.Forms.ComboBox();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet19 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet19();
            this.cmbBoxKho = new System.Windows.Forms.ComboBox();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet20 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet20();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hangHoaTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet19TableAdapters.HangHoaTableAdapter();
            this.khoTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet20TableAdapters.KhoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // Huy
            // 
            this.Huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Huy.ImageOptions.SvgImage")));
            this.Huy.Location = new System.Drawing.Point(391, 208);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(100, 45);
            this.Huy.TabIndex = 204;
            this.Huy.Text = "Hủy bỏ";
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Location = new System.Drawing.Point(203, 208);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 45);
            this.btnSua.TabIndex = 203;
            this.btnSua.Text = "Chấp nhận";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtSoTienCK
            // 
            this.txtSoTienCK.Enabled = false;
            this.txtSoTienCK.Location = new System.Drawing.Point(543, 92);
            this.txtSoTienCK.Name = "txtSoTienCK";
            this.txtSoTienCK.Size = new System.Drawing.Size(100, 20);
            this.txtSoTienCK.TabIndex = 202;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(479, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 201;
            this.label12.Text = "Chiết khấu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(443, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 200;
            this.label11.Text = "%";
            // 
            // txtPhanTramCK
            // 
            this.txtPhanTramCK.Location = new System.Drawing.Point(391, 89);
            this.txtPhanTramCK.Name = "txtPhanTramCK";
            this.txtPhanTramCK.Size = new System.Drawing.Size(46, 20);
            this.txtPhanTramCK.TabIndex = 199;
            this.txtPhanTramCK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhanTramCK_KeyPress);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(391, 152);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(252, 20);
            this.txtGhiChu.TabIndex = 198;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(391, 119);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(252, 20);
            this.txtThanhTien.TabIndex = 197;
            // 
            // txtDGsauCK
            // 
            this.txtDGsauCK.Enabled = false;
            this.txtDGsauCK.Location = new System.Drawing.Point(135, 119);
            this.txtDGsauCK.Name = "txtDGsauCK";
            this.txtDGsauCK.Size = new System.Drawing.Size(168, 20);
            this.txtDGsauCK.TabIndex = 196;
            // 
            // txtDGchuaCK
            // 
            this.txtDGchuaCK.Location = new System.Drawing.Point(135, 86);
            this.txtDGchuaCK.Name = "txtDGchuaCK";
            this.txtDGchuaCK.Size = new System.Drawing.Size(168, 20);
            this.txtDGchuaCK.TabIndex = 195;
            this.txtDGchuaCK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDGchuaCK_KeyPress);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(135, 57);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(168, 20);
            this.txtSoLuong.TabIndex = 194;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // cmbBoxHangHoa
            // 
            this.cmbBoxHangHoa.DataSource = this.hangHoaBindingSource;
            this.cmbBoxHangHoa.DisplayMember = "TenHangHoa";
            this.cmbBoxHangHoa.Enabled = false;
            this.cmbBoxHangHoa.FormattingEnabled = true;
            this.cmbBoxHangHoa.Location = new System.Drawing.Point(391, 57);
            this.cmbBoxHangHoa.Name = "cmbBoxHangHoa";
            this.cmbBoxHangHoa.Size = new System.Drawing.Size(252, 21);
            this.cmbBoxHangHoa.TabIndex = 192;
            this.cmbBoxHangHoa.ValueMember = "MaHangHoa";
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet19;
            // 
            // quanLyBanBanhKeo_DoAnDataSet19
            // 
            this.quanLyBanBanhKeo_DoAnDataSet19.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet19";
            this.quanLyBanBanhKeo_DoAnDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbBoxKho
            // 
            this.cmbBoxKho.DataSource = this.khoBindingSource;
            this.cmbBoxKho.DisplayMember = "TenKho";
            this.cmbBoxKho.FormattingEnabled = true;
            this.cmbBoxKho.Location = new System.Drawing.Point(135, 152);
            this.cmbBoxKho.Name = "cmbBoxKho";
            this.cmbBoxKho.Size = new System.Drawing.Size(168, 21);
            this.cmbBoxKho.TabIndex = 191;
            this.cmbBoxKho.ValueMember = "MaKho";
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet20;
            // 
            // quanLyBanBanhKeo_DoAnDataSet20
            // 
            this.quanLyBanBanhKeo_DoAnDataSet20.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet20";
            this.quanLyBanBanhKeo_DoAnDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 189;
            this.label6.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 188;
            this.label7.Text = "Thành tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 187;
            this.label8.Text = "% Chiết khấu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 185;
            this.label10.Text = "Tên hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 184;
            this.label5.Text = "Kho hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 183;
            this.label4.Text = "Đơn giá sau CK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 182;
            this.label3.Text = "Đơn giá chưa CK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 181;
            this.label2.Text = "Số lượng";
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // SuaHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 277);
            this.Controls.Add(this.Huy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtSoTienCK);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPhanTramCK);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtDGsauCK);
            this.Controls.Add(this.txtDGchuaCK);
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
            this.Name = "SuaHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaHangHoa";
            this.Load += new System.EventHandler(this.SuaHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Huy;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.TextBox txtSoTienCK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPhanTramCK;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDGsauCK;
        private System.Windows.Forms.TextBox txtDGchuaCK;
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
        private QuanLyBanBanhKeo_DoAnDataSet19 quanLyBanBanhKeo_DoAnDataSet19;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet19TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet20 quanLyBanBanhKeo_DoAnDataSet20;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet20TableAdapters.KhoTableAdapter khoTableAdapter;
    }
}