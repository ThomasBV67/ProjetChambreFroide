namespace UI_ChambreFroide_V1
{
    partial class Configuration
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_appliquer = new System.Windows.Forms.Button();
            this.cb_stop = new System.Windows.Forms.ComboBox();
            this.cb_nbBits = new System.Windows.Forms.ComboBox();
            this.cb_par = new System.Windows.Forms.ComboBox();
            this.cb_vitesse = new System.Windows.Forms.ComboBox();
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.l_stopBit = new System.Windows.Forms.Label();
            this.l_nbBits = new System.Windows.Forms.Label();
            this.l_par = new System.Windows.Forms.Label();
            this.l_baud = new System.Windows.Forms.Label();
            this.l_port = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.b_cancel);
            this.panel2.Controls.Add(this.b_appliquer);
            this.panel2.Controls.Add(this.cb_stop);
            this.panel2.Controls.Add(this.cb_nbBits);
            this.panel2.Controls.Add(this.cb_par);
            this.panel2.Controls.Add(this.cb_vitesse);
            this.panel2.Controls.Add(this.cb_port);
            this.panel2.Controls.Add(this.l_stopBit);
            this.panel2.Controls.Add(this.l_nbBits);
            this.panel2.Controls.Add(this.l_par);
            this.panel2.Controls.Add(this.l_baud);
            this.panel2.Controls.Add(this.l_port);
            this.panel2.Location = new System.Drawing.Point(63, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 337);
            this.panel2.TabIndex = 7;
            // 
            // b_cancel
            // 
            this.b_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_cancel.Location = new System.Drawing.Point(150, 250);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 11;
            this.b_cancel.Text = "Annuler";
            this.b_cancel.UseVisualStyleBackColor = true;
            // 
            // b_appliquer
            // 
            this.b_appliquer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.b_appliquer.Location = new System.Drawing.Point(22, 250);
            this.b_appliquer.Name = "b_appliquer";
            this.b_appliquer.Size = new System.Drawing.Size(81, 23);
            this.b_appliquer.TabIndex = 10;
            this.b_appliquer.Text = "OK";
            this.b_appliquer.UseVisualStyleBackColor = true;
            this.b_appliquer.Click += new System.EventHandler(this.b_appliquer_Click);
            // 
            // cb_stop
            // 
            this.cb_stop.FormattingEnabled = true;
            this.cb_stop.Location = new System.Drawing.Point(150, 201);
            this.cb_stop.Name = "cb_stop";
            this.cb_stop.Size = new System.Drawing.Size(121, 24);
            this.cb_stop.TabIndex = 9;
            // 
            // cb_nbBits
            // 
            this.cb_nbBits.FormattingEnabled = true;
            this.cb_nbBits.Location = new System.Drawing.Point(150, 159);
            this.cb_nbBits.Name = "cb_nbBits";
            this.cb_nbBits.Size = new System.Drawing.Size(121, 24);
            this.cb_nbBits.TabIndex = 8;
            // 
            // cb_par
            // 
            this.cb_par.FormattingEnabled = true;
            this.cb_par.Location = new System.Drawing.Point(150, 121);
            this.cb_par.Name = "cb_par";
            this.cb_par.Size = new System.Drawing.Size(121, 24);
            this.cb_par.TabIndex = 7;
            // 
            // cb_vitesse
            // 
            this.cb_vitesse.FormattingEnabled = true;
            this.cb_vitesse.Location = new System.Drawing.Point(150, 77);
            this.cb_vitesse.Name = "cb_vitesse";
            this.cb_vitesse.Size = new System.Drawing.Size(121, 24);
            this.cb_vitesse.TabIndex = 6;
            // 
            // cb_port
            // 
            this.cb_port.FormattingEnabled = true;
            this.cb_port.Location = new System.Drawing.Point(150, 37);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(121, 24);
            this.cb_port.TabIndex = 5;
            // 
            // l_stopBit
            // 
            this.l_stopBit.AutoSize = true;
            this.l_stopBit.Location = new System.Drawing.Point(19, 204);
            this.l_stopBit.Name = "l_stopBit";
            this.l_stopBit.Size = new System.Drawing.Size(73, 17);
            this.l_stopBit.TabIndex = 4;
            this.l_stopBit.Text = "Bit d\'arret:";
            // 
            // l_nbBits
            // 
            this.l_nbBits.AutoSize = true;
            this.l_nbBits.Location = new System.Drawing.Point(19, 162);
            this.l_nbBits.Name = "l_nbBits";
            this.l_nbBits.Size = new System.Drawing.Size(56, 17);
            this.l_nbBits.TabIndex = 3;
            this.l_nbBits.Text = "Nb bits:";
            // 
            // l_par
            // 
            this.l_par.AutoSize = true;
            this.l_par.Location = new System.Drawing.Point(16, 124);
            this.l_par.Name = "l_par";
            this.l_par.Size = new System.Drawing.Size(49, 17);
            this.l_par.TabIndex = 2;
            this.l_par.Text = "Parité:";
            // 
            // l_baud
            // 
            this.l_baud.AutoSize = true;
            this.l_baud.Location = new System.Drawing.Point(16, 80);
            this.l_baud.Name = "l_baud";
            this.l_baud.Size = new System.Drawing.Size(58, 17);
            this.l_baud.TabIndex = 1;
            this.l_baud.Text = "Vitesse:";
            // 
            // l_port
            // 
            this.l_port.AutoSize = true;
            this.l_port.Location = new System.Drawing.Point(16, 37);
            this.l_port.Name = "l_port";
            this.l_port.Size = new System.Drawing.Size(38, 17);
            this.l_port.TabIndex = 0;
            this.l_port.Text = "Port:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.MAJPorts);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.panel2);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button b_appliquer;
        private System.Windows.Forms.ComboBox cb_stop;
        private System.Windows.Forms.ComboBox cb_nbBits;
        private System.Windows.Forms.ComboBox cb_par;
        private System.Windows.Forms.ComboBox cb_vitesse;
        private System.Windows.Forms.ComboBox cb_port;
        private System.Windows.Forms.Label l_stopBit;
        private System.Windows.Forms.Label l_nbBits;
        private System.Windows.Forms.Label l_par;
        private System.Windows.Forms.Label l_baud;
        private System.Windows.Forms.Label l_port;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Timer timer1;
    }
}