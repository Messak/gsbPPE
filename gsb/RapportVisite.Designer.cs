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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumRapport = new System.Windows.Forms.Label();
            this.textBoxNumRapport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDateRapport = new System.Windows.Forms.Label();
            this.datePickerRapport = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Practiciens = new System.Windows.Forms.ComboBox();
            this.comboBoxMotifVisite = new System.Windows.Forms.ComboBox();
            this.labelMotifVisite = new System.Windows.Forms.Label();
            this.labelBilan = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toz = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.prdnewrdv = new System.Windows.Forms.Label();
            this.ConfPract = new System.Windows.Forms.Label();
            this.ConfLabo = new System.Windows.Forms.Label();
            this.ConnaissancePract = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(375, 22);
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
            // labelDateRapport
            // 
            this.labelDateRapport.AutoSize = true;
            this.labelDateRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateRapport.Location = new System.Drawing.Point(36, 162);
            this.labelDateRapport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateRapport.Name = "labelDateRapport";
            this.labelDateRapport.Size = new System.Drawing.Size(126, 25);
            this.labelDateRapport.TabIndex = 5;
            this.labelDateRapport.Text = "Date Rapport";
            // 
            // datePickerRapport
            // 
            this.datePickerRapport.Location = new System.Drawing.Point(223, 162);
            this.datePickerRapport.Margin = new System.Windows.Forms.Padding(4);
            this.datePickerRapport.Name = "datePickerRapport";
            this.datePickerRapport.Size = new System.Drawing.Size(265, 22);
            this.datePickerRapport.TabIndex = 6;
            // 
            // comboBox_Practiciens
            // 
            this.comboBox_Practiciens.FormattingEnabled = true;
            this.comboBox_Practiciens.Location = new System.Drawing.Point(223, 122);
            this.comboBox_Practiciens.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Practiciens.Name = "comboBox_Practiciens";
            this.comboBox_Practiciens.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Practiciens.TabIndex = 7;
            // 
            // comboBoxMotifVisite
            // 
            this.comboBoxMotifVisite.FormattingEnabled = true;
            this.comboBoxMotifVisite.Location = new System.Drawing.Point(223, 204);
            this.comboBoxMotifVisite.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMotifVisite.Name = "comboBoxMotifVisite";
            this.comboBoxMotifVisite.Size = new System.Drawing.Size(160, 24);
            this.comboBoxMotifVisite.TabIndex = 9;
            // 
            // labelMotifVisite
            // 
            this.labelMotifVisite.AutoSize = true;
            this.labelMotifVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotifVisite.Location = new System.Drawing.Point(36, 206);
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
            this.labelBilan.Location = new System.Drawing.Point(36, 249);
            this.labelBilan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBilan.Name = "labelBilan";
            this.labelBilan.Size = new System.Drawing.Size(69, 25);
            this.labelBilan.TabIndex = 10;
            this.labelBilan.Text = "BILAN";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(223, 249);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(265, 112);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // toz
            // 
            this.toz.AutoSize = true;
            this.toz.Location = new System.Drawing.Point(801, 177);
            this.toz.Name = "toz";
            this.toz.Size = new System.Drawing.Size(0, 17);
            this.toz.TabIndex = 12;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(550, 670);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(140, 65);
            this.btnsubmit.TabIndex = 13;
            this.btnsubmit.Text = "Valider";
            this.btnsubmit.UseVisualStyleBackColor = true;
            // 
            // prdnewrdv
            // 
            this.prdnewrdv.AutoSize = true;
            this.prdnewrdv.Location = new System.Drawing.Point(612, 79);
            this.prdnewrdv.Name = "prdnewrdv";
            this.prdnewrdv.Size = new System.Drawing.Size(221, 17);
            this.prdnewrdv.TabIndex = 14;
            this.prdnewrdv.Text = "Prendre nouveau renddez-vous ?";
            // 
            // ConfPract
            // 
            this.ConfPract.AutoSize = true;
            this.ConfPract.Location = new System.Drawing.Point(615, 122);
            this.ConfPract.Name = "ConfPract";
            this.ConfPract.Size = new System.Drawing.Size(156, 17);
            this.ConfPract.TabIndex = 15;
            this.ConfPract.Text = "Confiance practicien/10";
            // 
            // ConfLabo
            // 
            this.ConfLabo.AutoSize = true;
            this.ConfLabo.Location = new System.Drawing.Point(615, 162);
            this.ConfLabo.Name = "ConfLabo";
            this.ConfLabo.Size = new System.Drawing.Size(127, 17);
            this.ConfLabo.TabIndex = 16;
            this.ConfLabo.Text = "Confiance Labo/10";
            // 
            // ConnaissancePract
            // 
            this.ConnaissancePract.AutoSize = true;
            this.ConnaissancePract.Location = new System.Drawing.Point(615, 204);
            this.ConnaissancePract.Name = "ConnaissancePract";
            this.ConnaissancePract.Size = new System.Drawing.Size(163, 17);
            this.ConnaissancePract.TabIndex = 17;
            this.ConnaissancePract.Text = "Connaissance Practicien";
            // 
            // RapportVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 747);
            this.Controls.Add(this.ConnaissancePract);
            this.Controls.Add(this.ConfLabo);
            this.Controls.Add(this.ConfPract);
            this.Controls.Add(this.prdnewrdv);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.toz);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelBilan);
            this.Controls.Add(this.comboBoxMotifVisite);
            this.Controls.Add(this.labelMotifVisite);
            this.Controls.Add(this.comboBox_Practiciens);
            this.Controls.Add(this.datePickerRapport);
            this.Controls.Add(this.labelDateRapport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumRapport);
            this.Controls.Add(this.labelNumRapport);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RapportVisite";
            this.Text = "Rapport de Visite";
            this.Load += new System.EventHandler(this.RapportVisite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumRapport;
        private System.Windows.Forms.TextBox textBoxNumRapport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDateRapport;
        private System.Windows.Forms.DateTimePicker datePickerRapport;
        private System.Windows.Forms.ComboBox comboBox_Practiciens;
        private System.Windows.Forms.ComboBox comboBoxMotifVisite;
        private System.Windows.Forms.Label labelMotifVisite;
        private System.Windows.Forms.Label labelBilan;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label toz;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label prdnewrdv;
        private System.Windows.Forms.Label ConfPract;
        private System.Windows.Forms.Label ConfLabo;
        private System.Windows.Forms.Label ConnaissancePract;
    }
}