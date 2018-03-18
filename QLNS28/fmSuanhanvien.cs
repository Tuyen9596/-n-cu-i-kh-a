using System;
using System.Windows.Forms;

namespace QLNS28
{
    public partial class fmSuanhanvien : DevExpress.XtraEditors.XtraForm
    {
        private NHANVIEN nv = null;

        public fmSuanhanvien(NHANVIEN _nv)
        {
            nv = _nv;
            InitializeComponent();
        }

        private void resettext()
        {
            ma.ResetText();
            ten.ResetText();
            ngaysinh.ResetText();
            nam.Checked = false;
            nu.Checked = false;

            que.ResetText();

            sdt.ResetText();
            phongban.ResetText();
            chucvu.ResetText();

            luong.ResetText();
        }

        private void fmSuanhanvien_Load(object sender, EventArgs e)
        {
            QLNSDataContext db = new QLNSDataContext();
            resettext();
            ma.Text = nv.MANV;
            ten.Text = nv.HOTEN;
            ngaysinh.Text = nv.NGAYSINH.ToString();
            if (nv.GIOITINH.Trim().CompareTo("Nam") == 0) nam.Checked = true; else nu.Checked = true;
            que.Text = nv.QUEQUAN;
            sdt.Text = nv.SDT;

            if (nv.MAPB.Trim().CompareTo("KD") == 0) phongban.SelectedText = "Kinh doanh";
            if (nv.MAPB.Trim().CompareTo("KTH") == 0) phongban.SelectedText = "Kĩ thuật";
            if (nv.MAPB.Trim().CompareTo("KT") == 0) phongban.SelectedText = "Kế toán";
            if (nv.MAPB.Trim().CompareTo("NS") == 0) phongban.SelectedText = "Nhân sự";

            if (nv.MACV.Trim().CompareTo("TT") == 0) chucvu.Text = "Thực tập";
            if (nv.MACV.Trim().CompareTo("NV") == 0) chucvu.Text = "Nhân viên";
            if (nv.MACV.Trim().CompareTo("QL") == 0) chucvu.Text = "Quản lí";

            if (nv.MALUONG.Trim().CompareTo("TT") == 0) luong.Text = "Thực tập";
            if (nv.MALUONG.Trim().CompareTo("NV") == 0) luong.Text = "Nhân viên";
            if (nv.MALUONG.Trim().CompareTo("QL") == 0) luong.Text = "Quản lí";
        }

        private QLNSDataContext db = new QLNSDataContext();

        private void xong_Click(object sender, EventArgs e)
        {
            NHANVIEN tb = new NHANVIEN();

            tb.MANV = ma.Text.Trim();
            tb.HOTEN = ten.Text.Trim();
            tb.NGAYSINH = Convert.ToDateTime(ngaysinh.Text.Trim());
            if (nam.Checked) tb.GIOITINH = "Nam"; else tb.GIOITINH = "Nữ";
            tb.QUEQUAN = que.Text.Trim();
            tb.SDT = sdt.Text.Trim();

            string a = phongban.Text.Trim();
            if (a.CompareTo("Nhân sự") == 0) tb.MAPB = "NS";
            if (a.CompareTo("Kinh doanh") == 0) tb.MAPB = "KD";
            if (a.CompareTo("Kĩ thuật") == 0) tb.MAPB = "KTH";
            if (a.CompareTo("Kế toán") == 0) tb.MAPB = "KT";

            a = chucvu.Text.Trim();
            if (a.CompareTo("Thực tập") == 0) tb.MACV = "TT";
            if (a.CompareTo("Nhân viên") == 0) tb.MACV = "NV";
            if (a.CompareTo("Quản lí") == 0) tb.MACV = "QL";

            a = luong.Text.Trim();
            if (a.CompareTo("Thực tập") == 0) tb.MALUONG = "TT";
            if (a.CompareTo("Nhân viên") == 0) tb.MALUONG = "NV";
            if (a.CompareTo("Quản lí") == 0) tb.MALUONG = "QL";

            db.updateNhanVien(tb.MANV, tb.HOTEN, tb.NGAYSINH, tb.GIOITINH, tb.QUEQUAN, tb.SDT, tb.MAPB, tb.MACV, tb.MALUONG, tb.LUONG);
            //  db.NHANVIENs.InsertOnSubmit(tb);
            db.SubmitChanges();
            DevExpress.XtraEditors.XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            fmSuanhanvien_Load(sender, e);
        }
    }
}