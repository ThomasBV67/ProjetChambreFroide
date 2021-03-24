
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMoreOptions = new System.Windows.Forms.Button();
            this.btnLastDay = new System.Windows.Forms.Button();
            this.btnLastWeek = new System.Windows.Forms.Button();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.btnGroupName = new System.Windows.Forms.Button();
            this.listBoxChoixCapteur = new System.Windows.Forms.ListBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.btnMoreOptions.Location = new System.Drawing.Point(862, 438);
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
            this.btnLastDay.Location = new System.Drawing.Point(862, 165);
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
            this.btnLastWeek.Location = new System.Drawing.Point(862, 256);
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
            this.btnLastMonth.Location = new System.Drawing.Point(862, 347);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(150, 85);
            this.btnLastMonth.TabIndex = 8;
            this.btnLastMonth.Text = "Dernier mois";
            this.btnLastMonth.UseVisualStyleBackColor = true;
            this.btnLastMonth.Click += new System.EventHandler(this.timeframeBtns_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(36, 24);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(784, 73);
            this.labelTitre.TabIndex = 15;
            this.labelTitre.Text = "Choix du capteur à étudier";
            // 
            // btnGroupName
            // 
            this.btnGroupName.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupName.Location = new System.Drawing.Point(713, 299);
            this.btnGroupName.Name = "btnGroupName";
            this.btnGroupName.Size = new System.Drawing.Size(143, 89);
            this.btnGroupName.TabIndex = 14;
            this.btnGroupName.Text = "Groupes";
            this.btnGroupName.UseVisualStyleBackColor = true;
            this.btnGroupName.Click += new System.EventHandler(this.btnGroupName_Click);
            // 
            // listBoxChoixCapteur
            // 
            this.listBoxChoixCapteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxChoixCapteur.FormattingEnabled = true;
            this.listBoxChoixCapteur.ItemHeight = 42;
            this.listBoxChoixCapteur.Location = new System.Drawing.Point(12, 115);
            this.listBoxChoixCapteur.Name = "listBoxChoixCapteur";
            this.listBoxChoixCapteur.Size = new System.Drawing.Size(695, 466);
            this.listBoxChoixCapteur.TabIndex = 13;
            // 
            // btnDown
            // 
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(713, 394);
            this.btnDown.Name = "btnDown";
            this.btnDown.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnDown.Size = new System.Drawing.Size(143, 86);
            this.btnDown.TabIndex = 11;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(713, 210);
            this.btnUp.Name = "btnUp";
            this.btnUp.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnUp.Size = new System.Drawing.Size(143, 86);
            this.btnUp.TabIndex = 10;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // FormHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.btnGroupName);
            this.Controls.Add(this.listBoxChoixCapteur);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnLastMonth);
            this.Controls.Add(this.btnLastWeek);
            this.Controls.Add(this.btnLastDay);
            this.Controls.Add(this.btnMoreOptions);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistorique";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMoreOptions;
        private System.Windows.Forms.Button btnLastDay;
        private System.Windows.Forms.Button btnLastWeek;
        private System.Windows.Forms.Button btnLastMonth;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button btnGroupName;
        private System.Windows.Forms.ListBox listBoxChoixCapteur;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
    }
}