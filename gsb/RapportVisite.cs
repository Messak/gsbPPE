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
        string _numprat;
        private Dictionary<string, int> EchantillonsOffert = new Dictionary<string, int>();
        private Dictionary<string, int> EchantillonsPresente = new Dictionary<string, int>();

        public string Matuser { get => _matuser; set => _matuser = value; }
        string ChaineConnexion = "server=51.68.64.197;user=gsbuser;password=gsbmdp;database=gsbcsharp";
        private Dictionary<int, string> praticiens = new Dictionary<int, string>();

        
        public RapportVisite()
        {
            InitializeComponent();

            //Fonction qui rempli les datagrid views médicament
                CURS remplirmedoc = new CURS(ChaineConnexion);
                string requetemedoc = "SELECT `medicament`.`MED_NOMCOMMERCIAL` " +
                    "FROM `medicament` " +
                    "ORDER BY `medicament`.`MED_NOMCOMMERCIAL` ASC";
                remplirmedoc.ReqSelect(requetemedoc);
                while (!remplirmedoc.Fin())
                {
                    Medicaments.Items.Add(remplirmedoc.champ("MED_NOMCOMMERCIAL").ToString());
                    dataGridViewComboBoxColumn1.Items.Add(remplirmedoc.champ("MED_NOMCOMMERCIAL").ToString());
                    remplirmedoc.suivant();
                }
                remplirmedoc.fermer();            
            
            //Rempli le combobox praticien 
                CURS cs = new CURS(ChaineConnexion);
            string requete = "SELECT `praticien`.`PRA_NUM`, `praticien`.`PRA_NOM`, `praticien`.`PRA_PRENOM` FROM `praticien` ORDER BY `praticien`.`PRA_NOM`";
            cs.ReqSelect(requete);
            string Name = "";
            while (!cs.Fin())
            {
                _numprat = cs.champ("PRA_NUM").ToString();
                Name = cs.champ("PRA_NOM").ToString() + " " + cs.champ("PRA_PRENOM").ToString();
                praticiens.Add(Convert.ToInt16(cs.champ("PRA_NUM").ToString()), Name);
                comboBox_Practiciens.Items.Add(Name);
                cs.suivant();
            }
            cs.fermer();
            //Rempli le label id rapport
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
        /// <param name="idNumRapport">L'id du Rapport à affiché</param>
        public RapportVisite(string idNumRapport)
        {
            InitializeComponent();
            string reqSelectRapport = "SELECT r.RAP_DATE, r.RAP_BILAN,r.RAP_MOTIF, r.RAP_CONNAISSANCE_PRACTICIEN, r.RAP_CONFIANCE_LABO, r.RAP_DATE_VISITE, r.RAP_DATE_PROCHAINE_VISITE, r.RAP_PRESENCE_CONCURENCE, p.PRA_NOM, p.PRA_PRENOM, p.COEFNOTORIETE FROM rapport_visite,praticien AS r WHERE r.RAP_NUM ='" + idNumRapport + "' AND r.PRA_NUM=p.PRA_NUM;";
            CURS getRapportById = new CURS(ChaineConnexion);
            getRapportById.ReqSelect(reqSelectRapport);
            if (!getRapportById.Fin())
            {
                textBoxNumRapport.Text = idNumRapport;
                comboBox_Practiciens.Text = getRapportById.champ("PRA_NOM").ToString() + " " + getRapportById.champ("PRA_PRENOM").ToString();
                comboBoxMotifVisite.Text = getRapportById.champ("RAP_MOTIF").ToString();
                datePickerVisite.Value = Convert.ToDateTime(getRapportById.champ("RAP_DATE").ToString());
                string datenouveaurdv = getRapportById.champ("RAP_DATE_PROCHAINE_VISITE").ToString();
                if (!String.IsNullOrEmpty(datenouveaurdv))
                {
                    comboboxrdv.Text = "Oui";
                    datePickerProchainevisite.Show();
                    datePickerProchainevisite.Value = Convert.ToDateTime(datenouveaurdv);
                }
                else
                    datePickerProchainevisite.Hide();
                richTextBoxBilan.Text = getRapportById.champ("RAP_BILAN").ToString();
                comboBoxconfpract.Text = getRapportById.champ("PRA_COEFNOTORIETE").ToString();
                comboBoxConnaissancepract.Text = getRapportById.champ("RAP_CONNAISSANCE_PRACTICIEN").ToString();
            }
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

        private void Btnsubmit_Click(object sender, EventArgs e)
        {
            //Remplit des listes selon les tableaux d'echantillions
            foreach (DataGridViewRow ligne in dataGridView_echantillonOffert.Rows)
            {
                if(!String.IsNullOrWhiteSpace(ligne.Cells[0].FormattedValue.ToString())&& (!String.IsNullOrWhiteSpace(ligne.Cells[0].FormattedValue.ToString())))
                    EchantillonsOffert.Add(Convert.ToString(ligne.Cells[0].FormattedValue), Convert.ToInt32(ligne.Cells[1].FormattedValue));   
            }
            foreach (DataGridViewRow ligne in dataGridView_echantillonPresente.Rows)
            {
                if (!String.IsNullOrWhiteSpace(ligne.Cells[0].FormattedValue.ToString()) && (!String.IsNullOrWhiteSpace(ligne.Cells[0].FormattedValue.ToString())))
                    EchantillonsPresente.Add(Convert.ToString(ligne.Cells[0].FormattedValue), Convert.ToInt32(ligne.Cells[1].FormattedValue));
            }


            //Requete pour inserer dans la table Rapport visite
            string requete = "INSERT INTO `rapport_visite`(`COL_MATRICULE`, `RAP_NUM`, `RAP_DATE`, `RAP_BILAN`, `RAP_MOTIF`, `RAP_CONNAISSANCE_PRACTICIEN`, `RAP_CONFIANCE_LABO`, `RAP_DATE_VISITE`, `PRA_NUM`, `RAP_DATE_PROCHAINE_VISITE`)" +
                    " VALUES ('" + Matuser + "', " + textBoxNumRapport.Text + ", '" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd H:mm:ss") + "', '" + richTextBoxBilan.Text + "', '" + comboBoxMotifVisite.Text + "', " + comboBoxConnaissancepract.Text + ", " + comboBoxConfLab.Text +
                    ", '" + Convert.ToDateTime(datePickerVisite.Value).ToString("yyyy-MM-dd H:mm:ss") + "','" + _numprat + "'";
            if (comboboxrdv.Text == "Oui")
                requete += ",'" + Convert.ToDateTime(datePickerProchainevisite.Value).ToString("yyyy-MM-dd H:mm:ss") + "');"; 
            else
                requete += ",NULL);";
            
                CURS validdata = new CURS(ChaineConnexion);
                validdata.ReqAdmin(requete);
                if (!validdata.Fin())
                {
                    foreach (KeyValuePair<string, int> ligne in EchantillonsOffert)
                    { CURS insertdistribuer = new CURS(ChaineConnexion);
                        insertdistribuer.DefFonctStockee("ajoutmedicament");

                        insertdistribuer.ajouteparametreCol("NomMedoc", ligne.Key);
                        insertdistribuer.directionparametreCol("NomMedoc", ParameterDirection.Input);
                        insertdistribuer.ajouteparametreCol("MatUser", Matuser);
                        insertdistribuer.directionparametreCol("MatUser", ParameterDirection.Input);
                        insertdistribuer.ajouteparametreCol("NumRap", textBoxNumRapport.Text);
                        insertdistribuer.directionparametreCol("NumRap", ParameterDirection.Input);
                        insertdistribuer.ajouteparametreCol("QuantiteMedoc", ligne.Value);
                        insertdistribuer.directionparametreCol("QuantiteMedoc", ParameterDirection.Input);
                        insertdistribuer.ajouteparametreCol("coffert",1);
                        insertdistribuer.directionparametreCol("coffert", ParameterDirection.Input);
                        insertdistribuer.ajouteparametreCol("cpresente", 0);
                        insertdistribuer.directionparametreCol("cpresente", ParameterDirection.Input);
                        insertdistribuer.Appelfonctstockee();
                    }
                    foreach (KeyValuePair<string, int> ligne in EchantillonsPresente)
                    {
                        CURS insertdistribuer = new CURS(ChaineConnexion);
                        insertdistribuer.DefFonctStockee("ajoutmedicament");

                        insertdistribuer.ajouteparametreCol("NomMedoc", ligne.Key);
                        insertdistribuer.directionparametreCol("NomMedoc", ParameterDirection.Input);
                        insertdistribuer.ajouteparametreCol("MatUser", Matuser);
                        insertdistribuer.directionparametreCol("MatUser", ParameterDirection.Input);
                        insertdistribuer.ajouteparametreCol("NumRap", textBoxNumRapport.Text);
                        insertdistribuer.directionparametreCol("NumRap", ParameterDirection.Input);
                        insertdistribuer.ajouteparametreCol("QuantiteMedoc", ligne.Value);
                        insertdistribuer.directionparametreCol("QuantiteMedoc", ParameterDirection.Input);
                        insertdistribuer.ajouteparametreCol("coffert", 0);
                        insertdistribuer.directionparametreCol("coffert", ParameterDirection.Input);
                        insertdistribuer.ajouteparametreCol("cpresente", 1);
                        insertdistribuer.directionparametreCol("cpresente", ParameterDirection.Input);
                        insertdistribuer.Appelfonctstockee();
                    }

                    MessageBox.Show("Le rapport a été créé !");
                this.Close();
            }
            validdata.fermer();
        }

        private void comboboxrdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboboxrdv.SelectedIndex == 1)
            {
                datePickerProchainevisite.Show();
            }
            else
            {
                datePickerProchainevisite.Hide();
            }
        }
    }
    }
