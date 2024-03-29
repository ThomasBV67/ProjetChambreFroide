﻿
namespace UI_ChambreFroide_V1
{
    partial class FormConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listeCapteurs = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ensemble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niv_avertissement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niv_alerte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_decouverte = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.b_configSerie = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.infoPortActuel = new System.Windows.Forms.ToolStripStatusLabel();
            this.etatPortActuel = new System.Windows.Forms.ToolStripStatusLabel();
            this.b_ouvertureFermeturePort = new System.Windows.Forms.Button();
            this.b_up = new System.Windows.Forms.Button();
            this.b_modifyCapteur = new System.Windows.Forms.Button();
            this.b_down = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listeCapteurs)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listeCapteurs
            // 
            this.listeCapteurs.AllowUserToAddRows = false;
            this.listeCapteurs.AllowUserToOrderColumns = true;
            this.listeCapteurs.AllowUserToResizeColumns = false;
            this.listeCapteurs.AllowUserToResizeRows = false;
            this.listeCapteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeCapteurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.groupe,
            this.numero,
            this.nom,
            this.ensemble,
            this.niv_avertissement,
            this.niv_alerte});
            this.listeCapteurs.Cursor = System.Windows.Forms.Cursors.Cross;
            this.listeCapteurs.Location = new System.Drawing.Point(7, 26);
            this.listeCapteurs.Margin = new System.Windows.Forms.Padding(2);
            this.listeCapteurs.MultiSelect = false;
            this.listeCapteurs.Name = "listeCapteurs";
            this.listeCapteurs.RowHeadersVisible = false;
            this.listeCapteurs.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeCapteurs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.listeCapteurs.RowTemplate.Height = 35;
            this.listeCapteurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeCapteurs.Size = new System.Drawing.Size(797, 534);
            this.listeCapteurs.TabIndex = 0;
            // 
            // ID
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "Thermomètre";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 300;
            // 
            // groupe
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupe.DefaultCellStyle = dataGridViewCellStyle2;
            this.groupe.HeaderText = "# Gr";
            this.groupe.MinimumWidth = 6;
            this.groupe.Name = "groupe";
            this.groupe.Width = 45;
            // 
            // numero
            // 
            this.numero.HeaderText = "# Sous-Gr";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.Width = 45;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom de pièce";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.Width = 150;
            // 
            // ensemble
            // 
            this.ensemble.HeaderText = "Ensemble";
            this.ensemble.MinimumWidth = 6;
            this.ensemble.Name = "ensemble";
            this.ensemble.Width = 150;
            // 
            // niv_avertissement
            // 
            this.niv_avertissement.HeaderText = "Niveau d\'avertissement";
            this.niv_avertissement.MinimumWidth = 6;
            this.niv_avertissement.Name = "niv_avertissement";
            this.niv_avertissement.Width = 50;
            // 
            // niv_alerte
            // 
            this.niv_alerte.HeaderText = "Niveau d\'alerte";
            this.niv_alerte.MinimumWidth = 6;
            this.niv_alerte.Name = "niv_alerte";
            this.niv_alerte.Width = 50;
            // 
            // b_decouverte
            // 
            this.b_decouverte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_decouverte.Location = new System.Drawing.Point(809, 29);
            this.b_decouverte.Margin = new System.Windows.Forms.Padding(2);
            this.b_decouverte.Name = "b_decouverte";
            this.b_decouverte.Size = new System.Drawing.Size(100, 75);
            this.b_decouverte.TabIndex = 1;
            this.b_decouverte.Text = "Découvrir le réseau";
            this.b_decouverte.UseVisualStyleBackColor = true;
            this.b_decouverte.Click += new System.EventHandler(this.b_decouverte_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(915, 29);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 75);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // b_configSerie
            // 
            this.b_configSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_configSerie.Location = new System.Drawing.Point(809, 485);
            this.b_configSerie.Name = "b_configSerie";
            this.b_configSerie.Size = new System.Drawing.Size(100, 75);
            this.b_configSerie.TabIndex = 3;
            this.b_configSerie.Text = "Config du port série";
            this.b_configSerie.UseVisualStyleBackColor = true;
            this.b_configSerie.Click += new System.EventHandler(this.b_configSerie_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoPortActuel,
            this.etatPortActuel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1024, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // infoPortActuel
            // 
            this.infoPortActuel.Name = "infoPortActuel";
            this.infoPortActuel.Size = new System.Drawing.Size(118, 17);
            this.infoPortActuel.Text = "toolStripStatusLabel1";
            // 
            // etatPortActuel
            // 
            this.etatPortActuel.Name = "etatPortActuel";
            this.etatPortActuel.Size = new System.Drawing.Size(118, 17);
            this.etatPortActuel.Text = "toolStripStatusLabel2";
            // 
            // b_ouvertureFermeturePort
            // 
            this.b_ouvertureFermeturePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ouvertureFermeturePort.Location = new System.Drawing.Point(915, 485);
            this.b_ouvertureFermeturePort.Name = "b_ouvertureFermeturePort";
            this.b_ouvertureFermeturePort.Size = new System.Drawing.Size(100, 75);
            this.b_ouvertureFermeturePort.TabIndex = 5;
            this.b_ouvertureFermeturePort.Text = "Ouvrir le port";
            this.b_ouvertureFermeturePort.UseVisualStyleBackColor = true;
            this.b_ouvertureFermeturePort.Click += new System.EventHandler(this.b_ouvertureFermeturePort_Click);
            // 
            // b_up
            // 
            this.b_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_up.Location = new System.Drawing.Point(809, 108);
            this.b_up.Margin = new System.Windows.Forms.Padding(2);
            this.b_up.Name = "b_up";
            this.b_up.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.b_up.Size = new System.Drawing.Size(206, 130);
            this.b_up.TabIndex = 7;
            this.b_up.Text = "▲";
            this.b_up.UseVisualStyleBackColor = true;
            this.b_up.Click += new System.EventHandler(this.b_up_Click);
            // 
            // b_modifyCapteur
            // 
            this.b_modifyCapteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_modifyCapteur.Location = new System.Drawing.Point(809, 242);
            this.b_modifyCapteur.Margin = new System.Windows.Forms.Padding(2);
            this.b_modifyCapteur.Name = "b_modifyCapteur";
            this.b_modifyCapteur.Size = new System.Drawing.Size(206, 100);
            this.b_modifyCapteur.TabIndex = 8;
            this.b_modifyCapteur.Text = "Modifier\r\n";
            this.b_modifyCapteur.UseVisualStyleBackColor = true;
            this.b_modifyCapteur.Click += new System.EventHandler(this.b_modifyCapteur_Click);
            // 
            // b_down
            // 
            this.b_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_down.Location = new System.Drawing.Point(809, 346);
            this.b_down.Margin = new System.Windows.Forms.Padding(2);
            this.b_down.Name = "b_down";
            this.b_down.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.b_down.Size = new System.Drawing.Size(206, 130);
            this.b_down.TabIndex = 9;
            this.b_down.Text = "▼";
            this.b_down.UseVisualStyleBackColor = true;
            this.b_down.Click += new System.EventHandler(this.b_down_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.b_down);
            this.Controls.Add(this.b_modifyCapteur);
            this.Controls.Add(this.b_up);
            this.Controls.Add(this.b_ouvertureFermeturePort);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.b_configSerie);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.b_decouverte);
            this.Controls.Add(this.listeCapteurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfig";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.listeCapteurs)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_decouverte;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button b_configSerie;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel infoPortActuel;
        private System.Windows.Forms.ToolStripStatusLabel etatPortActuel;
        private System.Windows.Forms.Button b_ouvertureFermeturePort;
        public System.Windows.Forms.DataGridView listeCapteurs;
        private System.Windows.Forms.Button b_up;
        private System.Windows.Forms.Button b_modifyCapteur;
        private System.Windows.Forms.Button b_down;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ensemble;
        private System.Windows.Forms.DataGridViewTextBoxColumn niv_avertissement;
        private System.Windows.Forms.DataGridViewTextBoxColumn niv_alerte;
    }
}