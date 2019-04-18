namespace gsb
{
    partial class Praticiens
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
            this.NomPrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomPrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdressePrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPPrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VillePrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoefNotorietePrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypePrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomPrat,
            this.PrenomPrat,
            this.NumPrat,
            this.AdressePrat,
            this.CPPrat,
            this.VillePrat,
            this.CoefNotorietePrat,
            this.TypePrat});
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.Location = new System.Drawing.Point(0, -1);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(803, 432);
            this.dataGridView.TabIndex = 2;
            // 
            // NomPrat
            // 
            this.NomPrat.HeaderText = "Nom";
            this.NomPrat.Name = "NomPrat";
            // 
            // PrenomPrat
            // 
            this.PrenomPrat.HeaderText = "Prenom";
            this.PrenomPrat.Name = "PrenomPrat";
            // 
            // NumPrat
            // 
            this.NumPrat.HeaderText = "Numéro ";
            this.NumPrat.Name = "NumPrat";
            // 
            // AdressePrat
            // 
            this.AdressePrat.HeaderText = "Adresse";
            this.AdressePrat.Name = "AdressePrat";
            // 
            // CPPrat
            // 
            this.CPPrat.HeaderText = "Code postal";
            this.CPPrat.Name = "CPPrat";
            // 
            // VillePrat
            // 
            this.VillePrat.HeaderText = "Ville";
            this.VillePrat.Name = "VillePrat";
            // 
            // CoefNotorietePrat
            // 
            this.CoefNotorietePrat.HeaderText = "Coefficient Notoriété";
            this.CoefNotorietePrat.Name = "CoefNotorietePrat";
            // 
            // TypePrat
            // 
            this.TypePrat.HeaderText = "Type praticien";
            this.TypePrat.Name = "TypePrat";
            // 
            // Praticiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 426);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Praticiens";
            this.Text = "Praticiens";
            this.Load += new System.EventHandler(this.Praticiens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomPrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdressePrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPPrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn VillePrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoefNotorietePrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypePrat;
    }
}