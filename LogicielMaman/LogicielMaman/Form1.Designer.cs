namespace LogicielMaman
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonConnectionAdministrateur = new System.Windows.Forms.Button();
            this.textBoxMotDePasseAdministrateur = new System.Windows.Forms.TextBox();
            this.textBoxNomAdministrateur = new System.Windows.Forms.TextBox();
            this.labelNomAdministrateur = new System.Windows.Forms.Label();
            this.labelMotPasseAdministrateur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConnectionAdministrateur
            // 
            this.buttonConnectionAdministrateur.Location = new System.Drawing.Point(108, 536);
            this.buttonConnectionAdministrateur.Name = "buttonConnectionAdministrateur";
            this.buttonConnectionAdministrateur.Size = new System.Drawing.Size(375, 53);
            this.buttonConnectionAdministrateur.TabIndex = 0;
            this.buttonConnectionAdministrateur.Text = "Connection";
            this.buttonConnectionAdministrateur.UseVisualStyleBackColor = true;
            this.buttonConnectionAdministrateur.Click += new System.EventHandler(this.buttonConnectionAdministrateur_Click);
            // 
            // textBoxMotDePasseAdministrateur
            // 
            this.textBoxMotDePasseAdministrateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMotDePasseAdministrateur.Location = new System.Drawing.Point(130, 392);
            this.textBoxMotDePasseAdministrateur.Multiline = true;
            this.textBoxMotDePasseAdministrateur.Name = "textBoxMotDePasseAdministrateur";
            this.textBoxMotDePasseAdministrateur.PasswordChar = '*';
            this.textBoxMotDePasseAdministrateur.Size = new System.Drawing.Size(330, 43);
            this.textBoxMotDePasseAdministrateur.TabIndex = 1;
            // 
            // textBoxNomAdministrateur
            // 
            this.textBoxNomAdministrateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomAdministrateur.Location = new System.Drawing.Point(130, 277);
            this.textBoxNomAdministrateur.Multiline = true;
            this.textBoxNomAdministrateur.Name = "textBoxNomAdministrateur";
            this.textBoxNomAdministrateur.Size = new System.Drawing.Size(330, 43);
            this.textBoxNomAdministrateur.TabIndex = 2;
            // 
            // labelNomAdministrateur
            // 
            this.labelNomAdministrateur.AutoSize = true;
            this.labelNomAdministrateur.BackColor = System.Drawing.Color.Transparent;
            this.labelNomAdministrateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomAdministrateur.Location = new System.Drawing.Point(127, 227);
            this.labelNomAdministrateur.Name = "labelNomAdministrateur";
            this.labelNomAdministrateur.Size = new System.Drawing.Size(215, 25);
            this.labelNomAdministrateur.TabIndex = 3;
            this.labelNomAdministrateur.Text = "Nom de l\'administrateur";
            // 
            // labelMotPasseAdministrateur
            // 
            this.labelMotPasseAdministrateur.AutoSize = true;
            this.labelMotPasseAdministrateur.BackColor = System.Drawing.Color.Transparent;
            this.labelMotPasseAdministrateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotPasseAdministrateur.Location = new System.Drawing.Point(127, 354);
            this.labelMotPasseAdministrateur.Name = "labelMotPasseAdministrateur";
            this.labelMotPasseAdministrateur.Size = new System.Drawing.Size(130, 25);
            this.labelMotPasseAdministrateur.TabIndex = 4;
            this.labelMotPasseAdministrateur.Text = "Mot de passe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1882, 1045);
            this.Controls.Add(this.labelMotPasseAdministrateur);
            this.Controls.Add(this.labelNomAdministrateur);
            this.Controls.Add(this.textBoxNomAdministrateur);
            this.Controls.Add(this.textBoxMotDePasseAdministrateur);
            this.Controls.Add(this.buttonConnectionAdministrateur);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Connection de l\'administrateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnectionAdministrateur;
        private System.Windows.Forms.TextBox textBoxMotDePasseAdministrateur;
        private System.Windows.Forms.TextBox textBoxNomAdministrateur;
        private System.Windows.Forms.Label labelNomAdministrateur;
        private System.Windows.Forms.Label labelMotPasseAdministrateur;
    }
}

