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


            CURS mdp = new CURS(ChaineConnexion);
            string req = "SELECT COL_NOM, COL_DATEEMBAUCHE FROM collaborateur WHERE COL_NOM='" + inputID.Text + "';";
            mdp.ReqSelect(req);
            errorConnection.Clear();

            string mdpdate = mdp.champ("COL_DATEEMBAUCHE").ToString();
            mdp.fermer();
            if (true)
            {
                this.Hide();
            }
            else
            {
                errorConnection.SetError(submit, "Vérifier vote login ou votre mot de passe ! ");
            }
        }
    }
}
