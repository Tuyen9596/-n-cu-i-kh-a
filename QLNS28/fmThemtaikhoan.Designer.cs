namespace QLNS28
{
    partial class fmThemtaikhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmThemtaikhoan));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btmko = new System.Windows.Forms.RadioButton();
            this.btmco = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ma = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.ten = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.mk = new DevExpress.XtraEditors.TextEdit();
            this.xong = new DevExpress.XtraEditors.SimpleButton();
            this.quaylai = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mk.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btmko);
            this.groupControl1.Controls.Add(this.btmco);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.ma);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.ten);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.mk);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(329, 148);
            this.groupControl1.TabIndex = 29;
            this.groupControl1.Text = "Thêm tài khoản mới";
            // 
            // btmko
            // 
            this.btmko.AutoSize = true;
            this.btmko.Location = new System.Drawing.Point(236, 110);
            this.btmko.Name = "btmko";
            this.btmko.Size = new System.Drawing.Size(55, 17);
            this.btmko.TabIndex = 18;
            this.btmko.TabStop = true;
            this.btmko.Text = "Không";
            this.btmko.UseVisualStyleBackColor = true;
            // 
            // btmco
            // 
            this.btmco.AutoSize = true;
            this.btmco.Location = new System.Drawing.Point(116, 110);
            this.btmco.Name = "btmco";
            this.btmco.Size = new System.Drawing.Size(38, 17);
            this.btmco.TabIndex = 17;
            this.btmco.TabStop = true;
            this.btmco.Text = "Có";
            this.btmco.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quyền quản trị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã tài khoản";
            // 
            // ma
            // 
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
            this.label2.Text = "Tên đăng nhập";
            // 
            // ten
            // 
            this.ten.EditValue = "";
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
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mật khẩu";
            // 
            // mk
            // 
            this.mk.Location = new System.Drawing.Point(98, 83);
            this.mk.Name = "mk";
            this.mk.Size = new System.Drawing.Size(215, 20);
            this.mk.TabIndex = 15;
            // 
            // xong
            // 
            this.xong.Image = ((System.Drawing.Image)(resources.GetObject("xong.Image")));
            this.xong.Location = new System.Drawing.Point(102, 175);
            this.xong.Name = "xong";
            this.xong.Size = new System.Drawing.Size(243, 38);
            this.xong.TabIndex = 33;
            this.xong.Text = "Xong";
            this.xong.Click += new System.EventHandler(this.xong_Click);
            // 
            // quaylai
            // 
            this.quaylai.Image = ((System.Drawing.Image)(resources.GetObject("quaylai.Image")));
            this.quaylai.Location = new System.Drawing.Point(12, 175);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(84, 38);
            this.quaylai.TabIndex = 32;
            this.quaylai.Text = "Quay lại";
            this.quaylai.Click += new System.EventHandler(this.quaylai_Click);
            // 
            // fmThemtaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 237);
            this.Controls.Add(this.xong);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmThemtaikhoan";
            this.Text = "THÊM TÀI KHOẢN";
            this.Load += new System.EventHandler(this.fmThemtaikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mk.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton btmko;
        private System.Windows.Forms.RadioButton btmco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit ma;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit ten;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit mk;
        private DevExpress.XtraEditors.SimpleButton xong;
        private DevExpress.XtraEditors.SimpleButton quaylai;

    }
}