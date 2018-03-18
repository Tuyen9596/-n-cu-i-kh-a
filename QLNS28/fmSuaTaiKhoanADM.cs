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
    public partial class fmSuaTaiKhoanADM : Form
    {
        QLNSDataContext db = new QLNSDataContext();
        TAIKHOAN tk;
        public fmSuaTaiKhoanADM(TAIKHOAN _tk)
        {
            tk = _tk;
            InitializeComponent();
        }

        private void fmSuaTaiKhoanADM_Load(object sender, EventArgs e)
        {
            ma.ResetText();
            ten.ResetText();
            mk.ResetText();
            if (tk.MAQUYEN.Trim().CompareTo("1") == 0) btmco.Checked = true; else btmko.Checked = true;
            ma.Text = tk.MATK;
            ten.Text = tk.TK;
            mk.Text = tk.MK.Trim();


        }

        private void quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xong_Click(object sender, EventArgs e)
        {
            if (mk.Text != "" && ten.Text != "" && mk.Text.Length >= 6)
            {
                TAIKHOAN tb = db.TAIKHOANs.Single(p => p.MATK == tk.MATK);
                tk = null;
                tb.MK = mk.Text;
                if (btmco.Checked) tb.MAQUYEN = "1"; else tb.MAQUYEN = "0";
                db.SubmitChanges();
                
                XtraMessageBox.Show("Sửa thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else XtraMessageBox.Show("Mật khẩu không hợp lệ!\nMật khẩu từ 6 kí tự.","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }

        private void hoantac_Click(object sender, EventArgs e)
        {
            fmSuaTaiKhoanADM_Load(sender,e);
        }
    }
}
