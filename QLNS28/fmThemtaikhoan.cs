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
    public partial class fmThemtaikhoan : DevExpress.XtraEditors.XtraForm
    {
        public fmThemtaikhoan()
        {
            InitializeComponent();
        }

        private void fmThemtaikhoan_Load(object sender, EventArgs e)
        {

        }

        private void quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xong_Click(object sender, EventArgs e)
        {
            QLNSDataContext db = new QLNSDataContext();
            TAIKHOAN kt = (from a in db.TAIKHOANs  // check TK đã tồn tại hay chưa
                           where a.MATK == ma.Text
                           select a).SingleOrDefault();

            TAIKHOAN tdn = (from b in db.TAIKHOANs //Ten nguoi dung đã toond tai chưa
                           where b.TK == ten.Text
                           select b).SingleOrDefault();

            if (kt == null && tdn == null && mk.Text != ""  )
            {
                if (mk.Text.checkLength())
                {
                    if (ten.Text.checknull())
                    {
                        TAIKHOAN tk = new TAIKHOAN();
                        tk.MATK = ma.Text;
                        tk.TK = ten.Text;
                        tk.MK = mk.Text;
                        if (btmco.Checked) tk.MAQUYEN = "1"; else tk.MAQUYEN = "0";
                        if (btmko.Checked) tk.MAQUYEN = "0"; else tk.MAQUYEN = "1";
                        db.TAIKHOANs.InsertOnSubmit(tk);
                        db.SubmitChanges();
                        DevExpress.XtraEditors.XtraMessageBox.Show("Đã thêm tài khoản " + ten.Text + " !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else DevExpress.XtraEditors.XtraMessageBox.Show("Tên Không Được Để Trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else DevExpress.XtraEditors.XtraMessageBox.Show("Mật Khẩu Tối Đa 6 kí tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else DevExpress.XtraEditors.XtraMessageBox.Show("Tài Khoản Đã Tồn Tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);



            

        }
    }
}
