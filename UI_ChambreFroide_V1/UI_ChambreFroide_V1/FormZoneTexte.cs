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
        private bool shift = false;

        public int mode = 0;

        private List<Button> lst_Boutons = new List<Button>();

        private String[] LetterKeyboardLine0 =
            {"1","2","3","4","5","6","7","8","9","0"};

        private String[] LetterKeyboardLine1 = 
            {"q","w","e","r","t","y","u","i","o","p"};

        private String[] LetterKeyboardLine2 =
            {"a","s","d","f","g","h","j","k","l"};

        private String[] LetterKeyboardLine3 =
            {"⇧","z","x","c","v","b","n","m","⇦"};

        private String[] LetterKeyboardLine4 =
            { "|_____|"};


        private String[] numKeyboardLine0 =
            {"1", "2", "3"};

        private String[] numKeyboardLine1 =
            {"4", "5", "6"};

        private String[] numKeyboardLine2 =
            {"7", "8", "9"};

        private String[] numKeyboardLine3 =
            {"-", "0", "⇦"};


        public FormZoneTexte()
        {
            InitializeComponent();

            if(mode == 0)//Mode 0 --> Lettres et chiffres
            {
                MakeLetterKeyboard();
            }
            else
            {
                MakeNumberKeyboard();
            }
            
        }

        private void FormZoneTexte_Load(object sender, EventArgs e)
        {
           
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void MakeLetterKeyboard()
        {

            for (int i = 0; i < LetterKeyboardLine0.Length; i++)
            {
                lst_Boutons.Add(new Button());
                lst_Boutons[lst_Boutons.Count - 1].Name = "btn" + LetterKeyboardLine0[i];
                lst_Boutons[lst_Boutons.Count - 1].Text = LetterKeyboardLine0[i];
                lst_Boutons[lst_Boutons.Count - 1].Font = new Font(lst_Boutons[lst_Boutons.Count - 1].Font.FontFamily, 24);
                lst_Boutons[lst_Boutons.Count - 1].Visible = true;
                lst_Boutons[lst_Boutons.Count - 1].Location = new Point(5 + i * 100, 85);
                lst_Boutons[lst_Boutons.Count - 1].Width = 100;
                lst_Boutons[lst_Boutons.Count - 1].Height = 100;
                lst_Boutons[lst_Boutons.Count - 1].Enabled = true;
                Controls.Add(lst_Boutons[lst_Boutons.Count - 1]);
                lst_Boutons[lst_Boutons.Count - 1].Click += new EventHandler(btnPressed);
            }

            for (int i = 0; i< LetterKeyboardLine1.Length;i++)
            {
                lst_Boutons.Add(new Button());
                lst_Boutons[lst_Boutons.Count - 1].Name = "btn"+LetterKeyboardLine1[i];
                lst_Boutons[lst_Boutons.Count - 1].Text = LetterKeyboardLine1[i].ToUpper();
                lst_Boutons[lst_Boutons.Count - 1].Font = new Font(lst_Boutons[lst_Boutons.Count - 1].Font.FontFamily, 24);
                lst_Boutons[lst_Boutons.Count - 1].Visible = true;
                lst_Boutons[lst_Boutons.Count - 1].Location = new Point(15+i*100,185);
                lst_Boutons[lst_Boutons.Count - 1].Width = 100;
                lst_Boutons[lst_Boutons.Count - 1].Height = 100;
                lst_Boutons[lst_Boutons.Count - 1].Enabled = true;
                Controls.Add(lst_Boutons[lst_Boutons.Count - 1]);
                lst_Boutons[lst_Boutons.Count - 1].Click += new EventHandler(btnPressed);
            }
            for (int i = 0; i < LetterKeyboardLine2.Length; i++)
            {
                lst_Boutons.Add(new Button());
                lst_Boutons[lst_Boutons.Count - 1].Name = "btn" + LetterKeyboardLine2[i];
                lst_Boutons[lst_Boutons.Count - 1].Text = LetterKeyboardLine2[i].ToUpper();
                lst_Boutons[lst_Boutons.Count - 1].Font = new Font(lst_Boutons[lst_Boutons.Count - 1].Font.FontFamily, 24);
                lst_Boutons[lst_Boutons.Count - 1].Visible = true;
                lst_Boutons[lst_Boutons.Count - 1].Location = new Point(35 + i * 100, 285);
                lst_Boutons[lst_Boutons.Count - 1].Width = 100;
                lst_Boutons[lst_Boutons.Count - 1].Height = 100;
                lst_Boutons[lst_Boutons.Count - 1].Enabled = true;
                Controls.Add(lst_Boutons[lst_Boutons.Count - 1]);
                lst_Boutons[lst_Boutons.Count - 1].Click += new EventHandler(btnPressed);
            }

            for (int i = 0; i < LetterKeyboardLine3.Length; i++)
            {
                lst_Boutons.Add(new Button());
                lst_Boutons[lst_Boutons.Count - 1].Name = "btn" + LetterKeyboardLine3[i];
                lst_Boutons[lst_Boutons.Count - 1].Text = LetterKeyboardLine3[i].ToUpper();
                lst_Boutons[lst_Boutons.Count - 1].Font = new Font(lst_Boutons[lst_Boutons.Count - 1].Font.FontFamily, 24);
                lst_Boutons[lst_Boutons.Count - 1].Visible = true;
                lst_Boutons[lst_Boutons.Count - 1].Location = new Point(55 + i * 100, 385);
                lst_Boutons[lst_Boutons.Count - 1].Width = 100;
                lst_Boutons[lst_Boutons.Count - 1].Height = 100;
                lst_Boutons[lst_Boutons.Count - 1].Enabled = true;
                Controls.Add(lst_Boutons[lst_Boutons.Count - 1]);
                lst_Boutons[lst_Boutons.Count - 1].Click += new EventHandler(btnPressed);
            }

            lst_Boutons.Add(new Button());
            lst_Boutons[lst_Boutons.Count - 1].Name = "btn" + LetterKeyboardLine4[0];
            lst_Boutons[lst_Boutons.Count - 1].Text = LetterKeyboardLine4[0];
            lst_Boutons[lst_Boutons.Count - 1].Font = new Font(lst_Boutons[lst_Boutons.Count - 1].Font.FontFamily, 24);
            lst_Boutons[lst_Boutons.Count - 1].Visible = true;
            lst_Boutons[lst_Boutons.Count - 1].Location = new Point(200, 485);
            lst_Boutons[lst_Boutons.Count - 1].Width = 600;
            lst_Boutons[lst_Boutons.Count - 1].Height = 100;
            lst_Boutons[lst_Boutons.Count - 1].Enabled = true;
            Controls.Add(lst_Boutons[lst_Boutons.Count - 1]);
            lst_Boutons[lst_Boutons.Count - 1].Click += new EventHandler(btnPressed);
        }

        private void MakeNumberKeyboard()
        {
            for (int i = 0; i < numKeyboardLine0.Length; i++)
            {
                lst_Boutons.Add(new Button());
                lst_Boutons[lst_Boutons.Count - 1].Name = "btn" + numKeyboardLine0[i];
                lst_Boutons[lst_Boutons.Count - 1].Text = numKeyboardLine0[i].ToUpper();
                lst_Boutons[lst_Boutons.Count - 1].Font = new Font(lst_Boutons[lst_Boutons.Count - 1].Font.FontFamily, 24);
                lst_Boutons[lst_Boutons.Count - 1].Visible = true;
                lst_Boutons[lst_Boutons.Count - 1].Location = new Point(350 + i * 100, 85);
                lst_Boutons[lst_Boutons.Count - 1].Width = 100;
                lst_Boutons[lst_Boutons.Count - 1].Height = 100;
                lst_Boutons[lst_Boutons.Count - 1].Enabled = true;
                Controls.Add(lst_Boutons[lst_Boutons.Count - 1]);
                lst_Boutons[lst_Boutons.Count - 1].Click += new EventHandler(btnPressed);
            }
            for (int i = 0; i < numKeyboardLine1.Length; i++)
            {
                lst_Boutons.Add(new Button());
                lst_Boutons[lst_Boutons.Count - 1].Name = "btn" + numKeyboardLine1[i];
                lst_Boutons[lst_Boutons.Count - 1].Text = numKeyboardLine1[i].ToUpper();
                lst_Boutons[lst_Boutons.Count - 1].Font = new Font(lst_Boutons[lst_Boutons.Count - 1].Font.FontFamily, 24);
                lst_Boutons[lst_Boutons.Count - 1].Visible = true;
                lst_Boutons[lst_Boutons.Count - 1].Location = new Point(350 + i * 100, 185);
                lst_Boutons[lst_Boutons.Count - 1].Width = 100;
                lst_Boutons[lst_Boutons.Count - 1].Height = 100;
                lst_Boutons[lst_Boutons.Count - 1].Enabled = true;
                Controls.Add(lst_Boutons[lst_Boutons.Count - 1]);
                lst_Boutons[lst_Boutons.Count - 1].Click += new EventHandler(btnPressed);
            }
            for (int i = 0; i < numKeyboardLine2.Length; i++)
            {
                lst_Boutons.Add(new Button());
                lst_Boutons[lst_Boutons.Count - 1].Name = "btn" + numKeyboardLine2[i];
                lst_Boutons[lst_Boutons.Count - 1].Text = numKeyboardLine2[i].ToUpper();
                lst_Boutons[lst_Boutons.Count - 1].Font = new Font(lst_Boutons[lst_Boutons.Count - 1].Font.FontFamily, 24);
                lst_Boutons[lst_Boutons.Count - 1].Visible = true;
                lst_Boutons[lst_Boutons.Count - 1].Location = new Point(350 + i * 100, 285);
                lst_Boutons[lst_Boutons.Count - 1].Width = 100;
                lst_Boutons[lst_Boutons.Count - 1].Height = 100;
                lst_Boutons[lst_Boutons.Count - 1].Enabled = true;
                Controls.Add(lst_Boutons[lst_Boutons.Count - 1]);
                lst_Boutons[lst_Boutons.Count - 1].Click += new EventHandler(btnPressed);
            }
            for (int i = 0; i < numKeyboardLine3.Length; i++)
            {
                lst_Boutons.Add(new Button());
                lst_Boutons[lst_Boutons.Count - 1].Name = "btn" + numKeyboardLine3[i];
                lst_Boutons[lst_Boutons.Count - 1].Text = numKeyboardLine3[i].ToUpper();
                lst_Boutons[lst_Boutons.Count - 1].Font = new Font(lst_Boutons[lst_Boutons.Count - 1].Font.FontFamily, 24);
                lst_Boutons[lst_Boutons.Count - 1].Visible = true;
                lst_Boutons[lst_Boutons.Count - 1].Location = new Point(350 + i * 100, 385);
                lst_Boutons[lst_Boutons.Count - 1].Width = 100;
                lst_Boutons[lst_Boutons.Count - 1].Height = 100;
                lst_Boutons[lst_Boutons.Count - 1].Enabled = true;
                Controls.Add(lst_Boutons[lst_Boutons.Count - 1]);
                lst_Boutons[lst_Boutons.Count - 1].Click += new EventHandler(btnPressed);
            }
        }

        private void btnPressed(object sender, System.EventArgs e)
        {
            Button bouton;
            bouton = (Button)sender; //casting du sender en Button
            if(bouton.Text == "⇦")
            {
                if (tbModif.Text.Length > 0)
                {
                    tbModif.Text = tbModif.Text.Remove(tbModif.Text.Length - 1, 1);
                }
            }else if(bouton.Text == "-")
            {
                
                try
                {
                    tbModif.Text = Convert.ToString(-1 * Convert.ToInt32(tbModif.Text));
                }
                catch
                {
                    if (tbModif.Text == "")
                    {
                        tbModif.Text = "-";
                    }
                    else
                    {
                        tbModif.Text = "";
                    }
                }
            }else if(bouton.Text == "⇧" || bouton.Text == "⇑")
            {
                shift = !shift;
                if (shift)
                {
                    bouton.Text = "⇑";
                }
                else
                {
                    bouton.Text = "⇧";
                }
            }
            else
            {
                if(mode == 0)
                {
                    if (shift)
                    {
                        tbModif.Text += bouton.Text.ToUpper();
                    }
                    else
                    {
                        tbModif.Text += bouton.Text.ToLower();
                    }
                }
                else
                {
                    tbModif.Text += bouton.Text;
                }
            }
        }

        public void chgMode(int p_mode)
        {
            mode = p_mode;
            foreach(Button btn in lst_Boutons)
            {
                btn.Dispose();
            }

            lst_Boutons.Clear();
            if (mode == 0)//Mode 0 --> Lettres et chiffres
            {
                MakeLetterKeyboard();
            }
            else
            {
                MakeNumberKeyboard();
            }

            clearText();
        }

        public void clearText()
        {
            tbModif.Text = "";
        }
    }
}
