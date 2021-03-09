namespace UI_ChambreFroide_V1
{
    partial class FormChoixPlageTemps
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
            this.btnLastDay = new System.Windows.Forms.Button();
            this.btnLastWeek = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLastDay
            // 
            this.btnLastDay.Location = new System.Drawing.Point(49, 131);
            this.btnLastDay.Name = "btnLastDay";
            this.btnLastDay.Size = new System.Drawing.Size(199, 90);
            this.btnLastDay.TabIndex = 0;
            this.btnLastDay.Text = "Dernier jour";
            this.btnLastDay.UseVisualStyleBackColor = true;
            // 
            // btnLastWeek
            // 
            this.btnLastWeek.Location = new System.Drawing.Point(49, 227);
            this.btnLastWeek.Name = "btnLastWeek";
            this.btnLastWeek.Size = new System.Drawing.Size(199, 90);
            this.btnLastWeek.TabIndex = 1;
            this.btnLastWeek.Text = "Dernière semaine";
            this.btnLastWeek.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(49, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 90);
            this.button3.TabIndex = 2;
            this.button3.Text = "Dernier mois";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormChoixPlageTemps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLastWeek);
            this.Controls.Add(this.btnLastDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChoixPlageTemps";
            this.Text = "FormChoixPlageTemps";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLastDay;
        private System.Windows.Forms.Button btnLastWeek;
        private System.Windows.Forms.Button button3;
    }
}