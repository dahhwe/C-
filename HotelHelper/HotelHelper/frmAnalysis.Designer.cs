namespace HotelHelper
{
    partial class frmAnalysis
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
            this.crtAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPrintChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.crtAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // crtAnalysis
            // 
            chartArea1.Name = "ChartArea1";
            this.crtAnalysis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crtAnalysis.Legends.Add(legend1);
            this.crtAnalysis.Location = new System.Drawing.Point(288, 12);
            this.crtAnalysis.Name = "crtAnalysis";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Food Ordered";
            this.crtAnalysis.Series.Add(series1);
            this.crtAnalysis.Size = new System.Drawing.Size(500, 310);
            this.crtAnalysis.TabIndex = 0;
            this.crtAnalysis.Text = "chart1";
            // 
            // btnPrintChart
            // 
            this.btnPrintChart.Location = new System.Drawing.Point(706, 376);
            this.btnPrintChart.Name = "btnPrintChart";
            this.btnPrintChart.Size = new System.Drawing.Size(82, 26);
            this.btnPrintChart.TabIndex = 1;
            this.btnPrintChart.Text = "Print chart";
            this.btnPrintChart.UseVisualStyleBackColor = true;
            // 
            // frmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrintChart);
            this.Controls.Add(this.crtAnalysis);
            this.Name = "frmAnalysis";
            this.Text = "frmAnalysis";
            this.Load += new System.EventHandler(this.frmAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crtAnalysis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crtAnalysis;
        private System.Windows.Forms.Button btnPrintChart;
    }
}