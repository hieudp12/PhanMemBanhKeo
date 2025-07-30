namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHangHoaTrongKho
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
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxKho = new System.Windows.Forms.ComboBox();
            this.btnThemHangHoa = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cmbBoxHangHoa = new System.Windows.Forms.ComboBox();
            this.Huy = new DevExpress.XtraEditors.SimpleButton();
            this.quanLyBanBanhKeo_DoAnDataSet106 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet106();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet106TableAdapters.HangHoaTableAdapter();
            this.quanLyBanBanhKeo_DoAnDataSet107 = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet107();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new BanhKeo_Doan.QuanLyBanBanhKeo_DoAnDataSet107TableAdapters.KhoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet106)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet107)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 205;
            this.label10.Text = "Tên hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 204;
            this.label5.Text = "Kho hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 203;
            this.label2.Text = "Số lượng";
            // 
            // cmbBoxKho
            // 
            this.cmbBoxKho.DataSource = this.khoBindingSource;
            this.cmbBoxKho.DisplayMember = "TenKho";
            this.cmbBoxKho.FormattingEnabled = true;
            this.cmbBoxKho.Location = new System.Drawing.Point(142, 130);
            this.cmbBoxKho.Name = "cmbBoxKho";
            this.cmbBoxKho.Size = new System.Drawing.Size(252, 21);
            this.cmbBoxKho.TabIndex = 206;
            this.cmbBoxKho.ValueMember = "MaKho";
            // 
            // btnThemHangHoa
            // 
            this.btnThemHangHoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemHangHoa.ImageOptions.SvgImage")));
            this.btnThemHangHoa.Location = new System.Drawing.Point(40, 186);
            this.btnThemHangHoa.Name = "btnThemHangHoa";
            this.btnThemHangHoa.Size = new System.Drawing.Size(100, 45);
            this.btnThemHangHoa.TabIndex = 209;
            this.btnThemHangHoa.Text = "Chấp nhận";
            this.btnThemHangHoa.Click += new System.EventHandler(this.btnThemHangHoa_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(142, 90);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(252, 20);
            this.txtSoLuong.TabIndex = 208;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // cmbBoxHangHoa
            // 
            this.cmbBoxHangHoa.DataSource = this.hangHoaBindingSource;
            this.cmbBoxHangHoa.DisplayMember = "TenHangHoa";
            this.cmbBoxHangHoa.FormattingEnabled = true;
            this.cmbBoxHangHoa.Location = new System.Drawing.Point(142, 46);
            this.cmbBoxHangHoa.Name = "cmbBoxHangHoa";
            this.cmbBoxHangHoa.Size = new System.Drawing.Size(252, 21);
            this.cmbBoxHangHoa.TabIndex = 207;
            this.cmbBoxHangHoa.ValueMember = "MaHangHoa";
            // 
            // Huy
            // 
            this.Huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Huy.ImageOptions.SvgImage")));
            this.Huy.Location = new System.Drawing.Point(294, 186);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(100, 45);
            this.Huy.TabIndex = 210;
            this.Huy.Text = "Hủy bỏ";
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // quanLyBanBanhKeo_DoAnDataSet106
            // 
            this.quanLyBanBanhKeo_DoAnDataSet106.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet106";
            this.quanLyBanBanhKeo_DoAnDataSet106.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet106;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyBanBanhKeo_DoAnDataSet107
            // 
            this.quanLyBanBanhKeo_DoAnDataSet107.DataSetName = "QuanLyBanBanhKeo_DoAnDataSet107";
            this.quanLyBanBanhKeo_DoAnDataSet107.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.quanLyBanBanhKeo_DoAnDataSet107;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // SuaHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 277);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBoxKho);
            this.Controls.Add(this.btnThemHangHoa);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.cmbBoxHangHoa);
            this.Controls.Add(this.Huy);
            this.Name = "SuaHangHoa";
            this.Text = "SuaHangHoa";
            this.Load += new System.EventHandler(this.SuaHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet106)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanBanhKeo_DoAnDataSet107)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxKho;
        private DevExpress.XtraEditors.SimpleButton btnThemHangHoa;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cmbBoxHangHoa;
        private DevExpress.XtraEditors.SimpleButton Huy;
        private QuanLyBanBanhKeo_DoAnDataSet106 quanLyBanBanhKeo_DoAnDataSet106;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet106TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
        private QuanLyBanBanhKeo_DoAnDataSet107 quanLyBanBanhKeo_DoAnDataSet107;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QuanLyBanBanhKeo_DoAnDataSet107TableAdapters.KhoTableAdapter khoTableAdapter;
    }
}