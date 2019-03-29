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
    public partial class Visiteurs : Form
    {
        string ChaineConnexion = "server=51.68.64.197;user=gsbuser;password=gsbmdp;database=gsbcsharp";
        public Visiteurs()
        {
            InitializeComponent();
        }

        private void Visiteurs_Load(object sender, EventArgs e)
        {
            CURS cs = new CURS(ChaineConnexion);
            string req = "SELECT COL_MATRICULE, COL_NOM, COL_PRENOM, COL_ADRESSE, COL_CP, COL_VILLE, COL_DATEEMBAUCHE, LAB_NOM FROM collaborateur, labo WHERE collaborateur.LAB_CODE=labo.LAB_CODE;";
            cs.ReqSelect(req);
            while (!cs.Fin())
            {
                dataGridView.Rows.Add(cs.champ("COL_NOM").ToString(), cs.champ("COL_PRENOM").ToString(), cs.champ("COL_MATRICULE").ToString(), cs.champ("COL_ADRESSE").ToString(), cs.champ("COL_CP").ToString(), cs.champ("COL_VILLE").ToString(), cs.champ("COL_DATEEMBAUCHE").ToString(), cs.champ("LAB_NOM").ToString());
                cs.suivant();
            }
        }
    }
}
