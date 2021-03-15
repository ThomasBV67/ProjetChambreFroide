﻿
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMoreOptions = new System.Windows.Forms.Button();
            this.btnLastDay = new System.Windows.Forms.Button();
            this.btnLastWeek = new System.Windows.Forms.Button();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistorique)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitreHistorique
            // 
            this.lbTitreHistorique.AutoSize = true;
            this.lbTitreHistorique.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitreHistorique.Location = new System.Drawing.Point(173, 30);
            this.lbTitreHistorique.Name = "lbTitreHistorique";
            this.lbTitreHistorique.Size = new System.Drawing.Size(486, 42);
            this.lbTitreHistorique.TabIndex = 0;
            this.lbTitreHistorique.Text = "Historique des températures";
            // 
            // chartHistorique
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHistorique.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHistorique.Legends.Add(legend1);
            this.chartHistorique.Location = new System.Drawing.Point(12, 117);
            this.chartHistorique.Name = "chartHistorique";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartHistorique.Series.Add(series1);
            this.chartHistorique.Size = new System.Drawing.Size(831, 471);
            this.chartHistorique.TabIndex = 2;
            this.chartHistorique.Text = "chart1";
            // 
            // btnSelectCapteur
            // 
            this.btnSelectCapteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCapteur.Location = new System.Drawing.Point(862, 103);
            this.btnSelectCapteur.Name = "btnSelectCapteur";
            this.btnSelectCapteur.Size = new System.Drawing.Size(150, 85);
            this.btnSelectCapteur.TabIndex = 3;
            this.btnSelectCapteur.Text = "Sélection du capteur";
            this.btnSelectCapteur.UseVisualStyleBackColor = true;
            this.btnSelectCapteur.Click += new System.EventHandler(this.btnSelectCapteur_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(862, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 85);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMoreOptions
            // 
            this.btnMoreOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreOptions.Location = new System.Drawing.Point(862, 503);
            this.btnMoreOptions.Name = "btnMoreOptions";
            this.btnMoreOptions.Size = new System.Drawing.Size(150, 85);
            this.btnMoreOptions.TabIndex = 5;
            this.btnMoreOptions.Text = "Plus d\'options";
            this.btnMoreOptions.UseVisualStyleBackColor = true;
            this.btnMoreOptions.Click += new System.EventHandler(this.timeframeBtns_Click);
            // 
            // btnLastDay
            // 
            this.btnLastDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastDay.Location = new System.Drawing.Point(862, 230);
            this.btnLastDay.Name = "btnLastDay";
            this.btnLastDay.Size = new System.Drawing.Size(150, 85);
            this.btnLastDay.TabIndex = 6;
            this.btnLastDay.Text = "Dernier jour";
            this.btnLastDay.UseVisualStyleBackColor = true;
            this.btnLastDay.Click += new System.EventHandler(this.timeframeBtns_Click);
            // 
            // btnLastWeek
            // 
            this.btnLastWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastWeek.Location = new System.Drawing.Point(862, 321);
            this.btnLastWeek.Name = "btnLastWeek";
            this.btnLastWeek.Size = new System.Drawing.Size(150, 85);
            this.btnLastWeek.TabIndex = 7;
            this.btnLastWeek.Text = "Dernière semaine";
            this.btnLastWeek.UseVisualStyleBackColor = true;
            this.btnLastWeek.Click += new System.EventHandler(this.timeframeBtns_Click);
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastMonth.Location = new System.Drawing.Point(862, 412);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(150, 85);
            this.btnLastMonth.TabIndex = 8;
            this.btnLastMonth.Text = "Dernier mois";
            this.btnLastMonth.UseVisualStyleBackColor = true;
            this.btnLastMonth.Click += new System.EventHandler(this.timeframeBtns_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(33, 133);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(750, 433);
            this.listBox1.TabIndex = 9;
            // 
            // FormHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLastMonth);
            this.Controls.Add(this.btnLastWeek);
            this.Controls.Add(this.btnLastDay);
            this.Controls.Add(this.btnMoreOptions);
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
        private System.Windows.Forms.Button btnMoreOptions;
        private System.Windows.Forms.Button btnLastDay;
        private System.Windows.Forms.Button btnLastWeek;
        private System.Windows.Forms.Button btnLastMonth;
        private System.Windows.Forms.ListBox listBox1;
    }
}