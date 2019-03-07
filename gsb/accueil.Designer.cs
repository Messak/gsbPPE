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
            this.SuspendLayout();
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.AutoSize = true;
            this.labelMainTitle.BackColor = System.Drawing.SystemColors.Control;
            this.labelMainTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelMainTitle.Location = new System.Drawing.Point(190, 27);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(394, 32);
            this.labelMainTitle.TabIndex = 0;
            this.labelMainTitle.Text = "Gestion des comptes rendus";
            // 
            // buttonCompteRendu
            // 
            this.buttonCompteRendu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompteRendu.Location = new System.Drawing.Point(297, 103);
            this.buttonCompteRendu.Name = "buttonCompteRendu";
            this.buttonCompteRendu.Size = new System.Drawing.Size(180, 43);
            this.buttonCompteRendu.TabIndex = 1;
            this.buttonCompteRendu.Text = "Compte Rendu";
            this.buttonCompteRendu.UseVisualStyleBackColor = true;
            // 
            // buttonMedicament
            // 
            this.buttonMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedicament.Location = new System.Drawing.Point(297, 179);
            this.buttonMedicament.Name = "buttonMedicament";
            this.buttonMedicament.Size = new System.Drawing.Size(180, 43);
            this.buttonMedicament.TabIndex = 2;
            this.buttonMedicament.Text = "Médicaments";
            this.buttonMedicament.UseVisualStyleBackColor = true;
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeconnexion.Location = new System.Drawing.Point(297, 253);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(180, 43);
            this.buttonDeconnexion.TabIndex = 3;
            this.buttonDeconnexion.Text = "Déconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = true;
            // 
            // accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 360);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonMedicament);
            this.Controls.Add(this.buttonCompteRendu);
            this.Controls.Add(this.labelMainTitle);
            this.Name = "accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainTitle;
        private System.Windows.Forms.Button buttonCompteRendu;
        private System.Windows.Forms.Button buttonMedicament;
        private System.Windows.Forms.Button buttonDeconnexion;
    }
}