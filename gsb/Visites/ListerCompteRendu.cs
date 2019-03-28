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
    public partial class ListerCompteRendu : Form
    {
        private string ChaineConnexion = "server=51.68.64.197;user=gsbuser;password=gsbmdp;database=gsbcsharp";
        public ListerCompteRendu()
        {
            InitializeComponent();
        }

        private void ListerCompteRendu_Load(object sender, EventArgs e)
        {

            CURS cs = new CURS(ChaineConnexion);
            string rapNum, rapDate, colNom, PraNom;
            cs.ReqSelect("SELECT r.RAP_NUM,r.RAP_DATE,r.RAP_BILAN,c.COL_NOM,p.PRA_NOM FROM rapport_visite AS r,collaborateur AS c, praticien AS p WHERE c.COL_MATRICULE=r.COL_MATRICULE AND r.PRA_NUM = p.PRA_NUM");
            while (!cs.Fin())
            {
                rapNum = cs.champ("RAP_NUM").ToString();
                rapDate = cs.champ("RAP_DATE").ToString();
                colNom = cs.champ("COL_NOM").ToString();
                PraNom = cs.champ("PRA_NOM").ToString();
                dataGridView.Rows.Add(rapNum, rapDate, colNom,PraNom);
                cs.suivant();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
