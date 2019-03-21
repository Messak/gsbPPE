namespace gsb
{
    partial class ListerCompteRendu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.NumRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rapDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateVisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Praticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editer = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumRapport,
            this.rapDate,
            this.DateVisite,
            this.Praticien,
            this.Editer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.Size = new System.Drawing.Size(622, 377);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NumRapport
            // 
            this.NumRapport.HeaderText = "N°";
            this.NumRapport.Name = "NumRapport";
            this.NumRapport.ReadOnly = true;
            this.NumRapport.Width = 50;
            // 
            // rapDate
            // 
            this.rapDate.HeaderText = "Date Rapport";
            this.rapDate.Name = "rapDate";
            this.rapDate.ReadOnly = true;
            this.rapDate.Width = 150;
            // 
            // DateVisite
            // 
            this.DateVisite.HeaderText = "Date Visite";
            this.DateVisite.Name = "DateVisite";
            this.DateVisite.ReadOnly = true;
            this.DateVisite.Width = 150;
            // 
            // Praticien
            // 
            this.Praticien.HeaderText = "Praticien";
            this.Praticien.Name = "Praticien";
            this.Praticien.ReadOnly = true;
            this.Praticien.Width = 150;
            // 
            // Editer
            // 
            this.Editer.FillWeight = 50F;
            this.Editer.HeaderText = "Editer";
            this.Editer.Image = global::gsb.Properties.Resources.edit_icon;
            this.Editer.Name = "Editer";
            this.Editer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editer.ToolTipText = "Permet d\'éditer le rapport";
            this.Editer.Width = 80;
            // 
            // ListerCompteRendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 404);
            this.Controls.Add(this.dataGridView);
            this.Name = "ListerCompteRendu";
            this.Text = "ListerCompteRendu";
            this.Load += new System.EventHandler(this.ListerCompteRendu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn rapDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateVisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Praticien;
        private System.Windows.Forms.DataGridViewImageColumn Editer;
    }
}