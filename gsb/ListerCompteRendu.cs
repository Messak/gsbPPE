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
        private string ChaineConnexion = "server=51.68.64.197;user=gsbuser;password=gsbmdp;database=gsbcsharp",_matuser, _statutuser;
        public string Matuser1 { get => _matuser; set => _matuser = value; }
        public string Statutuser1 { get => _statutuser; set => _statutuser = value; }
        public ListerCompteRendu()
        {
            InitializeComponent();
        }

        private void ListerCompteRendu_Load(object sender, EventArgs e)
        {

            CURS cs = new CURS(ChaineConnexion);
            string rapNum, rapDate;
            cs.ReqSelect("SELECT r.RAP_NUM,r.RAP_DATE,r.RAP_BILAN,c.COL_NOM,p.PRA_NOM FROM rapport_visite AS r,collaborateur AS c, praticien AS p WHERE c.COL_MATRICULE=r.COL_MATRICULE AND r.PRA_NUM = p.PRA_NUM AND r.PRA_NUM='" + _matuser + "';");
            if (cs.Fin())
            {
                MessageBox.Show("Aucun Rapport a afficher");
                this.Close();
            } else
            {
                while (!cs.Fin())
                {
                    rapNum = cs.champ("RAP_NUM").ToString();
                    rapDate = cs.champ("RAP_DATE").ToString();
                    dataGridView.Rows.Add(rapNum, rapDate);
                    cs.suivant();
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) // verifie si il y a des lignes
            {
                dataGridView.CurrentRow.Selected = true;
                string id = dataGridView.Rows[e.RowIndex].Cells["NumRapport"].FormattedValue.ToString(); //récupère l'id de la ligne clické
                RapportVisite rap = new RapportVisite(id);
            }
        }
    }
}
