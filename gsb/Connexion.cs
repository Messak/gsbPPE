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
    string _statutuser="";
        string matuser;
    public string Statutuser { get => _statutuser; set => _statutuser = value; }
        public string Matuser { get => matuser; set => matuser = value; }
        string ChaineConnexion = "server=51.68.64.197;user=gsbuser;password=gsbmdp;database=gsbcsharp";


        public Connexion()
        {
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
            conex.ReqSelect("SELECT COL_MATRICULE FROM collaborateur " +
                "WHERE COL_NOM='" + inputid + "' " +
                "AND DATE_FORMAT(COL_DATEEMBAUCHE, '%Y-%b-%d') = '" + inputmdp + "';");

            if (!conex.Fin())
            {
                 matuser = conex.champ("COL_MATRICULE").ToString();

                CURS ifresponsable = new CURS(ChaineConnexion);
                ifresponsable.ReqSelect("SELECT * FROM responsable WHERE COL_MATRICULE='" + matuser + "';");
                if (!ifresponsable.Fin())
                {
                    _statutuser = "responsable";
                }
                else
                {
                    _statutuser = "visiteur";
                }
                ifresponsable.fermer();
                
                accueil home = new accueil();
                home.Statutuser = this.Statutuser;
                home.Matuser = this.Matuser;


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
