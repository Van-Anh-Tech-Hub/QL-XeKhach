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
            this.txtSeatCount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Trip)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.dgv_Trip.Location = new System.Drawing.Point(12, 429);
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
            this.dgv_Trip.Size = new System.Drawing.Size(1117, 488);
            this.dgv_Trip.TabIndex = 8;
            this.dgv_Trip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Trip_CellClick);
            this.dgv_Trip.SelectionChanged += new System.EventHandler(this.dgv_Trip_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBusDetail);
            this.groupBox3.Controls.Add(this.btnSeatCountDetail);
            this.groupBox3.Controls.Add(this.btnDriverDetail);
            this.groupBox3.Controls.Add(this.cboDestination);
            this.groupBox3.Controls.Add(this.cboDepartureLocation);
            this.groupBox3.Controls.Add(this.cboDriver);
            this.groupBox3.Controls.Add(this.cboBus);
            this.groupBox3.Controls.Add(this.txtSeatCount);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtTripCode);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(1157, 374);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(755, 543);
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
            this.btnSeatCountDetail.Location = new System.Drawing.Point(625, 471);
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
            this.cboDestination.Location = new System.Drawing.Point(265, 321);
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
            this.cboDepartureLocation.Location = new System.Drawing.Point(265, 247);
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
            this.cboDriver.Location = new System.Drawing.Point(265, 176);
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
            this.cboBus.Location = new System.Drawing.Point(265, 108);
            this.cboBus.Name = "cboBus";
            this.cboBus.Size = new System.Drawing.Size(333, 39);
            this.cboBus.TabIndex = 2;
            // 
            // txtSeatCount
            // 
            this.txtSeatCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeatCount.Location = new System.Drawing.Point(265, 471);
            this.txtSeatCount.Name = "txtSeatCount";
            this.txtSeatCount.Size = new System.Drawing.Size(333, 38);
            this.txtSeatCount.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(265, 392);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(333, 38);
            this.txtPrice.TabIndex = 1;
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
            this.txtTripCode.Location = new System.Drawing.Point(265, 37);
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
            this.label5.Location = new System.Drawing.Point(6, 474);
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
            this.label3.Location = new System.Drawing.Point(6, 395);
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
            this.groupBox2.Location = new System.Drawing.Point(1157, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 174);
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
            // frmManageTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 953);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Trip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboBus;
        private System.Windows.Forms.TextBox txtPrice;
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
        private System.Windows.Forms.TextBox txtSeatCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBusDetail;
        private System.Windows.Forms.Button btnSeatCountDetail;
        private System.Windows.Forms.Button btnDriverDetail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnResetAction;
        private System.Windows.Forms.Button btnThem;
    }
}