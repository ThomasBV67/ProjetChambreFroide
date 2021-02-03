
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbTitreHistorique = new System.Windows.Forms.Label();
            this.chartHistorique = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSelectCapteur = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistorique)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitreHistorique
            // 
            this.lbTitreHistorique.AutoSize = true;
            this.lbTitreHistorique.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitreHistorique.Location = new System.Drawing.Point(25, 45);
            this.lbTitreHistorique.Name = "lbTitreHistorique";
            this.lbTitreHistorique.Size = new System.Drawing.Size(628, 55);
            this.lbTitreHistorique.TabIndex = 0;
            this.lbTitreHistorique.Text = "Historique des températures";
            // 
            // chartHistorique
            // 
            chartArea2.Name = "ChartArea1";
            this.chartHistorique.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartHistorique.Legends.Add(legend2);
            this.chartHistorique.Location = new System.Drawing.Point(12, 144);
            this.chartHistorique.Name = "chartHistorique";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartHistorique.Series.Add(series2);
            this.chartHistorique.Size = new System.Drawing.Size(1000, 444);
            this.chartHistorique.TabIndex = 2;
            this.chartHistorique.Text = "chart1";
            // 
            // btnSelectCapteur
            // 
            this.btnSelectCapteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCapteur.Location = new System.Drawing.Point(659, 12);
            this.btnSelectCapteur.Name = "btnSelectCapteur";
            this.btnSelectCapteur.Size = new System.Drawing.Size(169, 102);
            this.btnSelectCapteur.TabIndex = 3;
            this.btnSelectCapteur.Text = "Sélection du capteur";
            this.btnSelectCapteur.UseVisualStyleBackColor = true;
            this.btnSelectCapteur.Click += new System.EventHandler(this.btnSelectCapteur_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(843, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(169, 102);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.btnBack);
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
        private System.Windows.Forms.Button btnBack;
    }
}