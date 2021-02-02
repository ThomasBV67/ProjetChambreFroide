
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateCapteurs
            // 
            this.btnUpdateCapteurs.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdateCapteurs.Location = new System.Drawing.Point(813, 89);
            this.btnUpdateCapteurs.Name = "btnUpdateCapteurs";
            this.btnUpdateCapteurs.Size = new System.Drawing.Size(143, 86);
            this.btnUpdateCapteurs.TabIndex = 0;
            this.btnUpdateCapteurs.Text = "Update liste capteurs";
            this.btnUpdateCapteurs.UseVisualStyleBackColor = true;
            this.btnUpdateCapteurs.Click += new System.EventHandler(this.btnUpdateCapteurs_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 490);
            this.dataGridView1.TabIndex = 1;
            // 
            // FormChoixCapteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdateCapteurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChoixCapteur";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateCapteurs;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}