using System;

namespace QLNS28
{
    public partial class TimKiemTheoTen : DevExpress.XtraEditors.XtraForm
    {
        public string Ten;

        public TimKiemTheoTen()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Ten = ma.Text;
            this.Close();
        }
    }
}