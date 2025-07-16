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

namespace BanhKeo_Doan.FormVaChucNangNghiepVu
{
    public partial class FormDonHang : Form
    {
        public FormDonHang()
        {
            InitializeComponent();
        }

        private KetNoiCSDL ketnoiCSDL = new KetNoiCSDL();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            ThemHangHoa themHangHoa = new ThemHangHoa(maDonHangDuocChon);
            themHangHoa.DaThemHangHoa += (s, args) =>
            {
                HienThiChiTietDonHang(maDonHangDuocChon);
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
                HienThiChiTietDonHang(maDonHangDuocChon);
            };
            suaHangHoa.Show();
        }

        private void btnThemDonHang_Click(object sender, EventArgs e)
        {
            ThemDonHang themDonHang = new ThemDonHang();
            themDonHang.DaThemDonHang += (s, args) =>
            {
                HienThiDonHang();
            };
            themDonHang.Show();
        }


        private void FormDonHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet48.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet48.NhanVien);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet47.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet47.KhachHang);
            HienThiDonHang();
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void HienThiDonHang()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            string tinhTongTienQuery = @"
                UPDATE DonHang
                SET TongTien = (
                SELECT SUM(ThanhTien)
                FROM ChiTietDonHang
                WHERE ChiTietDonHang.MaDonHang = DonHang.MaDonHang)";
            SqlCommand cmd = new SqlCommand(tinhTongTienQuery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            string query = "SELECT NgayLap," +
                " MaDonHang," +
                " LaDonDatTruoc," +
                " NgayGiao," +
                " KhachHang.TenKhachHang," +
                " KhachHang.Tel," +
                " KhachHang.DiaChi," +
                " TongTien," +
                " NhanVien.TenNhanVien," +
                " GhiChu FROM DonHang" +
                " Inner join KhachHang on DonHang.MaKhachHang = KhachHang.MaKhachHang" +
                " Inner join NhanVien on DonHang.MaNhanVien = NhanVien.MaNhanVien" +
                " Order by NgayLap DESC";
            dataDonHang.DataSource = ketnoiCSDL.GetData(query);
            dataDonHang.Columns["NgayLap"].HeaderText = "Ngày lập";
            dataDonHang.Columns["MaDonHang"].HeaderText = "Mã đơn hàng";
            dataDonHang.Columns["LaDonDatTruoc"].HeaderText = "Là đơn đặt trước";
            dataDonHang.Columns["NgayGiao"].HeaderText = "Ngày giao";
            dataDonHang.Columns["TenKhachHang"].HeaderText = "Khách hàng";
            dataDonHang.Columns["Tel"].HeaderText = "Số điện thoại";
            dataDonHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dataDonHang.Columns["TongTien"].HeaderText = "Tổng tiền";
            dataDonHang.Columns["TenNhanVien"].HeaderText = "Nhân viên";
            dataDonHang.Columns["GhiChu"].HeaderText = "Ghi chú";
            dataDonHang.Columns["TongTien"].DefaultCellStyle.Format = "N0";
        }
        public void HienThiChiTietDonHang(string maDonHang)
        {
            if(dataDonHang.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dataDonHang.CurrentRow;
                txtMaDonHang.Text = maDonHangDuocChon;
                datetimeNgayLap.Value = Convert.ToDateTime(selectedRow.Cells["NgayLap"].Value);
                object ngayGiaoValue = selectedRow.Cells["NgayGiao"].Value;
                if (ngayGiaoValue != DBNull.Value && ngayGiaoValue != null && !string.IsNullOrWhiteSpace(ngayGiaoValue.ToString()))
                {
                    dateNgayGiao.Value = Convert.ToDateTime(ngayGiaoValue);
                    dateNgayGiao.Enabled = true;
                }
                else
                {
                    dateNgayGiao.Enabled = false;
                }
                cmbBoxKH.Text = string.Empty;
                cmbBoxNhanVien.Text = string.Empty;
                cmbBoxNhanVien.SelectedText = selectedRow.Cells["TenNhanVien"].Value?.ToString();
                cmbBoxKH.SelectedText = selectedRow.Cells["TenKhachHang"].Value?.ToString();
                txtTel.Text = selectedRow.Cells["Tel"].Value?.ToString();
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
                        " PhanTramCK," +
                        " SoTienChietKhau," +
                        " DonGiaSauCK," +
                        " ThanhTien," +
                        " Kho.TenKho," +
                        " ChiTietDonHang.GhiChu FROM ChiTietDonHang" +
                        " Inner join DonHang on DonHang.MaDonHang = ChiTietDonHang.MaDonHang" +
                        " Inner join HangHoa on HangHoa.MaHangHoa = ChiTietDonHang.MaHangHoa" +
                        " Inner join DonViTinh on HangHoa.MaDVT = DonViTinh.MaDVT" +
                        " Inner join Kho on ChiTietDonHang.MaKho = Kho.MaKho" +
                        " where ChiTietDonHang.MaDonHang = @maDonHang";
                    SqlCommand cmd = new SqlCommand(query1, KetNoiCSDL.GetConnection());
                    cmd.Parameters.AddWithValue("@maDonHang", maDonHangDuocChon);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataChiTietDonHang.DataSource = dt;
                    if (dataChiTietDonHang.Columns["ID"] != null)
                    {
                        dataChiTietDonHang.Columns["ID"].Visible = false;
                    }
                    dataChiTietDonHang.Columns["TenHangHoa"].HeaderText = "Hàng hóa";
                    dataChiTietDonHang.Columns["TenDVT"].HeaderText = "Đơn vị tính";
                    dataChiTietDonHang.Columns["SoLuong"].HeaderText = "Số lượng";
                    dataChiTietDonHang.Columns["DonGiaTruocCK"].HeaderText = "Đơn giá trước CK";
                    dataChiTietDonHang.Columns["PhanTramCK"].HeaderText = "% CK";
                    dataChiTietDonHang.Columns["SoTienChietKhau"].HeaderText = "Số tiền CK";
                    dataChiTietDonHang.Columns["DonGiaSauCK"].HeaderText = "Đơn giá sau CK";
                    dataChiTietDonHang.Columns["ThanhTien"].HeaderText = "Thành tiền";
                    dataChiTietDonHang.Columns["TenKho"].HeaderText = "Kho";
                    dataChiTietDonHang.Columns["GhiChu"].HeaderText = "Ghi chú";
                    dataChiTietDonHang.Columns["DonGiaTruocCK"].DefaultCellStyle.Format = "N0";
                    dataChiTietDonHang.Columns["SoTienChietKhau"].DefaultCellStyle.Format = "N0";
                    dataChiTietDonHang.Columns["DonGiaSauCK"].DefaultCellStyle.Format = "N0";
                    dataChiTietDonHang.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";                   
        }

        private void tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabcontrol.SelectedTab == tabChiTietDonHang && !string.IsNullOrEmpty(maDonHangDuocChon))
            {
                HienThiChiTietDonHang(maDonHangDuocChon);
            }
            if (tabcontrol.SelectedTab == tabDonHang)
            {
                HienThiDonHang();
            }
        }    

        private void btnXoaDonHang_Click(object sender, EventArgs e)
        {
            string query2 = "DELETE FROM DonHang where MaDonHang = @maDonHang";
            SqlCommand cmd = new SqlCommand(query2, KetNoiCSDL.GetConnection());
            cmd.Parameters.AddWithValue("@maDonHang", maDonHangDuocChon);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            HienThiDonHang();
        }

       
        private void dataChiTietDonHang_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataChiTietDonHang.IsCurrentCellDirty)
            {
                dataChiTietDonHang.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnXoaHangHoa_Click(object sender, EventArgs e)
        {
            string query3 = "DELETE FROM ChiTietDonHang where ID = @ID";
            SqlCommand cmd = new SqlCommand(query3, KetNoiCSDL.GetConnection());
            cmd.Parameters.AddWithValue("@ID", IdDuocChon);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            HienThiChiTietDonHang(maDonHangDuocChon);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            InBaoGiaDonHang inBaoGiaDonHang = new InBaoGiaDonHang(maDonHangDuocChon);
            inBaoGiaDonHang.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbMaDonHang.Checked)
            {
                TkTheoMaDonHang();
            }
            if (cbNgay.Checked)
            {
                TkTheoNgay();
            }
            if (cbKH.Checked)
            {
                TkTheoKH();
            }
            if (cbKH.Checked == false && cbMaDonHang.Checked == false && cbNgay.Checked == false)
            {
                HienThiDonHang();
            }    
        }

        public void TkTheoMaDonHang()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            string query4 = "SELECT NgayLap," +
                " MaDonHang," +
                " KhachHang.TenKhachHang," +
                " KhachHang.Tel," +
                " KhachHang.DiaChi," +
                " TongTien," +
                " NhanVien.TenNhanVien," +
                " GhiChu FROM DonHang" +
                " Inner join KhachHang on DonHang.MaKhachHang = KhachHang.MaKhachHang" +
                " Inner join NhanVien on DonHang.MaNhanVien = NhanVien.MaNhanVien" +
                " Where MaDonHang = @maDonHang";
            SqlCommand cmd = new SqlCommand(query4, conn);
            cmd.Parameters.AddWithValue("@maDonHang", txtTkMaDonHang.Text);
            dataDonHang.DataSource = ketnoiCSDL.GetData1(cmd);
            dataDonHang.Columns["NgayLap"].HeaderText = "Ngày lập";
            dataDonHang.Columns["MaDonHang"].HeaderText = "Mã đơn hàng";
            dataDonHang.Columns["TenKhachHang"].HeaderText = "Khách hàng";
            dataDonHang.Columns["Tel"].HeaderText = "Số điện thoại";
            dataDonHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dataDonHang.Columns["TongTien"].HeaderText = "Tổng tiền";
            dataDonHang.Columns["TenNhanVien"].HeaderText = "Nhân viên";
            dataDonHang.Columns["GhiChu"].HeaderText = "Ghi chú";
            conn.Close();
        }

        public void TkTheoNgay()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            string query4 = "SELECT NgayLap," +
                " MaDonHang," +
                " KhachHang.TenKhachHang," +
                " KhachHang.Tel," +
                " KhachHang.DiaChi," +
                " TongTien," +
                " NhanVien.TenNhanVien," +
                " GhiChu FROM DonHang" +
                " Inner join KhachHang on DonHang.MaKhachHang = KhachHang.MaKhachHang" +
                " Inner join NhanVien on DonHang.MaNhanVien = NhanVien.MaNhanVien" +
                " Where NgayLap between @NgayBatDau and @NgayKetThuc";
            SqlCommand cmd = new SqlCommand(query4, conn);
            cmd.Parameters.AddWithValue("@NgayBatDau", dateNgayBD.Value.Date);
            cmd.Parameters.AddWithValue("@NgayKetThuc", dateNgayKT.Value.Date);
            dataDonHang.DataSource = ketnoiCSDL.GetData1(cmd);
            dataDonHang.Columns["NgayLap"].HeaderText = "Ngày lập";
            dataDonHang.Columns["MaDonHang"].HeaderText = "Mã đơn hàng";
            dataDonHang.Columns["TenKhachHang"].HeaderText = "Khách hàng";
            dataDonHang.Columns["Tel"].HeaderText = "Số điện thoại";
            dataDonHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dataDonHang.Columns["TongTien"].HeaderText = "Tổng tiền";
            dataDonHang.Columns["TenNhanVien"].HeaderText = "Nhân viên";
            dataDonHang.Columns["GhiChu"].HeaderText = "Ghi chú";
            conn.Close();
        }

        public void TkTheoKH()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            string query4 = "SELECT NgayLap," +
                " MaDonHang," +
                " KhachHang.TenKhachHang," +
                " KhachHang.Tel," +
                " KhachHang.DiaChi," +
                " TongTien," +
                " NhanVien.TenNhanVien," +
                " GhiChu FROM DonHang" +
                " Inner join KhachHang on DonHang.MaKhachHang = KhachHang.MaKhachHang" +
                " Inner join NhanVien on DonHang.MaNhanVien = NhanVien.MaNhanVien" +
                " Where KhachHang.MaKhachHang = @maKH";
            SqlCommand cmd = new SqlCommand(query4, conn);
            cmd.Parameters.AddWithValue("@maKH", cmbBoxTkKH.SelectedValue);
            dataDonHang.DataSource = ketnoiCSDL.GetData1(cmd);
            dataDonHang.Columns["NgayLap"].HeaderText = "Ngày lập";
            dataDonHang.Columns["MaDonHang"].HeaderText = "Mã đơn hàng";
            dataDonHang.Columns["TenKhachHang"].HeaderText = "Khách hàng";
            dataDonHang.Columns["Tel"].HeaderText = "Số điện thoại";
            dataDonHang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dataDonHang.Columns["TongTien"].HeaderText = "Tổng tiền";
            dataDonHang.Columns["TenNhanVien"].HeaderText = "Nhân viên";
            dataDonHang.Columns["GhiChu"].HeaderText = "Ghi chú";
            conn.Close();
        }

        private DataGridViewRow selectedRow;
        public string maDonHangDuocChon = "";
        private void dataDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataDonHang.Rows[e.RowIndex];
                maDonHangDuocChon = selectedRow.Cells["MaDonHang"].Value?.ToString();
            }
        }
        public string IdDuocChon = "";
        public string tenHangHoaDuocChon = "";
        public string soLuongDuocChon = "";
        public string DGtruocCkDuocChon = "";
        public string phanTramCkDuocChon = "";
        private void dataChiTietDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataChiTietDonHang.Rows[e.RowIndex];
                IdDuocChon = selectedRow.Cells["ID"].Value?.ToString();
                tenHangHoaDuocChon = selectedRow.Cells["TenHangHoa"].Value?.ToString();
                soLuongDuocChon = selectedRow.Cells["SoLuong"].Value?.ToString();
                DGtruocCkDuocChon = selectedRow.Cells["DonGiaTruocCK"].Value?.ToString();
                phanTramCkDuocChon = selectedRow.Cells["PhanTramCK"].Value?.ToString();
            }
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
            string insertQuery = "UPDATE DonHang SET " +
                    "NgayLap = @NgayLap," +
                    "MaKhachHang = @MaKhachHang," +
                    "MaNhanVien = @MaNhanVien," +
                    "NgayGiao = @NgayGiao," +
                    "GhiChu = @GhiChu " +
                    "Where MaDonHang = @MaDonHang";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@MaDonHang", maDonHangDuocChon);
            cmd.Parameters.AddWithValue("@NgayLap", datetimeNgayLap.Value.Date);
            cmd.Parameters.AddWithValue("@MaKhachHang", maKH);
            cmd.Parameters.AddWithValue("@MaNhanVien", maNV);
            if (dateNgayGiao.Enabled)
            {
                cmd.Parameters.AddWithValue("@NgayGiao", dateNgayGiao.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@NgayGiao", DBNull.Value);
            }
            cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sửa kế hoạch sản xuất thành công.", "Thông báo", MessageBoxButtons.OK);
            conn.Close();
        }
    }
}
