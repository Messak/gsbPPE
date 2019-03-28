namespace gsb
{
    partial class Visiteurs
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.NameVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresseVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Villevisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEmbaucheVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameVisiteur,
            this.PrenomVisiteur,
            this.MatVisiteur,
            this.AdresseVisiteur,
            this.CPVisiteur,
            this.Villevisiteur,
            this.DateEmbaucheVisiteur,
            this.LabVisiteur});
            this.dataGridView.Location = new System.Drawing.Point(57, 28);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1117, 532);
            this.dataGridView.TabIndex = 1;
            // 
            // NameVisiteur
            // 
            this.NameVisiteur.HeaderText = "Nom";
            this.NameVisiteur.Name = "NameVisiteur";
            // 
            // PrenomVisiteur
            // 
            this.PrenomVisiteur.HeaderText = "Prenom";
            this.PrenomVisiteur.Name = "PrenomVisiteur";
            // 
            // MatVisiteur
            // 
            this.MatVisiteur.HeaderText = "Matricule";
            this.MatVisiteur.Name = "MatVisiteur";
            // 
            // AdresseVisiteur
            // 
            this.AdresseVisiteur.HeaderText = "Adresse";
            this.AdresseVisiteur.Name = "AdresseVisiteur";
            // 
            // CPVisiteur
            // 
            this.CPVisiteur.HeaderText = "Code Postal";
            this.CPVisiteur.Name = "CPVisiteur";
            // 
            // Villevisiteur
            // 
            this.Villevisiteur.HeaderText = "Ville";
            this.Villevisiteur.Name = "Villevisiteur";
            // 
            // DateEmbaucheVisiteur
            // 
            this.DateEmbaucheVisiteur.HeaderText = "Date d\'embauche";
            this.DateEmbaucheVisiteur.Name = "DateEmbaucheVisiteur";
            // 
            // LabVisiteur
            // 
            this.LabVisiteur.HeaderText = "Laboratoire ";
            this.LabVisiteur.Name = "LabVisiteur";
            // 
            // Visiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 573);
            this.Controls.Add(this.dataGridView);
            this.Name = "Visiteurs";
            this.Text = "Visiteurs";
            this.Load += new System.EventHandler(this.Visiteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresseVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Villevisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEmbaucheVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabVisiteur;
    }
}