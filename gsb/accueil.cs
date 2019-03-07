using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsb
{
    public partial class accueil : Form
    {
        public accueil()
        {
            InitializeComponent();
        }

        private void buttonCompteRendu_Click(object sender, EventArgs e)
        {
            buttonCompteRendu.Visible = false;
            buttonListerCompteRendu.Visible = true;
            buttonRedigerCompteRendu.Visible = true;
        }
    }
}
