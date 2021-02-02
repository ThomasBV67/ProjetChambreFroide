
namespace UI_ChambreFroide_V1
{
    partial class FormChoixCapteur
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
            this.btnUpdateCapteurs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateCapteurs
            // 
            this.btnUpdateCapteurs.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdateCapteurs.Location = new System.Drawing.Point(409, 218);
            this.btnUpdateCapteurs.Name = "btnUpdateCapteurs";
            this.btnUpdateCapteurs.Size = new System.Drawing.Size(143, 86);
            this.btnUpdateCapteurs.TabIndex = 0;
            this.btnUpdateCapteurs.Text = "Update liste capteurs";
            this.btnUpdateCapteurs.UseVisualStyleBackColor = true;
            this.btnUpdateCapteurs.Click += new System.EventHandler(this.btnUpdateCapteurs_Click);
            // 
            // FormChoixCapteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.btnUpdateCapteurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChoixCapteur";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateCapteurs;
    }
}