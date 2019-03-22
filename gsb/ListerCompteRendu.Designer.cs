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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListerCompteRendu));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridColumnNumRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColumnrapDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColumnDateVisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColumnPraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridColumnEditer = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridColumnSupprimer = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.dataGridColumnNumRapport,
            this.dataGridColumnrapDate,
            this.dataGridColumnDateVisite,
            this.dataGridColumnPraticien,
            this.dataGridColumnEditer,
            this.dataGridColumnSupprimer});
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
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(584, 377);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "Editer";
            this.dataGridViewImageColumn1.Image = global::gsb.Properties.Resources.edit_icon;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Permet d\'éditer le rapport";
            this.dataGridViewImageColumn1.Width = 80;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Supprimer";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridColumnNumRapport
            // 
            this.dataGridColumnNumRapport.HeaderText = "N°";
            this.dataGridColumnNumRapport.Name = "dataGridColumnNumRapport";
            this.dataGridColumnNumRapport.ReadOnly = true;
            this.dataGridColumnNumRapport.Width = 50;
            // 
            // dataGridColumnrapDate
            // 
            this.dataGridColumnrapDate.HeaderText = "Date Rapport";
            this.dataGridColumnrapDate.Name = "dataGridColumnrapDate";
            this.dataGridColumnrapDate.ReadOnly = true;
            this.dataGridColumnrapDate.Width = 150;
            // 
            // dataGridColumnDateVisite
            // 
            this.dataGridColumnDateVisite.HeaderText = "Date Visite";
            this.dataGridColumnDateVisite.Name = "dataGridColumnDateVisite";
            this.dataGridColumnDateVisite.ReadOnly = true;
            this.dataGridColumnDateVisite.Width = 150;
            // 
            // dataGridColumnPraticien
            // 
            this.dataGridColumnPraticien.HeaderText = "Praticien";
            this.dataGridColumnPraticien.Name = "dataGridColumnPraticien";
            this.dataGridColumnPraticien.ReadOnly = true;
            this.dataGridColumnPraticien.Width = 150;
            // 
            // dataGridColumnEditer
            // 
            this.dataGridColumnEditer.FillWeight = 50F;
            this.dataGridColumnEditer.HeaderText = "Editer";
            this.dataGridColumnEditer.Image = global::gsb.Properties.Resources.edit_icon;
            this.dataGridColumnEditer.Name = "dataGridColumnEditer";
            this.dataGridColumnEditer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridColumnEditer.ToolTipText = "Permet d\'éditer le rapport";
            this.dataGridColumnEditer.Width = 80;
            // 
            // dataGridColumnSupprimer
            // 
            this.dataGridColumnSupprimer.HeaderText = "Supprimer";
            this.dataGridColumnSupprimer.Image = global::gsb.Properties.Resources.red_cross_icon;
            this.dataGridColumnSupprimer.Name = "dataGridColumnSupprimer";
            this.dataGridColumnSupprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridColumnSupprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridColumnSupprimer.Visible = false;
            // 
            // ListerCompteRendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 404);
            this.Controls.Add(this.dataGridView);
            this.Name = "ListerCompteRendu";
            this.Text = "ListerCompteRendu";
            this.Load += new System.EventHandler(this.ListerCompteRendu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColumnNumRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColumnrapDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColumnDateVisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridColumnPraticien;
        private System.Windows.Forms.DataGridViewImageColumn dataGridColumnEditer;
        private System.Windows.Forms.DataGridViewImageColumn dataGridColumnSupprimer;
    }
}