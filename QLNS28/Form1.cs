using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLNS28
{
    public partial class Form1 : XtraMessageBoxForm
    {
        //---------------------------------------------------------
        //               HÀM KHỞI CHẠY
        //---------------------------------------------------------
        private TAIKHOAN matk;

        public Form1(TAIKHOAN _matk)
        {
            matk = _matk;
            InitializeComponent();
        }

        private QLNSDataContext db = new QLNSDataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            if (matk.MAQUYEN.Trim() == "0")
            {
                //Các chức năng bị tắt
                btnThemNhanVien.Enabled = false;
                btnXoaNhanVien.Enabled = false;
                btnSuaNhanVien.Enabled = false;
                btnSuaLuong.Enabled = false;
                btnPhongbanchinhsua.Enabled = false;
                Chinhsua.Visible = false;
                chamcong.Enabled = false;
            }
        }

        //---------------------------------------------------------
        //               ĐĂNG NHẬP VÀ ĐĂNG XUẤT
        //---------------------------------------------------------
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmDangnhap f = new fmDangnhap();
            f.Show();
            this.Close();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmDangnhap f = new fmDangnhap();
            f.Show();
            this.Close();
        }

        //---------------------------------------------------------
        //               PHẦN ĐIỀU HƯỚNG BÊN TRÁI
        //---------------------------------------------------------
        private void navPhongKinhDoanh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QLNSDataContext db = new QLNSDataContext();
            gridView1.Columns.Clear();
            gridmain.DataSource = from nv in db.NHANVIENs
                                  from cv in db.CHUCVUs
                                  from luong in db.LUONGs

                                  where nv.MAPB.CompareTo("KD") == 0
                                  && nv.MACV.CompareTo(cv.MACV.ToString()) == 0
                                  && nv.MALUONG.CompareTo(luong.MALUONG.ToString()) == 0
                                  select new
                                  {
                                      Mã_Nhân_Viên = nv.MANV,
                                      Tên_Nhân_Viên = nv.HOTEN,
                                      Ngày_Sinh = nv.NGAYSINH,
                                      Giới_Tính = nv.GIOITINH,
                                      Quê_Quán = nv.QUEQUAN,
                                      SĐT = nv.SDT,
                                      Phòng_Ban = "Phòng Kinh Doanh",
                                      Chức_Vụ = cv.TENCV,
                                      Mức_Lương = luong.TENLUONG
                                  };
        }

        private void navPhongNhanSu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QLNSDataContext db = new QLNSDataContext();
            gridView1.Columns.Clear();
            gridmain.DataSource = from nv in db.NHANVIENs
                                  from cv in db.CHUCVUs
                                  from luong in db.LUONGs

                                  where nv.MAPB.CompareTo("NS") == 0
                                  && nv.MACV.CompareTo(cv.MACV.ToString()) == 0
                                  && nv.MALUONG.CompareTo(luong.MALUONG.ToString()) == 0
                                  select new
                                  {
                                      Mã_Nhân_Viên = nv.MANV,
                                      Tên_Nhân_Viên = nv.HOTEN,
                                      Ngày_Sinh = nv.NGAYSINH,
                                      Giới_Tính = nv.GIOITINH,
                                      Quê_Quán = nv.QUEQUAN,
                                      SĐT = nv.SDT,
                                      Phòng_Ban = "Phòng Nhân Sự",
                                      Chức_Vụ = cv.TENCV,
                                      Mức_Lương = luong.TENLUONG
                                  };
        }

        private void navPhongKiThuat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QLNSDataContext db = new QLNSDataContext();
            gridView1.Columns.Clear();
            gridmain.DataSource = from nv in db.NHANVIENs
                                  from cv in db.CHUCVUs
                                  from luong in db.LUONGs
                                  where nv.MAPB.CompareTo("KTH") == 0
                                  && nv.MACV.CompareTo(cv.MACV.ToString()) == 0
                                  && nv.MALUONG.CompareTo(luong.MALUONG.ToString()) == 0
                                  select new
                                  {
                                      Mã_Nhân_Viên = nv.MANV,
                                      Tên_Nhân_Viên = nv.HOTEN,
                                      Ngày_Sinh = nv.NGAYSINH,
                                      Giới_Tính = nv.GIOITINH,
                                      Quê_Quán = nv.QUEQUAN,
                                      SĐT = nv.SDT,
                                      Phòng_Ban = "Phòng Kĩ Thuật",
                                      Chức_Vụ = cv.TENCV,
                                      Mức_Lương = luong.TENLUONG
                                  };
        }

        private void btnPhongKeToan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QLNSDataContext db = new QLNSDataContext();
            gridView1.Columns.Clear();
            gridmain.DataSource = from nv in db.NHANVIENs
                                  from cv in db.CHUCVUs
                                  from luong in db.LUONGs

                                  where nv.MAPB.CompareTo("KT") == 0
                                  && nv.MACV.CompareTo(cv.MACV.ToString()) == 0
                                  && nv.MALUONG.CompareTo(luong.MALUONG.ToString()) == 0
                                  select new
                                  {
                                      Mã_Nhân_Viên = nv.MANV,
                                      Tên_Nhân_Viên = nv.HOTEN,
                                      Ngày_Sinh = nv.NGAYSINH,
                                      Giới_Tính = nv.GIOITINH,
                                      Quê_Quán = nv.QUEQUAN,
                                      SĐT = nv.SDT,
                                      Phòng_Ban = "Phòng Kế Toán",
                                      Chức_Vụ = cv.TENCV,
                                      Mức_Lương = luong.TENLUONG
                                  };
        }

        //---------------------------------------------------------
        //               A. PHẦN THÔNG TIN NHÂN SỰ
        //---------------------------------------------------------

        //A1: Tất cả nhân viên
        private void btnXemNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.Columns.Clear();
            gridmain.DataSource = from nv in db.NHANVIENs
                                  from cv in db.CHUCVUs
                                  from luong in db.LUONGs
                                  from pb in db.PHONGBANs
                                  where nv.MAPB == pb.MAPB
                                  && nv.MACV == cv.MACV
                                  && nv.MALUONG == luong.MALUONG
                                  select new
                                  {
                                      Mã_Nhân_Viên = nv.MANV,
                                      Tên_Nhân_Viên = nv.HOTEN,
                                      Ngày_Sinh = nv.NGAYSINH,
                                      Giới_Tính = nv.GIOITINH,
                                      Quê_Quán = nv.QUEQUAN,
                                      SĐT = nv.SDT,
                                      Phòng_Ban = pb.TENPB,
                                      Chức_Vụ = cv.TENCV,
                                      Lương = luong.LUONGCB * luong.HSLUONG
                                  };
        }

        //A2: Tải lại nhân viên
        private void btnLamMoiNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnXemNhanVien_ItemClick(sender, e);
        }

        //A3: Thêm nhân viên
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Themnhanvien f = new Themnhanvien();
            f.ShowDialog();
            btnLamMoiNhanVien_ItemClick(sender, e);
        }

        //A4: Xóa nhân viên
        private void btnXoaNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ns = db.NHANVIENs.Where(a => a.MANV == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã_Nhân_Viên").ToString()).SingleOrDefault();

            DialogResult s = XtraMessageBox.Show("Xóa " + ns.HOTEN.Trim() + " không ?", "Xóa nhân viên", MessageBoxButtons.YesNo);
            if (s == DialogResult.Yes)
            {
                db.NHANVIENs.DeleteOnSubmit(ns);
                db.SubmitChanges();
                btnLamMoiNhanVien_ItemClick(sender, e);
            }
        }

        //A5: Sửa thông tin

        private void btnSuaNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manv = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã_Nhân_Viên").ToString().Trim();
            NHANVIEN ns = db.NHANVIENs.Where(a => a.MANV == manv).SingleOrDefault();

            if (ns != null)
            {
                NHANVIEN nv = ns as NHANVIEN;
                fmSuanhanvien f = new fmSuanhanvien(nv);
                //db.NHANVIENs.DeleteOnSubmit(ns);

                db.SubmitChanges();

                f.ShowDialog();
            }
            btnLamMoiNhanVien_ItemClick(sender, e);
            ns = null;
        }

        //A6: Tìm kiếm nhân viên
        private void btnTimKiemNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Timkiem f = new Timkiem();
            f.ShowDialog();
            if (f.Manv != null)
            {
                gridView1.Columns.Clear();
                gridmain.DataSource = from nv in db.NHANVIENs
                                      from cv in db.CHUCVUs
                                      from luong in db.LUONGs
                                      from pb in db.PHONGBANs
                                      where nv.MAPB == pb.MAPB
                                      && nv.MANV.Contains(f.Manv)
                                      && nv.MACV == cv.MACV
                                      && nv.MALUONG == luong.MALUONG
                                      select new
                                      {
                                          Mã_Nhân_Viên = nv.MANV,
                                          Tên_Nhân_Viên = nv.HOTEN,
                                          Ngày_Sinh = nv.NGAYSINH,
                                          Giới_Tính = nv.GIOITINH,
                                          Quê_Quán = nv.QUEQUAN,
                                          SĐT = nv.SDT,
                                          Phòng_Ban = pb.TENPB,
                                          Chức_Vụ = cv.TENCV,
                                          Lương = luong.LUONGCB * luong.HSLUONG
                                      };
            }
        }

        //Tìm kiếm theo tên
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TimKiemTheoTen f = new TimKiemTheoTen();
            f.ShowDialog();
            if (f.Ten != null)
            {
                gridView1.Columns.Clear();
                gridmain.DataSource = from nv in db.NHANVIENs
                                      from cv in db.CHUCVUs
                                      from luong in db.LUONGs
                                      from pb in db.PHONGBANs
                                      where nv.MAPB == pb.MAPB
                                      && nv.HOTEN.Contains(f.Ten)
                                      && nv.MACV == cv.MACV
                                      && nv.MALUONG == luong.MALUONG
                                      select new
                                      {
                                          Mã_Nhân_Viên = nv.MANV,
                                          Tên_Nhân_Viên = nv.HOTEN,
                                          Ngày_Sinh = nv.NGAYSINH,
                                          Giới_Tính = nv.GIOITINH,
                                          Quê_Quán = nv.QUEQUAN,
                                          SĐT = nv.SDT,
                                          Phòng_Ban = pb.TENPB,
                                          Chức_Vụ = cv.TENCV,
                                          Lương = luong.LUONGCB * luong.HSLUONG
                                      };
            }
        }

        //A7 sắp xếp
        //1. Theo mã
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.Columns.Clear();
            gridmain.DataSource = from nv in db.NHANVIENs
                                  from cv in db.CHUCVUs
                                  from luong in db.LUONGs
                                  from pb in db.PHONGBANs
                                  where nv.MAPB == pb.MAPB
                                  && nv.MACV == cv.MACV
                                  && nv.MALUONG == luong.MALUONG
                                  orderby nv.MANV
                                  select new
                                  {
                                      Mã_Nhân_Viên = nv.MANV,
                                      Tên_Nhân_Viên = nv.HOTEN,
                                      Ngày_Sinh = nv.NGAYSINH,
                                      Giới_Tính = nv.GIOITINH,
                                      Quê_Quán = nv.QUEQUAN,
                                      SĐT = nv.SDT,
                                      Phòng_Ban = pb.TENPB,
                                      Chức_Vụ = cv.TENCV,
                                      Lương = luong.LUONGCB * luong.HSLUONG
                                  };
        }

        //2. Theo phòng ban
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.Columns.Clear();
            gridmain.DataSource = from nv in db.NHANVIENs
                                  from cv in db.CHUCVUs
                                  from luong in db.LUONGs
                                  from pb in db.PHONGBANs
                                  where nv.MAPB == pb.MAPB
                                  && nv.MACV == cv.MACV
                                  && nv.MALUONG == luong.MALUONG
                                  orderby pb.TENPB
                                  select new
                                  {
                                      Mã_Nhân_Viên = nv.MANV,
                                      Tên_Nhân_Viên = nv.HOTEN,
                                      Ngày_Sinh = nv.NGAYSINH,
                                      Giới_Tính = nv.GIOITINH,
                                      Quê_Quán = nv.QUEQUAN,
                                      SĐT = nv.SDT,
                                      Phòng_Ban = pb.TENPB,
                                      Chức_Vụ = cv.TENCV,
                                      Lương = luong.LUONGCB * luong.HSLUONG
                                  };
        }

        //3. Theo lương
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.Columns.Clear();
            var sapxepluong = from nv in db.NHANVIENs
                              from cv in db.CHUCVUs
                              from luong in db.LUONGs
                              from pb in db.PHONGBANs
                              where nv.MAPB == pb.MAPB
                              && nv.MACV == cv.MACV
                              && nv.MALUONG == luong.MALUONG

                              select new
                              {
                                  Mã_Nhân_Viên = nv.MANV,
                                  Tên_Nhân_Viên = nv.HOTEN,
                                  Ngày_Sinh = nv.NGAYSINH,
                                  Giới_Tính = nv.GIOITINH,
                                  Quê_Quán = nv.QUEQUAN,
                                  SĐT = nv.SDT,
                                  Phòng_Ban = pb.TENPB,
                                  Chức_Vụ = cv.TENCV,
                                  Lương = luong.LUONGCB * luong.HSLUONG
                              };
            sapxepluong = sapxepluong.OrderBy(p => p.Lương);
            gridmain.DataSource = sapxepluong;
        }

        //---------------------------------------------------------
        //               AA. PHẦN PHÒNG BAN
        //---------------------------------------------------------

        //AA1: Xem tất cả
        private void btnPhongban_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.Columns.Clear();
            gridmain.DataSource = from x in db.PHONGBANs
                                  select new
                                  {
                                      Phòng_Ban = x.MAPB,
                                      Tên_Phòng_Ban = x.TENPB,
                                      Số_Điện_Thoại = x.SDTPB
                                  };
        }

        //AA2: Làm mới
        private void btnPhongbanReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnPhongban_ItemClick(sender, e);
        }

        //AA3: Sửa phòng ban
        private void btnPhongbanchinhsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PHONGBAN ns = db.PHONGBANs.Where(a => a.MAPB == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Phòng_Ban").ToString()).SingleOrDefault();
            if (ns != null)
            {
                fmSuaPhongBan f = new fmSuaPhongBan(ns);
                f.ShowDialog();

                btnPhongbanReload_ItemClick(sender, e);
            }
        }

        //---------------------------------------------------------
        //               B. PHẦN LƯƠNG
        //---------------------------------------------------------
        //B1: Xem lương
        private void btnXemLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.Columns.Clear();
            gridmain.DataSource = from luong in db.LUONGs
                                  select new
                                  {
                                      Mã_Lương = luong.MALUONG,
                                      Loại_Lương = luong.TENLUONG,
                                      Lương_Cơ_Bản = luong.LUONGCB,
                                      Hệ_Số = luong.HSLUONG
                                  };
        }

        //B2: Làm mới
        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChamCong frm = new frmChamCong();
            frm.ShowDialog();
        }

        //B3: Sửa lương
        private void btnSuaLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ma = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã_Lương");
            if (ma != null)
            {
                LUONG ns = new LUONG();
                ns = db.LUONGs.Where(a => a.MALUONG == ma.ToString()).SingleOrDefault();
                fmSualuong f = new fmSualuong(ns);
                f.ShowDialog();

                btnXemLuong_ItemClick(sender, e);
            }
        }

        //---------------------------------------------------------
        //               C. LƯU TRỮ
        //---------------------------------------------------------
        //C1: Xuất execl
        private void btnXuatExecl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog open = new SaveFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    gridmain.ExportToXls(open.InitialDirectory + open.FileName + ".xls");
                    DevExpress.XtraEditors.XtraMessageBox.Show("Đã lưu tại " + open.InitialDirectory, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi lưu tại ", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                }
            }
        }

        //C2: Xuất PDF
        private void barButtonItem5_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog open = new SaveFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    gridmain.ExportToPdf(open.InitialDirectory + open.FileName + ".pdf");
                    DevExpress.XtraEditors.XtraMessageBox.Show("Đã lưu tại " + open.InitialDirectory, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Đã lưu tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //---------------------------------------------------------
        //               D. TÀI KHOẢN NGƯỜI DÙNG
        //---------------------------------------------------------
        //D1: Xem thông tin
        private void btnXemTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.Columns.Clear();
            gridmain.DataSource = from a in db.TAIKHOANs
                                  where a.MATK == matk.MATK
                                  select new
                                  {
                                      Mã_Tài_Khoản = a.MATK,
                                      Tên_Đăng_Nhập = a.TK,
                                  };
        }

        //D2: Đổi mật khẩu
        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                TAIKHOAN ns = new TAIKHOAN();
                if (ns != null)
                {
                    ns = db.TAIKHOANs.Where(a => a.MATK == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã_Tài_Khoản").ToString()).SingleOrDefault();
                    fmSuamatkhau f = new fmSuamatkhau(ns);
                    f.ShowDialog();
                }
            }
            catch (Exception) { }
        }

        //---------------------------------------------------------
        //               E. TÀI KHOẢN ADMIN
        //---------------------------------------------------------

        //E1: Tất cả tài khoản
        private void barButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.Columns.Clear();
            gridmain.DataSource = from a in db.TAIKHOANs
                                  from b in db.QUYENs
                                  where a.MAQUYEN == b.MAQUYEN
                                  select new
                                  {
                                      Mã_Tài_Khoản = a.MATK,
                                      Tên_Đăng_Nhập = a.TK,
                                      Mật_Khẩu = a.MK,
                                      Quyền = b.TENQUYEN
                                  };
        }

        //E2: Làm mới
        private void btnLamMoiTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barButtonItem4_ItemClick_1(sender, e);
        }

        //E3: Thêm tài khoản
        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmThemtaikhoan f = new fmThemtaikhoan();
            f.ShowDialog();
            barButtonItem4_ItemClick_1(sender, e);
        }

        //E4: Xóa tài khoản
        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ns = db.TAIKHOANs.Where(a => a.MATK == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã_Tài_Khoản").ToString()).SingleOrDefault();

            DialogResult s = XtraMessageBox.Show("Xóa " + ns.TK.Trim() + " không ?", "Xóa nhân viên", MessageBoxButtons.YesNo);
            if (s == DialogResult.Yes)
            {
                if (ns.MATK.Trim() != "admin") db.TAIKHOANs.DeleteOnSubmit(ns);
                else XtraMessageBox.Show("Tài khoản admin là mặc định!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                db.SubmitChanges();
                btnLamMoiTaiKhoan_ItemClick(sender, e);
            }
        }

        //E5: Chỉnh sửa tài khoản
        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ma = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã_Tài_Khoản");
            if (ma != null)
            {
                TAIKHOAN ns = new TAIKHOAN();
                ns = db.TAIKHOANs.Where(a => a.MATK == ma.ToString()).SingleOrDefault();
                if (ns != null)
                {
                    fmSuaTaiKhoanADM f = new fmSuaTaiKhoanADM(ns);
                    f.ShowDialog();
                    barButtonItem4_ItemClick_1(sender, e);
                }
            }
        }

        private void btnThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("             CÔNG TY CỔ PHẦN THÉP TÂN DÂN PHÚ\n\n\nMã số thuế: 0600743631\n\nNgày cấp: 08/11/2010\n\nCơ quan Thuế đang quản lý: Chi cục Thuế Huyện Mỹ Lộc\n\nĐịa chỉ: 158 Trần Thái Tông, Phường Thống Nhất, Thành phố Nam Định, Nam Định\n\nNgành nghề chính: Sản xuất sắt, thép, gang\n	\nLĩnh vực kinh tế: Kinh tế tư nhân\n\nLoại hình kinh tế: Công ty cổ phần nngoài quốc doanh (100% vốn tư nhân)	\n\nLoại hình tổ chức:			Tổ chức kinh tế SXKD dịch vụ, hàng hóa\n\nCấp chương: (3 - 754) Kinh tế hỗn hợp ngoài quốc doanh, Loại khoản (070 - 088) Sản xuất kim loại", "Thông tin Công Ti", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThongTinPM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("                                   PHẦN MỀM QUẢN LÍ NHÂN SỰ\n\n\nTên phiên bản: Phần mềm Quản lí nhân sự công ti thép Tân Dân Phú - Ổn định\n\nSố hiệu phiên bản: QLNS v1.1\n\nNgày cập nhật: 20/02/2018\n\nNgười tạo:Team Coder\n\nLiên hệ: tuxenpham@gmail.com", "Thông tin Phần mềm Quản lí nhân sự", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmDangnhap f = new fmDangnhap();
            f.Show();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }
    }
}