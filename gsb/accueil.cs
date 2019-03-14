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
        string _statutuser;
        string _matuser;
        public string Statutuser { get => _statutuser; set => _statutuser = value; }
        public string Matuser { get => _matuser; set => _matuser = value; }

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

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            Connexion firstecran = new Connexion();
            this.Hide();
            firstecran.Show();
        }

        private void accueil_Load(object sender, EventArgs e)
        {
            statututilisateur.Text = _statutuser;
        }

        private void buttonRedigerCompteRendu_Click(object sender, EventArgs e)
        {
            RapportVisite redac = new RapportVisite();
            this.Close();
            redac.Matuser = this.Matuser;
            redac.Show();

        }
    }
}
