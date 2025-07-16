using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangDonHang;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangKeHoachSX;
using DevExpress.XtraEditors;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SuaHangHoa = BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangKeHoachSX.SuaHangHoa;
using ThemHangHoa = BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangKeHoachSX.ThemHangHoa;

namespace BanhKeo_Doan.FormNghiepVu
{
    public partial class FormKeHoachSanXuat : Form
    {
        public FormKeHoachSanXuat()
        {
            InitializeComponent();
        }

        private KetNoiCSDL ketnoiCSDL = new KetNoiCSDL();
        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            ThemHangHoa themHangHoa = new ThemHangHoa(maKeHoachSxDuocChon);
            themHangHoa.DaThemHangHoa += (s, args) =>
            {
                HienThiChiTietKeHoachSX(maKeHoachSxDuocChon);
            };
            themHangHoa.Show();
        }

        private void btnSuaHangHoa_Click(object sender, EventArgs e)
        {
            SuaHangHoa suaHangHoa = new SuaHangHoa(IdDuocChon);
            suaHangHoa.tenHangHoa = tenHangHoaDuocChon;
            suaHangHoa.soLuong = soLuongDuocChon;
            suaHangHoa.donGia = donGiaDuocChon;
            suaHangHoa.DaSuaHangHoa += (s, args) =>
            {
                HienThiChiTietKeHoachSX(maKeHoachSxDuocChon);
            };
            suaHangHoa.Show();
        }

        private void btnThemKeHoachSX_Click(object sender, EventArgs e)
        {
            ThemKeHoachSX themKeHoachSX = new ThemKeHoachSX();
            themKeHoachSX.DaThemKeHoachSX += (s, args) =>
            {
                HienThiKeHoachSX();
            };
            themKeHoachSX.Show();
        }

