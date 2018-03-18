namespace QLNS28
{
    partial class Themnhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Themnhanvien));
            this.quaylai = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.chucvu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.phongban = new DevExpress.XtraEditors.ComboBoxEdit();
            this.luong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.xoa = new DevExpress.XtraEditors.SimpleButton();
            this.xong = new DevExpress.XtraEditors.SimpleButton();
            this.que = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.sdt = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ten = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.ma = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ngaysinh = new DevExpress.XtraEditors.DateEdit();
            this.nam = new System.Windows.Forms.RadioButton();
            this.nu = new System.Windows.Forms.RadioButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chucvu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.que.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quaylai
            // 
            this.quaylai.Image = ((System.Drawing.Image)(resources.GetObject("quaylai.Image")));
            this.quaylai.Location = new System.Drawing.Point(12, 229);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(163, 38);
            this.quaylai.TabIndex = 2;
            this.quaylai.Text = "Quay lại";
            this.quaylai.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Phòng ban:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Chức vụ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Chế độ lương:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.chucvu);
            this.groupControl2.Controls.Add(this.phongban);
            this.groupControl2.Controls.Add(this.luong);
            this.groupControl2.Controls.Add(this.label12);
            this.groupControl2.Controls.Add(this.label10);
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Location = new System.Drawing.Point(347, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(342, 199);
            this.groupControl2.TabIndex = 29;
            this.groupControl2.Text = "Thông tin công việc";
            // 
            // chucvu
            // 
            this.chucvu.Location = new System.Drawing.Point(115, 57);
            this.chucvu.Name = "chucvu";
            this.chucvu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.chucvu.Properties.Items.AddRange(new object[] {
            "Thực tập",
            "Nhân viên",
            "Quản lí"});
            this.chucvu.Size = new System.Drawing.Size(215, 20);
            this.chucvu.TabIndex = 30;
            // 
            // phongban
            // 
            this.phongban.Location = new System.Drawing.Point(115, 31);
            this.phongban.Name = "phongban";
            this.phongban.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.phongban.Properties.Items.AddRange(new object[] {
            "Nhân sự",
            "Kinh doanh",
            "Kĩ thuật",
            "Kế toán"});
            this.phongban.Size = new System.Drawing.Size(215, 20);
            this.phongban.TabIndex = 29;
            // 
            // luong
            // 
            this.luong.Location = new System.Drawing.Point(115, 83);
            this.luong.Name = "luong";
            this.luong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luong.Properties.Items.AddRange(new object[] {
            "Thực tập",
            "Nhân viên",
            "Quản lí"});
            this.luong.Size = new System.Drawing.Size(215, 20);
            this.luong.TabIndex = 28;
            // 
            // xoa
            // 
            this.xoa.Image = ((System.Drawing.Image)(resources.GetObject("xoa.Image")));
            this.xoa.Location = new System.Drawing.Point(181, 229);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(160, 38);
            this.xoa.TabIndex = 30;
            this.xoa.Text = "Xóa giá trị";
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // xong
            // 
            this.xong.Image = ((System.Drawing.Image)(resources.GetObject("xong.Image")));
            this.xong.Location = new System.Drawing.Point(347, 229);
            this.xong.Name = "xong";
            this.xong.Size = new System.Drawing.Size(342, 38);
            this.xong.TabIndex = 31;
            this.xong.Text = "Xong";
            this.xong.Click += new System.EventHandler(this.xong_Click);
            // 
            // que
            // 
            this.que.Location = new System.Drawing.Point(98, 131);
            this.que.Name = "que";
            this.que.Size = new System.Drawing.Size(215, 20);
            this.que.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "SĐT:";
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(98, 157);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(215, 20);
            this.sdt.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quê quán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày sinh:";
            // 
            // ten
            // 
            this.ten.EditValue = "";
            this.ten.Location = new System.Drawing.Point(98, 57);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(215, 20);
            this.ten.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ tên:";
            // 
            // ma
            // 
            this.ma.Location = new System.Drawing.Point(98, 31);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(215, 20);
            this.ma.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giới tính:";
            // 
            // ngaysinh
            // 
            this.ngaysinh.EditValue = null;
            this.ngaysinh.Location = new System.Drawing.Point(98, 83);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaysinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaysinh.Size = new System.Drawing.Size(215, 20);
            this.ngaysinh.TabIndex = 32;
            this.ngaysinh.EditValueChanged += new System.EventHandler(this.ngaysinh_EditValueChanged);
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Location = new System.Drawing.Point(117, 108);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(46, 17);
            this.nam.TabIndex = 33;
            this.nam.TabStop = true;
            this.nam.Text = "Nam";
            this.nam.UseVisualStyleBackColor = true;
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.Location = new System.Drawing.Point(211, 108);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(39, 17);
            this.nu.TabIndex = 34;
            this.nu.TabStop = true;
            this.nu.Text = "Nữ";
            this.nu.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.nu);
            this.groupControl1.Controls.Add(this.nam);
            this.groupControl1.Controls.Add(this.ngaysinh);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.ma);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.ten);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.sdt);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.que);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(329, 199);
            this.groupControl1.TabIndex = 28;
            this.groupControl1.Text = "Thông tin liên hệ";
            // 
            // Themnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 279);
            this.Controls.Add(this.xong);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.quaylai);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Themnhanvien";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM NHÂN VIÊN MỚI";
            this.Load += new System.EventHandler(this.Themnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chucvu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.que.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaysinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton quaylai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton xoa;
        private DevExpress.XtraEditors.SimpleButton xong;
        private DevExpress.XtraEditors.ComboBoxEdit luong;
        private DevExpress.XtraEditors.ComboBoxEdit phongban;
        private DevExpress.XtraEditors.ComboBoxEdit chucvu;
        private DevExpress.XtraEditors.TextEdit que;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit sdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit ten;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.DateEdit ngaysinh;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.RadioButton nu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}