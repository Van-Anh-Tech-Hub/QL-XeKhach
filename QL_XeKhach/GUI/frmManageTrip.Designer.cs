namespace QL_XeKhach.GUI
{
    partial class frmManageTrip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Trip = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBusDetail = new System.Windows.Forms.Button();
            this.btnSeatCountDetail = new System.Windows.Forms.Button();
            this.btnDriverDetail = new System.Windows.Forms.Button();
            this.cboDestination = new System.Windows.Forms.ComboBox();
            this.cboDepartureLocation = new System.Windows.Forms.ComboBox();
            this.cboDriver = new System.Windows.Forms.ComboBox();
            this.cboBus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTripCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnResetAction = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpEstimatedArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cboSeatCount = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtTripCodeSearch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboDepartureLocation_Search = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboDestination_Search = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Trip)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(794, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "QUẢN LÝ CHUYẾN XE";
            // 
            // dgv_Trip
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Trip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Trip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Trip.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Trip.Location = new System.Drawing.Point(12, 347);
            this.dgv_Trip.MultiSelect = false;
            this.dgv_Trip.Name = "dgv_Trip";
            this.dgv_Trip.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Trip.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Trip.RowHeadersWidth = 51;
            this.dgv_Trip.RowTemplate.Height = 24;
            this.dgv_Trip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Trip.Size = new System.Drawing.Size(1117, 570);
            this.dgv_Trip.TabIndex = 8;
            this.dgv_Trip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Trip_CellClick);
            this.dgv_Trip.SelectionChanged += new System.EventHandler(this.dgv_Trip_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboSeatCount);
            this.groupBox3.Controls.Add(this.dtpDepartureTime);
            this.groupBox3.Controls.Add(this.dtpEstimatedArrivalTime);
            this.groupBox3.Controls.Add(this.btnBusDetail);
            this.groupBox3.Controls.Add(this.btnSeatCountDetail);
            this.groupBox3.Controls.Add(this.btnDriverDetail);
            this.groupBox3.Controls.Add(this.cboDestination);
            this.groupBox3.Controls.Add(this.cboDepartureLocation);
            this.groupBox3.Controls.Add(this.cboDriver);
            this.groupBox3.Controls.Add(this.cboBus);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtTripCode);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(1157, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(755, 651);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chuyến";
            // 
            // btnBusDetail
            // 
            this.btnBusDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusDetail.Location = new System.Drawing.Point(619, 108);
            this.btnBusDetail.Name = "btnBusDetail";
            this.btnBusDetail.Size = new System.Drawing.Size(118, 41);
            this.btnBusDetail.TabIndex = 3;
            this.btnBusDetail.Text = "Chi tiết";
            this.btnBusDetail.UseVisualStyleBackColor = true;
            this.btnBusDetail.Click += new System.EventHandler(this.btnBusDetail_Click);
            // 
            // btnSeatCountDetail
            // 
            this.btnSeatCountDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeatCountDetail.Location = new System.Drawing.Point(625, 598);
            this.btnSeatCountDetail.Name = "btnSeatCountDetail";
            this.btnSeatCountDetail.Size = new System.Drawing.Size(118, 41);
            this.btnSeatCountDetail.TabIndex = 3;
            this.btnSeatCountDetail.Text = "Chi tiết";
            this.btnSeatCountDetail.UseVisualStyleBackColor = true;
            this.btnSeatCountDetail.Click += new System.EventHandler(this.btnSeatCountDetail_Click);
            // 
            // btnDriverDetail
            // 
            this.btnDriverDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriverDetail.Location = new System.Drawing.Point(619, 176);
            this.btnDriverDetail.Name = "btnDriverDetail";
            this.btnDriverDetail.Size = new System.Drawing.Size(118, 41);
            this.btnDriverDetail.TabIndex = 3;
            this.btnDriverDetail.Text = "Chi tiết";
            this.btnDriverDetail.UseVisualStyleBackColor = true;
            this.btnDriverDetail.Click += new System.EventHandler(this.btnDriverDetail_Click);
            // 
            // cboDestination
            // 
            this.cboDestination.DropDownHeight = 160;
            this.cboDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDestination.FormattingEnabled = true;
            this.cboDestination.IntegralHeight = false;
            this.cboDestination.Location = new System.Drawing.Point(280, 321);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(333, 39);
            this.cboDestination.TabIndex = 2;
            // 
            // cboDepartureLocation
            // 
            this.cboDepartureLocation.DropDownHeight = 160;
            this.cboDepartureLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartureLocation.FormattingEnabled = true;
            this.cboDepartureLocation.IntegralHeight = false;
            this.cboDepartureLocation.Location = new System.Drawing.Point(280, 247);
            this.cboDepartureLocation.Name = "cboDepartureLocation";
            this.cboDepartureLocation.Size = new System.Drawing.Size(333, 39);
            this.cboDepartureLocation.TabIndex = 2;
            // 
            // cboDriver
            // 
            this.cboDriver.DropDownHeight = 160;
            this.cboDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDriver.FormattingEnabled = true;
            this.cboDriver.IntegralHeight = false;
            this.cboDriver.Location = new System.Drawing.Point(280, 176);
            this.cboDriver.Name = "cboDriver";
            this.cboDriver.Size = new System.Drawing.Size(333, 39);
            this.cboDriver.TabIndex = 2;
            // 
            // cboBus
            // 
            this.cboBus.DropDownHeight = 160;
            this.cboBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBus.FormattingEnabled = true;
            this.cboBus.IntegralHeight = false;
            this.cboBus.Location = new System.Drawing.Point(280, 108);
            this.cboBus.Name = "cboBus";
            this.cboBus.Size = new System.Drawing.Size(333, 39);
            this.cboBus.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Điểm kết thúc:";
            // 
            // txtTripCode
            // 
            this.txtTripCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTripCode.Location = new System.Drawing.Point(280, 37);
            this.txtTripCode.Name = "txtTripCode";
            this.txtTripCode.ReadOnly = true;
            this.txtTripCode.Size = new System.Drawing.Size(333, 38);
            this.txtTripCode.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Điểm khởi hành:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài xế:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Xe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 601);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số chỗ ngồi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã chuyến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnResetAction);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(1157, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 174);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QL_XeKhach.Properties.Resources.delete;
            this.btnXoa.Location = new System.Drawing.Point(546, 40);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(152, 41);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QL_XeKhach.Properties.Resources.updated;
            this.btnSua.Location = new System.Drawing.Point(144, 105);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(152, 41);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnResetAction
            // 
            this.btnResetAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetAction.Image = global::QL_XeKhach.Properties.Resources.reset;
            this.btnResetAction.Location = new System.Drawing.Point(546, 105);
            this.btnResetAction.Name = "btnResetAction";
            this.btnResetAction.Size = new System.Drawing.Size(152, 44);
            this.btnResetAction.TabIndex = 5;
            this.btnResetAction.Text = "Reset";
            this.btnResetAction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetAction.UseVisualStyleBackColor = true;
            this.btnResetAction.Click += new System.EventHandler(this.btnResetAction_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QL_XeKhach.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(144, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(152, 41);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thời gian khởi hành:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 460);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Thời gian đến:";
            // 
            // dtpEstimatedArrivalTime
            // 
            this.dtpEstimatedArrivalTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEstimatedArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEstimatedArrivalTime.Location = new System.Drawing.Point(283, 391);
            this.dtpEstimatedArrivalTime.Name = "dtpEstimatedArrivalTime";
            this.dtpEstimatedArrivalTime.Size = new System.Drawing.Size(330, 34);
            this.dtpEstimatedArrivalTime.TabIndex = 4;
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDepartureTime.Location = new System.Drawing.Point(283, 458);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(330, 34);
            this.dtpDepartureTime.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(280, 530);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(333, 38);
            this.txtPrice.TabIndex = 1;
            // 
            // cboSeatCount
            // 
            this.cboSeatCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSeatCount.FormattingEnabled = true;
            this.cboSeatCount.Items.AddRange(new object[] {
            "16",
            "30",
            "35",
            "45"});
            this.cboSeatCount.Location = new System.Drawing.Point(280, 598);
            this.cboSeatCount.Name = "cboSeatCount";
            this.cboSeatCount.Size = new System.Drawing.Size(333, 39);
            this.cboSeatCount.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDestination_Search);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboDepartureLocation_Search);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txtTripCodeSearch);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1117, 234);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::QL_XeKhach.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(752, 158);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 46);
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
            this.btnReset.Location = new System.Drawing.Point(938, 160);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 44);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtTripCodeSearch
            // 
            this.txtTripCodeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTripCodeSearch.Location = new System.Drawing.Point(267, 70);
            this.txtTripCodeSearch.Name = "txtTripCodeSearch";
            this.txtTripCodeSearch.Size = new System.Drawing.Size(244, 38);
            this.txtTripCodeSearch.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(31, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 32);
            this.label14.TabIndex = 2;
            this.label14.Text = "Trip code:";
            // 
            // cboDepartureLocation_Search
            // 
            this.cboDepartureLocation_Search.DropDownHeight = 160;
            this.cboDepartureLocation_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartureLocation_Search.FormattingEnabled = true;
            this.cboDepartureLocation_Search.IntegralHeight = false;
            this.cboDepartureLocation_Search.Location = new System.Drawing.Point(267, 169);
            this.cboDepartureLocation_Search.Name = "cboDepartureLocation_Search";
            this.cboDepartureLocation_Search.Size = new System.Drawing.Size(244, 39);
            this.cboDepartureLocation_Search.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(31, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(219, 32);
            this.label15.TabIndex = 6;
            this.label15.Text = "Điểm khởi hành:";
            // 
            // cboDestination_Search
            // 
            this.cboDestination_Search.DropDownHeight = 160;
            this.cboDestination_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDestination_Search.FormattingEnabled = true;
            this.cboDestination_Search.IntegralHeight = false;
            this.cboDestination_Search.Location = new System.Drawing.Point(846, 70);
            this.cboDestination_Search.Name = "cboDestination_Search";
            this.cboDestination_Search.Size = new System.Drawing.Size(244, 39);
            this.cboDestination_Search.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(622, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 32);
            this.label11.TabIndex = 8;
            this.label11.Text = "Điểm kết thúc:";
            // 
            // frmManageTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgv_Trip);
            this.Controls.Add(this.label2);
            this.Name = "frmManageTrip";
            this.Text = "frmManageTrip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Trip)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Trip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboBus;
        private System.Windows.Forms.TextBox txtTripCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDriver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDepartureLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDestination;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBusDetail;
        private System.Windows.Forms.Button btnSeatCountDetail;
        private System.Windows.Forms.Button btnDriverDetail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnResetAction;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEstimatedArrivalTime;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cboSeatCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboDepartureLocation_Search;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtTripCodeSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboDestination_Search;
        private System.Windows.Forms.Label label11;
    }
}