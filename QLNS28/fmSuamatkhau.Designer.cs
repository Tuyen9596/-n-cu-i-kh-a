namespace QLNS28
{
    partial class fmSuamatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSuamatkhau));
            this.btnHoantac = new DevExpress.XtraEditors.SimpleButton();
            this.xong = new DevExpress.XtraEditors.SimpleButton();
            this.quaylai = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.ten = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.mkcu = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.matkhaumoi = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mkcu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matkhaumoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHoantac
            // 
            this.btnHoantac.Image = ((System.Drawing.Image)(resources.GetObject("btnHoantac.Image")));
            this.btnHoantac.Location = new System.Drawing.Point(92, 142);
            this.btnHoantac.Name = "btnHoantac";
            this.btnHoantac.Size = new System.Drawing.Size(74, 38);
            this.btnHoantac.TabIndex = 42;
            this.btnHoantac.Text = "Hoàn tác";
            // 
            // xong
            // 
            this.xong.Image = ((System.Drawing.Image)(resources.GetObject("xong.Image")));
            this.xong.Location = new System.Drawing.Point(172, 142);
            this.xong.Name = "xong";
            this.xong.Size = new System.Drawing.Size(169, 38);
            this.xong.TabIndex = 41;
            this.xong.Text = "Xong";
            this.xong.Click += new System.EventHandler(this.xong_Click);
            // 
            // quaylai
            // 
            this.quaylai.Image = ((System.Drawing.Image)(resources.GetObject("quaylai.Image")));
            this.quaylai.Location = new System.Drawing.Point(12, 142);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(74, 38);
            this.quaylai.TabIndex = 40;
            this.quaylai.Text = "Quay lại";
            this.quaylai.Click += new System.EventHandler(this.quaylai_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.ten);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.mkcu);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.matkhaumoi);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(329, 113);
            this.groupControl1.TabIndex = 39;
            this.groupControl1.Text = "Đổi mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            // 
            // ten
            // 
            this.ten.Enabled = false;
            this.ten.Location = new System.Drawing.Point(98, 31);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(215, 20);
            this.ten.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // mkcu
            // 
            this.mkcu.EditValue = "";
            this.mkcu.Location = new System.Drawing.Point(98, 57);
            this.mkcu.Name = "mkcu";
            this.mkcu.Size = new System.Drawing.Size(215, 20);
            this.mkcu.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mật khẩu mới";
            // 
            // matkhaumoi
            // 
            this.matkhaumoi.Location = new System.Drawing.Point(98, 83);
            this.matkhaumoi.Name = "matkhaumoi";
            this.matkhaumoi.Size = new System.Drawing.Size(215, 20);
            this.matkhaumoi.TabIndex = 15;
            // 
            // fmSuamatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 211);
            this.Controls.Add(this.btnHoantac);
            this.Controls.Add(this.xong);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmSuamatkhau";
            this.Text = "ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.fmSuamatkhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mkcu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matkhaumoi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHoantac;
        private DevExpress.XtraEditors.SimpleButton xong;
        private DevExpress.XtraEditors.SimpleButton quaylai;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit ten;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit mkcu;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit matkhaumoi;

    }
}