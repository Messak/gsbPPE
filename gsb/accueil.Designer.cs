namespace gsb
{
    partial class accueil
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
            this.labelMainTitle = new System.Windows.Forms.Label();
            this.buttonRapportMain = new System.Windows.Forms.Button();
            this.buttonMedicament = new System.Windows.Forms.Button();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.buttonRapportLister = new System.Windows.Forms.Button();
            this.buttonRapportModif = new System.Windows.Forms.Button();
            this.statututilisateur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVisiteurLister = new System.Windows.Forms.Button();
            this.buttonVisiteurMain = new System.Windows.Forms.Button();
            this.buttonVisiteurModif = new System.Windows.Forms.Button();
            this.buttonPraticienMain = new System.Windows.Forms.Button();
            this.buttonPraticienLister = new System.Windows.Forms.Button();
            this.buttonPraticienModif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.AutoSize = true;
            this.labelMainTitle.BackColor = System.Drawing.SystemColors.Control;
            this.labelMainTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelMainTitle.Location = new System.Drawing.Point(244, 29);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(291, 32);
            this.labelMainTitle.TabIndex = 0;
            this.labelMainTitle.Text = "RAPPORT DE VISITE";
            // 
            // buttonRapportMain
            // 
            this.buttonRapportMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRapportMain.Location = new System.Drawing.Point(196, 103);
            this.buttonRapportMain.Name = "buttonRapportMain";
            this.buttonRapportMain.Size = new System.Drawing.Size(388, 43);
            this.buttonRapportMain.TabIndex = 1;
            this.buttonRapportMain.Text = "Compte Rendu";
            this.buttonRapportMain.UseVisualStyleBackColor = true;
            this.buttonRapportMain.Click += new System.EventHandler(this.buttonCompteRendu_Click);
            // 
            // buttonMedicament
            // 
            this.buttonMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedicament.Location = new System.Drawing.Point(297, 282);
            this.buttonMedicament.Name = "buttonMedicament";
            this.buttonMedicament.Size = new System.Drawing.Size(180, 43);
            this.buttonMedicament.TabIndex = 2;
            this.buttonMedicament.Text = "Médicaments";
            this.buttonMedicament.UseVisualStyleBackColor = true;
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeconnexion.Location = new System.Drawing.Point(638, 306);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(122, 43);
            this.buttonDeconnexion.TabIndex = 3;
            this.buttonDeconnexion.Text = "Déconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = true;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // buttonRapportLister
            // 
            this.buttonRapportLister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRapportLister.Location = new System.Drawing.Point(196, 103);
            this.buttonRapportLister.Name = "buttonRapportLister";
            this.buttonRapportLister.Size = new System.Drawing.Size(180, 43);
            this.buttonRapportLister.TabIndex = 4;
            this.buttonRapportLister.Text = "Lister les Comptes Rendus";
            this.buttonRapportLister.UseVisualStyleBackColor = true;
            this.buttonRapportLister.Visible = false;
            this.buttonRapportLister.Click += new System.EventHandler(this.buttonListerCompteRendu_Click);
            // 
            // buttonRapportModif
            // 
            this.buttonRapportModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRapportModif.Location = new System.Drawing.Point(404, 103);
            this.buttonRapportModif.Name = "buttonRapportModif";
            this.buttonRapportModif.Size = new System.Drawing.Size(180, 43);
            this.buttonRapportModif.TabIndex = 5;
            this.buttonRapportModif.Text = "Rédiger un Compte Rendu";
            this.buttonRapportModif.UseVisualStyleBackColor = true;
            this.buttonRapportModif.Visible = false;
            this.buttonRapportModif.Click += new System.EventHandler(this.buttonRedigerCompteRendu_Click);
            // 
            // statututilisateur
            // 
            this.statututilisateur.AutoSize = true;
            this.statututilisateur.Location = new System.Drawing.Point(670, 7);
            this.statututilisateur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statututilisateur.Name = "statututilisateur";
            this.statututilisateur.Size = new System.Drawing.Size(0, 13);
            this.statututilisateur.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Connecté en tant que :";
            // 
            // buttonVisiteurLister
            // 
            this.buttonVisiteurLister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisiteurLister.Location = new System.Drawing.Point(196, 152);
            this.buttonVisiteurLister.Name = "buttonVisiteurLister";
            this.buttonVisiteurLister.Size = new System.Drawing.Size(180, 43);
            this.buttonVisiteurLister.TabIndex = 8;
            this.buttonVisiteurLister.Text = "Lister tout les visiteurs";
            this.buttonVisiteurLister.UseVisualStyleBackColor = true;
            this.buttonVisiteurLister.Visible = false;
            this.buttonVisiteurLister.Click += new System.EventHandler(this.BtnListerVisiteurs_Click);
            // 
            // buttonVisiteurMain
            // 
            this.buttonVisiteurMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisiteurMain.Location = new System.Drawing.Point(196, 152);
            this.buttonVisiteurMain.Name = "buttonVisiteurMain";
            this.buttonVisiteurMain.Size = new System.Drawing.Size(388, 43);
            this.buttonVisiteurMain.TabIndex = 10;
            this.buttonVisiteurMain.Text = "Visiteur";
            this.buttonVisiteurMain.UseVisualStyleBackColor = true;
            this.buttonVisiteurMain.Click += new System.EventHandler(this.buttonVisiteurMain_Click);
            // 
            // buttonVisiteurModif
            // 
            this.buttonVisiteurModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisiteurModif.Location = new System.Drawing.Point(404, 152);
            this.buttonVisiteurModif.Name = "buttonVisiteurModif";
            this.buttonVisiteurModif.Size = new System.Drawing.Size(180, 43);
            this.buttonVisiteurModif.TabIndex = 12;
            this.buttonVisiteurModif.Text = "Modifier/Ajouter un Visiteur";
            this.buttonVisiteurModif.UseVisualStyleBackColor = true;
            this.buttonVisiteurModif.Visible = false;
            // 
            // buttonPraticienMain
            // 
            this.buttonPraticienMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPraticienMain.Location = new System.Drawing.Point(196, 201);
            this.buttonPraticienMain.Name = "buttonPraticienMain";
            this.buttonPraticienMain.Size = new System.Drawing.Size(388, 43);
            this.buttonPraticienMain.TabIndex = 13;
            this.buttonPraticienMain.Text = "Praticien";
            this.buttonPraticienMain.UseVisualStyleBackColor = true;
            this.buttonPraticienMain.Click += new System.EventHandler(this.buttonPraticienMain_Click);
            // 
            // buttonPraticienLister
            // 
            this.buttonPraticienLister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonPraticienLister.Location = new System.Drawing.Point(196, 201);
            this.buttonPraticienLister.Name = "buttonPraticienLister";
            this.buttonPraticienLister.Size = new System.Drawing.Size(180, 43);
            this.buttonPraticienLister.TabIndex = 14;
            this.buttonPraticienLister.Text = "Lister tout les praticiens";
            this.buttonPraticienLister.UseVisualStyleBackColor = true;
            this.buttonPraticienLister.Visible = false;
            this.buttonPraticienLister.Click += new System.EventHandler(this.buttonPraticienLister_Click);
            // 
            // buttonPraticienModif
            // 
            this.buttonPraticienModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonPraticienModif.Location = new System.Drawing.Point(404, 201);
            this.buttonPraticienModif.Name = "buttonPraticienModif";
            this.buttonPraticienModif.Size = new System.Drawing.Size(180, 43);
            this.buttonPraticienModif.TabIndex = 15;
            this.buttonPraticienModif.Text = "Modifier/Ajouter un Praticien";
            this.buttonPraticienModif.UseVisualStyleBackColor = true;
            this.buttonPraticienModif.Visible = false;
            // 
            // accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 360);
            this.Controls.Add(this.buttonPraticienModif);
            this.Controls.Add(this.buttonPraticienLister);
            this.Controls.Add(this.buttonPraticienMain);
            this.Controls.Add(this.buttonVisiteurLister);
            this.Controls.Add(this.buttonVisiteurModif);
            this.Controls.Add(this.buttonVisiteurMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statututilisateur);
            this.Controls.Add(this.buttonRapportModif);
            this.Controls.Add(this.buttonRapportLister);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonMedicament);
            this.Controls.Add(this.buttonRapportMain);
            this.Controls.Add(this.labelMainTitle);
            this.Name = "accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.accueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainTitle;
        private System.Windows.Forms.Button buttonRapportMain;
        private System.Windows.Forms.Button buttonMedicament;
        private System.Windows.Forms.Button buttonDeconnexion;
        private System.Windows.Forms.Button buttonRapportLister;
        private System.Windows.Forms.Button buttonRapportModif;
        private System.Windows.Forms.Label statututilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVisiteurLister;
        private System.Windows.Forms.Button buttonVisiteurMain;
        private System.Windows.Forms.Button buttonVisiteurModif;
        private System.Windows.Forms.Button buttonPraticienMain;
        private System.Windows.Forms.Button buttonPraticienLister;
        private System.Windows.Forms.Button buttonPraticienModif;
    }
}