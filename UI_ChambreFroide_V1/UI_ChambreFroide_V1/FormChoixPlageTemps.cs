using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_ChambreFroide_V1
{
    public partial class FormChoixPlageTemps : Form
    {
        public int startYear = DateTime.Now.Year%100, startMonth = DateTime.Now.Month, startDay = DateTime.Now.Day, 
            startHour = DateTime.Now.Hour, startMin = DateTime.Now.Minute,
            endYear = DateTime.Now.Year % 100, endMonth = DateTime.Now.Month, endDay = DateTime.Now.Day, 
            endHour = DateTime.Now.Hour, endMin = DateTime.Now.Minute;

        int startDaysCurrentMonth = 31, endDaysCurrentMonth = 31;

        int[] daysPerMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public DateTime startDateTime, endDateTime;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(startDateTime > DateTime.Now && endDateTime > DateTime.Now)
            {
                MessageBox.Show("Dates invalides");
                return;
            }
            else if(startDateTime > DateTime.Now)
            {
                MessageBox.Show("Date de début invalide");
                return;
            }
            else if(endDateTime > DateTime.Now)
            {
                MessageBox.Show("Date de fin invalide");
                return;
            }
            else if(endDateTime < startDateTime)
            {
                MessageBox.Show("Date de fin avant date de début");
                return;
            }
            DialogResult = DialogResult.OK;
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }

        public FormChoixPlageTemps()
        {
            InitializeComponent();

            startDaysCurrentMonth = daysPerMonth[startMonth-1];
            endDaysCurrentMonth = daysPerMonth[endMonth - 1];
            UpdateDates();
        }

        private void btnUpDown_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Name.StartsWith("btnStart"))
            {
                if(btn.Name.StartsWith("btnStartDay"))
                {
                    if(btn.Name.EndsWith("Up"))
                    {
                        startDay++;
                        if(startDay > startDaysCurrentMonth)
                        {
                            startDay = 1;
                        }
                    }
                    else
                    {
                        startDay--;
                        if (startDay <= 0)
                        {
                            startDay = startDaysCurrentMonth;
                        }
                    }
                }
                else if(btn.Name.StartsWith("btnStartMonth"))
                {
                    if (btn.Name.EndsWith("Up"))
                    {
                        startMonth++;
                        if(startMonth > 12)
                        {
                            startMonth = 1;
                        }
                        
                    }
                    else
                    {
                        startMonth--;
                        if (startMonth <= 0)
                        {
                            startMonth = 12;
                        }
                    }
                    startDaysCurrentMonth = daysPerMonth[startMonth - 1];
                    if (startMonth == 2 && startYear % 4 == 0)
                    {
                        startDaysCurrentMonth = 29;
                    }
                    if(startDay>startDaysCurrentMonth)
                    {
                        startDay = startDaysCurrentMonth;
                    }
                }
                else if (btn.Name.StartsWith("btnStartYear"))
                {
                    if (btn.Name.EndsWith("Up"))
                    {
                        startYear++;
                        if (startYear > DateTime.Now.Year % 100)
                        {
                            startYear = DateTime.Now.Year % 100;
                        }
                    }
                    else
                    {
                        startYear--;
                        if(startYear < 20)
                        {
                            startYear = 20;
                        }
                    }
                }
                else if (btn.Name.StartsWith("btnStartHour"))
                {
                    if (btn.Name.EndsWith("Up"))
                    {
                        startHour++;
                        if(startHour > 23)
                        {
                            startHour = 0;
                        }
                    }
                    else
                    {
                        startHour--;
                        if(startHour < 0)
                        {
                            startHour = 23;
                        }
                    }
                }
                else if (btn.Name.StartsWith("btnStartMin"))
                {
                    if (btn.Name.EndsWith("Up"))
                    {
                        startMin++;
                        if (startMin > 59)
                        {
                            startMin = 0;
                        }
                    }
                    else
                    {
                        startMin--;
                        if (startMin < 0)
                        {
                            startMin = 59;
                        }
                    }
                }
            }
            else
            {
                if (btn.Name.StartsWith("btnEndDay"))
                {
                    if (btn.Name.EndsWith("Up"))
                    {
                        endDay++;
                        if (endDay > endDaysCurrentMonth)
                        {
                            endDay = 1;
                        }
                    }
                    else
                    {
                        endDay--;
                        if (endDay <= 0)
                        {
                            endDay = endDaysCurrentMonth;
                        }
                    }
                }
                else if (btn.Name.StartsWith("btnEndMonth"))
                {
                    if (btn.Name.EndsWith("Up"))
                    {
                        endMonth++;
                        if (endMonth > 12)
                        {
                            endMonth = 1;
                        }

                    }
                    else
                    {
                        endMonth--;
                        if (endMonth <= 0)
                        {
                            endMonth = 12;
                        }
                    }
                    endDaysCurrentMonth = daysPerMonth[endMonth - 1];
                    if (endMonth == 2 && endMonth % 4 == 0)
                    {
                        endDaysCurrentMonth = 29;
                    }
                    if (endMonth > endDaysCurrentMonth)
                    {
                        endMonth = endDaysCurrentMonth;
                    }
                }
                else if (btn.Name.StartsWith("btnEndYear"))
                {
                    if (btn.Name.EndsWith("Up"))
                    {
                        endYear++;
                        if (endYear > DateTime.Now.Year % 100)
                        {
                            endYear = DateTime.Now.Year % 100;
                        }
                    }
                    else
                    {
                        endYear--;
                        if (endYear < 20)
                        {
                            endYear = 20;
                        }
                    }
                }
                else if (btn.Name.StartsWith("btnEndHour"))
                {
                    if (btn.Name.EndsWith("Up"))
                    {
                        endHour++;
                        if (endHour > 23)
                        {
                            endHour = 0;
                        }
                    }
                    else
                    {
                        endHour--;
                        if (endHour < 0)
                        {
                            endHour = 23;
                        }
                    }
                }
                else if (btn.Name.StartsWith("btnEndMin"))
                {
                    if (btn.Name.EndsWith("Up"))
                    {
                        endMin++;
                        if (endMin > 59)
                        {
                            endMin = 0;
                        }
                    }
                    else
                    {
                        endMin--;
                        if (endMin < 0)
                        {
                            endMin = 59;
                        }
                    }
                }
            }
            UpdateDates();
        }

        void UpdateDates()
        {
            startDateTime = DateTime.ParseExact(startDay + "-" + startMonth + "-" + startYear + " " + startHour + ":" + startMin, "d-M-yy H:m", null);
            endDateTime = DateTime.ParseExact(endDay + "-" + endMonth + "-" + endYear + " " + endHour + ":" + endMin, "d-M-yy H:m", null);
            tbDateStart.Text = startDateTime.ToString("dd-MM-yy HH:mm");
            tbDateEnd.Text = endDateTime.ToString("dd-MM-yy HH:mm");
        }
    }
}
