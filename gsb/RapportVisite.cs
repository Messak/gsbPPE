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
    public partial class RapportVisite : Form
    {
        string _matuser;
        public string Matuser { get => _matuser; set => _matuser = value; }
        string ChaineConnexion = "server=51.68.64.197;user=gsbuser;password=gsbmdp;database=gsbcsharp";
        private Dictionary<int, string> praticiens = new Dictionary<int, string>();

        public RapportVisite()
        {
            InitializeComponent();


            CURS cs = new CURS(ChaineConnexion);
            string requete = "SELECT `praticien`.`PRA_NUM`, `praticien`.`PRA_NOM`, `praticien`.`PRA_PRENOM` FROM `praticien` ORDER BY `praticien`.`PRA_NOM`";
            cs.ReqSelect(requete);
            string Name = "";
            while (!cs.Fin())
            {
                Name = cs.champ("PRA_NOM").ToString() + " " + cs.champ("PRA_PRENOM").ToString();
                praticiens.Add(Convert.ToInt16(cs.champ("PRA_NUM").ToString()), Name);
                comboBox_Practiciens.Items.Add(Name);
                cs.suivant();
            }
            cs.fermer();

            CURS idrapp = new CURS(ChaineConnexion);
            idrapp.ReqSelect("SELECT RAP_NUM FROM rapport_visite ORDER BY RAP_NUM DESC LIMIT 1;");
            if (!idrapp.Fin())
            {
                int idrap = Convert.ToInt32(idrapp.champ("RAP_NUM").ToString()) + 1;
                textBoxNumRapport.Text = idrap.ToString();
            }
            idrapp.fermer();
        }

        /// <summary>
        /// Surcharge pour permettre l'affichage d'un rapport et non la rédaction
        /// </summary>
        /// <param name="id">L'id du Rapport à affiché</param>
        public RapportVisite(string id)
        {
            InitializeComponent();

        }

        private void RapportVisite_Load(object sender, EventArgs e)
        {
            
        }

        private void textBoxNumRapport_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
