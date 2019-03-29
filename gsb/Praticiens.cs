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
    public partial class Praticiens : Form
    {
        string ChaineConnexion = "server=51.68.64.197;user=gsbuser;password=gsbmdp;database=gsbcsharp";
        public Praticiens()
        {
            InitializeComponent();
        }

        private void Praticiens_Load(object sender, EventArgs e)
        {
            //Requete pour remplir le datagridview
            CURS cs = new CURS(ChaineConnexion);
            string req = "SELECT PRA_NUM, PRA_NOM, PRA_PRENOM, PRA_ADRESSE, PRA_CP, PRA_VILLE,PRA_COEFNOTORIETE, TYP_LIBELLE FROM praticien, type_praticien WHERE praticien.typ_code=type_praticien.TYP_CODE;";
            cs.ReqSelect(req);
            while (!cs.Fin())
            {
                dataGridView.Rows.Add(cs.champ("PRA_NOM").ToString(), cs.champ("PRA_PRENOM").ToString(), cs.champ("PRA_NUM").ToString(), cs.champ("PRA_ADRESSE").ToString(), cs.champ("PRA_CP").ToString(), cs.champ("PRA_VILLE").ToString(), cs.champ("PRA_COEFNOTORIETE").ToString(), cs.champ("TYP_LIBELLE").ToString());
                cs.suivant();
            }
            cs.fermer();
        }
    }
}
