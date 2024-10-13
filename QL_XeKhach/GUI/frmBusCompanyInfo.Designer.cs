namespace QL_XeKhach.GUI
{
    partial class frmBusCompanyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusCompanyInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHeadquartersAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTongSoXe = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTongNhanVien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(562, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(862, 91);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN CÔNG TY";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QL_XeKhach.Properties.Resources.bus_image3;
            this.pictureBox2.Location = new System.Drawing.Point(1562, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 350);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(668, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên công ty:";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompanyName.Location = new System.Drawing.Point(911, 174);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(0, 39);
            this.lbCompanyName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(589, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ:";
            // 
            // lbHeadquartersAddress
            // 
            this.lbHeadquartersAddress.AutoSize = true;
            this.lbHeadquartersAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeadquartersAddress.Location = new System.Drawing.Point(760, 257);
            this.lbHeadquartersAddress.Name = "lbHeadquartersAddress";
            this.lbHeadquartersAddress.Size = new System.Drawing.Size(0, 39);
            this.lbHeadquartersAddress.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(750, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số điện thoại:";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumber.Location = new System.Drawing.Point(1015, 343);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(0, 39);
            this.lbPhoneNumber.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(826, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 39);
            this.label7.TabIndex = 3;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(978, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 39);
            this.label8.TabIndex = 3;
            // 
            // dgvXe
            // 
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe.Location = new System.Drawing.Point(14, 554);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.RowHeadersWidth = 51;
            this.dgvXe.RowTemplate.Height = 24;
            this.dgvXe.Size = new System.Drawing.Size(859, 345);
            this.dgvXe.TabIndex = 4;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(972, 554);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(942, 345);
            this.dgvNhanVien.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tổng số xe:";
            // 
            // lbTongSoXe
            // 
            this.lbTongSoXe.AutoSize = true;
            this.lbTongSoXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongSoXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.lbTongSoXe.Location = new System.Drawing.Point(166, 513);
            this.lbTongSoXe.Name = "lbTongSoXe";
            this.lbTongSoXe.Size = new System.Drawing.Size(0, 29);
            this.lbTongSoXe.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(967, 513);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 29);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tổng số nhân viên:";
            // 
            // lbTongNhanVien
            // 
            this.lbTongNhanVien.AutoSize = true;
            this.lbTongNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.lbTongNhanVien.Location = new System.Drawing.Point(1198, 513);
            this.lbTongNhanVien.Name = "lbTongNhanVien";
            this.lbTongNhanVien.Size = new System.Drawing.Size(0, 29);
            this.lbTongNhanVien.TabIndex = 3;
            // 
            // frmBusCompanyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.dgvXe);
            this.Controls.Add(this.lbTongNhanVien);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbTongSoXe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbHeadquartersAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmBusCompanyInfo";
            this.Text = "frmBusCompanyInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHeadquartersAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvXe;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTongSoXe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTongNhanVien;
    }
}