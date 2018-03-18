using System;
using System.Linq;
using System.Windows.Forms;

namespace QLNS28
{
    public partial class fmSualuong : DevExpress.XtraEditors.XtraForm
    {
        private QLNSDataContext db = new QLNSDataContext();
        private LUONG l = null;

        public fmSualuong(LUONG _l)
        {
            l = _l;
            InitializeComponent();
        }

        private void fmSualuong_Load(object sender, EventArgs e)
        {
            ma.ResetText();
            ten.ResetText();
            luongcb.ResetText();
            heso.ResetText();

            ma.Text = l.MALUONG;
            ten.Text = l.TENLUONG.Trim();
            luongcb.Text = l.LUONGCB.ToString().Trim();
            heso.Text = l.HSLUONG.ToString().Trim();
        }

        private void xong_Click(object sender, EventArgs e)
        {
            if (ten.Text != null && luongcb.Text != "" && heso.Text != "")
            {
                LUONG tb = db.LUONGs.Single(p => p.MALUONG == l.MALUONG);
                tb.MALUONG = ma.Text;
                tb.TENLUONG = ten.Text;
                tb.LUONGCB = Convert.ToDouble(luongcb.Text);
                tb.HSLUONG = Convert.ToDouble(heso.Text);

                db.SubmitChanges();
                DevExpress.XtraEditors.XtraMessageBox.Show("Sửa thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else DevExpress.XtraEditors.XtraMessageBox.Show("Có gì đó sai sai ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnHoantac_Click(object sender, EventArgs e)
        {
            fmSualuong_Load(sender, e);
        }

        private void quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}