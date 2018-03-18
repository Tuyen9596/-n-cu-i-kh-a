using System;

namespace QLNS28
{
    public partial class Timkiem : DevExpress.XtraEditors.XtraForm
    {
        public string Manv;

        public Timkiem()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Manv = ma.Text;
            this.Close();
        }
    }
}