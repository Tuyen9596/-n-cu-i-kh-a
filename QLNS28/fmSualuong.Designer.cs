namespace QLNS28
{
    partial class fmSualuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSualuong));
            this.btnHoantac = new DevExpress.XtraEditors.SimpleButton();
            this.xong = new DevExpress.XtraEditors.SimpleButton();
            this.quaylai = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label3 = new System.Windows.Forms.Label();
            this.heso = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.ma = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.ten = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.luongcb = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongcb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHoantac
            // 
            this.btnHoantac.Image = ((System.Drawing.Image)(resources.GetObject("btnHoantac.Image")));
            this.btnHoantac.Location = new System.Drawing.Point(95, 177);
            this.btnHoantac.Name = "btnHoantac";
            this.btnHoantac.Size = new System.Drawing.Size(74, 38);
            this.btnHoantac.TabIndex = 38;
            this.btnHoantac.Text = "Hoàn tác";
            this.btnHoantac.Click += new System.EventHandler(this.btnHoantac_Click);
            // 
            // xong
            // 
            this.xong.Image = ((System.Drawing.Image)(resources.GetObject("xong.Image")));
            this.xong.Location = new System.Drawing.Point(175, 177);
            this.xong.Name = "xong";
            this.xong.Size = new System.Drawing.Size(169, 38);
            this.xong.TabIndex = 37;
            this.xong.Text = "Xong";
            this.xong.Click += new System.EventHandler(this.xong_Click);
            // 
            // quaylai
            // 
            this.quaylai.Image = ((System.Drawing.Image)(resources.GetObject("quaylai.Image")));
            this.quaylai.Location = new System.Drawing.Point(15, 177);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(74, 38);
            this.quaylai.TabIndex = 36;
            this.quaylai.Text = "Quay lại";
            this.quaylai.Click += new System.EventHandler(this.quaylai_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.heso);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.ma);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.ten);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.luongcb);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(329, 144);
            this.groupControl1.TabIndex = 35;
            this.groupControl1.Text = "Chỉnh sửa lương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hệ số lương";
            // 
            // heso
            // 
            this.heso.Location = new System.Drawing.Point(98, 109);
            this.heso.Name = "heso";
            this.heso.Size = new System.Drawing.Size(215, 20);
            this.heso.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã lương";
            // 
            // ma
            // 
            this.ma.Enabled = false;
            this.ma.Location = new System.Drawing.Point(98, 31);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(215, 20);
            this.ma.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên lương";
            // 
            // ten
            // 
            this.ten.EditValue = "";
            this.ten.Enabled = false;
            this.ten.Location = new System.Drawing.Point(98, 57);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(215, 20);
            this.ten.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lương cơ bản";
            // 
            // luongcb
            // 
            this.luongcb.Location = new System.Drawing.Point(98, 83);
            this.luongcb.Name = "luongcb";
            this.luongcb.Size = new System.Drawing.Size(215, 20);
            this.luongcb.TabIndex = 15;
            // 
            // fmSualuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 227);
            this.ControlBox = false;
            this.Controls.Add(this.btnHoantac);
            this.Controls.Add(this.xong);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.groupControl1);
            this.Name = "fmSualuong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CHỈNH SỬA LƯƠNG";
            this.Load += new System.EventHandler(this.fmSualuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongcb.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHoantac;
        private DevExpress.XtraEditors.SimpleButton xong;
        private DevExpress.XtraEditors.SimpleButton quaylai;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit ma;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit ten;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit luongcb;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit heso;
    }
}