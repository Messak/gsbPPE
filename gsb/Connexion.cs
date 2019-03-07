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
    public partial class Connexion : Form
    {
        string chaineConnexion;
        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }

        public Connexion()
        {
             ChaineConnexion = "server=localhost;user=root;database=gsbcsharp";
            InitializeComponent();

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inputID_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputMDP_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            errorConnection.Clear();
            string inputid = inputID.Text.ToString();
            string inputmdp = inputMDP.Text.ToString();

            CURS conex = new CURS(ChaineConnexion);
            conex.ReqSelect("SELECT COL_NOM, COL_DATEEMBAUCHE, COL_MATRICULE FROM collaborateur " +
                "WHERE COL_NOM='" + inputid + "' " +
                "AND DATE_FORMAT(COL_DATEEMBAUCHE, '%Y-%b-%d') = '" + inputmdp + "';");

            if (!conex.Fin())
                {
                string matuser = conex.champ("COL_DATEEMBAUCHE").ToString();
                string statutuser = "";

                CURS ifvisiteur = new CURS(ChaineConnexion);
                ifvisiteur.ReqSelect("SELECT * FROM visiteur WHERE COL_MATRICULE='" + matuser + "';");
                if (!ifvisiteur.Fin())
                {
                    statutuser = "visiteur";
                }
                ifvisiteur.fermer();
                CURS ifresponsable = new CURS(ChaineConnexion);
                ifresponsable.ReqSelect("SELECT * FROM responsable WHERE COL_MATRICULE='" + matuser + "';");
                if (!ifresponsable.Fin())
                {
                    statutuser = "responsable";
                }
                ifresponsable.fermer();
                accueil home = new accueil();
                    this.Hide();
                    home.Show(); 
            }
                else
                {
                    errorConnection.SetError(submit, "Vérifier vote login ou votre mot de passe ! ");
                }
            
            conex.fermer();
        }
    }
}
