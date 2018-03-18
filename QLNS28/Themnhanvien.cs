using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLNS28
{
    public partial class Themnhanvien : DevExpress.XtraEditors.XtraForm
    {
        public Themnhanvien()
        {
            InitializeComponent();
        }

        

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        void resettext()
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

        private void xoa_Click(object sender, EventArgs e)
        {

            resettext();

            
        }

        private void xong_Click(object sender, EventArgs e)
        {
            QLNSDataContext db = new QLNSDataContext(); 
            //Check
            NHANVIEN kt = (from nv in db.NHANVIENs
                           where nv.MANV == ma.Text
                           select nv).SingleOrDefault();
            //
            if (kt == null && ngaysinh.Text!="")
            {

                NHANVIEN tb = new NHANVIEN();


                tb.MANV = ma.Text;
                tb.HOTEN = ten.Text;
                tb.NGAYSINH = Convert.ToDateTime(ngaysinh.Text);
                if (nam.Checked) tb.GIOITINH = "Nam"; else tb.GIOITINH = "Nữ";
                tb.QUEQUAN = que.Text;
                tb.SDT = sdt.Text;

                string a = phongban.Text;
                if (a.CompareTo("Nhân sự") == 0) tb.MAPB = "NS";
                if (a.CompareTo("Kinh doanh") == 0) tb.MAPB = "KD";
                if (a.CompareTo("Kĩ thuật") == 0) tb.MAPB = "KTH";
                if (a.CompareTo("Kế toán") == 0) tb.MAPB = "KT";

                a = chucvu.Text;
                if (a.CompareTo("Thực tập") == 0) tb.MACV = "TT";
                if (a.CompareTo("Nhân viên") == 0) tb.MACV = "NV";
                if (a.CompareTo("Quản lí") == 0) tb.MACV = "QL";

                a = luong.Text;
                if (a.CompareTo("Thực tập") == 0) tb.MALUONG = "TT";
                if (a.CompareTo("Nhân viên") == 0) tb.MALUONG = "NV";
                if (a.CompareTo("Quản lí") == 0) tb.MALUONG = "QL";





                db.NHANVIENs.InsertOnSubmit(tb);
                db.SubmitChanges();
                DevExpress.XtraEditors.XtraMessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resettext();
            }
            else DevExpress.XtraEditors.XtraMessageBox.Show("Mã nhân viên đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                                
             
        }

        private void ngaysinh_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Themnhanvien_Load(object sender, EventArgs e)
        {

        }
    }
}
