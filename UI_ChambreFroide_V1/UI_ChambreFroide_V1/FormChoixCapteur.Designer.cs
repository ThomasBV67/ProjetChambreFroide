
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.listBoxChoixCapteur = new System.Windows.Forms.ListBox();
            this.btnGroupName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(813, 438);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 86);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUp
            // 
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(813, 150);
            this.btnUp.Name = "btnUp";
            this.btnUp.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnUp.Size = new System.Drawing.Size(143, 86);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(813, 334);
            this.btnDown.Name = "btnDown";
            this.btnDown.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnDown.Size = new System.Drawing.Size(143, 86);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(813, 242);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnSelect.Size = new System.Drawing.Size(143, 86);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "⬤";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // listBoxChoixCapteur
            // 
            this.listBoxChoixCapteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxChoixCapteur.FormattingEnabled = true;
            this.listBoxChoixCapteur.ItemHeight = 31;
            this.listBoxChoixCapteur.Location = new System.Drawing.Point(22, 12);
            this.listBoxChoixCapteur.Name = "listBoxChoixCapteur";
            this.listBoxChoixCapteur.Size = new System.Drawing.Size(727, 531);
            this.listBoxChoixCapteur.TabIndex = 6;
            // 
            // btnGroupName
            // 
            this.btnGroupName.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupName.Location = new System.Drawing.Point(813, 44);
            this.btnGroupName.Name = "btnGroupName";
            this.btnGroupName.Size = new System.Drawing.Size(143, 86);
            this.btnGroupName.TabIndex = 7;
            this.btnGroupName.Text = "Groupes";
            this.btnGroupName.UseVisualStyleBackColor = true;
            this.btnGroupName.Click += new System.EventHandler(this.btnGroupName_Click);
            // 
            // FormChoixCapteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 572);
            this.Controls.Add(this.btnGroupName);
            this.Controls.Add(this.listBoxChoixCapteur);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChoixCapteur";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormChoixCapteur_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox listBoxChoixCapteur;
        private System.Windows.Forms.Button btnGroupName;
    }
}