using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuNhap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
namespace BanhKeo_Doan.FormVaChucNangNghiepVu
{
    public partial class FormPhieuNhap : Form
    {
        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        
        
        private string maPhieuNhap = "";
        
        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
           
            ThemHangHoa themHangHoa = new ThemHangHoa(maPhieuNhap);
            themHangHoa.DaThemHangHoa += (s, args) =>
            {
                LoadChiTietPhieuNhap(maPhieuNhap);
                LoadPhieuNhap();
            };
            themHangHoa.Show();
        }
        
        private void btnSuaHangHoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuNhap.CurrentRow != null)
            {

                string idDuocChon = dgvChiTietPhieuNhap.CurrentRow.Cells["ID"].Value.ToString();

               
                SuaHangHoa suaHangHoa = new SuaHangHoa(idDuocChon, maPhieuNhap);

                suaHangHoa.DaSuaHangHoa += (s, args) =>
                {
                    LoadChiTietPhieuNhap(maPhieuNhap);
                    LoadPhieuNhap();
                };
                suaHangHoa.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            ThemPhieuNhap form = new ThemPhieuNhap();
            form.DaThemPhieuNhap += (s, args) => LoadPhieuNhap(); 
            form.Show();
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet40.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet40.NhaCungCap);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet6.NhaCungCap' table. You can move, or remove it, as needed.
            LoadPhieuNhap();
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;

        }
        private void LoadPhieuNhap()
        {
            try
            {
                using (SqlConnection conn = KetNoiCSDL.GetConnection())
                {
                    conn.Open();


                    string updateTongTienQuery = @"
                     UPDATE PhieuNhap
                     SET TongTien = (
                         SELECT SUM(ThanhTien)
                         FROM ChiTietPhieuNhap
                         WHERE ChiTietPhieuNhap.MaPhieuNhap = PhieuNhap.MaPhieuNhap
                     )";
                    using (SqlCommand cmdUpdate = new SqlCommand(updateTongTienQuery, conn))
                    {
                        cmdUpdate.ExecuteNonQuery();
                    }


                    string selectQuery = @"
                             SELECT 
                                 pn.MaPhieuNhap AS [Mã phiếu nhập],
                                 pn.NgayNhap AS [Ngày nhập],
                                 pn.LoaiNhap AS [Loại nhập],
                                 ncc.TenNhaCungCap AS [Nhà cung cấp],
                                 pn.TongTien AS [Tổng tiền],
                                 nv.TenNhanVien AS [Nhân viên nhận],
                                 pn.GhiChu AS [Ghi chú]
                             FROM PhieuNhap pn
                             JOIN NhaCungCap ncc ON pn.MaNhaCungCap = ncc.MaNhaCungCap
                             JOIN NhanVien nv ON pn.MaNhanVien = nv.MaNhanVien";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvPhieuNhap.DataSource = dt;
                        dgvPhieuNhap.Columns["Tổng tiền"].DefaultCellStyle.Format = "N0";
                        dgvPhieuNhap.Columns["Ngày nhập"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải phiếu nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

           
           
            if (ckbTheoSoPhieu.Checked && string.IsNullOrWhiteSpace(txtSoPhieu.Text))
            {
                MessageBox.Show("Vui lòng nhập số phiếu cần tìm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
                    SELECT 
                         pn.MaPhieuNhap AS [Mã phiếu nhập],
                    pn.NgayNhap AS [Ngày nhập],
                    pn.LoaiNhap AS [Loại nhập],
                    ncc.TenNhaCungCap AS [Nhà cung cấp],
                    pn.TongTien AS [Tổng tiền],
                    nv.TenNhanVien AS [Nhân viên nhận],
                    pn.GhiChu AS [Ghi chú]
                     FROM PhieuNhap pn
                        JOIN NhaCungCap ncc ON pn.MaNhaCungCap = ncc.MaNhaCungCap
                        JOIN NhanVien nv ON pn.MaNhanVien = nv.MaNhanVien
                    WHERE 1=1";

            List<SqlParameter> parameters = new List<SqlParameter>();

            
            if (ckbTheoSoPhieu.Checked)
            {
                query += " AND pn.MaPhieuNhap LIKE @maPhieu";
                parameters.Add(new SqlParameter("@maPhieu", "%" + txtSoPhieu.Text.Trim() + "%"));
            }

           
            if (ckbTheoNgay.Checked)
            {
                DateTime tuNgay = dtmTuNgay.Value.Date;
                DateTime denNgay = dtmDenNgay.Value.Date.AddDays(1).AddTicks(-1);
                query += " AND pn.NgayNhap BETWEEN @tuNgay AND @denNgay";
                parameters.Add(new SqlParameter("@tuNgay", tuNgay));
                parameters.Add(new SqlParameter("@denNgay", denNgay));
            }

            
            if (ckbNCC.Checked && cmbNCC.SelectedValue != null)
            {
                query += " AND pn.MaNhaCungCap = @maNCC";
                parameters.Add(new SqlParameter("@maNCC", cmbNCC.SelectedValue));
            }

           
            if (ckbLoaiNhap.Checked && cmbLoaiNhap.SelectedItem != null)
            {
                query += " AND pn.LoaiNhap = @loaiNhap";
                parameters.Add(new SqlParameter("@loaiNhap", cmbLoaiNhap.SelectedItem));
            }

          
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters.ToArray());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvPhieuNhap.DataSource = dt;
            }
        }
        private void LoadChiTietPhieuNhap(string maPhieuNhap)
        {
            string query = @"
                SELECT 
                    ctpn.ID AS [ID],
                    hh.TenHangHoa AS [Tên hàng],
                    dvt.TenDVT AS[Đơn vị tính],
                    ctpn.SoLuongNhap AS [Số lượng nhập],
                    ctpn.DonGiaChuaCK AS [Đơn giá trước CK],
                    ctpn.PhanTramCK AS [% CK],
                    ctpn.ChietKhau AS [Chiết khấu],
                    ctpn.DonGiaSauCK AS [Đơn giá sau CK],
                    ctpn.ThanhTien AS [Thành tiền],
                    k.TenKho AS [Tên kho],
                    ctpn.GhiChu AS [Ghi chú]
                FROM ChiTietPhieuNhap ctpn
                JOIN HangHoa hh ON ctpn.MaHangHoa = hh.MaHangHoa
                JOIN Kho k ON ctpn.MaKho = k.MaKho
                JOIN DonViTinh dvt ON hh.MaDVT = dvt.MaDVT
                WHERE MaPhieuNhap = @MaPhieuNhap";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvChiTietPhieuNhap.DataSource = dt;
                dgvChiTietPhieuNhap.Columns["Số lượng nhập"].DefaultCellStyle.Format = "N2";
                dgvChiTietPhieuNhap.Columns["Đơn giá trước CK"].DefaultCellStyle.Format = "N0";
                dgvChiTietPhieuNhap.Columns["Đơn giá sau CK"].DefaultCellStyle.Format = "N0";
                dgvChiTietPhieuNhap.Columns["Thành tiền"].DefaultCellStyle.Format = "N0";
                dgvChiTietPhieuNhap.Columns["Chiết khấu"].DefaultCellStyle.Format = "N0";
            }
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];

                maPhieuNhap = row.Cells["Mã phiếu nhập"].Value?.ToString();

                txtSoPN.Text = maPhieuNhap;
                dtmNgay.Value = Convert.ToDateTime(row.Cells["Ngày nhập"].Value);
                txtLoaiNhap.Text = row.Cells["Loại nhập"].Value?.ToString();
                txtNCC.Text = row.Cells["Nhà cung cấp"].Value?.ToString();
                txtTongTien.Text = row.Cells["Tổng tiền"].Value?.ToString();
                txtNVNhan.Text = row.Cells["Nhân viên nhận"].Value?.ToString();
                txtGhiChu.Text = row.Cells["Ghi chú"].Value?.ToString();

                LoadChiTietPhieuNhap(maPhieuNhap);

                tabControl1.SelectedTab = tabPage2;
            }
        }
       

        private void dgvChiTietPhieuNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                DataGridViewRow row = dgvChiTietPhieuNhap.Rows[e.RowIndex];

               
                string idDuocChon = row.Cells["ID"].Value.ToString();


                
                SuaHangHoa suaHangHoa = new SuaHangHoa(idDuocChon, maPhieuNhap);


                suaHangHoa.DaSuaHangHoa += (s, args) =>
                {
                    LoadChiTietPhieuNhap(maPhieuNhap); 
                };

                suaHangHoa.Show();
            }
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maPhieuNhap))
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phiếu nhập này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = KetNoiCSDL.GetConnection())
                    {
                        conn.Open();

                   
                        SqlCommand cmdChiTiet = new SqlCommand("DELETE FROM ChiTietPhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap", conn);
                        cmdChiTiet.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
                        cmdChiTiet.ExecuteNonQuery();

                        SqlCommand cmdPhieu = new SqlCommand("DELETE FROM PhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap", conn);
                        cmdPhieu.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
                        cmdPhieu.ExecuteNonQuery();
                    }

                    MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPhieuNhap();
                    dgvChiTietPhieuNhap.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phiếu nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dgvChiTietPhieuNhap.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hàng hóa cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string idDuocChon = dgvChiTietPhieuNhap.CurrentRow.Cells["ID"].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = KetNoiCSDL.GetConnection())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM ChiTietPhieuNhap WHERE ID = @ID", conn);
                        cmd.Parameters.AddWithValue("@ID", idDuocChon);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChiTietPhieuNhap(maPhieuNhap);
                    LoadPhieuNhap();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            InPhieuNhap inPhieuNhap = new InPhieuNhap(maPhieuNhap);
            inPhieuNhap.Show();
        }
    }
}
