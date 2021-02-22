
namespace UI_ChambreFroide_V1
{
    partial class FormModifCapteur
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
            this.btnModifNom = new System.Windows.Forms.Button();
            this.lbTitre = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.btnModifGroupe = new System.Windows.Forms.Button();
            this.btnModifWarning = new System.Windows.Forms.Button();
            this.btnModifAlerte = new System.Windows.Forms.Button();
            this.lbGroupe = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.lbAlerte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModifNom
            // 
            this.btnModifNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifNom.Location = new System.Drawing.Point(106, 128);
            this.btnModifNom.Name = "btnModifNom";
            this.btnModifNom.Size = new System.Drawing.Size(360, 90);
            this.btnModifNom.TabIndex = 0;
            this.btnModifNom.Text = "Nom du capteur\r\n";
            this.btnModifNom.UseVisualStyleBackColor = true;
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(173, 33);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(670, 55);
            this.lbTitre.TabIndex = 1;
            this.lbTitre.Text = "Choix du paramètre à modifier";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(526, 155);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(113, 37);
            this.lbNom.TabIndex = 2;
            this.lbNom.Text = "Nom : ";
            // 
            // btnModifGroupe
            // 
            this.btnModifGroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifGroupe.Location = new System.Drawing.Point(106, 233);
            this.btnModifGroupe.Name = "btnModifGroupe";
            this.btnModifGroupe.Size = new System.Drawing.Size(360, 90);
            this.btnModifGroupe.TabIndex = 3;
            this.btnModifGroupe.Text = "Groupe du capteur\r\n";
            this.btnModifGroupe.UseVisualStyleBackColor = true;
            this.btnModifGroupe.Click += new System.EventHandler(this.btnModifGroupe_Click);
            // 
            // btnModifWarning
            // 
            this.btnModifWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifWarning.Location = new System.Drawing.Point(106, 341);
            this.btnModifWarning.Name = "btnModifWarning";
            this.btnModifWarning.Size = new System.Drawing.Size(360, 90);
            this.btnModifWarning.TabIndex = 4;
            this.btnModifWarning.Text = "Niveau d\'avertissement";
            this.btnModifWarning.UseVisualStyleBackColor = true;
            // 
            // btnModifAlerte
            // 
            this.btnModifAlerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifAlerte.Location = new System.Drawing.Point(106, 447);
            this.btnModifAlerte.Name = "btnModifAlerte";
            this.btnModifAlerte.Size = new System.Drawing.Size(360, 90);
            this.btnModifAlerte.TabIndex = 5;
            this.btnModifAlerte.Text = "Niveau d\'alerte";
            this.btnModifAlerte.UseVisualStyleBackColor = true;
            // 
            // lbGroupe
            // 
            this.lbGroupe.AutoSize = true;
            this.lbGroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroupe.Location = new System.Drawing.Point(526, 260);
            this.lbGroupe.Name = "lbGroupe";
            this.lbGroupe.Size = new System.Drawing.Size(151, 37);
            this.lbGroupe.TabIndex = 6;
            this.lbGroupe.Text = "Groupe : ";
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarning.Location = new System.Drawing.Point(526, 368);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(374, 37);
            this.lbWarning.TabIndex = 7;
            this.lbWarning.Text = "Niveau d\'avertissement : ";
            // 
            // lbAlerte
            // 
            this.lbAlerte.AutoSize = true;
            this.lbAlerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlerte.Location = new System.Drawing.Point(526, 474);
            this.lbAlerte.Name = "lbAlerte";
            this.lbAlerte.Size = new System.Drawing.Size(256, 37);
            this.lbAlerte.TabIndex = 8;
            this.lbAlerte.Text = "Niveau d\'alerte : ";
            // 
            // FormModifCapteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.lbAlerte);
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.lbGroupe);
            this.Controls.Add(this.btnModifAlerte);
            this.Controls.Add(this.btnModifWarning);
            this.Controls.Add(this.btnModifGroupe);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lbTitre);
            this.Controls.Add(this.btnModifNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModifCapteur";
            this.Text = "FormModifCapteur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifNom;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Button btnModifGroupe;
        private System.Windows.Forms.Button btnModifWarning;
        private System.Windows.Forms.Button btnModifAlerte;
        private System.Windows.Forms.Label lbGroupe;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label lbAlerte;
    }
}