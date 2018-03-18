namespace QLNS28
{
    partial class fmSuaPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSuaPhongBan));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.ma = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.ten = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.sdt = new DevExpress.XtraEditors.TextEdit();
            this.xong = new DevExpress.XtraEditors.SimpleButton();
            this.quaylai = new DevExpress.XtraEditors.SimpleButton();
            this.btnHoantac = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.ma);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.ten);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.sdt);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(329, 121);
            this.groupControl1.TabIndex = 29;
            this.groupControl1.Text = "Chỉnh sửa phòng ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã phòng ban\r\n";
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
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên phòng ban";
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
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Số điện thoại";
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(98, 83);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(215, 20);
            this.sdt.TabIndex = 15;
            // 
            // xong
            // 
            this.xong.Image = ((System.Drawing.Image)(resources.GetObject("xong.Image")));
            this.xong.Location = new System.Drawing.Point(172, 163);
            this.xong.Name = "xong";
            this.xong.Size = new System.Drawing.Size(169, 38);
            this.xong.TabIndex = 33;
            this.xong.Text = "Xong";
            this.xong.Click += new System.EventHandler(this.xong_Click);
            // 
            // quaylai
            // 
            this.quaylai.Image = ((System.Drawing.Image)(resources.GetObject("quaylai.Image")));
            this.quaylai.Location = new System.Drawing.Point(12, 163);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(74, 38);
            this.quaylai.TabIndex = 32;
            this.quaylai.Text = "Quay lại";
            this.quaylai.Click += new System.EventHandler(this.quaylai_Click);
            // 
            // btnHoantac
            // 
            this.btnHoantac.Image = ((System.Drawing.Image)(resources.GetObject("btnHoantac.Image")));
            this.btnHoantac.Location = new System.Drawing.Point(92, 163);
            this.btnHoantac.Name = "btnHoantac";
            this.btnHoantac.Size = new System.Drawing.Size(74, 38);
            this.btnHoantac.TabIndex = 34;
            this.btnHoantac.Text = "Hoàn tác";
            this.btnHoantac.Click += new System.EventHandler(this.btnHoantac_Click);
            // 
            // fmSuaPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 225);
            this.ControlBox = false;
            this.Controls.Add(this.btnHoantac);
            this.Controls.Add(this.xong);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmSuaPhongBan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CHỈNH SỬA PHÒNG BAN";
            this.Load += new System.EventHandler(this.fmSuaPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit ma;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit ten;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit sdt;
        private DevExpress.XtraEditors.SimpleButton xong;
        private DevExpress.XtraEditors.SimpleButton quaylai;
        private DevExpress.XtraEditors.SimpleButton btnHoantac;
    }
}