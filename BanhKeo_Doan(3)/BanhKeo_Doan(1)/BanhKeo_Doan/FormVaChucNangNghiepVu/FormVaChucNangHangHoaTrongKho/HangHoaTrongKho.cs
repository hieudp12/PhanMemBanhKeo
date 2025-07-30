using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHangHoaTrongKho
{
    public partial class HangHoaTrongKho : Form
    {
        public HangHoaTrongKho()
        {
            InitializeComponent();
        }
        private KetNoiCSDL ketnoiCSDL = new KetNoiCSDL();
        public void HienThiHangHoaTrongKho()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            string query = "SELECT ID," +
                " HangHoa.TenHangHoa," +
                " DonViTinh.TenDVT," +
                " SoLuong," +
                " Kho.TenKho FROM HangHoaTrongKho" +
                " Inner join HangHoa on HangHoaTrongKho.MaHangHoa = HangHoa.MaHangHoa" +
                " Inner join Kho on HangHoaTrongKho.MaKho = Kho.MaKho" +
                " Inner join DonViTinh on HangHoa.MaDVT = DonViTinh.MaDVT";
            dataHangHoaTrongKho.DataSource = ketnoiCSDL.GetData(query);
            dataHangHoaTrongKho.Columns["ID"].HeaderText = "Stt";
            dataHangHoaTrongKho.Columns["TenHangHoa"].HeaderText = "Hàng hóa";
            dataHangHoaTrongKho.Columns["TenDVT"].HeaderText = "Đơn vị tính";
            dataHangHoaTrongKho.Columns["SoLuong"].HeaderText = "Số lượng";
            dataHangHoaTrongKho.Columns["TenKho"].HeaderText = "Kho";
        }

        private DataGridViewRow selectedRow;
        public string idDuocChon;
        public string tenHHDuocChon;
        public string SoLuong;

        private void dataHangHoaTrongKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataHangHoaTrongKho.Rows[e.RowIndex];
                idDuocChon = selectedRow.Cells["ID"].Value?.ToString();
                tenHHDuocChon = selectedRow.Cells["TenHangHoa"].Value?.ToString();
                SoLuong = selectedRow.Cells["SoLuong"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemHangHoa themHangHoa = new ThemHangHoa();
            themHangHoa.DaThemHangHoa += (s, args) =>
            {
                HienThiHangHoaTrongKho();
            };
            themHangHoa.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaHangHoa suaHangHoa = new SuaHangHoa(idDuocChon);
            suaHangHoa.tenHangHoa = tenHHDuocChon;
            suaHangHoa.soLuong = SoLuong;
            suaHangHoa.DaSuaHangHoa += (s, args) =>
            {
                HienThiHangHoaTrongKho();
            };
            suaHangHoa.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query3 = "DELETE FROM HangHoaTrongKho where ID = @ID";
            SqlCommand cmd = new SqlCommand(query3, KetNoiCSDL.GetConnection());
            cmd.Parameters.AddWithValue("@ID", idDuocChon);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MessageBox.Show("Xóa hàng hóa thành công.", "Thông báo", MessageBoxButtons.OK);
            HienThiHangHoaTrongKho();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbHH.Checked)
            {
                TkTheoHangHoa();
            }
            if (cbLoaiHang.Checked)
            {
                TkTheoLoaiHang();
            }
            if (cbKho.Checked)
            {
                TkTheoKho();
            }
            if (cbHH.Checked == false && cbLoaiHang.Checked == false && cbKho.Checked == false)
            {
                HienThiHangHoaTrongKho();
            }
        }
        public void TkTheoHangHoa()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            string query4 = "SELECT ID," +
                " HangHoa.TenHangHoa," +
                " DonViTinh.TenDVT," +
                " SoLuong," +
                " Kho.TenKho FROM HangHoaTrongKho" +
                " Inner join HangHoa on HangHoaTrongKho.MaHangHoa = HangHoa.MaHangHoa" +
                " Inner join Kho on HangHoaTrongKho.MaKho = Kho.MaKho" +
                " Inner join DonViTinh on HangHoa.MaDVT = DonViTinh.MaDVT" +
                " Where HangHoaTrongKho.MaHangHoa = @MaHangHoa";
            SqlCommand cmd = new SqlCommand(query4, conn);
            cmd.Parameters.AddWithValue("@MaHangHoa", cmbBoxHH.SelectedValue);
            dataHangHoaTrongKho.DataSource = ketnoiCSDL.GetData1(cmd);
            dataHangHoaTrongKho.Columns["ID"].HeaderText = "Stt";
            dataHangHoaTrongKho.Columns["TenHangHoa"].HeaderText = "Hàng hóa";
            dataHangHoaTrongKho.Columns["TenDVT"].HeaderText = "Đơn vị tính";
            dataHangHoaTrongKho.Columns["SoLuong"].HeaderText = "Số lượng";
            dataHangHoaTrongKho.Columns["TenKho"].HeaderText = "Kho";
            conn.Close();
        }
        public void TkTheoLoaiHang()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            string query4 = "SELECT ID," +
                " HangHoa.TenHangHoa," +
                " DonViTinh.TenDVT," +
                " SoLuong," +
                " Kho.TenKho FROM HangHoaTrongKho" +
                " Inner join HangHoa on HangHoaTrongKho.MaHangHoa = HangHoa.MaHangHoa" +
                " Inner join Kho on HangHoaTrongKho.MaKho = Kho.MaKho" +
                " Inner join DonViTinh on HangHoa.MaDVT = DonViTinh.MaDVT" +
                " Where HangHoa.MaLoaiHang = @MaLoaiHang";
            SqlCommand cmd = new SqlCommand(query4, conn);
            cmd.Parameters.AddWithValue("@MaLoaiHang", cmbBoxLoaiHang.SelectedValue);
            dataHangHoaTrongKho.DataSource = ketnoiCSDL.GetData1(cmd);
            dataHangHoaTrongKho.Columns["ID"].HeaderText = "Stt";
            dataHangHoaTrongKho.Columns["TenHangHoa"].HeaderText = "Hàng hóa";
            dataHangHoaTrongKho.Columns["TenDVT"].HeaderText = "Đơn vị tính";
            dataHangHoaTrongKho.Columns["SoLuong"].HeaderText = "Số lượng";
            dataHangHoaTrongKho.Columns["TenKho"].HeaderText = "Kho";
            conn.Close();
        }
        public void TkTheoKho()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            string query4 = "SELECT ID," +
                " HangHoa.TenHangHoa," +
                " DonViTinh.TenDVT," +
                " SoLuong," +
                " Kho.TenKho FROM HangHoaTrongKho" +
                " Inner join HangHoa on HangHoaTrongKho.MaHangHoa = HangHoa.MaHangHoa" +
                " Inner join Kho on HangHoaTrongKho.MaKho = Kho.MaKho" +
                " Inner join DonViTinh on HangHoa.MaDVT = DonViTinh.MaDVT" +
                " Where HangHoaTrongKho.MaKho = @MaKho";
            SqlCommand cmd = new SqlCommand(query4, conn);
            cmd.Parameters.AddWithValue("@MaKho", cmbBoxKho.SelectedValue);
            dataHangHoaTrongKho.DataSource = ketnoiCSDL.GetData1(cmd);
            dataHangHoaTrongKho.Columns["ID"].HeaderText = "Stt";
            dataHangHoaTrongKho.Columns["TenHangHoa"].HeaderText = "Hàng hóa";
            dataHangHoaTrongKho.Columns["TenDVT"].HeaderText = "Đơn vị tính";
            dataHangHoaTrongKho.Columns["SoLuong"].HeaderText = "Số lượng";
            dataHangHoaTrongKho.Columns["TenKho"].HeaderText = "Kho";
            conn.Close();
        }

        private void HangHoaTrongKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet110.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet110.Kho);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet109.LoaiHang' table. You can move, or remove it, as needed.
            this.loaiHangTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet109.LoaiHang);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet108.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet108.HangHoa);
            HienThiHangHoaTrongKho();
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
