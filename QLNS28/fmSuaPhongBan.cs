using System;
using System.Linq;
using System.Windows.Forms;

namespace QLNS28
{
    public partial class fmSuaPhongBan : DevExpress.XtraEditors.XtraForm
    {
        private QLNSDataContext db = new QLNSDataContext();
        private PHONGBAN pn = null;

        public fmSuaPhongBan(PHONGBAN _pn)
        {
            pn = _pn;
            InitializeComponent();
        }

        private void fmSuaPhongBan_Load(object sender, EventArgs e)
        {
            ma.ResetText();
            ten.ResetText();
            sdt.ResetText();
            ma.Text = pn.MAPB;
            ten.Text = pn.TENPB;
            sdt.Text = pn.SDTPB;
        }

        private void quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHoantac_Click(object sender, EventArgs e)
        {
            fmSuaPhongBan_Load(sender, e);
        }

        private void xong_Click(object sender, EventArgs e)
        {
            PHONGBAN tb = db.PHONGBANs.Single(p => p.MAPB == pn.MAPB);
            tb.MAPB = ma.Text;
            tb.TENPB = ten.Text;
            tb.SDTPB = sdt.Text;
            pn = null;
            db.SubmitChanges();
            DevExpress.XtraEditors.XtraMessageBox.Show("Sửa thành công ! Áp dụng sau khi khởi động lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}