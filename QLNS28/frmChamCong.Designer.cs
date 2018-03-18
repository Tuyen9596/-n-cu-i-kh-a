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
            this.panel12 = new System.Windows.Forms.Panel();
            this.dtgChamCong = new DevExpress.XtraGrid.GridControl();
            this.pLinqInstantFeedbackSource1 = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Thang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoNgayNghi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoNgayDiLam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienPhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhuCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linqInstantFeedbackSource1 = new DevExpress.Data.Linq.LinqInstantFeedbackSource();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lblsndl = new System.Windows.Forms.Label();
            this.lblsnn = new System.Windows.Forms.Label();
            this.lbltennv = new System.Windows.Forms.Label();
            this.lblmanv = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtthang = new System.Windows.Forms.TextBox();
            this.cbngaydilam = new System.Windows.Forms.ComboBox();
            this.cbngaynghi = new System.Windows.Forms.ComboBox();
            this.cbphucap = new System.Windows.Forms.ComboBox();
            this.txttienphat = new System.Windows.Forms.TextBox();
            this.txttienthuong = new System.Windows.Forms.TextBox();
            this.qLNSDataContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.panel22.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dtgChamCong);
            this.panel12.Controls.Add(this.button1);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 168);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(967, 266);
            this.panel12.TabIndex = 1;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.MaCC,
            this.MaNV,
            this.HOTEN,
            this.MAPB,
            this.Thang,
            this.Nam,
            this.SoNgayNghi,
            this.SoNgayDiLam,
            this.TienThuong,
            this.TienPhat,
            this.PhuCap,
            this.TongLuong});
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
            // MaCC
            // 
            this.MaCC.Caption = "Mã Chấm Công";
            this.MaCC.FieldName = "MaCC";
            this.MaCC.Name = "MaCC";
            this.MaCC.Visible = true;
            this.MaCC.VisibleIndex = 0;
            this.MaCC.Width = 40;
            // 
            // MaNV
            // 
            this.MaNV.Caption = "Mã Nhân Viên";
            this.MaNV.FieldName = "MaNV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Visible = true;
            this.MaNV.VisibleIndex = 1;
            this.MaNV.Width = 69;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "Họ Tên";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 2;
            this.HOTEN.Width = 103;
            // 
            // MAPB
            // 
            this.MAPB.Caption = "MÃ PB";
            this.MAPB.FieldName = "MAPB";
            this.MAPB.Name = "MAPB";
            this.MAPB.Visible = true;
            this.MAPB.VisibleIndex = 3;
            this.MAPB.Width = 48;
            // 
            // Thang
            // 
            this.Thang.Caption = "Tháng";
            this.Thang.FieldName = "Thang";
            this.Thang.Name = "Thang";
            this.Thang.Visible = true;
            this.Thang.VisibleIndex = 4;
            this.Thang.Width = 50;
            // 
            // Nam
            // 
            this.Nam.Caption = "Năm";
            this.Nam.FieldName = "Nam";
            this.Nam.Name = "Nam";
            this.Nam.Visible = true;
            this.Nam.VisibleIndex = 5;
            this.Nam.Width = 50;
            // 
            // SoNgayNghi
            // 
            this.SoNgayNghi.Caption = "Số Ngày Nghỉ";
            this.SoNgayNghi.FieldName = "SoNgayNghi";
            this.SoNgayNghi.Name = "SoNgayNghi";
            this.SoNgayNghi.Visible = true;
            this.SoNgayNghi.VisibleIndex = 6;
            this.SoNgayNghi.Width = 69;
            // 
            // SoNgayDiLam
            // 
            this.SoNgayDiLam.Caption = "Só Ngày Đi Làm";
            this.SoNgayDiLam.FieldName = "SoNgayDiLam";
            this.SoNgayDiLam.Name = "SoNgayDiLam";
            this.SoNgayDiLam.Visible = true;
            this.SoNgayDiLam.VisibleIndex = 7;
            this.SoNgayDiLam.Width = 85;
            // 
            // TienThuong
            // 
            this.TienThuong.Caption = "Tiền Thưởng";
            this.TienThuong.FieldName = "TienThuong";
            this.TienThuong.Name = "TienThuong";
            this.TienThuong.Visible = true;
            this.TienThuong.VisibleIndex = 8;
            this.TienThuong.Width = 90;
            // 
            // TienPhat
            // 
            this.TienPhat.Caption = "Tiền Phạt";
            this.TienPhat.FieldName = "TienPhat";
            this.TienPhat.Name = "TienPhat";
            this.TienPhat.Visible = true;
            this.TienPhat.VisibleIndex = 9;
            this.TienPhat.Width = 94;
            // 
            // PhuCap
            // 
            this.PhuCap.Caption = "Phụ Cấp";
            this.PhuCap.FieldName = "PhuCap";
            this.PhuCap.Name = "PhuCap";
            this.PhuCap.Visible = true;
            this.PhuCap.VisibleIndex = 10;
            this.PhuCap.Width = 101;
            // 
            // TongLuong
            // 
            this.TongLuong.Caption = "Tổng Lương";
            this.TongLuong.FieldName = "TongLuong";
            this.TongLuong.Name = "TongLuong";
            this.TongLuong.Visible = true;
            this.TongLuong.VisibleIndex = 11;
            this.TongLuong.Width = 150;
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
            // panel22
            // 
            this.panel22.Controls.Add(this.label6);
            this.panel22.Controls.Add(this.label8);
            this.panel22.Controls.Add(this.label9);
            this.panel22.Controls.Add(this.label11);
            this.panel22.Controls.Add(this.label12);
            this.panel22.Controls.Add(this.label13);
            this.panel22.Controls.Add(this.label14);
            this.panel22.Controls.Add(this.button5);
            this.panel22.Controls.Add(this.lblsndl);
            this.panel22.Controls.Add(this.lblsnn);
            this.panel22.Controls.Add(this.lbltennv);
            this.panel22.Controls.Add(this.lblmanv);
            this.panel22.Controls.Add(this.button2);
            this.panel22.Controls.Add(this.groupBox1);
            this.panel22.Controls.Add(this.cbngaydilam);
            this.panel22.Controls.Add(this.cbngaynghi);
            this.panel22.Controls.Add(this.cbphucap);
            this.panel22.Controls.Add(this.txttienphat);
            this.panel22.Controls.Add(this.txttienthuong);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(0, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(967, 168);
            this.panel22.TabIndex = 2;
            this.panel22.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Tên Nhân Viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Mã Nhân Viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Phụ Cấp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(298, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Tiền Phạt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(298, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Tiền Thưởng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Số Ngày Đi Làm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Số Ngày Nghỉ";
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
            this.lblsndl.Location = new System.Drawing.Point(116, 100);
            this.lblsndl.Name = "lblsndl";
            this.lblsndl.Size = new System.Drawing.Size(0, 17);
            this.lblsndl.TabIndex = 28;
            // 
            // lblsnn
            // 
            this.lblsnn.AutoSize = true;
            this.lblsnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsnn.ForeColor = System.Drawing.Color.Blue;
            this.lblsnn.Location = new System.Drawing.Point(116, 62);
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
            this.lbltennv.Location = new System.Drawing.Point(386, 21);
            this.lbltennv.Name = "lbltennv";
            this.lbltennv.Size = new System.Drawing.Size(0, 17);
            this.lbltennv.TabIndex = 25;
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanv.ForeColor = System.Drawing.Color.Blue;
            this.lblmanv.Location = new System.Drawing.Point(106, 21);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(0, 17);
            this.lblmanv.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 25);
            this.button2.TabIndex = 21;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.time);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.txtthang);
            this.groupBox1.Location = new System.Drawing.Point(580, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 137);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // time
            // 
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time.Location = new System.Drawing.Point(6, 111);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(186, 20);
            this.time.TabIndex = 38;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(208, 106);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(161, 25);
            this.button7.TabIndex = 22;
            this.button7.Text = "Tạo Bảng Chấm Công Mới";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.AllowDrop = true;
            this.button3.Location = new System.Drawing.Point(248, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 25);
            this.button3.TabIndex = 28;
            this.button3.Text = "Xuất File PDF";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 71);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 25);
            this.button6.TabIndex = 37;
            this.button6.Text = "Xem";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Xem Lương Theo Tháng";
            // 
            // button4
            // 
            this.button4.AllowDrop = true;
            this.button4.Location = new System.Drawing.Point(248, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 25);
            this.button4.TabIndex = 27;
            this.button4.Text = "Xuất File Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtthang
            // 
            this.txtthang.Location = new System.Drawing.Point(6, 41);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(186, 20);
            this.txtthang.TabIndex = 29;
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
            this.cbngaydilam.Location = new System.Drawing.Point(167, 96);
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
            this.cbngaynghi.Location = new System.Drawing.Point(167, 58);
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
            this.cbphucap.Location = new System.Drawing.Point(117, 130);
            this.cbphucap.Name = "cbphucap";
            this.cbphucap.Size = new System.Drawing.Size(168, 21);
            this.cbphucap.TabIndex = 12;
            this.cbphucap.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txttienphat
            // 
            this.txttienphat.Location = new System.Drawing.Point(373, 97);
            this.txttienphat.Name = "txttienphat";
            this.txttienphat.Size = new System.Drawing.Size(157, 20);
            this.txttienphat.TabIndex = 7;
            this.txttienphat.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // txttienthuong
            // 
            this.txttienthuong.Location = new System.Drawing.Point(373, 59);
            this.txttienthuong.Name = "txttienthuong";
            this.txttienthuong.Size = new System.Drawing.Size(157, 20);
            this.txttienthuong.TabIndex = 5;
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
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.panel12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChamCong";
            this.Text = "Chấm Công";
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            this.Click += new System.EventHandler(this.frmChamCong_Click);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataContextBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox txttienphat;
        private System.Windows.Forms.TextBox txttienthuong;
        private System.Windows.Forms.ComboBox cbphucap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbngaydilam;
        private System.Windows.Forms.ComboBox cbngaynghi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbltennv;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.Button button4;
        private DevExpress.XtraGrid.GridControl dtgChamCong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Data.Linq.LinqInstantFeedbackSource linqInstantFeedbackSource1;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private System.Windows.Forms.BindingSource qLNSDataContextBindingSource;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource1;
        private System.Windows.Forms.Label lblsndl;
        private System.Windows.Forms.Label lblsnn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtthang;
        private DevExpress.XtraGrid.Columns.GridColumn MaCC;
        private DevExpress.XtraGrid.Columns.GridColumn MaNV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn MAPB;
        private DevExpress.XtraGrid.Columns.GridColumn Thang;
        private DevExpress.XtraGrid.Columns.GridColumn Nam;
        private DevExpress.XtraGrid.Columns.GridColumn SoNgayNghi;
        private DevExpress.XtraGrid.Columns.GridColumn SoNgayDiLam;
        private DevExpress.XtraGrid.Columns.GridColumn TienThuong;
        private DevExpress.XtraGrid.Columns.GridColumn TienPhat;
        private DevExpress.XtraGrid.Columns.GridColumn PhuCap;
        private DevExpress.XtraGrid.Columns.GridColumn TongLuong;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.Button button7;
    }
}