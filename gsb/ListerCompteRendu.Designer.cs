﻿namespace gsb
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.NumRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rapDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.praticienNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumRapport,
            this.rapDate,
            this.Col,
            this.praticienNom});
            this.dataGridView.Location = new System.Drawing.Point(24, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(745, 389);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NumRapport
            // 
            this.NumRapport.HeaderText = "Num Rapport";
            this.NumRapport.Name = "NumRapport";
            // 
            // rapDate
            // 
            this.rapDate.HeaderText = "Date";
            this.rapDate.Name = "rapDate";
            // 
            // Col
            // 
            this.Col.HeaderText = "Collaborateur";
            this.Col.Name = "Col";
            // 
            // praticienNom
            // 
            this.praticienNom.HeaderText = "Praticien";
            this.praticienNom.Name = "praticienNom";
            // 
            // ListerCompteRendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn praticienNom;
    }
}