using BanhKeo_Doan.BaoCaoThongKe;
using BanhKeo_Doan.BaoCaoThongKe.DoanhSoBanHang;
using BanhKeo_Doan.BaoCaoThongKe.LoiNhuanTheoDonHang;
using BanhKeo_Doan.BaoCaoThongKe.XuatNhapTon;
using BanhKeo_Doan.Chuc_nang_nguoi_dung;
using BanhKeo_Doan.FormNghiepVu;
using BanhKeo_Doan.FormVaChucNangNghiepVu;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHangHoaTrongKho;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHangTon;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHoaDonXuatHang;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuChiTraNCC;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuThuTienKH;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatChuyen;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatRaSX;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangSoChi;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangSoThu;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanhKeo_Doan
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public RibbonForm1()
        {
            InitializeComponent();
            
        }
        private KetNoiCSDL ketnoiCSDL = new KetNoiCSDL();

        
        private void LoadUserControl(UserControl uc)
        {
            pnlContent.Controls.Clear(); 
            uc.Dock = DockStyle.Fill; 
            pnlContent.Controls.Add(uc); 
        }

        private void btnNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUserControl(new FormNCC());
            ThemCheckBox(dataDanhMuc);
            string query = "SELECT * FROM NhaCungCap";
            dataDanhMuc.DataSource = ketnoiCSDL.GetData(query);
            dataDanhMuc.Columns["MaNhaCungCap"].HeaderText = "Mã NCC";
            dataDanhMuc.Columns["TenNhaCungCap"].HeaderText = "Tên nhà cung cấp";
            dataDanhMuc.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dataDanhMuc.Columns["Tel"].HeaderText = "Số điện thoại";
            dataDanhMuc.Columns["MaSoThue"].HeaderText = "Mã số thuế";
            dataDanhMuc.Columns["SoTaiKhoan"].HeaderText = "Số tài khoản";
            dataDanhMuc.Columns["TenNganHang"].HeaderText = "Tên ngân hàng";
            dataDanhMuc.Columns["DiaChiNganHang"].HeaderText = "Địa chỉ ngân hàng";
            dataDanhMuc.Columns["NoCu"].HeaderText = "Nợ cũ";
        }

        private void BtnNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUserControl(new FormNguoiDung());
            ThemCheckBox(dataDanhMuc);
            string query = "SELECT * FROM NguoiDung";
            dataDanhMuc.DataSource = ketnoiCSDL.GetData(query);
            dataDanhMuc.Columns["MaNguoiDung"].HeaderText = "Mã người dùng";
            dataDanhMuc.Columns["TenNguoiDung"].HeaderText = "Tên người dùng";
            dataDanhMuc.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dataDanhMuc.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dataDanhMuc.Columns["ChucVu"].HeaderText = "Chức vụ";
        }

        private void BtnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUserControl(new FormKhachHang());
            ThemCheckBox(dataDanhMuc);
            string query = "SELECT * FROM KhachHang";
            dataDanhMuc.DataSource = ketnoiCSDL.GetData(query);
            dataDanhMuc.Columns["MaKhachHang"].HeaderText = "Mã khách hàng";
            dataDanhMuc.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
            dataDanhMuc.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dataDanhMuc.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dataDanhMuc.Columns["Tel"].HeaderText = "Số điện thoại";
            dataDanhMuc.Columns["MaSoThue"].HeaderText = "Mã số thuế";
            dataDanhMuc.Columns["SoTaiKhoan"].HeaderText = "Số tài khoản";
            dataDanhMuc.Columns["TenNganHang"].HeaderText = "Tên ngân hàng";
            dataDanhMuc.Columns["DiaChiNganHang"].HeaderText = "Địa chỉ ngân hàng";
            dataDanhMuc.Columns["NoCu"].HeaderText = "Nợ cũ";
        }

        private void BtnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUserControl(new FormNhanVien());
            ThemCheckBox(dataDanhMuc);
            string query = "SELECT * FROM NhanVien";
            dataDanhMuc.DataSource = ketnoiCSDL.GetData(query);
            dataDanhMuc.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dataDanhMuc.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dataDanhMuc.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dataDanhMuc.Columns["Tel"].HeaderText = "Số điện thoại";
            dataDanhMuc.Columns["GioiTinh"].HeaderText = "Giới tính";
            dataDanhMuc.Columns["SoCMND"].HeaderText = "Số CMND";
            dataDanhMuc.Columns["LuongCoBan"].HeaderText = "Lương cơ bản";
            dataDanhMuc.Columns["PhuCap"].HeaderText = "Phụ cấp";
            dataDanhMuc.Columns["TienTrachNhiem"].HeaderText = "Tiền trách nhiệm";
        }

        private void BtnKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUserControl(new FormKho());
            ThemCheckBox(dataDanhMuc);
            string query = "SELECT * FROM Kho";
            dataDanhMuc.DataSource = ketnoiCSDL.GetData(query);
            dataDanhMuc.Columns["MaKho"].HeaderText = "Mã kho";
            dataDanhMuc.Columns["TenKho"].HeaderText = "Tên kho";        
        }

        private void BtnDVT_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUserControl(new FormDVT());
            ThemCheckBox(dataDanhMuc);
            string query = "SELECT * FROM DonViTinh";
            dataDanhMuc.DataSource = ketnoiCSDL.GetData(query);
            dataDanhMuc.Columns["MaDVT"].HeaderText = "Mã đơn vị tính";
            dataDanhMuc.Columns["TenDVT"].HeaderText = "Tên đơn vị tính";
        }

        private void BtnNganhHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUserControl(new FormNganhHang());
            ThemCheckBox(dataDanhMuc);
            string query = "SELECT * FROM NganhHang";
            dataDanhMuc.DataSource = ketnoiCSDL.GetData(query);
            dataDanhMuc.Columns["MaNganhHang"].HeaderText = "Mã ngành hàng";
            dataDanhMuc.Columns["TenNganhHang"].HeaderText = "Tên ngành hàng";
        }

        private void BtnLoaiHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUserControl(new FormLoaiHang());
            ThemCheckBox(dataDanhMuc);
            string query = "SELECT MaLoaiHang, TenLoaiHang, NganhHang.TenNganhHang FROM LoaiHang" +
                " Inner Join NganhHang on LoaiHang.MaNganhHang = NganhHang.MaNganhHang";
            dataDanhMuc.DataSource = ketnoiCSDL.GetData(query);
            dataDanhMuc.Columns["MaLoaiHang"].HeaderText = "Mã loại hàng";
            dataDanhMuc.Columns["TenLoaiHang"].HeaderText = "Tên loại hàng";
            dataDanhMuc.Columns["TenNganhHang"].HeaderText = "Tên ngành hàng";
        }

        private void BtnMatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUserControl(new FormHangHoa());
            ThemCheckBox(dataDanhMuc);
            string query = "SELECT MaHangHoa, TenHangHoa, LoaiHang.TenLoaiHang, DonViTinh.TenDVT FROM HangHoa" +
                " Inner join LoaiHang on HangHoa.MaLoaiHang = LoaiHang.MaLoaiHang" +
                " Inner join DonViTinh on HangHoa.MaDVT = DonViTinh.MaDVT";
            dataDanhMuc.DataSource = ketnoiCSDL.GetData(query);
            dataDanhMuc.Columns["MaHangHoa"].HeaderText = "Mã hàng hóa";
            dataDanhMuc.Columns["TenHangHoa"].HeaderText = "Tên hàng hóa";
            dataDanhMuc.Columns["TenLoaiHang"].HeaderText = "Tên loại hàng";
            dataDanhMuc.Columns["TenDVT"].HeaderText = "Tên đơn vị tính";
        }

        private void BtnBangGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUserControl(new FormBangGia());
            ThemCheckBox(dataDanhMuc);
            string query = "SELECT MaBangGia, NgayCapNhat, HangHoa.TenHangHoa, LoaiHang.TenLoaiHang, DonViTinh.TenDVT, GiaNhap, GiaBuon, GiaBanLe FROM BangGia" +
                " Inner join HangHoa on HangHoa.MaHangHoa = BangGia.MaHangHoa" +
                " Inner join LoaiHang on HangHoa.MaLoaiHang = LoaiHang.MaLoaiHang" +
                " Inner join DonViTinh on HangHoa.MaDVT = DonViTinh.MaDVT";
            dataDanhMuc.DataSource = ketnoiCSDL.GetData(query);
            dataDanhMuc.Columns["MaBangGia"].HeaderText = "Mã bảng giá";
            dataDanhMuc.Columns["NgayCapNhat"].HeaderText = "Ngày cập nhật";
            dataDanhMuc.Columns["TenHangHoa"].HeaderText = "Tên hàng hóa";
            dataDanhMuc.Columns["TenLoaiHang"].HeaderText = "Tên loại hàng";
            dataDanhMuc.Columns["TenDVT"].HeaderText = "Tên đơn vị tính";
            dataDanhMuc.Columns["GiaNhap"].HeaderText = "Giá nhập";
            dataDanhMuc.Columns["GiaBuon"].HeaderText = "Giá bán buôn";
            dataDanhMuc.Columns["GiaBanLe"].HeaderText = "Giá bán lẻ";
        }


        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            DoiMatKhau f2 = new DoiMatKhau();
            f2.Show();
        }

        private void btnKeHoachSX_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            FormKeHoachSanXuat keHoachSanXuat = new FormKeHoachSanXuat();
            keHoachSanXuat.Show();
        }

        

        private void btnThanhToanNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            FormPhieuChiTraNCC formPhieuChiTraNCC = new FormPhieuChiTraNCC();
            formPhieuChiTraNCC.Show();
        }

        private void btnThanhToanKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            FormPhieuThuTienKH formPhieuThuTienKH = new FormPhieuThuTienKH();
            formPhieuThuTienKH.Show();
        }

        private void btnHangTon_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            FormHangTon formHangTon = new FormHangTon();
            formHangTon.Show();
        }

        private void btnPhieuNhapKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            FormPhieuNhap formPhieuNhap = new FormPhieuNhap();
            formPhieuNhap.Show();
        }

        private void btnPhieuXuatChuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            FormPhieuXuatChuyen formPhieuXuatChuyen = new FormPhieuXuatChuyen();
            formPhieuXuatChuyen.Show();
        }

        private void btnPhieuXuatRaSX_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            FormPhieuXuatRaSX formPhieuXuatRaSX = new FormPhieuXuatRaSX();
            formPhieuXuatRaSX.Show();
        }

        private void btnHoaDonXuatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            FormHoaDonXuatHang formHoaDonXuatHang = new FormHoaDonXuatHang();
            formHoaDonXuatHang.Show();
        }

        private void btnDonHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            FormDonHang formDonHang = new FormDonHang();
            formDonHang.Show();
        }

        private void BtnLoaiThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUserControl(new FormLoaiThu());
            ThemCheckBox(dataDanhMuc);
            string query = "SELECT * FROM LoaiThu";
            dataDanhMuc.DataSource = ketnoiCSDL.GetData(query);
            dataDanhMuc.Columns["MaLoaiThu"].HeaderText = "Mã loại thu";
            dataDanhMuc.Columns["TenLoaiThu"].HeaderText = "Tên loại thu";
        }

        private void BtnLoaiChi_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUserControl(new FormLoaiChi());
            ThemCheckBox(dataDanhMuc);
            string query = "SELECT * FROM LoaiChi";
            dataDanhMuc.DataSource = ketnoiCSDL.GetData(query);
            dataDanhMuc.Columns["MaLoaiChi"].HeaderText = "Mã loại chi";
            dataDanhMuc.Columns["TenLoaiChi"].HeaderText = "Tên loại chi";
        }

        private void btnSoThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormSoThu formSoThu = new FormSoThu();
            formSoThu.Show();
        }

        private void btnSoChi_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormSoChi formSoChi = new FormSoChi();
            formSoChi.Show();
        }

        public static void ThemCheckBox(DataGridView dataGridView)
        {
            if (!dataGridView.Columns.Contains("Chon"))
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Chọn";
                checkBoxColumn.Name = "Chon";
                dataGridView.Columns.Add(checkBoxColumn);
                dataGridView.AllowUserToAddRows = false;
            }
            
        }
        public string maNccDuocChon = "";
        public string maKhDuocChon = "";


        private void dataDanhMuc_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataDanhMuc.IsCurrentCellDirty)
            {
                dataDanhMuc.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnDoanhSoBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            BaoCaoDoanhSoBanHang baoCaoDoanhSoBanHang = new BaoCaoDoanhSoBanHang();
            baoCaoDoanhSoBanHang.Show();
        }

        private void btnLoiNhuanTheoDH_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoiNhuanTheoDonHang loiNhuanTheoDonHang = new LoiNhuanTheoDonHang();
            loiNhuanTheoDonHang.Show();
        }

        private void btnHangDoiTra_ItemClick(object sender, ItemClickEventArgs e)
        {
            HangDoiTra hangDoiTra = new HangDoiTra();
            hangDoiTra.Show();
        }

        private void btnHangHoaTrongKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormHangHoaTrongKho formHangHoaTrongKho = new FormHangHoaTrongKho();
            formHangHoaTrongKho.Show();
        }

        private void btnXuatNhapTon_ItemClick(object sender, ItemClickEventArgs e)
        {
            XuatNhapTon xuatNhapTon = new XuatNhapTon();
            xuatNhapTon.Show();
        }
    }
}

