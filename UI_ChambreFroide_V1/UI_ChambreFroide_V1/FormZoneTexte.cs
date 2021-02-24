using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_ChambreFroide_V1
{
    public partial class FormZoneTexte : Form
    {
        public enum properties {name, group, warning, alert};
        public properties currentProp;

        public String modifiedProperty;

        public FormZoneTexte()
        {
            InitializeComponent();
        }

        private void FormZoneTexte_Load(object sender, EventArgs e)
        {
            try
            {
                //Kill all on screen keyboards
                Process[] oskProcessArray = Process.GetProcessesByName("TabTip");
                foreach (Process onscreenProcess in oskProcessArray)
                {
                    onscreenProcess.Kill();
                }

                string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
                string onScreenKeyboardPath = System.IO.Path.Combine(progFiles, "TabTip.exe");
                Process onScreenKeyboardProc = System.Diagnostics.Process.Start(onScreenKeyboardPath);
            }
            catch (Exception error)
            {
                string err = error.ToString();
                MessageBox.Show(err);
            }
            tbModif.Focus();
        }


        private void tbModif_Enter(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(currentProp == properties.name || currentProp == properties.group)
            {
                
            }
            else if (currentProp == properties.warning || currentProp == properties.alert)
            {
                try
                {
                    modifiedProperty = tbModif.Text;
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite");
            }
           
        }

        private void tbModif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (currentProp == properties.name || currentProp == properties.group)
            {
                if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || 
                    (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == ' ' || e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (currentProp == properties.warning || currentProp == properties.alert)
            {
                if((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || (e.KeyChar == '.' && tbModif.Text.Contains('.')==false))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
