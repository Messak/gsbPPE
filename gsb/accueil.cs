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

        private void resetButtons()
        {
            buttonRapportMain.Visible = true;
            buttonVisiteurMain.Visible = true;
            buttonPraticienMain.Visible = true;
            buttonRapportLister.Visible = false;
            buttonRapportModif.Visible = false;
            buttonVisiteurLister.Visible = false;
            buttonVisiteurModif.Visible = false;
            buttonPraticienLister.Visible = false;
            buttonPraticienModif.Visible = false;
        }
        public accueil()
        {
            InitializeComponent();
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
            if(!(statututilisateur.Text=="responsable"))
            {
                buttonVisiteurLister.Hide(); buttonPraticienLister.Hide(); buttonRapportLister.Text = "Lister mes Comptes Rendus";
            }
        }

        private void buttonRedigerCompteRendu_Click(object sender, EventArgs e)
        {
            RapportVisite redac = new RapportVisite();
            redac.Matuser = this.Matuser;
            redac.Show();

        }

        private void buttonListerCompteRendu_Click(object sender, EventArgs e)
        {
            ListerCompteRendu lister = new ListerCompteRendu();
            lister.Statutuser1 = _statutuser;
            lister.Matuser1 = _matuser;
            lister.Show();
        }

        private void BtnListerVisiteurs_Click(object sender, EventArgs e)
        {
            Visiteurs VoirLesVisiteurs = new Visiteurs(_statutuser);
            VoirLesVisiteurs.Show();
        }
        private void buttonCompteRendu_Click(object sender, EventArgs e)
        {
            resetButtons();
            buttonRapportMain.Visible = false;
            buttonRapportLister.Visible = true;
            buttonRapportModif.Visible = true;
        }
        private void buttonVisiteurMain_Click(object sender, EventArgs e)
        {
            resetButtons();
            buttonVisiteurMain.Visible = false;
            buttonVisiteurLister.Visible = true;
            if (!(statututilisateur.Text == "responsable"))
            {
                buttonVisiteurModif.Visible = false;
                buttonVisiteurLister.Size = new Size(388, 43);
            }
            else
                buttonVisiteurModif.Visible = true;
        }

        private void buttonPraticienMain_Click(object sender, EventArgs e)
        {
            resetButtons();
            buttonPraticienMain.Visible = false;
            buttonPraticienLister.Visible = true;
            if (!(statututilisateur.Text == "responsable"))
            {
                buttonPraticienModif.Visible = false;
                buttonPraticienLister.Size = new Size(388, 43);
            }
            else
                buttonPraticienModif.Visible = true;
        }

        private void buttonPraticienLister_Click(object sender, EventArgs e)
        {
            Praticiens VoirLesPraticiens = new Praticiens();
            VoirLesPraticiens.Show();
        }
    }
}
