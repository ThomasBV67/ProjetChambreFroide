namespace UI_ChambreFroide_V1
{
    partial class FormChoixPlageTemps
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
            this.btnStartDayUp = new System.Windows.Forms.Button();
            this.tbDateStart = new System.Windows.Forms.TextBox();
            this.lbDebutGraph = new System.Windows.Forms.Label();
            this.lbStartDay = new System.Windows.Forms.Label();
            this.lbStartMonth = new System.Windows.Forms.Label();
            this.lbStartYear = new System.Windows.Forms.Label();
            this.lbStartHour = new System.Windows.Forms.Label();
            this.lbStartMin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStartMinDown = new System.Windows.Forms.Button();
            this.btnStartHourDown = new System.Windows.Forms.Button();
            this.btnStartYearDown = new System.Windows.Forms.Button();
            this.btnStartMonthDown = new System.Windows.Forms.Button();
            this.btnStartMinUp = new System.Windows.Forms.Button();
            this.btnStartHourUp = new System.Windows.Forms.Button();
            this.btnStartYearUp = new System.Windows.Forms.Button();
            this.btnStartMonthUp = new System.Windows.Forms.Button();
            this.btnStartDayDown = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEndMinDown = new System.Windows.Forms.Button();
            this.btnEndHourDown = new System.Windows.Forms.Button();
            this.btnEndYearDown = new System.Windows.Forms.Button();
            this.btnEndMonthDown = new System.Windows.Forms.Button();
            this.btnEndMinUp = new System.Windows.Forms.Button();
            this.btnEndHourUp = new System.Windows.Forms.Button();
            this.btnEndYearUp = new System.Windows.Forms.Button();
            this.btnEndMonthUp = new System.Windows.Forms.Button();
            this.btnEndDayDown = new System.Windows.Forms.Button();
            this.lbEndMin = new System.Windows.Forms.Label();
            this.lbEndHour = new System.Windows.Forms.Label();
            this.lbEndYear = new System.Windows.Forms.Label();
            this.lbEndMonth = new System.Windows.Forms.Label();
            this.lbEndDay = new System.Windows.Forms.Label();
            this.lbFinGraph = new System.Windows.Forms.Label();
            this.tbDateEnd = new System.Windows.Forms.TextBox();
            this.btnEndDayUp = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbPageTitle = new System.Windows.Forms.Label();
            this.btnStartZero = new System.Windows.Forms.Button();
            this.btnEndZero = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartDayUp
            // 
            this.btnStartDayUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartDayUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartDayUp.Location = new System.Drawing.Point(24, 167);
            this.btnStartDayUp.Name = "btnStartDayUp";
            this.btnStartDayUp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStartDayUp.Size = new System.Drawing.Size(70, 150);
            this.btnStartDayUp.TabIndex = 0;
            this.btnStartDayUp.Text = "+";
            this.btnStartDayUp.UseVisualStyleBackColor = true;
            this.btnStartDayUp.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // tbDateStart
            // 
            this.tbDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateStart.Location = new System.Drawing.Point(45, 63);
            this.tbDateStart.Name = "tbDateStart";
            this.tbDateStart.Size = new System.Drawing.Size(340, 62);
            this.tbDateStart.TabIndex = 1;
            this.tbDateStart.Text = "01-01-21 00:00";
            // 
            // lbDebutGraph
            // 
            this.lbDebutGraph.AutoSize = true;
            this.lbDebutGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbDebutGraph.Location = new System.Drawing.Point(28, 5);
            this.lbDebutGraph.Name = "lbDebutGraph";
            this.lbDebutGraph.Size = new System.Drawing.Size(368, 46);
            this.lbDebutGraph.TabIndex = 2;
            this.lbDebutGraph.Text = "Début du graphique";
            // 
            // lbStartDay
            // 
            this.lbStartDay.AutoSize = true;
            this.lbStartDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDay.Location = new System.Drawing.Point(32, 144);
            this.lbStartDay.Name = "lbStartDay";
            this.lbStartDay.Size = new System.Drawing.Size(52, 20);
            this.lbStartDay.TabIndex = 3;
            this.lbStartDay.Text = "Jour : ";
            // 
            // lbStartMonth
            // 
            this.lbStartMonth.AutoSize = true;
            this.lbStartMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartMonth.Location = new System.Drawing.Point(109, 144);
            this.lbStartMonth.Name = "lbStartMonth";
            this.lbStartMonth.Size = new System.Drawing.Size(50, 20);
            this.lbStartMonth.TabIndex = 4;
            this.lbStartMonth.Text = "Mois :";
            // 
            // lbStartYear
            // 
            this.lbStartYear.AutoSize = true;
            this.lbStartYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartYear.Location = new System.Drawing.Point(178, 144);
            this.lbStartYear.Name = "lbStartYear";
            this.lbStartYear.Size = new System.Drawing.Size(68, 20);
            this.lbStartYear.TabIndex = 5;
            this.lbStartYear.Text = "Année : ";
            // 
            // lbStartHour
            // 
            this.lbStartHour.AutoSize = true;
            this.lbStartHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartHour.Location = new System.Drawing.Point(257, 144);
            this.lbStartHour.Name = "lbStartHour";
            this.lbStartHour.Size = new System.Drawing.Size(65, 20);
            this.lbStartHour.TabIndex = 6;
            this.lbStartHour.Text = "Heure : ";
            // 
            // lbStartMin
            // 
            this.lbStartMin.AutoSize = true;
            this.lbStartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartMin.Location = new System.Drawing.Point(329, 144);
            this.lbStartMin.Name = "lbStartMin";
            this.lbStartMin.Size = new System.Drawing.Size(69, 20);
            this.lbStartMin.TabIndex = 7;
            this.lbStartMin.Text = "Minute : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStartZero);
            this.panel1.Controls.Add(this.btnStartMinDown);
            this.panel1.Controls.Add(this.btnStartHourDown);
            this.panel1.Controls.Add(this.btnStartYearDown);
            this.panel1.Controls.Add(this.btnStartMonthDown);
            this.panel1.Controls.Add(this.btnStartMinUp);
            this.panel1.Controls.Add(this.btnStartHourUp);
            this.panel1.Controls.Add(this.btnStartYearUp);
            this.panel1.Controls.Add(this.btnStartMonthUp);
            this.panel1.Controls.Add(this.btnStartDayDown);
            this.panel1.Controls.Add(this.lbStartMin);
            this.panel1.Controls.Add(this.lbStartHour);
            this.panel1.Controls.Add(this.lbStartYear);
            this.panel1.Controls.Add(this.lbStartMonth);
            this.panel1.Controls.Add(this.lbStartDay);
            this.panel1.Controls.Add(this.lbDebutGraph);
            this.panel1.Controls.Add(this.tbDateStart);
            this.panel1.Controls.Add(this.btnStartDayUp);
            this.panel1.Location = new System.Drawing.Point(1, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 490);
            this.panel1.TabIndex = 2;
            // 
            // btnStartMinDown
            // 
            this.btnStartMinDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMinDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartMinDown.Location = new System.Drawing.Point(328, 278);
            this.btnStartMinDown.Name = "btnStartMinDown";
            this.btnStartMinDown.Padding = new System.Windows.Forms.Padding(10, 0, 0, 25);
            this.btnStartMinDown.Size = new System.Drawing.Size(70, 105);
            this.btnStartMinDown.TabIndex = 29;
            this.btnStartMinDown.Text = "-";
            this.btnStartMinDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStartMinDown.UseVisualStyleBackColor = true;
            this.btnStartMinDown.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnStartHourDown
            // 
            this.btnStartHourDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartHourDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartHourDown.Location = new System.Drawing.Point(252, 278);
            this.btnStartHourDown.Name = "btnStartHourDown";
            this.btnStartHourDown.Padding = new System.Windows.Forms.Padding(10, 0, 0, 25);
            this.btnStartHourDown.Size = new System.Drawing.Size(70, 105);
            this.btnStartHourDown.TabIndex = 28;
            this.btnStartHourDown.Text = "-";
            this.btnStartHourDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStartHourDown.UseVisualStyleBackColor = true;
            this.btnStartHourDown.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnStartYearDown
            // 
            this.btnStartYearDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartYearDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartYearDown.Location = new System.Drawing.Point(176, 323);
            this.btnStartYearDown.Name = "btnStartYearDown";
            this.btnStartYearDown.Padding = new System.Windows.Forms.Padding(10, 0, 0, 20);
            this.btnStartYearDown.Size = new System.Drawing.Size(70, 150);
            this.btnStartYearDown.TabIndex = 27;
            this.btnStartYearDown.Text = "-";
            this.btnStartYearDown.UseVisualStyleBackColor = true;
            this.btnStartYearDown.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnStartMonthDown
            // 
            this.btnStartMonthDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMonthDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartMonthDown.Location = new System.Drawing.Point(100, 323);
            this.btnStartMonthDown.Name = "btnStartMonthDown";
            this.btnStartMonthDown.Padding = new System.Windows.Forms.Padding(10, 0, 0, 20);
            this.btnStartMonthDown.Size = new System.Drawing.Size(70, 150);
            this.btnStartMonthDown.TabIndex = 26;
            this.btnStartMonthDown.Text = "-";
            this.btnStartMonthDown.UseVisualStyleBackColor = true;
            this.btnStartMonthDown.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnStartMinUp
            // 
            this.btnStartMinUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMinUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartMinUp.Location = new System.Drawing.Point(328, 167);
            this.btnStartMinUp.Name = "btnStartMinUp";
            this.btnStartMinUp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStartMinUp.Size = new System.Drawing.Size(70, 105);
            this.btnStartMinUp.TabIndex = 25;
            this.btnStartMinUp.Text = "+";
            this.btnStartMinUp.UseVisualStyleBackColor = true;
            this.btnStartMinUp.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnStartHourUp
            // 
            this.btnStartHourUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartHourUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartHourUp.Location = new System.Drawing.Point(252, 167);
            this.btnStartHourUp.Name = "btnStartHourUp";
            this.btnStartHourUp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.btnStartHourUp.Size = new System.Drawing.Size(70, 105);
            this.btnStartHourUp.TabIndex = 24;
            this.btnStartHourUp.Text = "+";
            this.btnStartHourUp.UseVisualStyleBackColor = true;
            this.btnStartHourUp.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnStartYearUp
            // 
            this.btnStartYearUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartYearUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartYearUp.Location = new System.Drawing.Point(176, 167);
            this.btnStartYearUp.Name = "btnStartYearUp";
            this.btnStartYearUp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStartYearUp.Size = new System.Drawing.Size(70, 150);
            this.btnStartYearUp.TabIndex = 23;
            this.btnStartYearUp.Text = "+";
            this.btnStartYearUp.UseVisualStyleBackColor = true;
            this.btnStartYearUp.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnStartMonthUp
            // 
            this.btnStartMonthUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMonthUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartMonthUp.Location = new System.Drawing.Point(100, 167);
            this.btnStartMonthUp.Name = "btnStartMonthUp";
            this.btnStartMonthUp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStartMonthUp.Size = new System.Drawing.Size(70, 150);
            this.btnStartMonthUp.TabIndex = 22;
            this.btnStartMonthUp.Text = "+";
            this.btnStartMonthUp.UseVisualStyleBackColor = true;
            this.btnStartMonthUp.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnStartDayDown
            // 
            this.btnStartDayDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartDayDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartDayDown.Location = new System.Drawing.Point(24, 323);
            this.btnStartDayDown.Name = "btnStartDayDown";
            this.btnStartDayDown.Padding = new System.Windows.Forms.Padding(10, 0, 0, 20);
            this.btnStartDayDown.Size = new System.Drawing.Size(70, 150);
            this.btnStartDayDown.TabIndex = 21;
            this.btnStartDayDown.Text = "-";
            this.btnStartDayDown.UseVisualStyleBackColor = true;
            this.btnStartDayDown.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(862, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 85);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEndZero);
            this.panel2.Controls.Add(this.btnEndMinDown);
            this.panel2.Controls.Add(this.btnEndHourDown);
            this.panel2.Controls.Add(this.btnEndYearDown);
            this.panel2.Controls.Add(this.btnEndMonthDown);
            this.panel2.Controls.Add(this.btnEndMinUp);
            this.panel2.Controls.Add(this.btnEndHourUp);
            this.panel2.Controls.Add(this.btnEndYearUp);
            this.panel2.Controls.Add(this.btnEndMonthUp);
            this.panel2.Controls.Add(this.btnEndDayDown);
            this.panel2.Controls.Add(this.lbEndMin);
            this.panel2.Controls.Add(this.lbEndHour);
            this.panel2.Controls.Add(this.lbEndYear);
            this.panel2.Controls.Add(this.lbEndMonth);
            this.panel2.Controls.Add(this.lbEndDay);
            this.panel2.Controls.Add(this.lbFinGraph);
            this.panel2.Controls.Add(this.tbDateEnd);
            this.panel2.Controls.Add(this.btnEndDayUp);
            this.panel2.Location = new System.Drawing.Point(429, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 490);
            this.panel2.TabIndex = 26;
            // 
            // btnEndMinDown
            // 
            this.btnEndMinDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndMinDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEndMinDown.Location = new System.Drawing.Point(326, 278);
            this.btnEndMinDown.Name = "btnEndMinDown";
            this.btnEndMinDown.Padding = new System.Windows.Forms.Padding(10, 0, 0, 20);
            this.btnEndMinDown.Size = new System.Drawing.Size(70, 105);
            this.btnEndMinDown.TabIndex = 33;
            this.btnEndMinDown.Text = "-";
            this.btnEndMinDown.UseVisualStyleBackColor = true;
            this.btnEndMinDown.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnEndHourDown
            // 
            this.btnEndHourDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndHourDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEndHourDown.Location = new System.Drawing.Point(250, 278);
            this.btnEndHourDown.Name = "btnEndHourDown";
            this.btnEndHourDown.Padding = new System.Windows.Forms.Padding(10, 0, 0, 20);
            this.btnEndHourDown.Size = new System.Drawing.Size(70, 105);
            this.btnEndHourDown.TabIndex = 32;
            this.btnEndHourDown.Text = "-";
            this.btnEndHourDown.UseVisualStyleBackColor = true;
            this.btnEndHourDown.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnEndYearDown
            // 
            this.btnEndYearDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndYearDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEndYearDown.Location = new System.Drawing.Point(174, 323);
            this.btnEndYearDown.Name = "btnEndYearDown";
            this.btnEndYearDown.Padding = new System.Windows.Forms.Padding(10, 0, 0, 20);
            this.btnEndYearDown.Size = new System.Drawing.Size(70, 150);
            this.btnEndYearDown.TabIndex = 31;
            this.btnEndYearDown.Text = "-";
            this.btnEndYearDown.UseVisualStyleBackColor = true;
            this.btnEndYearDown.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnEndMonthDown
            // 
            this.btnEndMonthDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndMonthDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEndMonthDown.Location = new System.Drawing.Point(98, 323);
            this.btnEndMonthDown.Name = "btnEndMonthDown";
            this.btnEndMonthDown.Padding = new System.Windows.Forms.Padding(10, 0, 0, 20);
            this.btnEndMonthDown.Size = new System.Drawing.Size(70, 150);
            this.btnEndMonthDown.TabIndex = 30;
            this.btnEndMonthDown.Text = "-";
            this.btnEndMonthDown.UseVisualStyleBackColor = true;
            this.btnEndMonthDown.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnEndMinUp
            // 
            this.btnEndMinUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndMinUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEndMinUp.Location = new System.Drawing.Point(326, 167);
            this.btnEndMinUp.Name = "btnEndMinUp";
            this.btnEndMinUp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEndMinUp.Size = new System.Drawing.Size(70, 105);
            this.btnEndMinUp.TabIndex = 25;
            this.btnEndMinUp.Text = "+";
            this.btnEndMinUp.UseVisualStyleBackColor = true;
            this.btnEndMinUp.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnEndHourUp
            // 
            this.btnEndHourUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndHourUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEndHourUp.Location = new System.Drawing.Point(250, 167);
            this.btnEndHourUp.Name = "btnEndHourUp";
            this.btnEndHourUp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEndHourUp.Size = new System.Drawing.Size(70, 105);
            this.btnEndHourUp.TabIndex = 24;
            this.btnEndHourUp.Text = "+";
            this.btnEndHourUp.UseVisualStyleBackColor = true;
            this.btnEndHourUp.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnEndYearUp
            // 
            this.btnEndYearUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndYearUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEndYearUp.Location = new System.Drawing.Point(174, 167);
            this.btnEndYearUp.Name = "btnEndYearUp";
            this.btnEndYearUp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEndYearUp.Size = new System.Drawing.Size(70, 150);
            this.btnEndYearUp.TabIndex = 23;
            this.btnEndYearUp.Text = "+";
            this.btnEndYearUp.UseVisualStyleBackColor = true;
            this.btnEndYearUp.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnEndMonthUp
            // 
            this.btnEndMonthUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndMonthUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEndMonthUp.Location = new System.Drawing.Point(98, 167);
            this.btnEndMonthUp.Name = "btnEndMonthUp";
            this.btnEndMonthUp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEndMonthUp.Size = new System.Drawing.Size(70, 150);
            this.btnEndMonthUp.TabIndex = 22;
            this.btnEndMonthUp.Text = "+";
            this.btnEndMonthUp.UseVisualStyleBackColor = true;
            this.btnEndMonthUp.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnEndDayDown
            // 
            this.btnEndDayDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndDayDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEndDayDown.Location = new System.Drawing.Point(22, 323);
            this.btnEndDayDown.Name = "btnEndDayDown";
            this.btnEndDayDown.Padding = new System.Windows.Forms.Padding(10, 0, 0, 20);
            this.btnEndDayDown.Size = new System.Drawing.Size(70, 150);
            this.btnEndDayDown.TabIndex = 21;
            this.btnEndDayDown.Text = "-";
            this.btnEndDayDown.UseVisualStyleBackColor = true;
            this.btnEndDayDown.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // lbEndMin
            // 
            this.lbEndMin.AutoSize = true;
            this.lbEndMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndMin.Location = new System.Drawing.Point(327, 144);
            this.lbEndMin.Name = "lbEndMin";
            this.lbEndMin.Size = new System.Drawing.Size(69, 20);
            this.lbEndMin.TabIndex = 7;
            this.lbEndMin.Text = "Minute : ";
            // 
            // lbEndHour
            // 
            this.lbEndHour.AutoSize = true;
            this.lbEndHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndHour.Location = new System.Drawing.Point(255, 144);
            this.lbEndHour.Name = "lbEndHour";
            this.lbEndHour.Size = new System.Drawing.Size(65, 20);
            this.lbEndHour.TabIndex = 6;
            this.lbEndHour.Text = "Heure : ";
            // 
            // lbEndYear
            // 
            this.lbEndYear.AutoSize = true;
            this.lbEndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndYear.Location = new System.Drawing.Point(176, 144);
            this.lbEndYear.Name = "lbEndYear";
            this.lbEndYear.Size = new System.Drawing.Size(68, 20);
            this.lbEndYear.TabIndex = 5;
            this.lbEndYear.Text = "Année : ";
            // 
            // lbEndMonth
            // 
            this.lbEndMonth.AutoSize = true;
            this.lbEndMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndMonth.Location = new System.Drawing.Point(107, 144);
            this.lbEndMonth.Name = "lbEndMonth";
            this.lbEndMonth.Size = new System.Drawing.Size(50, 20);
            this.lbEndMonth.TabIndex = 4;
            this.lbEndMonth.Text = "Mois :";
            // 
            // lbEndDay
            // 
            this.lbEndDay.AutoSize = true;
            this.lbEndDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndDay.Location = new System.Drawing.Point(30, 144);
            this.lbEndDay.Name = "lbEndDay";
            this.lbEndDay.Size = new System.Drawing.Size(52, 20);
            this.lbEndDay.TabIndex = 3;
            this.lbEndDay.Text = "Jour : ";
            // 
            // lbFinGraph
            // 
            this.lbFinGraph.AutoSize = true;
            this.lbFinGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbFinGraph.Location = new System.Drawing.Point(53, 5);
            this.lbFinGraph.Name = "lbFinGraph";
            this.lbFinGraph.Size = new System.Drawing.Size(317, 46);
            this.lbFinGraph.TabIndex = 2;
            this.lbFinGraph.Text = "Fin du graphique";
            // 
            // tbDateEnd
            // 
            this.tbDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateEnd.Location = new System.Drawing.Point(43, 63);
            this.tbDateEnd.Name = "tbDateEnd";
            this.tbDateEnd.Size = new System.Drawing.Size(340, 62);
            this.tbDateEnd.TabIndex = 1;
            this.tbDateEnd.Text = "01-01-21 00:00";
            // 
            // btnEndDayUp
            // 
            this.btnEndDayUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndDayUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEndDayUp.Location = new System.Drawing.Point(22, 167);
            this.btnEndDayUp.Name = "btnEndDayUp";
            this.btnEndDayUp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEndDayUp.Size = new System.Drawing.Size(70, 150);
            this.btnEndDayUp.TabIndex = 0;
            this.btnEndDayUp.Text = "+";
            this.btnEndDayUp.UseVisualStyleBackColor = true;
            this.btnEndDayUp.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(862, 102);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 85);
            this.btnConfirm.TabIndex = 27;
            this.btnConfirm.Text = "Confirmer";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbPageTitle
            // 
            this.lbPageTitle.AutoSize = true;
            this.lbPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPageTitle.Location = new System.Drawing.Point(128, 20);
            this.lbPageTitle.Name = "lbPageTitle";
            this.lbPageTitle.Size = new System.Drawing.Size(606, 55);
            this.lbPageTitle.TabIndex = 28;
            this.lbPageTitle.Text = "Choix de la plage de temps";
            // 
            // btnStartZero
            // 
            this.btnStartZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartZero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartZero.Location = new System.Drawing.Point(252, 389);
            this.btnStartZero.Name = "btnStartZero";
            this.btnStartZero.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnStartZero.Size = new System.Drawing.Size(146, 84);
            this.btnStartZero.TabIndex = 31;
            this.btnStartZero.Text = "Zéro";
            this.btnStartZero.UseVisualStyleBackColor = true;
            this.btnStartZero.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnEndZero
            // 
            this.btnEndZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndZero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEndZero.Location = new System.Drawing.Point(250, 389);
            this.btnEndZero.Name = "btnEndZero";
            this.btnEndZero.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnEndZero.Size = new System.Drawing.Size(146, 84);
            this.btnEndZero.TabIndex = 34;
            this.btnEndZero.Text = "Zéro";
            this.btnEndZero.UseVisualStyleBackColor = true;
            this.btnEndZero.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // FormChoixPlageTemps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.lbPageTitle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChoixPlageTemps";
            this.Text = "FormChoixPlageTemps";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartDayUp;
        private System.Windows.Forms.TextBox tbDateStart;
        private System.Windows.Forms.Label lbDebutGraph;
        private System.Windows.Forms.Label lbStartDay;
        private System.Windows.Forms.Label lbStartMonth;
        private System.Windows.Forms.Label lbStartYear;
        private System.Windows.Forms.Label lbStartHour;
        private System.Windows.Forms.Label lbStartMin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStartDayDown;
        private System.Windows.Forms.Button btnStartMinUp;
        private System.Windows.Forms.Button btnStartHourUp;
        private System.Windows.Forms.Button btnStartYearUp;
        private System.Windows.Forms.Button btnStartMonthUp;
        private System.Windows.Forms.Button btnStartMinDown;
        private System.Windows.Forms.Button btnStartHourDown;
        private System.Windows.Forms.Button btnStartYearDown;
        private System.Windows.Forms.Button btnStartMonthDown;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEndMinDown;
        private System.Windows.Forms.Button btnEndHourDown;
        private System.Windows.Forms.Button btnEndYearDown;
        private System.Windows.Forms.Button btnEndMonthDown;
        private System.Windows.Forms.Button btnEndMinUp;
        private System.Windows.Forms.Button btnEndHourUp;
        private System.Windows.Forms.Button btnEndYearUp;
        private System.Windows.Forms.Button btnEndMonthUp;
        private System.Windows.Forms.Button btnEndDayDown;
        private System.Windows.Forms.Label lbEndMin;
        private System.Windows.Forms.Label lbEndHour;
        private System.Windows.Forms.Label lbEndYear;
        private System.Windows.Forms.Label lbEndMonth;
        private System.Windows.Forms.Label lbEndDay;
        private System.Windows.Forms.Label lbFinGraph;
        private System.Windows.Forms.TextBox tbDateEnd;
        private System.Windows.Forms.Button btnEndDayUp;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lbPageTitle;
        private System.Windows.Forms.Button btnStartZero;
        private System.Windows.Forms.Button btnEndZero;
    }
}