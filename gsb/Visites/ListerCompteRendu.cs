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
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;

            CURS cs = new CURS(ChaineConnexion);
            string rapNum, rapDate,rapDateVisite,rapNomPra;
            string reqInfoRapport = "SELECT r.RAP_NUM,r.RAP_DATE,r.RAP_DATE_PROCHAINE_VISITE,r.RAP_BILAN,c.COL_NOM,p.PRA_NOM FROM rapport_visite AS r,collaborateur AS c, praticien AS p WHERE c.COL_MATRICULE=r.COL_MATRICULE AND r.PRA_NUM = p.PRA_NUM";
            if (_statutuser == "responsable")
            {
                reqInfoRapport += ";";
                dataGridView.Columns[5].Visible = true;                                             // Rend la colonne supprimer visible si responsable
                dataGridView.Size = new Size(dataGridView.Size.Width+100,dataGridView.Size.Height); // Agrandi le dataGridView
                this.Size = new Size(this.Size.Width+100,this.Height);                              // Agrandi la fenetre
            }
            else
                reqInfoRapport += " AND r.COL_MATRICULE ='" + _matuser + "';";
            cs.ReqSelect(reqInfoRapport);
            if (cs.Fin())
            {
                cs.fermer();
                MessageBox.Show("Aucun Rapport a afficher");
                this.Close();
            } else
            {
                while (!cs.Fin())
                {
                    rapNum = cs.champ("RAP_NUM").ToString();
                    rapDate = cs.champ("RAP_DATE").ToString();
                    rapDateVisite = cs.champ("RAP_DATE_PROCHAINE_VISITE").ToString();
                    rapNomPra = cs.champ("PRA_NOM").ToString();
                    dataGridView.Rows.Add(rapNum, rapDate, rapDateVisite, rapNomPra);
                    cs.suivant();
                }
                cs.fermer();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.ToString() == "4")                                                                       //Edite le rapport seulement quand l'utilisateur clique sur editer
            {
                dataGridView.CurrentRow.Selected = true;
                string id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["dataGridColumnNumRapport"].FormattedValue.ToString()) >= 0  ? dataGridView.Rows[e.RowIndex].Cells["dataGridColumnNumRapport"].FormattedValue.ToString() : ("0"); //récupère l'id de la ligne cliqué
                RapportVisite rap = new RapportVisite(id);
                rap.Show();
            }

            if (e.ColumnIndex.ToString() == "5")                                                                       // Permet de supprimer le rapport seulement si la croix rouge est cliqué, récupère l'id de la ligne, Demande vérif et supprime
            {
                CURS cs = new CURS(ChaineConnexion);
                dataGridView.CurrentRow.Selected = true;
                string id = dataGridView.Rows[e.RowIndex].Cells["dataGridColumnNumRapport"].FormattedValue.ToString(); //récupère l'id de la ligne cliqué
                string reqDeleteRapport = "DELETE FROM rapport_visite WHERE RAP_NUM=" + id + ";";
                var verifSiSupression = MessageBox.Show("Etes vous sur de vouloir supprimer ce rapport ?","Vérification",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (verifSiSupression == DialogResult.Yes)
                {
                    cs.ReqAdmin(reqDeleteRapport);
                    cs.fermer();
                    dataGridView.Rows.RemoveAt(e.RowIndex);                                                            // Supprime la ligne après acceptation. ? Actualiser tout meilleur soluce ?
                }


            }
        }
    }
}
