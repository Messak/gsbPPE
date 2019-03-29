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
            //Appuyer sur le bouton "Compte Rendu"
            buttonCompteRendu.Visible = false;
            buttonListerCompteRendu.Visible = true;
            buttonRedigerCompteRendu.Visible = true;
        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            //On déconnecte l'utilisateur et on le renvoi sur la première page de connexion

            Connexion firstecran = new Connexion();
            this.Hide();
            firstecran.Show();
        }

        private void accueil_Load(object sender, EventArgs e)
        {  //On vérifie le statut de l'utilisateur pour afficher ce dont il a le droit ou pas
            statututilisateur.Text = _statutuser;
            if(!(statututilisateur.Text=="responsable"))
            { BtnListerVisiteurs.Hide(); BtnPraticien.Hide(); buttonListerCompteRendu.Text = "Lister mes Comptes Rendus"; }
        }

        private void buttonRedigerCompteRendu_Click(object sender, EventArgs e)
        {
            //On affiche l'écran pour rédiger un compte rendu
            RapportVisite redac = new RapportVisite();
            redac.Matuser = this.Matuser;
            redac.Show();

        }

        private void buttonListerCompteRendu_Click(object sender, EventArgs e)
        {
            //On affiche l'écran pour lister les comptes rendus
            ListerCompteRendu lister = new ListerCompteRendu();
            lister.Statutuser1 = _statutuser;
            lister.Matuser1 = _matuser;
            lister.Show();
        }

        private void BtnListerVisiteurs_Click(object sender, EventArgs e)
        {
            //On affiche l'écran pour lister les visiteur uniquement disponible pour les responsables
            Visiteurs VoirLesVisiteurs = new Visiteurs();
            VoirLesVisiteurs.Show();
        }

        private void BtnPraticien_Click(object sender, EventArgs e)
        {
            //On affiche l'écran pour lister les visiteur uniquement disponible pour les responsables
            Praticiens VoirLesPraticiens = new Praticiens();
            VoirLesPraticiens.Show();
        }
    }
}
