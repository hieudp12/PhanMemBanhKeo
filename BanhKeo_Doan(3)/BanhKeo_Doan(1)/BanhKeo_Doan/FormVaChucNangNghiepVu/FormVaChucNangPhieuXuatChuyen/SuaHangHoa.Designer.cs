namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatChuyen
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
            this.Huy1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnChapNhan1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoLuongXuat1 = new System.Windows.Forms.TextBox();
            this.txtGhiC = new System.Windows.Forms.TextBox();
            this.cmbHangHoa1 = new System.Windows.Forms.ComboBox();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet92 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet92();
            this.cmbKhoNhap1 = new System.Windows.Forms.ComboBox();
            this.khoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet98 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet98();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanBanhKeo_DoAnDataSet49 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet49();
            this.cmbKhoXuat1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDVT1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.khoTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet49TableAdapters.KhoTableAdapter();
            this.hangHoaTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet92TableAdapters.HangHoaTableAdapter();
            this.khoTableAdapter1 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet98TableAdapters.KhoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet92)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet98)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet49)).BeginInit();
            this.SuspendLayout();
            // 
            // Huy1
            // 
            this.Huy1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Huy1.ImageOptions.SvgImage")));
            this.Huy1.Location = new System.Drawing.Point(364, 165);
            this.Huy1.Margin = new System.Windows.Forms.Padding(4);
            this.Huy1.Name = "Huy1";
            this.Huy1.Size = new System.Drawing.Size(124, 56);
            this.Huy1.TabIndex = 181;
            this.Huy1.Text = "Hủy bỏ";
            this.Huy1.Click += new System.EventHandler(this.Huy1_Click);
            // 
            // btnChapNhan1
            // 
            this.btnChapNhan1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChapNhan1.ImageOptions.SvgImage")));
            this.btnChapNhan1.Location = new System.Drawing.Point(91, 165);
            this.btnChapNhan1.Margin = new System.Windows.Forms.Padding(4);
            this.btnChapNhan1.Name = "btnChapNhan1";
            this.btnChapNhan1.Size = new System.Drawing.Size(124, 56);
            this.btnChapNhan1.TabIndex = 180;
            this.btnChapNhan1.Text = "Chấp nhận";
            this.btnChapNhan1.Click += new System.EventHandler(this.btnChapNhan1_Click);
            // 
            // txtSoLuongXuat1
            // 
            this.txtSoLuongXuat1.Location = new System.Drawing.Point(364, 70);
            this.txtSoLuongXuat1.Name = "txtSoLuongXuat1";
            this.txtSoLuongXuat1.Size = new System.Drawing.Size(182, 20);
            this.txtSoLuongXuat1.TabIndex = 178;
            // 
            // txtGhiC
            // 
            this.txtGhiC.Location = new System.Drawing.Point(364, 106);
            this.txtGhiC.Name = "txtGhiC";
            this.txtGhiC.Size = new System.Drawing.Size(182, 20);
            this.txtGhiC.TabIndex = 179;
            // 
            // cmbHangHoa1
            // 
            this.cmbHangHoa1.DataSource = this.hangHoaBindingSource;
            this.cmbHangHoa1.DisplayMember = "TenHangHoa";
            this.cmbHangHoa1.Enabled = false;
            this.cmbHangHoa1.FormattingEnabled = true;
            this.cmbHangHoa1.Location = new System.Drawing.Point(108, 70);
            this.cmbHangHoa1.Name = "cmbHangHoa1";
            this.cmbHangHoa1.Size = new System.Drawing.Size(168, 21);
            this.cmbHangHoa1.TabIndex = 177;
            this.cmbHangHoa1.ValueMember = "MaHangHoa";
            this.cmbHangHoa1.SelectedIndexChanged += new System.EventHandler(this.cmbHangHoa1_SelectedIndexChanged);
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet92;
            // 
            // quanLyBanBanhKeo_DoAnDataSet92
            // 
            this.quanLyBanBanhKeo_DoAnDataSet92.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet92";
            this.quanLyBanBanhKeo_DoAnDataSet92.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbKhoNhap1
            // 
            this.cmbKhoNhap1.DataSource = this.khoBindingSource1;
            this.cmbKhoNhap1.DisplayMember = "TenKho";
            this.cmbKhoNhap1.FormattingEnabled = true;
            this.cmbKhoNhap1.Location = new System.Drawing.Point(364, 37);
            this.cmbKhoNhap1.Name = "cmbKhoNhap1";
            this.cmbKhoNhap1.Size = new System.Drawing.Size(181, 21);
            this.cmbKhoNhap1.TabIndex = 176;
            this.cmbKhoNhap1.ValueMember = "MaKho";
            // 
            // khoBindingSource1
            // 
            this.khoBindingSource1.DataMember = "Kho";
            this.khoBindingSource1.DataSource = this.quanLyBanBanhKeo_DoAnDataSet98;
            // 
            // quanLyBanBanhKeo_DoAnDataSet98
            // 
            this.quanLyBanBanhKeo_DoAnDataSet98.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet98";
            this.quanLyBanBanhKeo_DoAnDataSet98.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet49;
            // 
            // quanLyBanBanhKeo_DoAnDataSet49
            // 
            this.quanLyBanBanhKeo_DoAnDataSet49.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet49";
            this.quanLyBanBanhKeo_DoAnDataSet49.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbKhoXuat1
            // 
            this.cmbKhoXuat1.DataSource = this.khoBindingSource;
            this.cmbKhoXuat1.DisplayMember = "TenKho";
            this.cmbKhoXuat1.FormattingEnabled = true;
            this.cmbKhoXuat1.Location = new System.Drawing.Point(108, 37);
            this.cmbKhoXuat1.Name = "cmbKhoXuat1";
            this.cmbKhoXuat1.Size = new System.Drawing.Size(168, 21);
            this.cmbKhoXuat1.TabIndex = 175;
            this.cmbKhoXuat1.ValueMember = "MaKho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 174;
            this.label6.Text = "Ghi chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 173;
            this.label9.Text = "Tên hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 172;
            this.label10.Text = "Tên kho nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 171;
            this.label5.Text = "Số lượng xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 170;
            this.label1.Text = "Tên kho xuất";
            // 
            // txtDVT1
            // 
            this.txtDVT1.Location = new System.Drawing.Point(108, 109);
            this.txtDVT1.Name = "txtDVT1";
            this.txtDVT1.ReadOnly = true;
            this.txtDVT1.Size = new System.Drawing.Size(168, 20);
            this.txtDVT1.TabIndex = 179;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 173;
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
            // SuaHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 241);
            this.Controls.Add(this.Huy1);
            this.Controls.Add(this.btnChapNhan1);
            this.Controls.Add(this.txtSoLuongXuat1);
            this.Controls.Add(this.txtDVT1);
            this.Controls.Add(this.txtGhiC);
            this.Controls.Add(this.cmbHangHoa1);
            this.Controls.Add(this.cmbKhoNhap1);
            this.Controls.Add(this.cmbKhoXuat1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "SuaHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaHangHoa";
            this.Load += new System.EventHandler(this.SuaHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet92)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet98)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet49)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Huy1;
        private DevExpress.XtraEditors.SimpleButton btnChapNhan1;
        private System.Windows.Forms.TextBox txtSoLuongXuat1;
        private System.Windows.Forms.TextBox txtGhiC;
        private System.Windows.Forms.ComboBox cmbHangHoa1;
        private System.Windows.Forms.ComboBox cmbKhoNhap1;
        private System.Windows.Forms.ComboBox cmbKhoXuat1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDVT1;
        private System.Windows.Forms.Label label2;
        private QuanLyBanBanhKeo_DoAnDataSet49 quanLyBanBanhKeo_DoAnDataSet49;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet49TableAdapters.KhoTableAdapter khoTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet92 quanLyBanBanhKeo_DoAnDataSet92;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet92TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet98 quanLyBanBanhKeo_DoAnDataSet98;
        private System.Windows.Forms.BindingSource khoBindingSource1;
        private QuanLyBanBanhKeo_DoAnDataSet98TableAdapters.KhoTableAdapter khoTableAdapter1;
    }
}