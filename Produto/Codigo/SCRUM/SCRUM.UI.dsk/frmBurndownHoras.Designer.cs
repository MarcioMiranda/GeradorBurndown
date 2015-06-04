namespace SCRUM.UI.dsk
{
    partial class frmBurndownHoras
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.grafBurndownHoras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grafBurndownHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // grafBurndownHoras
            // 
            this.grafBurndownHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.grafBurndownHoras.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafBurndownHoras.Legends.Add(legend1);
            this.grafBurndownHoras.Location = new System.Drawing.Point(0, 0);
            this.grafBurndownHoras.Name = "grafBurndownHoras";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafBurndownHoras.Series.Add(series1);
            this.grafBurndownHoras.Size = new System.Drawing.Size(1007, 476);
            this.grafBurndownHoras.TabIndex = 0;
            title1.Name = "Title1";
            this.grafBurndownHoras.Titles.Add(title1);
            // 
            // frmBurndownHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 471);
            this.Controls.Add(this.grafBurndownHoras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBurndownHoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burndown Horas";
            this.Load += new System.EventHandler(this.frmBurndownHoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafBurndownHoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafBurndownHoras;
    }
}