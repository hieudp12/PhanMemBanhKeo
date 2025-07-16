using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangDonHang;
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

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHoaDonXuatHang
{
    public partial class FormHoaDonXuatHang : Form
    {
        public FormHoaDonXuatHang()
        {
            InitializeComponent();
        }
        private KetNoiCSDL ketnoiCSDL = new KetNoiCSDL();

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            ThemHangHoa themHangHoa = new ThemHangHoa(maHoaDonDuocChon);
            themHangHoa.DaThemHangHoa += (s, args) =>
            {
                HienThiChiTietHoaDon(maHoaDonDuocChon);
            };
            themHangHoa.Show();
        }

        private void btnSuaHangHoa_Click(object sender, EventArgs e)
        {
            SuaHangHoa suaHangHoa = new SuaHangHoa(IdDuocChon);
            suaHangHoa.tenHangHoa = tenHangHoaDuocChon;
            suaHangHoa.soLuong = soLuongDuocChon;
            suaHangHoa.donGia = DGtruocCkDuocChon;
            suaHangHoa.phanTramCK = phanTramCkDuocChon;
            suaHangHoa.DaSuaHangHoa += (s, args) =>
            {
                HienThiChiTietHoaDon(maHoaDonDuocChon);
            };
            suaHangHoa.Show();
        }

        private void btnThemHoaDonXuatHang_Click(object sender, EventArgs e)
        {
            ThemHoaDonXuatHang themHoaDonXuatHang = new ThemHoaDonXuatHang();
            themHoaDonXuatHang.DaThemHoaDon += (s, args) =>
            {
                HienThiHoaDon();
            };
            themHoaDonXuatHang.Show();
        }

        private void FormHoaDonXuatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet51.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet51.NhanVien);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet50.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet50.Kho);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet49.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter1.Fill(this.quanLyBanBanhKeo_DoAnDataSet49.KhachHang);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet26.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet26.KhachHang);
            HienThiHoaDon();
        }

        public void HienThiHoaDon()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            string tinhTongTienQuery = @"
                    UPDATE HoaDonXuatHang
                    SET TongChuaCK = (
                    SELECT SUM(ThanhTien)
                    FROM ChiTietHoaDonXuatHang
                    WHERE ChiTietHoaDonXuatHang.MaHoaDonXuatHang = HoaDonXuatHang.MaHoaDonXuatHang);
                    UPDATE HoaDonXuatHang
                    SET ChietKhau = TongChuaCK * PhanTramCK / 100,
                        TongTien = TongChuaCK - ChietKhau";
            SqlCommand cmd = new SqlCommand(tinhTongTienQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            string query = "SELECT NgayXuat," +
                " MaHoaDonXuatHang," +
                " KhachHang.TenKhachHang," +
                " KhachHang.Tel," +
                " KhachHang.DiaChi," +
                " TongChuaCK," +
                " PhanTramCK," +
                " ChietKhau," +
                " TongTien," +
                " NhanVien.TenNhanVien," +
                " GhiChu FROM HoaDonXuatHang" +
                " Inner join KhachHang on HoaDonXuatHang.MaKhachHang = KhachHang.MaKhachHang" +
                " Inner join NhanVien on HoaDonXuatHang.MaNhanVien = NhanVien.MaNhanVien" +
                " Order by NgayXuat DESC";
            dataHoaDonXuatHang.DataSource = ketnoiCSDL.GetData(query);
            dataHoaDonXuatHang.Columns["NgayXuat"].HeaderText = "Ngày xuất";
            dataHoaDonXuatHang.Columns["MaHoaDonXuatHang"].HeaderText = "Mã hóa đơn";
            dataHoaDonXuatHang.Columns["TenKhachHang"].HeaderText = "Khách hàng";
            dataHoaDonXuatHang.Columns["Tel"].HeaderText = "Số điện thoại";
            dataHoaDonXuatHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dataHoaDonXuatHang.Columns["TongChuaCK"].HeaderText = "Tổng chưa CK";
            dataHoaDonXuatHang.Columns["PhanTramCK"].HeaderText = "% chiết khấu";
            dataHoaDonXuatHang.Columns["ChietKhau"].HeaderText = "Số tiền CK";
            dataHoaDonXuatHang.Columns["TongTien"].HeaderText = "Tổng sau CK";
            dataHoaDonXuatHang.Columns["TenNhanVien"].HeaderText = "Nhân viên";
            dataHoaDonXuatHang.Columns["GhiChu"].HeaderText = "Ghi chú";
            dataHoaDonXuatHang.Columns["TongChuaCK"].DefaultCellStyle.Format = "c0";
            dataHoaDonXuatHang.Columns["ChietKhau"].DefaultCellStyle.Format = "c0";
            dataHoaDonXuatHang.Columns["TongTien"].DefaultCellStyle.Format = "c0";
            dataHoaDonXuatHang.Columns["TongChuaCK"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
            dataHoaDonXuatHang.Columns["ChietKhau"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
            dataHoaDonXuatHang.Columns["TongTien"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
        }

        private DataGridViewRow selectedRow;
        private string maHoaDonDuocChon = "";
        
        private void dataHoaDonXuatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataHoaDonXuatHang.Rows[e.RowIndex];
                maHoaDonDuocChon = selectedRow.Cells["MaHoaDonXuatHang"].Value?.ToString();
            }
        }

        public void HienThiChiTietHoaDon(string maHoaDonDuocChon)
        {
            if (dataHoaDonXuatHang.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dataHoaDonXuatHang.CurrentRow;
                txtMaHD.Text = maHoaDonDuocChon;
                dateNgayXuat.Value = Convert.ToDateTime(selectedRow.Cells["NgayXuat"].Value);
                cmbBoxKH.Text = string.Empty;
                cmbBoxNhanVien.Text = string.Empty;
                cmbBoxNhanVien.SelectedText = selectedRow.Cells["TenNhanVien"].Value?.ToString();
                cmbBoxKH.SelectedText = selectedRow.Cells["TenKhachHang"].Value?.ToString();
                txtSDT.Text = selectedRow.Cells["Tel"].Value?.ToString();
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
                " DonGiaTruocCK," +
                " ChiTietHoaDonXuatHang.PhanTramCK," +
                " ChiTietHoaDonXuatHang.ChietKhau," +
                " DonGiaSauCK," +
                " ThanhTien," +
                " Kho.TenKho," +
                " ChiTietHoaDonXuatHang.GhiChu FROM ChiTietHoaDonXuatHang" +
                " Inner join HoaDonXuatHang on HoaDonXuatHang.MaHoaDonXuatHang = ChiTietHoaDonXuatHang.MaHoaDonXuatHang" +
                " Inner join HangHoa on HangHoa.MaHangHoa = ChiTietHoaDonXuatHang.MaHangHoa" +
                " Inner join DonViTinh on HangHoa.MaDVT = DonViTinh.MaDVT" +
                " Inner join Kho on Kho.MaKho = ChiTietHoaDonXuatHang.MaKho" +
                " where ChiTietHoaDonXuatHang.MaHoaDonXuatHang = @maHoaDonXuatHang";
            SqlCommand cmd = new SqlCommand(query1, KetNoiCSDL.GetConnection());
            cmd.Parameters.AddWithValue("@maHoaDonXuatHang", maHoaDonDuocChon);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataChiTietHoaDonXuatHang.DataSource = dt;
            if (dataChiTietHoaDonXuatHang.Columns["ID"] != null)
            {
                dataChiTietHoaDonXuatHang.Columns["ID"].Visible = false;
            }
            dataChiTietHoaDonXuatHang.Columns["TenHangHoa"].HeaderText = "Hàng hóa";
            dataChiTietHoaDonXuatHang.Columns["TenDVT"].HeaderText = "Đơn vị tính";
            dataChiTietHoaDonXuatHang.Columns["SoLuong"].HeaderText = "Số lượng";
            dataChiTietHoaDonXuatHang.Columns["DonGiaTruocCK"].HeaderText = "Đơn giá trước CK";
            dataChiTietHoaDonXuatHang.Columns["PhanTramCK"].HeaderText = "% chiết khấu";
            dataChiTietHoaDonXuatHang.Columns["ChietKhau"].HeaderText = "Số tiền CK";
            dataChiTietHoaDonXuatHang.Columns["DonGiaSauCK"].HeaderText = "Đơn giá sau CK";
            dataChiTietHoaDonXuatHang.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dataChiTietHoaDonXuatHang.Columns["TenKho"].HeaderText = "Kho xuất";
            dataChiTietHoaDonXuatHang.Columns["GhiChu"].HeaderText = "Ghi chú";
            dataChiTietHoaDonXuatHang.Columns["DonGiaTruocCK"].DefaultCellStyle.Format = "c0";
            dataChiTietHoaDonXuatHang.Columns["ChietKhau"].DefaultCellStyle.Format = "c0";
            dataChiTietHoaDonXuatHang.Columns["DonGiaSauCK"].DefaultCellStyle.Format = "c0";
            dataChiTietHoaDonXuatHang.Columns["ThanhTien"].DefaultCellStyle.Format = "c0";
            dataChiTietHoaDonXuatHang.Columns["DonGiaTruocCK"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
            dataChiTietHoaDonXuatHang.Columns["ChietKhau"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
            dataChiTietHoaDonXuatHang.Columns["DonGiaSauCK"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
            dataChiTietHoaDonXuatHang.Columns["ThanhTien"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabChiTietHoaDon && selectedRow != null)
            {
                if (!string.IsNullOrEmpty(maHoaDonDuocChon))
                {
                    HienThiChiTietHoaDon(maHoaDonDuocChon);
                }
            }
            if (tabControl1.SelectedTab == tabHoaDon)
            {
                HienThiHoaDon();
            }
        }

        private string IdDuocChon = "";
        private string tenHangHoaDuocChon = "";
        public string soLuongDuocChon = "";
        public string DGtruocCkDuocChon = "";
        public string phanTramCkDuocChon = "";

        private void dataChiTietHoaDonXuatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataChiTietHoaDonXuatHang.Rows[e.RowIndex];
                IdDuocChon = selectedRow.Cells["ID"].Value?.ToString();
                tenHangHoaDuocChon = selectedRow.Cells["TenHangHoa"].Value?.ToString();
                soLuongDuocChon = selectedRow.Cells["SoLuong"].Value?.ToString();
                DGtruocCkDuocChon = selectedRow.Cells["DonGiaTruocCK"].Value?.ToString();
                phanTramCkDuocChon = selectedRow.Cells["PhanTramCK"].Value?.ToString();

            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            InHoaDonXuatHang inHoaDonXuatHang = new InHoaDonXuatHang(maHoaDonDuocChon);
            inHoaDonXuatHang.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query3 = "DELETE FROM ChiTietHoaDonXuatHang where ID = @ID";
            SqlCommand cmd = new SqlCommand(query3, KetNoiCSDL.GetConnection());
            cmd.Parameters.AddWithValue("@ID", IdDuocChon);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            HienThiChiTietHoaDon(maHoaDonDuocChon);
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            string query2 = "DELETE FROM HoaDonXuatHang where MaHoaDonXuatHang = @maHoaDonXuatHang";
            SqlCommand cmd = new SqlCommand(query2, KetNoiCSDL.GetConnection());
            cmd.Parameters.AddWithValue("@maHoaDonXuatHang", maHoaDonDuocChon);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            HienThiHoaDon();
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbMaHoaDon.Checked)
            {
                TkTheoMaHoaDon();
            }
            if (cbNgay.Checked)
            {
                TkTheoNgay();
            }    
            if (cbKH.Checked)
            {
                TkTheoKH();
            }
            if (cbKH.Checked == false && cbMaHoaDon.Checked == false && cbNgay.Checked == false)
            {
                HienThiHoaDon();
            }
        }

        public void TkTheoMaHoaDon()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            string query4 = "SELECT NgayXuat," +
                " MaHoaDonXuatHang," +
                " KhachHang.TenKhachHang," +
                " KhachHang.Tel," +
                " KhachHang.DiaChi," +
                " TongChuaCK," +
                " PhanTramCK," +
                " ChietKhau," +
                " TongTien," +
                " NhanVien.TenNhanVien," +
                " GhiChu FROM HoaDonXuatHang" +
                " Inner join KhachHang on HoaDonXuatHang.MaKhachHang = KhachHang.MaKhachHang" +
                " Inner join NhanVien on HoaDonXuatHang.MaNhanVien = NhanVien.MaNhanVien" +
                " Where MaHoaDonXuatHang = @maHoaDon";
            SqlCommand cmd = new SqlCommand(query4, conn);
            cmd.Parameters.AddWithValue("@maHoaDon", txtTkMaHoaDon.Text);
            dataHoaDonXuatHang.DataSource = ketnoiCSDL.GetData1(cmd);
            dataHoaDonXuatHang.Columns["NgayXuat"].HeaderText = "Ngày xuất";
            dataHoaDonXuatHang.Columns["MaHoaDonXuatHang"].HeaderText = "Mã hóa đơn";
            dataHoaDonXuatHang.Columns["TenKhachHang"].HeaderText = "Khách hàng";
            dataHoaDonXuatHang.Columns["Tel"].HeaderText = "Số điện thoại";
            dataHoaDonXuatHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dataHoaDonXuatHang.Columns["TongChuaCK"].HeaderText = "Tổng chưa CK";
            dataHoaDonXuatHang.Columns["PhanTramCK"].HeaderText = "% chiết khấu";
            dataHoaDonXuatHang.Columns["ChietKhau"].HeaderText = "Số tiền CK";
            dataHoaDonXuatHang.Columns["TongTien"].HeaderText = "Tổng sau CK";
            dataHoaDonXuatHang.Columns["TenNhanVien"].HeaderText = "Nhân viên";
            dataHoaDonXuatHang.Columns["GhiChu"].HeaderText = "Ghi chú";
            conn.Close();
        }

        public void TkTheoNgay()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            string query4 = "SELECT NgayXuat," +
                " MaHoaDonXuatHang," +
                " KhachHang.TenKhachHang," +
                " KhachHang.Tel," +
                " KhachHang.DiaChi," +
                " TongChuaCK," +
                " PhanTramCK," +
                " ChietKhau," +
                " TongTien," +
                " NhanVien.TenNhanVien," +
                " GhiChu FROM HoaDonXuatHang" +
                " Inner join KhachHang on HoaDonXuatHang.MaKhachHang = KhachHang.MaKhachHang" +
                " Inner join NhanVien on HoaDonXuatHang.MaNhanVien = NhanVien.MaNhanVien" +
                " Where NgayXuat between @NgayBatDau and @NgayKetThuc";
            SqlCommand cmd = new SqlCommand(query4, conn);
            cmd.Parameters.AddWithValue("@NgayBatDau", dateNgayBD.Value.Date);
            cmd.Parameters.AddWithValue("@NgayKetThuc", dateNgayKT.Value.Date);
            dataHoaDonXuatHang.DataSource = ketnoiCSDL.GetData1(cmd);
            dataHoaDonXuatHang.Columns["NgayXuat"].HeaderText = "Ngày xuất";
            dataHoaDonXuatHang.Columns["MaHoaDonXuatHang"].HeaderText = "Mã hóa đơn";
            dataHoaDonXuatHang.Columns["TenKhachHang"].HeaderText = "Khách hàng";
            dataHoaDonXuatHang.Columns["Tel"].HeaderText = "Số điện thoại";
            dataHoaDonXuatHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dataHoaDonXuatHang.Columns["TongChuaCK"].HeaderText = "Tổng chưa CK";
            dataHoaDonXuatHang.Columns["PhanTramCK"].HeaderText = "% chiết khấu";
            dataHoaDonXuatHang.Columns["ChietKhau"].HeaderText = "Số tiền CK";
            dataHoaDonXuatHang.Columns["TongTien"].HeaderText = "Tổng sau CK";
            dataHoaDonXuatHang.Columns["TenNhanVien"].HeaderText = "Nhân viên";
            dataHoaDonXuatHang.Columns["GhiChu"].HeaderText = "Ghi chú";
            conn.Close();
        }

        public void TkTheoKH()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            string query4 = "SELECT NgayXuat," +
                " MaHoaDonXuatHang," +
                " KhachHang.TenKhachHang," +
                " KhachHang.Tel," +
                " KhachHang.DiaChi," +
                " TongChuaCK," +
                " PhanTramCK," +
                " ChietKhau," +
                " TongTien," +
                " NhanVien.TenNhanVien," +
                " GhiChu FROM HoaDonXuatHang" +
                " Inner join KhachHang on HoaDonXuatHang.MaKhachHang = KhachHang.MaKhachHang" +
                " Inner join NhanVien on HoaDonXuatHang.MaNhanVien = NhanVien.MaNhanVien" +
                " Where KhachHang.MaKhachHang = @maKH";
            SqlCommand cmd = new SqlCommand(query4, conn);
            cmd.Parameters.AddWithValue("@maKH", cmbBoxKH.SelectedValue);
            dataHoaDonXuatHang.DataSource = ketnoiCSDL.GetData1(cmd);
            dataHoaDonXuatHang.Columns["NgayXuat"].HeaderText = "Ngày xuất";
            dataHoaDonXuatHang.Columns["MaHoaDonXuatHang"].HeaderText = "Mã hóa đơn";
            dataHoaDonXuatHang.Columns["TenKhachHang"].HeaderText = "Khách hàng";
            dataHoaDonXuatHang.Columns["Tel"].HeaderText = "Số điện thoại";
            dataHoaDonXuatHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dataHoaDonXuatHang.Columns["TongChuaCK"].HeaderText = "Tổng chưa CK";
            dataHoaDonXuatHang.Columns["PhanTramCK"].HeaderText = "% chiết khấu";
            dataHoaDonXuatHang.Columns["ChietKhau"].HeaderText = "Số tiền CK";
            dataHoaDonXuatHang.Columns["TongTien"].HeaderText = "Tổng sau CK";
            dataHoaDonXuatHang.Columns["TenNhanVien"].HeaderText = "Nhân viên";
            dataHoaDonXuatHang.Columns["GhiChu"].HeaderText = "Ghi chú";
            conn.Close();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            int index = cmbBoxKH.FindStringExact(cmbBoxKH.Text);
            cmbBoxKH.SelectedIndex = index;
            string maKH = cmbBoxKH.SelectedValue?.ToString();
            int index1 = cmbBoxNhanVien.FindStringExact(cmbBoxNhanVien.Text);
            cmbBoxNhanVien.SelectedIndex = index1;
            string maNV = cmbBoxNhanVien.SelectedValue?.ToString();
            string insertQuery = "UPDATE HoaDonXuatHang SET " +
                    "NgayXuat = @NgayXuat," +
                    "MaKhachHang = @MaKhachHang," +
                    "MaNhanVien = @MaNhanVien," +
                    "GhiChu = @GhiChu " +
                    "Where MaHoaDonXuatHang = @MaHoaDonXuatHang";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@MaHoaDonXuatHang", maHoaDonDuocChon);
            cmd.Parameters.AddWithValue("@NgayXuat", dateNgayXuat.Value.Date);
            cmd.Parameters.AddWithValue("@MaKhachHang", maKH);
            cmd.Parameters.AddWithValue("@MaNhanVien", maNV);           
            cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa hóa đơn xuất hàng thành công.", "Thông báo", MessageBoxButtons.OK);
            conn.Close();
        }
    }
}
