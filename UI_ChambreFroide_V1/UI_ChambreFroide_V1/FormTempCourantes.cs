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
    public partial class FormTempCourantes : Form
    {
        public List<Button> m_listCapteurs = new List<Button>();
        public int m_nbCapteurs = 0;

        public FormTempCourantes()
        {
            InitializeComponent();

            for(int i = 0; i < m_nbCapteurs; i++)
            {
                String newCap = "";
                newCap = "Capteur " + i;
               // m_listCapteurs.Add();
            }
        }
    }
}
