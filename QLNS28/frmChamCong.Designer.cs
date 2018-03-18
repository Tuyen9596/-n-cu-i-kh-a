namespace QLNS28
{
    partial class frmChamCong
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgChamCong = new DevExpress.XtraGrid.GridControl();
            this.pLinqInstantFeedbackSource1 = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoNgayNghi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoNgayDiLam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienPhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhuCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTONGLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linqInstantFeedbackSource1 = new DevExpress.Data.Linq.LinqInstantFeedbackSource();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.lblsndl = new System.Windows.Forms.Label();
            this.lblsnn = new System.Windows.Forms.Label();
            this.lbltennv = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblmanv = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cbngaydilam = new System.Windows.Forms.ComboBox();
            this.cbngaynghi = new System.Windows.Forms.ComboBox();
            this.cbphucap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttienphat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttienthuong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qLNSDataContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgChamCong);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 266);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dtgChamCong
            // 
            this.dtgChamCong.DataSource = this.pLinqInstantFeedbackSource1;
            this.dtgChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgChamCong.Location = new System.Drawing.Point(0, 0);
            this.dtgChamCong.MainView = this.gridView1;
            this.dtgChamCong.Name = "dtgChamCong";
            this.dtgChamCong.Size = new System.Drawing.Size(967, 266);
            this.dtgChamCong.TabIndex = 14;
            this.dtgChamCong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dtgChamCong.Click += new System.EventHandler(this.dtgChamCong_Click);
            this.dtgChamCong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgChamCong_MouseClick);
            // 
            // pLinqInstantFeedbackSource1
            // 
            this.pLinqInstantFeedbackSource1.DefaultSorting = "MANV ASC";
            this.pLinqInstantFeedbackSource1.DesignTimeElementType = typeof(QLNS28.NHANVIEN);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colHOTEN,
            this.colLUONG,
            this.colSoNgayNghi,
            this.colSoNgayDiLam,
            this.colTienThuong,
            this.colTienPhat,
            this.colPhuCap,
            this.colTONGLUONG});
            this.gridView1.GridControl = this.dtgChamCong;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.gridView1_CellMerge);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            this.gridView1.DataSourceChanged += new System.EventHandler(this.gridView1_DataSourceChanged);
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Mã Nhân Viên";
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ Tên";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            // 
            // colLUONG
            // 
            this.colLUONG.Caption = "Lương";
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 2;
            // 
            // colSoNgayNghi
            // 
            this.colSoNgayNghi.Caption = "Số Ngày Nghỉ";
            this.colSoNgayNghi.FieldName = "SoNgayNghi";
            this.colSoNgayNghi.Name = "colSoNgayNghi";
            this.colSoNgayNghi.Visible = true;
            this.colSoNgayNghi.VisibleIndex = 3;
            // 
            // colSoNgayDiLam
            // 
            this.colSoNgayDiLam.Caption = "Số Ngày Đi Làm";
            this.colSoNgayDiLam.FieldName = "SoNgayDiLam";
            this.colSoNgayDiLam.Name = "colSoNgayDiLam";
            this.colSoNgayDiLam.Visible = true;
            this.colSoNgayDiLam.VisibleIndex = 4;
            // 
            // colTienThuong
            // 
            this.colTienThuong.Caption = "Tiền Thưởng";
            this.colTienThuong.FieldName = "TienThuong";
            this.colTienThuong.Name = "colTienThuong";
            this.colTienThuong.Visible = true;
            this.colTienThuong.VisibleIndex = 5;
            // 
            // colTienPhat
            // 
            this.colTienPhat.Caption = "Tiền Phạt";
            this.colTienPhat.FieldName = "TienPhat";
            this.colTienPhat.Name = "colTienPhat";
            this.colTienPhat.Visible = true;
            this.colTienPhat.VisibleIndex = 6;
            // 
            // colPhuCap
            // 
            this.colPhuCap.Caption = "Phụ Cấp";
            this.colPhuCap.FieldName = "PhuCap";
            this.colPhuCap.Name = "colPhuCap";
            this.colPhuCap.Visible = true;
            this.colPhuCap.VisibleIndex = 7;
            // 
            // colTONGLUONG
            // 
            this.colTONGLUONG.Caption = "Tổng Lương";
            this.colTONGLUONG.FieldName = "TONGLUONG";
            this.colTONGLUONG.Name = "colTONGLUONG";
            this.colTONGLUONG.Visible = true;
            this.colTONGLUONG.VisibleIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, -23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // linqInstantFeedbackSource1
            // 
            this.linqInstantFeedbackSource1.DefaultSorting = "MANV ASC";
            this.linqInstantFeedbackSource1.DesignTimeElementType = typeof(QLNS28.NHANVIEN);
            this.linqInstantFeedbackSource1.KeyExpression = "MANV";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.lblsndl);
            this.panel2.Controls.Add(this.lblsnn);
            this.panel2.Controls.Add(this.lbltennv);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblmanv);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.cbngaydilam);
            this.panel2.Controls.Add(this.cbngaynghi);
            this.panel2.Controls.Add(this.cbphucap);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txttienphat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txttienthuong);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 168);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(928, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblsndl
            // 
            this.lblsndl.AutoSize = true;
            this.lblsndl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsndl.ForeColor = System.Drawing.Color.Blue;
            this.lblsndl.Location = new System.Drawing.Point(116, 85);
            this.lblsndl.Name = "lblsndl";
            this.lblsndl.Size = new System.Drawing.Size(0, 17);
            this.lblsndl.TabIndex = 28;
            // 
            // lblsnn
            // 
            this.lblsnn.AutoSize = true;
            this.lblsnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsnn.ForeColor = System.Drawing.Color.Blue;
            this.lblsnn.Location = new System.Drawing.Point(116, 48);
            this.lblsnn.Name = "lblsnn";
            this.lblsnn.Size = new System.Drawing.Size(0, 17);
            this.lblsnn.TabIndex = 27;
            // 
            // lbltennv
            // 
            this.lbltennv.AutoSize = true;
            this.lbltennv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbltennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltennv.ForeColor = System.Drawing.Color.Blue;
            this.lbltennv.Location = new System.Drawing.Point(427, 25);
            this.lbltennv.Name = "lbltennv";
            this.lbltennv.Size = new System.Drawing.Size(0, 17);
            this.lbltennv.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Tên Nhân Viên";
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanv.ForeColor = System.Drawing.Color.Blue;
            this.lblmanv.Location = new System.Drawing.Point(106, 25);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(0, 17);
            this.lblmanv.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mã Nhân Viên";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(534, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 25);
            this.button2.TabIndex = 21;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(632, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 137);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.AllowDrop = true;
            this.button3.Location = new System.Drawing.Point(6, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 25);
            this.button3.TabIndex = 28;
            this.button3.Text = "Xuất File Excel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AllowDrop = true;
            this.button4.Location = new System.Drawing.Point(6, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 25);
            this.button4.TabIndex = 27;
            this.button4.Text = "Xuất File Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbngaydilam
            // 
            this.cbngaydilam.FormattingEnabled = true;
            this.cbngaydilam.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbngaydilam.Location = new System.Drawing.Point(164, 85);
            this.cbngaydilam.Name = "cbngaydilam";
            this.cbngaydilam.Size = new System.Drawing.Size(118, 21);
            this.cbngaydilam.TabIndex = 15;
            this.cbngaydilam.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cbngaynghi
            // 
            this.cbngaynghi.FormattingEnabled = true;
            this.cbngaynghi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbngaynghi.Location = new System.Drawing.Point(164, 44);
            this.cbngaynghi.Name = "cbngaynghi";
            this.cbngaynghi.Size = new System.Drawing.Size(118, 21);
            this.cbngaynghi.TabIndex = 14;
            // 
            // cbphucap
            // 
            this.cbphucap.FormattingEnabled = true;
            this.cbphucap.Items.AddRange(new object[] {
            "150000",
            "300000",
            "450000",
            "600000",
            "900000",
            "1000000",
            "1500000"});
            this.cbphucap.Location = new System.Drawing.Point(114, 120);
            this.cbphucap.Name = "cbphucap";
            this.cbphucap.Size = new System.Drawing.Size(168, 21);
            this.cbphucap.TabIndex = 12;
            this.cbphucap.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phụ Cấp";
            // 
            // txttienphat
            // 
            this.txttienphat.Location = new System.Drawing.Point(414, 101);
            this.txttienphat.Name = "txttienphat";
            this.txttienphat.Size = new System.Drawing.Size(194, 20);
            this.txttienphat.TabIndex = 7;
            this.txttienphat.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tiền Phạt";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // txttienthuong
            // 
            this.txttienthuong.Location = new System.Drawing.Point(414, 63);
            this.txttienthuong.Name = "txttienthuong";
            this.txttienthuong.Size = new System.Drawing.Size(194, 20);
            this.txttienthuong.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiền Thưởng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số Ngày Đi Làm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Ngày Nghỉ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // qLNSDataContextBindingSource
            // 
            this.qLNSDataContextBindingSource.DataSource = typeof(QLNS28.QLNSDataContext);
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChamCong";
            this.Text = "Chấm Công";
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            this.Click += new System.EventHandler(this.frmChamCong_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataContextBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttienphat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttienthuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbphucap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbngaydilam;
        private System.Windows.Forms.ComboBox cbngaynghi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbltennv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private DevExpress.XtraGrid.GridControl dtgChamCong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Data.Linq.LinqInstantFeedbackSource linqInstantFeedbackSource1;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private System.Windows.Forms.BindingSource qLNSDataContextBindingSource;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSoNgayNghi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoNgayDiLam;
        private DevExpress.XtraGrid.Columns.GridColumn colTienThuong;
        private DevExpress.XtraGrid.Columns.GridColumn colTienPhat;
        private DevExpress.XtraGrid.Columns.GridColumn colPhuCap;
        private DevExpress.XtraGrid.Columns.GridColumn colTONGLUONG;
        private System.Windows.Forms.Label lblsndl;
        private System.Windows.Forms.Label lblsnn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
    }
}