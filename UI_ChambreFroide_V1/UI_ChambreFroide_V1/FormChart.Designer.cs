
namespace UI_ChambreFroide_V1
{
    partial class FormChart
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
            this.chartTemp = new LiveCharts.WinForms.CartesianChart();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chartTemp
            // 
            this.chartTemp.Location = new System.Drawing.Point(12, 12);
            this.chartTemp.Name = "chartTemp";
            this.chartTemp.Size = new System.Drawing.Size(849, 576);
            this.chartTemp.TabIndex = 10;
            this.chartTemp.Text = "chartTemp";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(862, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 85);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chartTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChart";
            this.Text = "FormChart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chartTemp;
        private System.Windows.Forms.Button btnBack;
    }
}