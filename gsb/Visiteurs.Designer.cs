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
            this.Modifier = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameVisiteur,
            this.PrenomVisiteur,
            this.MatVisiteur,
            this.AdresseVisiteur,
            this.CPVisiteur,
            this.Villevisiteur,
            this.DateEmbaucheVisiteur,
            this.LabVisiteur,
            this.Modifier});
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.Location = new System.Drawing.Point(0, -1);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(802, 432);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // NameVisiteur
            // 
            this.NameVisiteur.HeaderText = "Nom";
            this.NameVisiteur.Name = "NameVisiteur";
            this.NameVisiteur.ReadOnly = true;
            // 
            // PrenomVisiteur
            // 
            this.PrenomVisiteur.HeaderText = "Prenom";
            this.PrenomVisiteur.Name = "PrenomVisiteur";
            this.PrenomVisiteur.ReadOnly = true;
            // 
            // MatVisiteur
            // 
            this.MatVisiteur.HeaderText = "Matricule";
            this.MatVisiteur.Name = "MatVisiteur";
            this.MatVisiteur.ReadOnly = true;
            // 
            // AdresseVisiteur
            // 
            this.AdresseVisiteur.HeaderText = "Adresse";
            this.AdresseVisiteur.Name = "AdresseVisiteur";
            this.AdresseVisiteur.ReadOnly = true;
            // 
            // CPVisiteur
            // 
            this.CPVisiteur.HeaderText = "Code Postal";
            this.CPVisiteur.Name = "CPVisiteur";
            this.CPVisiteur.ReadOnly = true;
            // 
            // Villevisiteur
            // 
            this.Villevisiteur.HeaderText = "Ville";
            this.Villevisiteur.Name = "Villevisiteur";
            this.Villevisiteur.ReadOnly = true;
            // 
            // DateEmbaucheVisiteur
            // 
            this.DateEmbaucheVisiteur.HeaderText = "Date d\'embauche";
            this.DateEmbaucheVisiteur.Name = "DateEmbaucheVisiteur";
            this.DateEmbaucheVisiteur.ReadOnly = true;
            // 
            // LabVisiteur
            // 
            this.LabVisiteur.HeaderText = "Laboratoire ";
            this.LabVisiteur.Name = "LabVisiteur";
            this.LabVisiteur.ReadOnly = true;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Image = global::gsb.Properties.Resources.document;
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            this.Modifier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modifier.Visible = false;
            // 
            // Visiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Visiteurs";
            this.Text = "Visiteurs";
            this.Load += new System.EventHandler(this.Visiteurs_Load);
            this.Resize += new System.EventHandler(this.Visiteurs_Resize);
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
        private System.Windows.Forms.DataGridViewImageColumn Modifier;
    }
}