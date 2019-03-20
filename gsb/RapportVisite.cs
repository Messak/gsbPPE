﻿using System;
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

        //Fonction qui rempli les datagrid views médicament
        private void Add_comboBox_Medicament()
        {
            CURS remplirmedoc = new CURS(ChaineConnexion);
            string requete = "SELECT `medicament`.`MED_NOMCOMMERCIAL` " +
                "FROM `medicament` " +
                "ORDER BY `medicament`.`MED_NOMCOMMERCIAL` ASC";
            remplirmedoc.ReqSelect(requete);
            while (!remplirmedoc.Fin())
            {
                Medicaments.Items.Add(remplirmedoc.champ("MED_NOMCOMMERCIAL").ToString());
                dataGridViewComboBoxColumn1.Items.Add(remplirmedoc.champ("MED_NOMCOMMERCIAL").ToString());
                remplirmedoc.suivant();
            }
            remplirmedoc.fermer();
        }
        public RapportVisite()
        {
            InitializeComponent();
            Add_comboBox_Medicament();
            //Rempli le combobox praticien 
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
            string requete = "INSERT INTO `rapport_visite`(`COL_MATRICULE`, `RAP_NUM`, `RAP_DATE`, `RAP_BILAN`, `RAP_MOTIF`, `RAP_CONNAISSANCE_PRACTICIEN`, `RAP_CONFIANCE_LABO`, `RAP_DATE_VISITE`, `RAP_DATE_PROCHAINE_VISITE`, `RAP_PRESENCE_CONCURENCE`, `PRA_NUM`)" +
                    " VALUES ('" + Matuser + "', '" + textBoxNumRapport.Text + "', '" + dateJour + "', '" + rapBilan + "', '" + rapMotif + "', " + rapConnaissancePraticien + ", " + rapConnaissanceLabo + ", '" + rapDate + "',";
            requete += comboBox_NewRDV.Text == "Oui"
                ? "'" + rapDateProVisite + "'"
                : rapDateProVisite;
            requete += ", " + rapPresenceConcurence + ", " + praNum + ")"



        }
    }
}
