
namespace UI_ChambreFroide_V1
{
    partial class FormTempCourantes
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
            this.b_historique = new System.Windows.Forms.Button();
            this.b_config = new System.Windows.Forms.Button();
            this.b_suivant = new System.Windows.Forms.Button();
            this.b_precedent = new System.Windows.Forms.Button();
            this.l_tempsRestant = new System.Windows.Forms.Label();
            this.panelTemp = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox11 = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBox12 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.richTextBox13 = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.richTextBox14 = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.richTextBox15 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox10 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.t_timeoutScan = new System.Windows.Forms.Timer(this.components);
            this.t_checkTemps = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.l_page = new System.Windows.Forms.Label();
            this.panelTemp.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_historique
            // 
            this.b_historique.Location = new System.Drawing.Point(401, 534);
            this.b_historique.Margin = new System.Windows.Forms.Padding(4);
            this.b_historique.Name = "b_historique";
            this.b_historique.Size = new System.Drawing.Size(204, 69);
            this.b_historique.TabIndex = 38;
            this.b_historique.Text = "Historique";
            this.b_historique.UseVisualStyleBackColor = true;
            this.b_historique.Click += new System.EventHandler(this.b_historique_Click);
            // 
            // b_config
            // 
            this.b_config.Location = new System.Drawing.Point(759, 535);
            this.b_config.Margin = new System.Windows.Forms.Padding(4);
            this.b_config.Name = "b_config";
            this.b_config.Size = new System.Drawing.Size(203, 68);
            this.b_config.TabIndex = 39;
            this.b_config.Text = "Configuration...";
            this.b_config.UseVisualStyleBackColor = true;
            this.b_config.Click += new System.EventHandler(this.b_config_Click);
            // 
            // b_suivant
            // 
            this.b_suivant.Location = new System.Drawing.Point(1101, 535);
            this.b_suivant.Margin = new System.Windows.Forms.Padding(4);
            this.b_suivant.Name = "b_suivant";
            this.b_suivant.Size = new System.Drawing.Size(203, 69);
            this.b_suivant.TabIndex = 37;
            this.b_suivant.Text = "Suivant -->";
            this.b_suivant.UseVisualStyleBackColor = true;
            this.b_suivant.Click += new System.EventHandler(this.b_suivant_Click);
            // 
            // b_precedent
            // 
            this.b_precedent.Location = new System.Drawing.Point(59, 535);
            this.b_precedent.Margin = new System.Windows.Forms.Padding(4);
            this.b_precedent.Name = "b_precedent";
            this.b_precedent.Size = new System.Drawing.Size(204, 69);
            this.b_precedent.TabIndex = 36;
            this.b_precedent.Text = "<-- Précédent";
            this.b_precedent.UseVisualStyleBackColor = true;
            this.b_precedent.Click += new System.EventHandler(this.b_precedent_Click);
            // 
            // l_tempsRestant
            // 
            this.l_tempsRestant.AutoSize = true;
            this.l_tempsRestant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.l_tempsRestant.Location = new System.Drawing.Point(152, 677);
            this.l_tempsRestant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_tempsRestant.Name = "l_tempsRestant";
            this.l_tempsRestant.Size = new System.Drawing.Size(419, 29);
            this.l_tempsRestant.TabIndex = 35;
            this.l_tempsRestant.Text = "Temps avant la prochaine mise à jour:";
            // 
            // panelTemp
            // 
            this.panelTemp.Controls.Add(this.label11);
            this.panelTemp.Controls.Add(this.richTextBox11);
            this.panelTemp.Controls.Add(this.label12);
            this.panelTemp.Controls.Add(this.richTextBox12);
            this.panelTemp.Controls.Add(this.label13);
            this.panelTemp.Controls.Add(this.richTextBox13);
            this.panelTemp.Controls.Add(this.label14);
            this.panelTemp.Controls.Add(this.richTextBox14);
            this.panelTemp.Controls.Add(this.label15);
            this.panelTemp.Controls.Add(this.richTextBox15);
            this.panelTemp.Controls.Add(this.label6);
            this.panelTemp.Controls.Add(this.richTextBox6);
            this.panelTemp.Controls.Add(this.label7);
            this.panelTemp.Controls.Add(this.richTextBox7);
            this.panelTemp.Controls.Add(this.label8);
            this.panelTemp.Controls.Add(this.richTextBox8);
            this.panelTemp.Controls.Add(this.label9);
            this.panelTemp.Controls.Add(this.richTextBox9);
            this.panelTemp.Controls.Add(this.label10);
            this.panelTemp.Controls.Add(this.richTextBox10);
            this.panelTemp.Controls.Add(this.label5);
            this.panelTemp.Controls.Add(this.richTextBox5);
            this.panelTemp.Controls.Add(this.label4);
            this.panelTemp.Controls.Add(this.richTextBox4);
            this.panelTemp.Controls.Add(this.label3);
            this.panelTemp.Controls.Add(this.richTextBox3);
            this.panelTemp.Controls.Add(this.label2);
            this.panelTemp.Controls.Add(this.richTextBox2);
            this.panelTemp.Controls.Add(this.label1);
            this.panelTemp.Controls.Add(this.richTextBox1);
            this.panelTemp.Location = new System.Drawing.Point(5, 14);
            this.panelTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTemp.Name = "panelTemp";
            this.panelTemp.Size = new System.Drawing.Size(1345, 503);
            this.panelTemp.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label11.Location = new System.Drawing.Point(1088, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 39);
            this.label11.TabIndex = 28;
            this.label11.Text = "NOM_PIECE";
            // 
            // richTextBox11
            // 
            this.richTextBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F);
            this.richTextBox11.Location = new System.Drawing.Point(1096, 378);
            this.richTextBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox11.Name = "richTextBox11";
            this.richTextBox11.Size = new System.Drawing.Size(241, 89);
            this.richTextBox11.TabIndex = 29;
            this.richTextBox11.Text = "-XX.X°";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label12.Location = new System.Drawing.Point(816, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(220, 39);
            this.label12.TabIndex = 26;
            this.label12.Text = "NOM_PIECE";
            // 
            // richTextBox12
            // 
            this.richTextBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F);
            this.richTextBox12.Location = new System.Drawing.Point(824, 378);
            this.richTextBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox12.Name = "richTextBox12";
            this.richTextBox12.Size = new System.Drawing.Size(239, 89);
            this.richTextBox12.TabIndex = 27;
            this.richTextBox12.Text = "-XX.X°";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label13.Location = new System.Drawing.Point(545, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 39);
            this.label13.TabIndex = 24;
            this.label13.Text = "NOM_PIECE";
            // 
            // richTextBox13
            // 
            this.richTextBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F);
            this.richTextBox13.Location = new System.Drawing.Point(553, 378);
            this.richTextBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox13.Name = "richTextBox13";
            this.richTextBox13.Size = new System.Drawing.Size(239, 89);
            this.richTextBox13.TabIndex = 25;
            this.richTextBox13.Text = "-XX.X°";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label14.Location = new System.Drawing.Point(269, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(220, 39);
            this.label14.TabIndex = 22;
            this.label14.Text = "NOM_PIECE";
            // 
            // richTextBox14
            // 
            this.richTextBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F);
            this.richTextBox14.Location = new System.Drawing.Point(277, 378);
            this.richTextBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox14.Name = "richTextBox14";
            this.richTextBox14.Size = new System.Drawing.Size(239, 89);
            this.richTextBox14.TabIndex = 23;
            this.richTextBox14.Text = "-XX.X°";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label15.Location = new System.Drawing.Point(7, 336);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(220, 39);
            this.label15.TabIndex = 20;
            this.label15.Text = "NOM_PIECE";
            // 
            // richTextBox15
            // 
            this.richTextBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F);
            this.richTextBox15.Location = new System.Drawing.Point(15, 378);
            this.richTextBox15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox15.Name = "richTextBox15";
            this.richTextBox15.Size = new System.Drawing.Size(239, 89);
            this.richTextBox15.TabIndex = 21;
            this.richTextBox15.Text = "-XX.X°";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label6.Location = new System.Drawing.Point(1088, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 39);
            this.label6.TabIndex = 18;
            this.label6.Text = "NOM_PIECE";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F);
            this.richTextBox6.Location = new System.Drawing.Point(1096, 226);
            this.richTextBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(241, 89);
            this.richTextBox6.TabIndex = 19;
            this.richTextBox6.Text = "-XX.X°";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label7.Location = new System.Drawing.Point(816, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 39);
            this.label7.TabIndex = 16;
            this.label7.Text = "NOM_PIECE";
            // 
            // richTextBox7
            // 
            this.richTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F);
            this.richTextBox7.Location = new System.Drawing.Point(824, 226);
            this.richTextBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(239, 89);
            this.richTextBox7.TabIndex = 17;
            this.richTextBox7.Text = "-XX.X°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label8.Location = new System.Drawing.Point(545, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 39);
            this.label8.TabIndex = 14;
            this.label8.Text = "NOM_PIECE";
            // 
            // richTextBox8
            // 
            this.richTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F);
            this.richTextBox8.Location = new System.Drawing.Point(553, 226);
            this.richTextBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(239, 89);
            this.richTextBox8.TabIndex = 15;
            this.richTextBox8.Text = "-XX.X°";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label9.Location = new System.Drawing.Point(269, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 39);
            this.label9.TabIndex = 12;
            this.label9.Text = "NOM_PIECE";
            // 
            // richTextBox9
            // 
            this.richTextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F);
            this.richTextBox9.Location = new System.Drawing.Point(277, 226);
            this.richTextBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.Size = new System.Drawing.Size(239, 89);
            this.richTextBox9.TabIndex = 13;
            this.richTextBox9.Text = "-XX.X°";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label10.Location = new System.Drawing.Point(9, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 39);
            this.label10.TabIndex = 10;
            this.label10.Text = "NOM_PIECE";
            // 
            // richTextBox10
            // 
            this.richTextBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F);
            this.richTextBox10.Location = new System.Drawing.Point(17, 226);
            this.richTextBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox10.Name = "richTextBox10";
            this.richTextBox10.Size = new System.Drawing.Size(239, 89);
            this.richTextBox10.TabIndex = 11;
            this.richTextBox10.Text = "-XX.X°";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label5.Location = new System.Drawing.Point(1088, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "NOM_PIECE";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F);
            this.richTextBox5.Location = new System.Drawing.Point(1096, 84);
            this.richTextBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(241, 89);
            this.richTextBox5.TabIndex = 9;
            this.richTextBox5.Text = "-XX.X°";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label4.Location = new System.Drawing.Point(816, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "NOM_PIECE";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F);
            this.richTextBox4.Location = new System.Drawing.Point(824, 84);
            this.richTextBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(239, 89);
            this.richTextBox4.TabIndex = 7;
            this.richTextBox4.Text = "-XX.X°";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label3.Location = new System.Drawing.Point(545, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOM_PIECE";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F);
            this.richTextBox3.Location = new System.Drawing.Point(553, 84);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(239, 89);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "-XX.X°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label2.Location = new System.Drawing.Point(269, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOM_PIECE";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F);
            this.richTextBox2.Location = new System.Drawing.Point(277, 84);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(239, 89);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "-XX.X°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOM_PIECE";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42.75F);
            this.richTextBox1.Location = new System.Drawing.Point(17, 84);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(239, 89);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "-XX.X°";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.getLoRa);
            // 
            // t_timeoutScan
            // 
            this.t_timeoutScan.Interval = 2000;
            this.t_timeoutScan.Tick += new System.EventHandler(this.t_timeoutScan_Tick);
            // 
            // t_checkTemps
            // 
            this.t_checkTemps.Enabled = true;
            this.t_checkTemps.Interval = 1000;
            this.t_checkTemps.Tick += new System.EventHandler(this.t_checkTemps_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1101, 635);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 66);
            this.button1.TabIndex = 41;
            this.button1.Text = "lire maintenant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.lireMaintenant);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 619);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 17);
            this.label16.TabIndex = 42;
            this.label16.Text = "label16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 635);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 17);
            this.label17.TabIndex = 43;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 651);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 17);
            this.label18.TabIndex = 44;
            this.label18.Text = "label18";
            // 
            // l_page
            // 
            this.l_page.AutoSize = true;
            this.l_page.Location = new System.Drawing.Point(647, 561);
            this.l_page.Name = "l_page";
            this.l_page.Size = new System.Drawing.Size(67, 17);
            this.l_page.TabIndex = 45;
            this.l_page.Text = "Page X/Y";
            // 
            // FormTempCourantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 738);
            this.Controls.Add(this.l_page);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_historique);
            this.Controls.Add(this.b_config);
            this.Controls.Add(this.b_suivant);
            this.Controls.Add(this.b_precedent);
            this.Controls.Add(this.l_tempsRestant);
            this.Controls.Add(this.panelTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTempCourantes";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTempCourantes_Load);
            this.panelTemp.ResumeLayout(false);
            this.panelTemp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_historique;
        private System.Windows.Forms.Button b_config;
        private System.Windows.Forms.Button b_suivant;
        private System.Windows.Forms.Button b_precedent;
        private System.Windows.Forms.Label l_tempsRestant;
        private System.Windows.Forms.Panel panelTemp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextBox13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox richTextBox14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox richTextBox15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.Timer t_timeoutScan;
        private System.Windows.Forms.Timer t_checkTemps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label l_page;
    }
}

