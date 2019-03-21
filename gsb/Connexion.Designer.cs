namespace gsb
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputID = new System.Windows.Forms.TextBox();
            this.inputMDP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.errorConnection = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(279, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(346, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identification";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputID
            // 
            this.inputID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.inputID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputID.ForeColor = System.Drawing.SystemColors.MenuText;
            this.inputID.Location = new System.Drawing.Point(224, 202);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(143, 30);
            this.inputID.TabIndex = 2;
            this.inputID.Text = "Cadic";
            this.inputID.TextChanged += new System.EventHandler(this.inputID_TextChanged);
            // 
            // inputMDP
            // 
            this.inputMDP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.inputMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputMDP.Location = new System.Drawing.Point(410, 202);
            this.inputMDP.Name = "inputMDP";
            this.inputMDP.Size = new System.Drawing.Size(143, 30);
            this.inputMDP.TabIndex = 3;
            this.inputMDP.Text = "1993-dec-06";
            this.inputMDP.TextChanged += new System.EventHandler(this.inputMDP_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(427, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.submit.Location = new System.Drawing.Point(350, 276);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(84, 51);
            this.submit.TabIndex = 5;
            this.submit.Text = "Valider";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // errorConnection
            // 
            this.errorConnection.ContainerControl = this;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputMDP);
            this.Controls.Add(this.inputID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Connexion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputID;
        private System.Windows.Forms.TextBox inputMDP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ErrorProvider errorConnection;
    }
}

