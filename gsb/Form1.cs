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
    public partial class Form1 : Form
    {
        string chaineConnexion;
        public string ChaineConnexion
        {
            get { return chaineConnexion; }
            set { chaineConnexion = value; }
        }

        public Form1()
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
            string req = "SELECT COL_NOM, COL_DATEEMBAUCHE FROM collaborateur WHERE COL_NOM='" + inputID.Text+"';";
            mdp.ReqSelect(req);
            errorConnection.Clear();

            string mdpdate = mdp.champ("COL_DATEEMBAUCHE").ToString();
            mdp.fermer();

            mdpdate = mdpdate[8, 9]+;
            19-jan-2003
                2003 - 06 - 18 00:00:00
                Hey
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
