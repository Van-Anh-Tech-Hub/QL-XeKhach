namespace QL_XeKhach.GUI
{
    partial class frmBanVe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDiemden = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoGhe = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvTrips = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tgDen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboDepartureLocation = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTripCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeatCountDetail = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTaiXe = new System.Windows.Forms.TextBox();
            this.txtXe = new System.Windows.Forms.TextBox();
            this.txt_tgKhoiHanh = new System.Windows.Forms.TextBox();
            this.txtSeatCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvSeats = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_SearchHD = new System.Windows.Forms.Button();
            this.btnCapNhatHoaDon = new System.Windows.Forms.Button();
            this.txtInvoiceCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.dtpUpdatedAt = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeats)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDiemden);
            this.groupBox1.Controls.Add(this.cboTrangThai);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSoGhe);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(58, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 259);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin vé";
            // 
            // cboDiemden
            // 
            this.cboDiemden.DropDownHeight = 160;
            this.cboDiemden.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDiemden.FormattingEnabled = true;
            this.cboDiemden.IntegralHeight = false;
            this.cboDiemden.Location = new System.Drawing.Point(169, 30);
            this.cboDiemden.Name = "cboDiemden";
            this.cboDiemden.Size = new System.Drawing.Size(287, 39);
            this.cboDiemden.TabIndex = 22;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "16",
            "30",
            "35",
            "45"});
            this.cboTrangThai.Location = new System.Drawing.Point(169, 141);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(238, 39);
            this.cboTrangThai.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::QL_XeKhach.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(462, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 41);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = global::QL_XeKhach.Properties.Resources.reset;
            this.btnReset.Location = new System.Drawing.Point(462, 91);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 44);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 32);
            this.label10.TabIndex = 2;
            this.label10.Text = "Điểm đến:";
            // 
            // txtSoGhe
            // 
            this.txtSoGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoGhe.Location = new System.Drawing.Point(169, 193);
            this.txtSoGhe.Name = "txtSoGhe";
            this.txtSoGhe.ReadOnly = true;
            this.txtSoGhe.Size = new System.Drawing.Size(255, 38);
            this.txtSoGhe.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(169, 85);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(255, 38);
            this.txtPrice.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 32);
            this.label11.TabIndex = 2;
            this.label11.Text = "Số ghế:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 32);
            this.label13.TabIndex = 2;
            this.label13.Text = "Giá:";
            // 
            // dgvTrips
            // 
            this.dgvTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrips.Location = new System.Drawing.Point(24, 543);
            this.dgvTrips.Name = "dgvTrips";
            this.dgvTrips.RowHeadersWidth = 51;
            this.dgvTrips.RowTemplate.Height = 24;
            this.dgvTrips.Size = new System.Drawing.Size(1420, 175);
            this.dgvTrips.TabIndex = 9;
            this.dgvTrips.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrips_CellClick);
            this.dgvTrips.SelectionChanged += new System.EventHandler(this.dgvTrips_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thời gian đến dự kiến:";
            // 
            // txt_tgDen
            // 
            this.txt_tgDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tgDen.Location = new System.Drawing.Point(315, 142);
            this.txt_tgDen.Name = "txt_tgDen";
            this.txt_tgDen.Size = new System.Drawing.Size(224, 38);
            this.txt_tgDen.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboDepartureLocation);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTripCode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSeatCountDetail);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_tgDen);
            this.groupBox2.Controls.Add(this.txtTaiXe);
            this.groupBox2.Controls.Add(this.txtXe);
            this.groupBox2.Controls.Add(this.txt_tgKhoiHanh);
            this.groupBox2.Controls.Add(this.txtSeatCount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(775, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1092, 259);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chuyến đi";
            // 
            // cboDepartureLocation
            // 
            this.cboDepartureLocation.DropDownHeight = 160;
            this.cboDepartureLocation.Enabled = false;
            this.cboDepartureLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartureLocation.FormattingEnabled = true;
            this.cboDepartureLocation.IntegralHeight = false;
            this.cboDepartureLocation.Location = new System.Drawing.Point(739, 34);
            this.cboDepartureLocation.Name = "cboDepartureLocation";
            this.cboDepartureLocation.Size = new System.Drawing.Size(333, 39);
            this.cboDepartureLocation.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(586, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 32);
            this.label9.TabIndex = 8;
            this.label9.Text = "Xe:";
            // 
            // txtTripCode
            // 
            this.txtTripCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTripCode.Location = new System.Drawing.Point(220, 34);
            this.txtTripCode.Name = "txtTripCode";
            this.txtTripCode.ReadOnly = true;
            this.txtTripCode.Size = new System.Drawing.Size(319, 38);
            this.txtTripCode.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số chỗ ngồi:";
            // 
            // btnSeatCountDetail
            // 
            this.btnSeatCountDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeatCountDetail.Location = new System.Drawing.Point(421, 193);
            this.btnSeatCountDetail.Name = "btnSeatCountDetail";
            this.btnSeatCountDetail.Size = new System.Drawing.Size(118, 41);
            this.btnSeatCountDetail.TabIndex = 3;
            this.btnSeatCountDetail.Text = "Chi tiết";
            this.btnSeatCountDetail.UseVisualStyleBackColor = true;
            this.btnSeatCountDetail.Click += new System.EventHandler(this.btnSeatCountDetail_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(586, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tài xế:";
            // 
            // txtTaiXe
            // 
            this.txtTaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiXe.Location = new System.Drawing.Point(739, 88);
            this.txtTaiXe.Name = "txtTaiXe";
            this.txtTaiXe.Size = new System.Drawing.Size(224, 38);
            this.txtTaiXe.TabIndex = 3;
            // 
            // txtXe
            // 
            this.txtXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXe.Location = new System.Drawing.Point(739, 141);
            this.txtXe.Name = "txtXe";
            this.txtXe.Size = new System.Drawing.Size(255, 38);
            this.txtXe.TabIndex = 3;
            // 
            // txt_tgKhoiHanh
            // 
            this.txt_tgKhoiHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tgKhoiHanh.Location = new System.Drawing.Point(315, 88);
            this.txt_tgKhoiHanh.Name = "txt_tgKhoiHanh";
            this.txt_tgKhoiHanh.Size = new System.Drawing.Size(224, 38);
            this.txt_tgKhoiHanh.TabIndex = 3;
            // 
            // txtSeatCount
            // 
            this.txtSeatCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeatCount.Location = new System.Drawing.Point(218, 193);
            this.txtSeatCount.Name = "txtSeatCount";
            this.txtSeatCount.Size = new System.Drawing.Size(197, 38);
            this.txtSeatCount.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thời gian khởi hành:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(586, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Khởi hành:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã chuyến đi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.label7.Location = new System.Drawing.Point(884, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 51);
            this.label7.TabIndex = 11;
            this.label7.Text = "BÁN VÉ XE";
            // 
            // dgvSeats
            // 
            this.dgvSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeats.Location = new System.Drawing.Point(1463, 348);
            this.dgvSeats.Name = "dgvSeats";
            this.dgvSeats.RowHeadersWidth = 51;
            this.dgvSeats.RowTemplate.Height = 24;
            this.dgvSeats.Size = new System.Drawing.Size(436, 539);
            this.dgvSeats.TabIndex = 12;
            this.dgvSeats.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeats_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_SearchHD);
            this.groupBox3.Controls.Add(this.btnCapNhatHoaDon);
            this.groupBox3.Controls.Add(this.txtInvoiceCode);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtCustomerPhoneNumber);
            this.groupBox3.Controls.Add(this.dtpUpdatedAt);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.dtpCreatedAt);
            this.groupBox3.Controls.Add(this.txtCustomerName);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtCustomerEmail);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(68, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1332, 187);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin hoá đơn";
            // 
            // btn_SearchHD
            // 
            this.btn_SearchHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchHD.Image = global::QL_XeKhach.Properties.Resources.search;
            this.btn_SearchHD.Location = new System.Drawing.Point(1174, 23);
            this.btn_SearchHD.Name = "btn_SearchHD";
            this.btn_SearchHD.Size = new System.Drawing.Size(152, 41);
            this.btn_SearchHD.TabIndex = 24;
            this.btn_SearchHD.Text = "Search";
            this.btn_SearchHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SearchHD.UseVisualStyleBackColor = true;
            this.btn_SearchHD.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCapNhatHoaDon
            // 
            this.btnCapNhatHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatHoaDon.Image = global::QL_XeKhach.Properties.Resources.updated;
            this.btnCapNhatHoaDon.Location = new System.Drawing.Point(1174, 128);
            this.btnCapNhatHoaDon.Name = "btnCapNhatHoaDon";
            this.btnCapNhatHoaDon.Size = new System.Drawing.Size(152, 41);
            this.btnCapNhatHoaDon.TabIndex = 23;
            this.btnCapNhatHoaDon.Text = "Sửa";
            this.btnCapNhatHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhatHoaDon.UseVisualStyleBackColor = true;
            this.btnCapNhatHoaDon.Click += new System.EventHandler(this.btnCapNhatHoaDon_Click);
            // 
            // txtInvoiceCode
            // 
            this.txtInvoiceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceCode.Location = new System.Drawing.Point(737, 26);
            this.txtInvoiceCode.Name = "txtInvoiceCode";
            this.txtInvoiceCode.ReadOnly = true;
            this.txtInvoiceCode.Size = new System.Drawing.Size(385, 38);
            this.txtInvoiceCode.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(572, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 32);
            this.label14.TabIndex = 20;
            this.label14.Text = "Mã HĐ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(571, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 32);
            this.label12.TabIndex = 16;
            this.label12.Text = "Thời gian thêm:";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QL_XeKhach.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(1174, 75);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(152, 41);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(572, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(193, 32);
            this.label16.TabIndex = 16;
            this.label16.Text = "Thời gian sửa:";
            // 
            // txtCustomerPhoneNumber
            // 
            this.txtCustomerPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhoneNumber.Location = new System.Drawing.Point(146, 74);
            this.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            this.txtCustomerPhoneNumber.Size = new System.Drawing.Size(386, 38);
            this.txtCustomerPhoneNumber.TabIndex = 4;
            // 
            // dtpUpdatedAt
            // 
            this.dtpUpdatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUpdatedAt.Location = new System.Drawing.Point(792, 121);
            this.dtpUpdatedAt.Name = "dtpUpdatedAt";
            this.dtpUpdatedAt.Size = new System.Drawing.Size(330, 34);
            this.dtpUpdatedAt.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 32);
            this.label17.TabIndex = 17;
            this.label17.Text = "Email";
            // 
            // dtpCreatedAt
            // 
            this.dtpCreatedAt.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCreatedAt.Location = new System.Drawing.Point(792, 72);
            this.dtpCreatedAt.Name = "dtpCreatedAt";
            this.dtpCreatedAt.Size = new System.Drawing.Size(330, 34);
            this.dtpCreatedAt.TabIndex = 14;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(146, 26);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(386, 38);
            this.txtCustomerName.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(21, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 32);
            this.label18.TabIndex = 17;
            this.label18.Text = "SĐT";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerEmail.Location = new System.Drawing.Point(146, 122);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(386, 38);
            this.txtCustomerEmail.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(21, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 32);
            this.label19.TabIndex = 17;
            this.label19.Text = "Tên KH";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvInvoices);
            this.groupBox4.Location = new System.Drawing.Point(12, 733);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1432, 208);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bảng hoá đơn";
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(12, 22);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.RowHeadersWidth = 51;
            this.dgvInvoices.RowTemplate.Height = 24;
            this.dgvInvoices.Size = new System.Drawing.Size(1414, 180);
            this.dgvInvoices.TabIndex = 1;
            this.dgvInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellClick);
            // 
            // frmBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 953);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvSeats);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvTrips);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBanVe";
            this.Text = "frmBanVe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeats)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvTrips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tgDen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tgKhoiHanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvSeats;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtXe;
        private System.Windows.Forms.TextBox txtTaiXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeatCount;
        private System.Windows.Forms.Button btnSeatCountDetail;
        private System.Windows.Forms.TextBox txtTripCode;
        private System.Windows.Forms.ComboBox cboDepartureLocation;
        private System.Windows.Forms.TextBox txtSoGhe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCustomerPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtpUpdatedAt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpCreatedAt;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCapNhatHoaDon;
        private System.Windows.Forms.TextBox txtInvoiceCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Button btn_SearchHD;
        private System.Windows.Forms.ComboBox cboDiemden;
    }
}