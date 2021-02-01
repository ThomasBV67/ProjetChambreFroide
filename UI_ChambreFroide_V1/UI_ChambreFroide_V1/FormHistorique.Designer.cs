
namespace UI_ChambreFroide_V1
{
    partial class FormHistorique
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
            this.lbTitreHistorique = new System.Windows.Forms.Label();
            this.chartHistorique = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSelectCapteur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistorique)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitreHistorique
            // 
            this.lbTitreHistorique.AutoSize = true;
            this.lbTitreHistorique.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitreHistorique.Location = new System.Drawing.Point(73, 36);
            this.lbTitreHistorique.Name = "lbTitreHistorique";
            this.lbTitreHistorique.Size = new System.Drawing.Size(628, 55);
            this.lbTitreHistorique.TabIndex = 0;
            this.lbTitreHistorique.Text = "Historique des températures";
            // 
            // chartHistorique
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHistorique.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHistorique.Legends.Add(legend1);
            this.chartHistorique.Location = new System.Drawing.Point(12, 144);
            this.chartHistorique.Name = "chartHistorique";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartHistorique.Series.Add(series1);
            this.chartHistorique.Size = new System.Drawing.Size(1000, 444);
            this.chartHistorique.TabIndex = 2;
            this.chartHistorique.Text = "chart1";
            // 
            // btnSelectCapteur
            // 
            this.btnSelectCapteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCapteur.Location = new System.Drawing.Point(800, 18);
            this.btnSelectCapteur.Name = "btnSelectCapteur";
            this.btnSelectCapteur.Size = new System.Drawing.Size(200, 102);
            this.btnSelectCapteur.TabIndex = 3;
            this.btnSelectCapteur.Text = "Sélection du capteur";
            this.btnSelectCapteur.UseVisualStyleBackColor = true;
            // 
            // FormHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.btnSelectCapteur);
            this.Controls.Add(this.chartHistorique);
            this.Controls.Add(this.lbTitreHistorique);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistorique";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartHistorique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitreHistorique;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistorique;
        private System.Windows.Forms.Button btnSelectCapteur;
    }
}