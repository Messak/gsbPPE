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
            this.buttonCompteRendu = new System.Windows.Forms.Button();
            this.buttonMedicament = new System.Windows.Forms.Button();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.buttonListerCompteRendu = new System.Windows.Forms.Button();
            this.buttonRedigerCompteRendu = new System.Windows.Forms.Button();
            this.statututilisateur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.AutoSize = true;
            this.labelMainTitle.BackColor = System.Drawing.SystemColors.Control;
            this.labelMainTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelMainTitle.Location = new System.Drawing.Point(253, 33);
            this.labelMainTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(482, 40);
            this.labelMainTitle.TabIndex = 0;
            this.labelMainTitle.Text = "Gestion des comptes rendus";
            // 
            // buttonCompteRendu
            // 
            this.buttonCompteRendu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompteRendu.Location = new System.Drawing.Point(396, 127);
            this.buttonCompteRendu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCompteRendu.Name = "buttonCompteRendu";
            this.buttonCompteRendu.Size = new System.Drawing.Size(240, 53);
            this.buttonCompteRendu.TabIndex = 1;
            this.buttonCompteRendu.Text = "Compte Rendu";
            this.buttonCompteRendu.UseVisualStyleBackColor = true;
            this.buttonCompteRendu.Click += new System.EventHandler(this.buttonCompteRendu_Click);
            // 
            // buttonMedicament
            // 
            this.buttonMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedicament.Location = new System.Drawing.Point(396, 220);
            this.buttonMedicament.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMedicament.Name = "buttonMedicament";
            this.buttonMedicament.Size = new System.Drawing.Size(240, 53);
            this.buttonMedicament.TabIndex = 2;
            this.buttonMedicament.Text = "Médicaments";
            this.buttonMedicament.UseVisualStyleBackColor = true;
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeconnexion.Location = new System.Drawing.Point(396, 313);
            this.buttonDeconnexion.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(240, 53);
            this.buttonDeconnexion.TabIndex = 3;
            this.buttonDeconnexion.Text = "Déconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = true;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // buttonListerCompteRendu
            // 
            this.buttonListerCompteRendu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListerCompteRendu.Location = new System.Drawing.Point(261, 127);
            this.buttonListerCompteRendu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonListerCompteRendu.Name = "buttonListerCompteRendu";
            this.buttonListerCompteRendu.Size = new System.Drawing.Size(240, 53);
            this.buttonListerCompteRendu.TabIndex = 4;
            this.buttonListerCompteRendu.Text = "Lister les Comptes Rendus";
            this.buttonListerCompteRendu.UseVisualStyleBackColor = true;
            this.buttonListerCompteRendu.Visible = false;
            // 
            // buttonRedigerCompteRendu
            // 
            this.buttonRedigerCompteRendu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedigerCompteRendu.Location = new System.Drawing.Point(539, 127);
            this.buttonRedigerCompteRendu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRedigerCompteRendu.Name = "buttonRedigerCompteRendu";
            this.buttonRedigerCompteRendu.Size = new System.Drawing.Size(240, 53);
            this.buttonRedigerCompteRendu.TabIndex = 5;
            this.buttonRedigerCompteRendu.Text = "Rédiger un Compte Rendu";
            this.buttonRedigerCompteRendu.UseVisualStyleBackColor = true;
            this.buttonRedigerCompteRendu.Visible = false;
            this.buttonRedigerCompteRendu.Click += new System.EventHandler(this.buttonRedigerCompteRendu_Click);
            // 
            // statututilisateur
            // 
            this.statututilisateur.AutoSize = true;
            this.statututilisateur.Location = new System.Drawing.Point(894, 9);
            this.statututilisateur.Name = "statututilisateur";
            this.statututilisateur.Size = new System.Drawing.Size(0, 17);
            this.statututilisateur.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(736, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Connecté en tant que :";
            // 
            // accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statututilisateur);
            this.Controls.Add(this.buttonRedigerCompteRendu);
            this.Controls.Add(this.buttonListerCompteRendu);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonMedicament);
            this.Controls.Add(this.buttonCompteRendu);
            this.Controls.Add(this.labelMainTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.accueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainTitle;
        private System.Windows.Forms.Button buttonCompteRendu;
        private System.Windows.Forms.Button buttonMedicament;
        private System.Windows.Forms.Button buttonDeconnexion;
        private System.Windows.Forms.Button buttonListerCompteRendu;
        private System.Windows.Forms.Button buttonRedigerCompteRendu;
        private System.Windows.Forms.Label statututilisateur;
        private System.Windows.Forms.Label label1;
    }
}