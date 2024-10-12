namespace QL_XeKhach.GUI
{
    partial class frmManageBus
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
            this.dgv_Bus = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Bus
            // 
            this.dgv_Bus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bus.Location = new System.Drawing.Point(44, 184);
            this.dgv_Bus.Name = "dgv_Bus";
            this.dgv_Bus.RowHeadersWidth = 51;
            this.dgv_Bus.RowTemplate.Height = 24;
            this.dgv_Bus.Size = new System.Drawing.Size(750, 344);
            this.dgv_Bus.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(77)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(860, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "QUẢN LÝ XE";
            // 
            // frmManageBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Bus);
            this.Name = "frmManageBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Bus;
        private System.Windows.Forms.Label label2;
    }
}