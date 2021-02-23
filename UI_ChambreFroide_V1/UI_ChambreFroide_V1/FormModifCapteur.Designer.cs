
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModifNom
            // 
            this.btnModifNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifNom.Location = new System.Drawing.Point(50, 101);
            this.btnModifNom.Name = "btnModifNom";
            this.btnModifNom.Size = new System.Drawing.Size(360, 90);
            this.btnModifNom.TabIndex = 0;
            this.btnModifNom.Text = "Nom du capteur\r\n";
            this.btnModifNom.UseVisualStyleBackColor = true;
            this.btnModifNom.Click += new System.EventHandler(this.btnModifNom_Click);
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(40, 29);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(670, 55);
            this.lbTitre.TabIndex = 1;
            this.lbTitre.Text = "Choix du paramètre à modifier";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(459, 138);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(113, 37);
            this.lbNom.TabIndex = 2;
            this.lbNom.Text = "Nom : ";
            // 
            // btnModifGroupe
            // 
            this.btnModifGroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifGroupe.Location = new System.Drawing.Point(50, 197);
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
            this.btnModifWarning.Location = new System.Drawing.Point(50, 293);
            this.btnModifWarning.Name = "btnModifWarning";
            this.btnModifWarning.Size = new System.Drawing.Size(360, 90);
            this.btnModifWarning.TabIndex = 4;
            this.btnModifWarning.Text = "Niveau d\'avertissement";
            this.btnModifWarning.UseVisualStyleBackColor = true;
            this.btnModifWarning.Click += new System.EventHandler(this.btnModifWarning_Click);
            // 
            // btnModifAlerte
            // 
            this.btnModifAlerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifAlerte.Location = new System.Drawing.Point(50, 389);
            this.btnModifAlerte.Name = "btnModifAlerte";
            this.btnModifAlerte.Size = new System.Drawing.Size(360, 90);
            this.btnModifAlerte.TabIndex = 5;
            this.btnModifAlerte.Text = "Niveau d\'alerte";
            this.btnModifAlerte.UseVisualStyleBackColor = true;
            this.btnModifAlerte.Click += new System.EventHandler(this.btnModifAlerte_Click);
            // 
            // lbGroupe
            // 
            this.lbGroupe.AutoSize = true;
            this.lbGroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroupe.Location = new System.Drawing.Point(459, 234);
            this.lbGroupe.Name = "lbGroupe";
            this.lbGroupe.Size = new System.Drawing.Size(151, 37);
            this.lbGroupe.TabIndex = 6;
            this.lbGroupe.Text = "Groupe : ";
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarning.Location = new System.Drawing.Point(459, 330);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(374, 37);
            this.lbWarning.TabIndex = 7;
            this.lbWarning.Text = "Niveau d\'avertissement : ";
            // 
            // lbAlerte
            // 
            this.lbAlerte.AutoSize = true;
            this.lbAlerte.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlerte.Location = new System.Drawing.Point(459, 426);
            this.lbAlerte.Name = "lbAlerte";
            this.lbAlerte.Size = new System.Drawing.Size(256, 37);
            this.lbAlerte.TabIndex = 8;
            this.lbAlerte.Text = "Niveau d\'alerte : ";
            // 
            // btnRetour
            // 
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(769, 13);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(243, 86);
            this.btnRetour.TabIndex = 9;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(50, 485);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(360, 90);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "Appliquer";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // FormModifCapteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnRetour);
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
            this.Load += new System.EventHandler(this.FormModifCapteur_Load);
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
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnApply;
    }
}