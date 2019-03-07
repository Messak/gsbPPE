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
            conex.ReqSelect("SELECT COL_NOM, COL_DATEEMBAUCHE FROM collaborateur " +
                "WHERE COL_NOM='" + inputid + "' " +
                "AND DATE_FORMAT(COL_DATEEMBAUCHE, '%Y-%b-%d') = '" + inputmdp + "';");

            string vraimdp = conex.champ("COL_DATEEMBAUCHE").ToString();

            
                if (!conex.Fin())
                {
                    Form accueil = new Form();
                    this.Hide();
                    accueil.Show();
                    
                }
                else
                {
                    errorConnection.SetError(submit, "Vérifier vote login ou votre mot de passe ! ");
                }
            
            conex.fermer();
        }
    }
}
