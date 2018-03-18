using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

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