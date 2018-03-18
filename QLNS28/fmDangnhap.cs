using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLNS28
{
    public partial class fmDangnhap : DevExpress.XtraEditors.XtraForm
    {
        public fmDangnhap()
        {
            InitializeComponent();
            
        }

        
        

        private void fmDangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QLNSDataContext db = new QLNSDataContext();

            
            if(txtTen.Text!="" && txtMatKhau.Text!=""){
                TAIKHOAN kt = (from a in db.TAIKHOANs
                               where a.TK == txtTen.Text.Trim() && a.MK == txtMatKhau.Text
                               select a).SingleOrDefault();

                if (kt != null)
                {
                    this.Hide();

                    Form1 f = new Form1(kt);
                    f.Show();
                    XtraMessageBox.Show("Đã đăng nhập bằng tài khoản " + kt.TK.Trim() + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else XtraMessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }else XtraMessageBox.Show("Có gì đó sai sai !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
           
            
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
