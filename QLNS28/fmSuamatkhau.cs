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
   
    public partial class fmSuamatkhau : DevExpress.XtraEditors.XtraForm
    {
        QLNSDataContext db = new QLNSDataContext();
        TAIKHOAN tk;
        public fmSuamatkhau(TAIKHOAN _tk)
        {
            tk = _tk;
            InitializeComponent();
        }

        private void fmSuamatkhau_Load(object sender, EventArgs e)
        {
            ten.ResetText();
            mkcu.ResetText();
            matkhaumoi.ResetText();
            ten.Text = tk.TK;
        }

        private void xong_Click(object sender, EventArgs e)
        {
            TAIKHOAN kt = (from a in db.TAIKHOANs
                           where a.TK == tk.TK && a.MK == mkcu.Text
                           select a).SingleOrDefault();

            if (kt!=null && matkhaumoi.Text.Length >= 6 && mkcu.Text.CompareTo(matkhaumoi.Text)!=0)
            {
                kt.MK = matkhaumoi.Text;
                DevExpress.XtraEditors.XtraMessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else DevExpress.XtraEditors.XtraMessageBox.Show("Có gì đó sai sai !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            db.SubmitChanges();
            
        }
    }
}
