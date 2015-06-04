namespace SCRUM.UI.dsk
{
    partial class frmPrincipal
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
            this.btnGerarGrafico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerarGrafico
            // 
            this.btnGerarGrafico.Location = new System.Drawing.Point(12, 12);
            this.btnGerarGrafico.Name = "btnGerarGrafico";
            this.btnGerarGrafico.Size = new System.Drawing.Size(75, 23);
            this.btnGerarGrafico.TabIndex = 0;
            this.btnGerarGrafico.Text = " Gráfico";
            this.btnGerarGrafico.UseVisualStyleBackColor = true;
            this.btnGerarGrafico.Click += new System.EventHandler(this.btnGerarGrafico_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 447);
            this.Controls.Add(this.btnGerarGrafico);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráfico BurnUp e BurnDown";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerarGrafico;
    }
}

