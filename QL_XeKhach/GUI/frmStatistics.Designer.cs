namespace QL_XeKhach.GUI
{
    partial class frmStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartBusCompanies = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.BookTicketChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartBusCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookTicketChart)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBusCompanies
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBusCompanies.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBusCompanies.Legends.Add(legend1);
            this.chartBusCompanies.Location = new System.Drawing.Point(76, 67);
            this.chartBusCompanies.Name = "chartBusCompanies";
            this.chartBusCompanies.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBusCompanies.Series.Add(series1);
            this.chartBusCompanies.Size = new System.Drawing.Size(614, 394);
            this.chartBusCompanies.TabIndex = 0;
            this.chartBusCompanies.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê";
            // 
            // BookTicketChart
            // 
            chartArea2.Name = "ChartArea1";
            this.BookTicketChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.BookTicketChart.Legends.Add(legend2);
            this.BookTicketChart.Location = new System.Drawing.Point(824, 67);
            this.BookTicketChart.Name = "BookTicketChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.BookTicketChart.Series.Add(series2);
            this.BookTicketChart.Size = new System.Drawing.Size(465, 394);
            this.BookTicketChart.TabIndex = 2;
            this.BookTicketChart.Text = "chart1";
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 774);
            this.Controls.Add(this.BookTicketChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartBusCompanies);
            this.Name = "frmStatistics";
            this.Text = "frmStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.chartBusCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookTicketChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBusCompanies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart BookTicketChart;
    }
}