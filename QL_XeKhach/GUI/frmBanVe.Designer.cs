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
            this.btnSua = new System.Windows.Forms.Button();
            this.cboDiemden = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvTrips = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tgDen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tgKhoiHanh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvSeats = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtXe = new System.Windows.Forms.TextBox();
            this.txtTaiXe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeatCount = new System.Windows.Forms.TextBox();
            this.btnSeatCountDetail = new System.Windows.Forms.Button();
            this.txtTripCode = new System.Windows.Forms.TextBox();
            this.cboDepartureLocation = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoGhe = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSua);
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
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QL_XeKhach.Properties.Resources.updated;
            this.btnSua.Location = new System.Drawing.Point(462, 147);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(152, 41);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Lưu";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cboDiemden
            // 
            this.cboDiemden.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDiemden.FormattingEnabled = true;
            this.cboDiemden.Items.AddRange(new object[] {
            "16",
            "30",
            "35",
            "45"});
            this.cboDiemden.Location = new System.Drawing.Point(169, 30);
            this.cboDiemden.Name = "cboDiemden";
            this.cboDiemden.Size = new System.Drawing.Size(238, 39);
            this.cboDiemden.TabIndex = 6;
            this.cboDiemden.SelectedIndexChanged += new System.EventHandler(this.cboDiemden_SelectedIndexChanged);
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
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(169, 85);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(255, 38);
            this.txtPrice.TabIndex = 3;
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
            this.dgvTrips.Location = new System.Drawing.Point(24, 349);
            this.dgvTrips.Name = "dgvTrips";
            this.dgvTrips.RowHeadersWidth = 51;
            this.dgvTrips.RowTemplate.Height = 24;
            this.dgvTrips.Size = new System.Drawing.Size(1336, 592);
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
            // txt_tgKhoiHanh
            // 
            this.txt_tgKhoiHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tgKhoiHanh.Location = new System.Drawing.Point(315, 88);
            this.txt_tgKhoiHanh.Name = "txt_tgKhoiHanh";
            this.txt_tgKhoiHanh.Size = new System.Drawing.Size(224, 38);
            this.txt_tgKhoiHanh.TabIndex = 3;
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
            this.dgvSeats.Location = new System.Drawing.Point(1406, 349);
            this.dgvSeats.Name = "dgvSeats";
            this.dgvSeats.RowHeadersWidth = 51;
            this.dgvSeats.RowTemplate.Height = 24;
            this.dgvSeats.Size = new System.Drawing.Size(506, 539);
            this.dgvSeats.TabIndex = 12;
            this.dgvSeats.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeats_CellClick);
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
            // txtXe
            // 
            this.txtXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXe.Location = new System.Drawing.Point(739, 141);
            this.txtXe.Name = "txtXe";
            this.txtXe.Size = new System.Drawing.Size(255, 38);
            this.txtXe.TabIndex = 3;
            // 
            // txtTaiXe
            // 
            this.txtTaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiXe.Location = new System.Drawing.Point(739, 88);
            this.txtTaiXe.Name = "txtTaiXe";
            this.txtTaiXe.Size = new System.Drawing.Size(224, 38);
            this.txtTaiXe.TabIndex = 3;
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
            // txtSeatCount
            // 
            this.txtSeatCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeatCount.Location = new System.Drawing.Point(218, 193);
            this.txtSeatCount.Name = "txtSeatCount";
            this.txtSeatCount.Size = new System.Drawing.Size(197, 38);
            this.txtSeatCount.TabIndex = 1;
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
            // txtTripCode
            // 
            this.txtTripCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTripCode.Location = new System.Drawing.Point(220, 34);
            this.txtTripCode.Name = "txtTripCode";
            this.txtTripCode.ReadOnly = true;
            this.txtTripCode.Size = new System.Drawing.Size(319, 38);
            this.txtTripCode.TabIndex = 7;
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
            // txtSoGhe
            // 
            this.txtSoGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoGhe.Location = new System.Drawing.Point(169, 193);
            this.txtSoGhe.Name = "txtSoGhe";
            this.txtSoGhe.Size = new System.Drawing.Size(255, 38);
            this.txtSoGhe.TabIndex = 3;
            // 
            // frmBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 953);
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
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cboDiemden;
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
    }
}