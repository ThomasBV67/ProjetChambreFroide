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
    public partial class FormHistorique : Form
    {
        public String selectedName;
        public bool selectedIsGroup;

        public FormTempCourantes objFormTempCourantes;
        public FormHistorique()
        {
            InitializeComponent();
        }

        private void btnSelectCapteur_Click(object sender, EventArgs e)
        {
            using (var form = new FormChoixCapteur())
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    selectedName = form.returnName;
                    selectedIsGroup = form.isGroup;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
