
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ensemble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niv_avertissement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niv_alerte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_decouverte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.goupe,
            this.numero,
            this.nom,
            this.ensemble,
            this.niv_avertissement,
            this.niv_alerte});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 714);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "Thermomètre";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // goupe
            // 
            this.goupe.HeaderText = "Numéro de Groupe";
            this.goupe.MinimumWidth = 6;
            this.goupe.Name = "goupe";
            this.goupe.ReadOnly = true;
            this.goupe.Width = 125;
            // 
            // numero
            // 
            this.numero.HeaderText = "Numéro de Sous-Groupe";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 125;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom de pièce";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.Width = 125;
            // 
            // ensemble
            // 
            this.ensemble.HeaderText = "Ensemble";
            this.ensemble.MinimumWidth = 6;
            this.ensemble.Name = "ensemble";
            this.ensemble.Width = 125;
            // 
            // niv_avertissement
            // 
            this.niv_avertissement.HeaderText = "Niveau d\'avertissement";
            this.niv_avertissement.MinimumWidth = 6;
            this.niv_avertissement.Name = "niv_avertissement";
            this.niv_avertissement.Width = 125;
            // 
            // niv_alerte
            // 
            this.niv_alerte.HeaderText = "Niveau d\'alerte";
            this.niv_alerte.MinimumWidth = 6;
            this.niv_alerte.Name = "niv_alerte";
            this.niv_alerte.Width = 125;
            // 
            // b_decouverte
            // 
            this.b_decouverte.Location = new System.Drawing.Point(1065, 81);
            this.b_decouverte.Name = "b_decouverte";
            this.b_decouverte.Size = new System.Drawing.Size(189, 79);
            this.b_decouverte.TabIndex = 1;
            this.b_decouverte.Text = "Découvrir le réseau";
            this.b_decouverte.UseVisualStyleBackColor = true;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 738);
            this.Controls.Add(this.b_decouverte);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormConfig";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn goupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ensemble;
        private System.Windows.Forms.DataGridViewTextBoxColumn niv_avertissement;
        private System.Windows.Forms.DataGridViewTextBoxColumn niv_alerte;
        private System.Windows.Forms.Button b_decouverte;
    }
}