        private void FormKeHoachSanXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet46.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet46.NhanVien);
            HienThiKeHoachSX();
        }

        public void HienThiKeHoachSX()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            string tinhTongTienQuery = @"
                UPDATE KeHoachSanXuat
                SET TongTien = (
                SELECT SUM(ThanhTien)
                FROM ChiTietKeHoachSX
                WHERE ChiTietKeHoachSX.MaKeHoach = KeHoachSanXuat.MaKeHoach)";
            SqlCommand cmd = new SqlCommand(tinhTongTienQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            string query = "SELECT NgayLap," +
                " MaKeHoach," +
                " MaDonHang," +
                " TongTien," +
                " NhanVien.TenNhanVien," +
                " GhiChu FROM KeHoachSanXuat" +
                " Inner join NhanVien On NhanVien.MaNhanVien = KeHoachSanXuat.MaNhanVien" +
                " Order by NgayLap DESC";
            dataKeHoachSX.DataSource = ketnoiCSDL.GetData(query);
            dataKeHoachSX.Columns["NgayLap"].HeaderText = "Ngày lập";
            dataKeHoachSX.Columns["MaKeHoach"].HeaderText = "Mã kế hoạch";
            dataKeHoachSX.Columns["MaDonHang"].HeaderText = "Mã đơn hàng";
            dataKeHoachSX.Columns["TongTien"].HeaderText = "Tổng tiền";
            dataKeHoachSX.Columns["TenNhanVien"].HeaderText = "Nhân viên";
            dataKeHoachSX.Columns["GhiChu"].HeaderText = "Ghi chú";
            dataKeHoachSX.Columns["TongTien"].DefaultCellStyle.Format = "c0";
            dataKeHoachSX.Columns["TongTien"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
        }

        public void HienThiChiTietKeHoachSX(string maKeHoachSxDuocChon)
        {
            if (dataKeHoachSX.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dataKeHoachSX.CurrentRow;
                txtMaKeHoach.Text = maKeHoachSxDuocChon;
                cmbBoxNhanVien.Text = string.Empty;
                cmbBoxNhanVien.SelectedText = selectedRow.Cells["TenNhanVien"].Value?.ToString();
                dateNgayLapKeHoach.Value = (DateTime)selectedRow.Cells["NgayLap"].Value;
                object tongTienValue = selectedRow.Cells["TongTien"].Value;
                if (tongTienValue != DBNull.Value && tongTienValue != null && decimal.TryParse(tongTienValue.ToString(), out decimal tongTien))
                {
                    txtTongTien.Text = tongTien.ToString("c0", new System.Globalization.CultureInfo("vi-VN"));
                }
                txtGhiChu.Text = selectedRow.Cells["GhiChu"].Value?.ToString();
            }         
                string query1 = "SELECT ID," +
                    " HangHoa.TenHangHoa," +
                    " DonViTinh.TenDVT," +
                    " SoLuong," +
                    " DonGia," +
                    " ThanhTien," +
                    " Kho.TenKho, " +
                    " ChiTietKeHoachSX.GhiChu FROM ChiTietKeHoachSX" +
                    " Inner join KeHoachSanXuat on KeHoachSanXuat.MaKeHoach = ChiTietKeHoachSX.MaKeHoach" +
                    " Inner join HangHoa on HangHoa.MaHangHoa = ChiTietKeHoachSX.MaHangHoa" +
                    " Inner join DonViTinh on HangHoa.MaDVT = DonViTinh.MaDVT" +
                    " Inner join Kho on ChiTietKeHoachSX.MaKho = Kho.MaKho" +
                    " where ChiTietKeHoachSX.MaKeHoach = @maKeHoach";
                SqlCommand cmd = new SqlCommand(query1, KetNoiCSDL.GetConnection());
                cmd.Parameters.AddWithValue("@maKeHoach", maKeHoachSxDuocChon);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataChiTietKeHoachSX.DataSource = dt;
                if (dataChiTietKeHoachSX.Columns["ID"] != null)
                {
                    dataChiTietKeHoachSX.Columns["ID"].Visible = false;
                }
                dataChiTietKeHoachSX.Columns["TenHangHoa"].HeaderText = "Hàng hóa";
                dataChiTietKeHoachSX.Columns["TenDVT"].HeaderText = "Đơn vị tính";
                dataChiTietKeHoachSX.Columns["SoLuong"].HeaderText = "Số lượng";
                dataChiTietKeHoachSX.Columns["DonGia"].HeaderText = "Đơn giá";
                dataChiTietKeHoachSX.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dataChiTietKeHoachSX.Columns["TenKho"].HeaderText = "Tên kho";
                dataChiTietKeHoachSX.Columns["GhiChu"].HeaderText = "Ghi chú";
                dataChiTietKeHoachSX.Columns["DonGia"].DefaultCellStyle.Format = "c0";
                dataChiTietKeHoachSX.Columns["DonGia"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
                dataChiTietKeHoachSX.Columns["ThanhTien"].DefaultCellStyle.Format = "c0";
                dataChiTietKeHoachSX.Columns["ThanhTien"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
        }

        public void HienThiDinhLuong(string maKeHoachSxDuocChon)
        {
            string query2 = "SELECT HangHoa.TenHangHoa," +
                " DonViTinh.TenDVT," +
                " SUM(DinhLuong.SoLuong * ChiTietKeHoachSX.SoLuong) AS TongSoLuong" +
                " FROM ChiTietKeHoachSX " +
                " INNER JOIN DinhLuong ON ChiTietKeHoachSX.MaHangHoa = DinhLuong.MaHangHoa" +
                " INNER JOIN KeHoachSanXuat ON KeHoachSanXuat.MaKeHoach = ChiTietKeHoachSX.MaKeHoach" +
                " INNER JOIN HangHoa ON HangHoa.MaHangHoa = DinhLuong.MaHangHoaNL" +
                " INNER JOIN DonViTinh ON DonViTinh.MaDVT = HangHoa.MaDVT" +
                " WHERE KeHoachSanXuat.MaKeHoach = @MaKeHoach" +
                " GROUP BY HangHoa.TenHangHoa, DonViTinh.TenDVT";
            SqlCommand cmd = new SqlCommand(query2, KetNoiCSDL.GetConnection());
            cmd.Parameters.AddWithValue("@MaKeHoach", maKeHoachSxDuocChon);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataDinhLuong.DataSource = dt;
            dataDinhLuong.Columns["TenHangHoa"].HeaderText = "Hàng hóa nguyên liệu";
            dataDinhLuong.Columns["TenDVT"].HeaderText = "Đơn vị tính";
            dataDinhLuong.Columns["TongSoLuong"].HeaderText = "Tổng số lượng";
        }

        private DataGridViewRow selectedRow;
        private string maKeHoachSxDuocChon = "";
        private void dataKeHoachSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataKeHoachSX.Rows[e.RowIndex];
                maKeHoachSxDuocChon = selectedRow.Cells["MaKeHoach"].Value?.ToString();
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }
        private string IdDuocChon = "";
        private string tenHangHoaDuocChon = "";
        public string soLuongDuocChon = "";
        public string donGiaDuocChon = "";
        private void dataChiTietKeHoachSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataChiTietKeHoachSX.Rows[e.RowIndex];
                IdDuocChon = selectedRow.Cells["ID"].Value?.ToString();
                tenHangHoaDuocChon = selectedRow.Cells["TenHangHoa"].Value?.ToString();
                soLuongDuocChon = selectedRow.Cells["SoLuong"].Value?.ToString();
                donGiaDuocChon = selectedRow.Cells["DonGia"].Value?.ToString();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabChiTietKeHoachSX && selectedRow != null)
            {
                if (!string.IsNullOrEmpty(maKeHoachSxDuocChon))
                {
                    HienThiChiTietKeHoachSX(maKeHoachSxDuocChon);
                }
            }
            if (tabControl1.SelectedTab == tabKeHoachSX)
            {
                HienThiKeHoachSX();
            }
            if (tabControl1.SelectedTab == PageDinhLuong)
            {
                HienThiDinhLuong(maKeHoachSxDuocChon);
            }
        }

        private void btnXoaKeHoach_Click(object sender, EventArgs e)
        {
            string query2 = "DELETE FROM KeHoachSanXuat where MaKeHoach = @maKeHoach";
            SqlCommand cmd = new SqlCommand(query2, KetNoiCSDL.GetConnection());
            cmd.Parameters.AddWithValue("@maKeHoach", maKeHoachSxDuocChon);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            HienThiKeHoachSX();
        }

        private void btnXoaHangHoa_Click(object sender, EventArgs e)
        {
            string query3 = "DELETE FROM ChiTietKeHoachSX where ID = @ID";
            SqlCommand cmd = new SqlCommand(query3, KetNoiCSDL.GetConnection());
            cmd.Parameters.AddWithValue("@ID", IdDuocChon);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            HienThiChiTietKeHoachSX(maKeHoachSxDuocChon);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbMaKeHoach.Checked)
            {
                TKtheoMaKH();
            }
            if (cbNgay.Checked)
            {
                TKtheoNgay();
            }
            if (cbMaKeHoach.Checked == false && cbNgay.Checked == false)
            {
                HienThiKeHoachSX();
            }
        }

        public void TKtheoMaKH()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            string query4 = "SELECT NgayLap," +
                " MaKeHoach," +
                " TongTien," +
                " GhiChu FROM KeHoachSanXuat" +
                " Where MaKeHoach = @maKeHoach";
            SqlCommand cmd = new SqlCommand(query4, conn);
            cmd.Parameters.AddWithValue("@maKeHoach", txtTKMaKeHoach.Text);
            dataKeHoachSX.DataSource = ketnoiCSDL.GetData1(cmd);
            dataKeHoachSX.Columns["NgayLap"].HeaderText = "Ngày lập";
            dataKeHoachSX.Columns["MaKeHoach"].HeaderText = "Mã kế hoạch";
            dataKeHoachSX.Columns["TongTien"].HeaderText = "Tổng tiền";
            dataKeHoachSX.Columns["GhiChu"].HeaderText = "Ghi chú";
            conn.Close();
        }

        public void TKtheoNgay()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            string query4 = "SELECT NgayLap," +
                " MaKeHoach," +
                " TongTien," +
                " GhiChu FROM KeHoachSanXuat" +
                " Where NgayLap between @NgayBatDau and @NgayKetThuc";
            SqlCommand cmd = new SqlCommand(query4, conn);
            cmd.Parameters.AddWithValue("@NgayBatDau", dateNgayBD.Value.Date);
            cmd.Parameters.AddWithValue("@NgayKetThuc", dateNgayKT.Value.Date);
            dataKeHoachSX.DataSource = ketnoiCSDL.GetData1(cmd);
            dataKeHoachSX.Columns["NgayLap"].HeaderText = "Ngày lập";
            dataKeHoachSX.Columns["MaKeHoach"].HeaderText = "Mã kế hoạch";
            dataKeHoachSX.Columns["TongTien"].HeaderText = "Tổng tiền";
            dataKeHoachSX.Columns["GhiChu"].HeaderText = "Ghi chú";
            conn.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            InKeHoachSanXuat inKeHoachSanXuat = new InKeHoachSanXuat(maKeHoachSxDuocChon);
            inKeHoachSanXuat.Show();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            int index1 = cmbBoxNhanVien.FindStringExact(cmbBoxNhanVien.Text);
            cmbBoxNhanVien.SelectedIndex = index1;
            string maNV = cmbBoxNhanVien.SelectedValue?.ToString();
            string insertQuery = "UPDATE KeHoachSanXuat SET " +
                    "NgayLap = @NgayLap," +
                    "MaNhanVien = @MaNhanVien, " +
                    "GhiChu = @GhiChu " +
                    "Where MaKeHoach = @MaKeHoach";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@MaKeHoach", maKeHoachSxDuocChon);
            cmd.Parameters.AddWithValue("@NgayLap", dateNgayLapKeHoach.Value.Date);
            cmd.Parameters.AddWithValue("@MaNhanVien", cmbBoxNhanVien.SelectedValue);
            cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa kế hoạch sản xuất thành công.", "Thông báo", MessageBoxButtons.OK);
            conn.Close();
        }
    }
}
