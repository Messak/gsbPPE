namespace gsb
{
    partial class RapportVisite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumRapport = new System.Windows.Forms.Label();
            this.textBoxNumRapport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDateVisite = new System.Windows.Forms.Label();
            this.datePickerVisite = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Practiciens = new System.Windows.Forms.ComboBox();
            this.comboBoxMotifVisite = new System.Windows.Forms.ComboBox();
            this.labelMotifVisite = new System.Windows.Forms.Label();
            this.labelBilan = new System.Windows.Forms.Label();
            this.richTextBoxBilan = new System.Windows.Forms.RichTextBox();
            this.Btnsubmit = new System.Windows.Forms.Button();
            this.prdnewrdv = new System.Windows.Forms.Label();
            this.ConfPract = new System.Windows.Forms.Label();
            this.ConfLabo = new System.Windows.Forms.Label();
            this.ConnaissancePract = new System.Windows.Forms.Label();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.LabelOffreechantillons = new System.Windows.Forms.Label();
            this.Labeloffreechantillions = new System.Windows.Forms.Label();
            this.comboboxrdv = new System.Windows.Forms.ComboBox();
            this.comboBoxconfpract = new System.Windows.Forms.ComboBox();
            this.comboBoxConfLab = new System.Windows.Forms.ComboBox();
            this.comboBoxConnaissancepract = new System.Windows.Forms.ComboBox();
            this.datePickerProchainevisite = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_echantillonOffert = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_echantillonPresente = new System.Windows.Forms.DataGridView();
            this.Medicaments = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorPraticien = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorMotifVisite = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorConfiancePrat = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorConfianceLabo = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorConnaissancePrat = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_echantillonOffert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_echantillonPresente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPraticien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMotifVisite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorConfiancePrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorConfianceLabo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorConnaissancePrat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(565, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rapport de Visite";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNumRapport
            // 
            this.labelNumRapport.AutoSize = true;
            this.labelNumRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumRapport.Location = new System.Drawing.Point(36, 79);
            this.labelNumRapport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumRapport.Name = "labelNumRapport";
            this.labelNumRapport.Size = new System.Drawing.Size(154, 25);
            this.labelNumRapport.TabIndex = 1;
            this.labelNumRapport.Text = "Numéro Rapport";
            // 
            // textBoxNumRapport
            // 
            this.textBoxNumRapport.Location = new System.Drawing.Point(223, 79);
            this.textBoxNumRapport.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumRapport.Name = "textBoxNumRapport";
            this.textBoxNumRapport.ReadOnly = true;
            this.textBoxNumRapport.Size = new System.Drawing.Size(132, 22);
            this.textBoxNumRapport.TabIndex = 2;
            this.textBoxNumRapport.TextChanged += new System.EventHandler(this.textBoxNumRapport_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Praticien";
            // 
            // labelDateVisite
            // 
            this.labelDateVisite.AutoSize = true;
            this.labelDateVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateVisite.Location = new System.Drawing.Point(610, 79);
            this.labelDateVisite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateVisite.Name = "labelDateVisite";
            this.labelDateVisite.Size = new System.Drawing.Size(106, 25);
            this.labelDateVisite.TabIndex = 5;
            this.labelDateVisite.Text = "Date Visite";
            // 
            // datePickerVisite
            // 
            this.datePickerVisite.Location = new System.Drawing.Point(912, 82);
            this.datePickerVisite.Margin = new System.Windows.Forms.Padding(4);
            this.datePickerVisite.Name = "datePickerVisite";
            this.datePickerVisite.Size = new System.Drawing.Size(265, 22);
            this.datePickerVisite.TabIndex = 6;
            // 
            // comboBox_Practiciens
            // 
            this.comboBox_Practiciens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Practiciens.FormattingEnabled = true;
            this.comboBox_Practiciens.Location = new System.Drawing.Point(223, 122);
            this.comboBox_Practiciens.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Practiciens.Name = "comboBox_Practiciens";
            this.comboBox_Practiciens.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Practiciens.TabIndex = 7;
            // 
            // comboBoxMotifVisite
            // 
            this.comboBoxMotifVisite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMotifVisite.FormattingEnabled = true;
            this.comboBoxMotifVisite.Items.AddRange(new object[] {
            "Actualisation annuelle",
            "Baisse activité ",
            "Périodicité",
            "Rapport Annuel"});
            this.comboBoxMotifVisite.Location = new System.Drawing.Point(222, 181);
            this.comboBoxMotifVisite.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMotifVisite.Name = "comboBoxMotifVisite";
            this.comboBoxMotifVisite.Size = new System.Drawing.Size(160, 24);
            this.comboBoxMotifVisite.TabIndex = 9;
            // 
            // labelMotifVisite
            // 
            this.labelMotifVisite.AutoSize = true;
            this.labelMotifVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotifVisite.Location = new System.Drawing.Point(35, 183);
            this.labelMotifVisite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMotifVisite.Name = "labelMotifVisite";
            this.labelMotifVisite.Size = new System.Drawing.Size(107, 25);
            this.labelMotifVisite.TabIndex = 8;
            this.labelMotifVisite.Text = "Motif Visite";
            // 
            // labelBilan
            // 
            this.labelBilan.AutoSize = true;
            this.labelBilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBilan.Location = new System.Drawing.Point(36, 235);
            this.labelBilan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBilan.Name = "labelBilan";
            this.labelBilan.Size = new System.Drawing.Size(69, 25);
            this.labelBilan.TabIndex = 10;
            this.labelBilan.Text = "BILAN";
            // 
            // richTextBoxBilan
            // 
            this.richTextBoxBilan.Location = new System.Drawing.Point(223, 235);
            this.richTextBoxBilan.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxBilan.Name = "richTextBoxBilan";
            this.richTextBoxBilan.Size = new System.Drawing.Size(265, 112);
            this.richTextBoxBilan.TabIndex = 11;
            this.richTextBoxBilan.Text = "";
            // 
            // Btnsubmit
            // 
            this.Btnsubmit.Location = new System.Drawing.Point(521, 544);
            this.Btnsubmit.Name = "Btnsubmit";
            this.Btnsubmit.Size = new System.Drawing.Size(140, 65);
            this.Btnsubmit.TabIndex = 13;
            this.Btnsubmit.Text = "Valider";
            this.Btnsubmit.UseVisualStyleBackColor = true;
            this.Btnsubmit.Click += new System.EventHandler(this.Btnsubmit_Click);
            // 
            // prdnewrdv
            // 
            this.prdnewrdv.AutoSize = true;
            this.prdnewrdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.prdnewrdv.Location = new System.Drawing.Point(609, 129);
            this.prdnewrdv.Name = "prdnewrdv";
            this.prdnewrdv.Size = new System.Drawing.Size(281, 25);
            this.prdnewrdv.TabIndex = 14;
            this.prdnewrdv.Text = "Prendre nouveau rendez-vous ";
            // 
            // ConfPract
            // 
            this.ConfPract.AutoSize = true;
            this.ConfPract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConfPract.Location = new System.Drawing.Point(610, 217);
            this.ConfPract.Name = "ConfPract";
            this.ConfPract.Size = new System.Drawing.Size(217, 25);
            this.ConfPract.TabIndex = 15;
            this.ConfPract.Text = "Confiance practicien/10";
            // 
            // ConfLabo
            // 
            this.ConfLabo.AutoSize = true;
            this.ConfLabo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConfLabo.Location = new System.Drawing.Point(609, 266);
            this.ConfLabo.Name = "ConfLabo";
            this.ConfLabo.Size = new System.Drawing.Size(178, 25);
            this.ConfLabo.TabIndex = 16;
            this.ConfLabo.Text = "Confiance Labo/10";
            // 
            // ConnaissancePract
            // 
            this.ConnaissancePract.AutoSize = true;
            this.ConnaissancePract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConnaissancePract.Location = new System.Drawing.Point(609, 312);
            this.ConnaissancePract.Name = "ConnaissancePract";
            this.ConnaissancePract.Size = new System.Drawing.Size(228, 25);
            this.ConnaissancePract.TabIndex = 17;
            this.ConnaissancePract.Text = "Connaissance Practicien";
            // 
            // BtnFermer
            // 
            this.BtnFermer.Location = new System.Drawing.Point(740, 544);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(140, 65);
            this.BtnFermer.TabIndex = 18;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.UseVisualStyleBackColor = true;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // LabelOffreechantillons
            // 
            this.LabelOffreechantillons.AutoSize = true;
            this.LabelOffreechantillons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LabelOffreechantillons.Location = new System.Drawing.Point(134, 385);
            this.LabelOffreechantillons.Name = "LabelOffreechantillons";
            this.LabelOffreechantillons.Size = new System.Drawing.Size(221, 25);
            this.LabelOffreechantillons.TabIndex = 19;
            this.LabelOffreechantillons.Text = "Offre échantillons offerts";
            // 
            // Labeloffreechantillions
            // 
            this.Labeloffreechantillions.AutoSize = true;
            this.Labeloffreechantillions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Labeloffreechantillions.Location = new System.Drawing.Point(992, 385);
            this.Labeloffreechantillions.Name = "Labeloffreechantillions";
            this.Labeloffreechantillions.Size = new System.Drawing.Size(254, 25);
            this.Labeloffreechantillions.TabIndex = 21;
            this.Labeloffreechantillions.Text = "Offre échantillons présentés";
            // 
            // comboboxrdv
            // 
            this.comboboxrdv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxrdv.FormattingEnabled = true;
            this.comboboxrdv.Items.AddRange(new object[] {
            "Non",
            "Oui"});
            this.comboboxrdv.Location = new System.Drawing.Point(912, 129);
            this.comboboxrdv.Name = "comboboxrdv";
            this.comboboxrdv.Size = new System.Drawing.Size(121, 24);
            this.comboboxrdv.TabIndex = 23;
            this.comboboxrdv.SelectedIndexChanged += new System.EventHandler(this.comboboxrdv_SelectedIndexChanged);
            // 
            // comboBoxconfpract
            // 
            this.comboBoxconfpract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxconfpract.FormattingEnabled = true;
            this.comboBoxconfpract.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Aucune évaluation"});
            this.comboBoxconfpract.Location = new System.Drawing.Point(912, 217);
            this.comboBoxconfpract.Name = "comboBoxconfpract";
            this.comboBoxconfpract.Size = new System.Drawing.Size(121, 24);
            this.comboBoxconfpract.TabIndex = 24;
            this.comboBoxconfpract.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBoxConfLab
            // 
            this.comboBoxConfLab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfLab.FormattingEnabled = true;
            this.comboBoxConfLab.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Aucune évaluation"});
            this.comboBoxConfLab.Location = new System.Drawing.Point(912, 266);
            this.comboBoxConfLab.Name = "comboBoxConfLab";
            this.comboBoxConfLab.Size = new System.Drawing.Size(121, 24);
            this.comboBoxConfLab.TabIndex = 25;
            this.comboBoxConfLab.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBoxConnaissancepract
            // 
            this.comboBoxConnaissancepract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConnaissancepract.FormattingEnabled = true;
            this.comboBoxConnaissancepract.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Aucune évaluation"});
            this.comboBoxConnaissancepract.Location = new System.Drawing.Point(912, 312);
            this.comboBoxConnaissancepract.Name = "comboBoxConnaissancepract";
            this.comboBoxConnaissancepract.Size = new System.Drawing.Size(121, 24);
            this.comboBoxConnaissancepract.TabIndex = 26;
            // 
            // datePickerProchainevisite
            // 
            this.datePickerProchainevisite.Location = new System.Drawing.Point(912, 169);
            this.datePickerProchainevisite.Margin = new System.Windows.Forms.Padding(4);
            this.datePickerProchainevisite.Name = "datePickerProchainevisite";
            this.datePickerProchainevisite.Size = new System.Drawing.Size(265, 22);
            this.datePickerProchainevisite.TabIndex = 28;
            this.datePickerProchainevisite.Visible = false;
            // 
            // dataGridView_echantillonOffert
            // 
            this.dataGridView_echantillonOffert.AllowUserToDeleteRows = false;
            this.dataGridView_echantillonOffert.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_echantillonOffert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_echantillonOffert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView_echantillonOffert.Location = new System.Drawing.Point(78, 421);
            this.dataGridView_echantillonOffert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_echantillonOffert.Name = "dataGridView_echantillonOffert";
            this.dataGridView_echantillonOffert.RowTemplate.Height = 24;
            this.dataGridView_echantillonOffert.Size = new System.Drawing.Size(350, 185);
            this.dataGridView_echantillonOffert.TabIndex = 44;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.Frozen = true;
            this.dataGridViewComboBoxColumn1.HeaderText = "Médicament";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridView_echantillonPresente
            // 
            this.dataGridView_echantillonPresente.AllowUserToDeleteRows = false;
            this.dataGridView_echantillonPresente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_echantillonPresente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_echantillonPresente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicaments,
            this.Nombre});
            this.dataGridView_echantillonPresente.Location = new System.Drawing.Point(943, 421);
            this.dataGridView_echantillonPresente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_echantillonPresente.Name = "dataGridView_echantillonPresente";
            this.dataGridView_echantillonPresente.RowTemplate.Height = 24;
            this.dataGridView_echantillonPresente.Size = new System.Drawing.Size(350, 185);
            this.dataGridView_echantillonPresente.TabIndex = 45;
            // 
            // Medicaments
            // 
            this.Medicaments.Frozen = true;
            this.Medicaments.HeaderText = "Médicament";
            this.Medicaments.Name = "Medicaments";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ErrorPraticien
            // 
            this.ErrorPraticien.ContainerControl = this;
            // 
            // ErrorMotifVisite
            // 
            this.ErrorMotifVisite.ContainerControl = this;
            // 
            // ErrorConfiancePrat
            // 
            this.ErrorConfiancePrat.ContainerControl = this;
            // 
            // ErrorConfianceLabo
            // 
            this.ErrorConfianceLabo.ContainerControl = this;
            // 
            // ErrorConnaissancePrat
            // 
            this.ErrorConnaissancePrat.ContainerControl = this;
            // 
            // RapportVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 654);
            this.Controls.Add(this.dataGridView_echantillonPresente);
            this.Controls.Add(this.dataGridView_echantillonOffert);
            this.Controls.Add(this.datePickerProchainevisite);
            this.Controls.Add(this.comboBoxConnaissancepract);
            this.Controls.Add(this.comboBoxConfLab);
            this.Controls.Add(this.comboBoxconfpract);
            this.Controls.Add(this.comboboxrdv);
            this.Controls.Add(this.Labeloffreechantillions);
            this.Controls.Add(this.LabelOffreechantillons);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.ConnaissancePract);
            this.Controls.Add(this.ConfLabo);
            this.Controls.Add(this.ConfPract);
            this.Controls.Add(this.prdnewrdv);
            this.Controls.Add(this.Btnsubmit);
            this.Controls.Add(this.richTextBoxBilan);
            this.Controls.Add(this.labelBilan);
            this.Controls.Add(this.comboBoxMotifVisite);
            this.Controls.Add(this.labelMotifVisite);
            this.Controls.Add(this.comboBox_Practiciens);
            this.Controls.Add(this.datePickerVisite);
            this.Controls.Add(this.labelDateVisite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumRapport);
            this.Controls.Add(this.labelNumRapport);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RapportVisite";
            this.Text = "Rapport de Visite";
            this.Load += new System.EventHandler(this.RapportVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_echantillonOffert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_echantillonPresente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPraticien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMotifVisite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorConfiancePrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorConfianceLabo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorConnaissancePrat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumRapport;
        private System.Windows.Forms.TextBox textBoxNumRapport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDateVisite;
        private System.Windows.Forms.DateTimePicker datePickerVisite;
        private System.Windows.Forms.ComboBox comboBox_Practiciens;
        private System.Windows.Forms.ComboBox comboBoxMotifVisite;
        private System.Windows.Forms.Label labelMotifVisite;
        private System.Windows.Forms.Label labelBilan;
        private System.Windows.Forms.RichTextBox richTextBoxBilan;
        private System.Windows.Forms.Button Btnsubmit;
        private System.Windows.Forms.Label prdnewrdv;
        private System.Windows.Forms.Label ConfPract;
        private System.Windows.Forms.Label ConfLabo;
        private System.Windows.Forms.Label ConnaissancePract;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Label LabelOffreechantillons;
        private System.Windows.Forms.Label Labeloffreechantillions;
        private System.Windows.Forms.ComboBox comboboxrdv;
        private System.Windows.Forms.ComboBox comboBoxconfpract;
        private System.Windows.Forms.ComboBox comboBoxConfLab;
        private System.Windows.Forms.ComboBox comboBoxConnaissancepract;
        private System.Windows.Forms.DateTimePicker datePickerProchainevisite;
        private System.Windows.Forms.DataGridView dataGridView_echantillonOffert;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView_echantillonPresente;
        private System.Windows.Forms.DataGridViewComboBoxColumn Medicaments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.ErrorProvider ErrorPraticien;
        private System.Windows.Forms.ErrorProvider ErrorMotifVisite;
        private System.Windows.Forms.ErrorProvider ErrorConfiancePrat;
        private System.Windows.Forms.ErrorProvider ErrorConfianceLabo;
        private System.Windows.Forms.ErrorProvider ErrorConnaissancePrat;
    }
}