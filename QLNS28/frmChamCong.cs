﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Editors;
using DevExpress.XtraEditors;

namespace QLNS28
{
    public partial class frmChamCong : Form
    {
        ChamCong backup = new ChamCong();
        QLNSDataContext db;
        public frmChamCong()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            db = new QLNSDataContext();
            dtgChamCong.DataSource = null;
            
            dtgChamCong.DataSource = db.NHANVIENs;
        }
        private void frmChamCong_Click(object sender, EventArgs e)
        {
           
       }

        private void button2_Click(object sender, EventArgs e)
        {
            if (backup.MaNV != null)
            {
                db = new QLNSDataContext();
                int ngaynghi = backup.SoNgayNghi.Value + (String.IsNullOrEmpty(cbngaynghi.Text) ? 0 : int.Parse(cbngaynghi.Text));
                int ngaydilam = backup.SoNgayDiLam.Value + (String.IsNullOrEmpty(cbngaydilam.Text) ? 0 : int.Parse(cbngaydilam.Text));
                double tienthuong = backup.TienThuong.Value + (String.IsNullOrEmpty(txttienthuong.Text) ? 0 : double.Parse(txttienthuong.Text));
                double tienphat = backup.TienPhat.Value + (String.IsNullOrEmpty(txttienphat.Text) ? 0 : double.Parse(txttienphat.Text));
                double phucap = String.IsNullOrEmpty(cbphucap.Text) ? 0 : double.Parse(cbphucap.Text);
                try
                {
                    db.updateChamCong(backup.MaNV, ngaynghi, ngaydilam,
                    tienthuong, tienphat, double.Parse(cbphucap.Text));
                    //db.updatetongluongnhanvien1();
                    //db.updateluongnhanvien();
                    db.SubmitChanges();
                    frmChamCong_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtgChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                db = new QLNSDataContext();
                var lst = db.NHANVIENs;
                foreach (var item in lst)
                {
                    db.updatetongluong(item.MANV);
                }
                db.SubmitChanges();
                frmChamCong_Load(sender, e);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void dtgChamCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog open = new SaveFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dtgChamCong.ExportToXls(open.InitialDirectory+open.FileName+".xls");
                    DevExpress.XtraEditors.XtraMessageBox.Show("Đã lưu tại " + open.InitialDirectory, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi lưu tại " , "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                }
            }
        }

        private void dtgChamCong_Click(object sender, EventArgs e)
        {
            
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
        }

        private void dtgChamCong_MouseClick(object sender, MouseEventArgs e)
        {

        }

        // This event is generated by Data Source Configuration Wizard
        void linqInstantFeedbackSource1_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {

            // Instantiate a new DataContext
            QLNS28.QLNSDataContext dataContext = new QLNS28.QLNSDataContext();
            // Assign a queryable source to the LinqInstantFeedbackSource
            e.QueryableSource = dataContext.NHANVIENs;
            // Assign the DataContext to the Tag property,
            // to dispose of it in the DismissQueryable event handler
            e.Tag = dataContext;
        }

        // This event is generated by Data Source Configuration Wizard
        void linqInstantFeedbackSource1_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {

            // Dispose of the DataContext
            ((QLNS28.QLNSDataContext)e.Tag).Dispose();
        }

        // This event is generated by Data Source Configuration Wizard
        void pLinqInstantFeedbackSource1_GetEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {

            // Instantiate a new DataContext
            QLNS28.QLNSDataContext dataContext = new QLNS28.QLNSDataContext();
            // Assign a queryable source to the PLinqInstantFeedbackSource
            e.Source = dataContext.ChamCongs;
            // Assign the DataContext to the Tag property,
            // to dispose of it in the DismissEnumerable event handler
            e.Tag = dataContext;
        }

        // This event is generated by Data Source Configuration Wizard
        void pLinqInstantFeedbackSource1_DismissEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {

            // Dispose of the DataContext
            ((QLNS28.QLNSDataContext)e.Tag).Dispose();
        }

        private void gridView1_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            db = new QLNSDataContext();
            lblmanv.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV").ToString();
            lbltennv.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HOTEN").ToString();
            backup = db.ChamCongs.SingleOrDefault(x => x.MaNV == lblmanv.Text);
            if (backup.SoNgayDiLam == null) { backup.SoNgayDiLam = 0; }
            if (backup.SoNgayNghi == null) { backup.SoNgayNghi = 0; }
            if (backup.PhuCap == null) { backup.PhuCap = 0; };
            if (backup.TienThuong == null) { backup.TienThuong = 0; }
            if (backup.TienPhat == null) { backup.TienPhat = 0; }
            cbphucap.Text = backup.PhuCap.ToString();
            lblsnn.Text = backup.SoNgayNghi + "  +";
            lblsndl.Text = backup.SoNgayDiLam + "  +";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
