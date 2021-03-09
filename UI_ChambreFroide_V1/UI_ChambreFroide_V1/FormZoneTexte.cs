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

        private List<Button> m_listBtn = new List<Button>();

        private String[] LetterKeyboardLine1 = 
            {"q","w","e","r","t","y","u","i","o","p"};

        private String[] LetterKeyboardLine2 =
            {"a","s","d","f","g","h","j","k","l"};

        private String[] LetterKeyboardLine3 =
            {"⇧","z","x","c","v","b","n","m","⇦"};

        private String[] LetterKeyboardLine4 =
            { "123", "space" };

        public FormZoneTexte()
        {
            InitializeComponent();

            MakeLetterKeyboard();
        }

        private void FormZoneTexte_Load(object sender, EventArgs e)
        {
            /*try
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
            tbModif.Focus();*/
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

        private void MakeLetterKeyboard()
        {
            DeleteKeyboard();
            for(int i = 0; i< LetterKeyboardLine1.Length;i++)
            {
                Button btn = new Button();
                btn.Name = "btn"+LetterKeyboardLine1[i];
                btn.Text = LetterKeyboardLine1[i];
                btn.Visible = true;
                btn.Location = new Point(15+i*25,85);
                btn.Width = 25;
                btn.Height = 25;
                btn.Enabled = true;
                Controls.Add(btn);
                m_listBtn.Add(btn);
            }
        }

        private void MakeNumberKeyboard()
        {
            DeleteKeyboard();
        }

        private void DeleteKeyboard()
        {
            m_listBtn.Clear();
        }
    }
}
