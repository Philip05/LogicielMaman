namespace LogicielMaman
{
    partial class MenuAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAccueil));
            this.buttonClients = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.labelBonjour = new System.Windows.Forms.Label();
            this.buttonProduits = new System.Windows.Forms.Button();
            this.buttonFournisseurs = new System.Windows.Forms.Button();
            this.buttonMonCompte = new System.Windows.Forms.Button();
            this.buttonVente = new System.Windows.Forms.Button();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClients
            // 
            this.buttonClients.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClients.Location = new System.Drawing.Point(22, 219);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(250, 80);
            this.buttonClients.TabIndex = 0;
            this.buttonClients.Text = "Clients";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BackColor = System.Drawing.Color.Transparent;
            this.labelMenu.Font = new System.Drawing.Font("Harrington", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(148, 74);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(98, 40);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "Menu";
            // 
            // labelBonjour
            // 
            this.labelBonjour.AutoSize = true;
            this.labelBonjour.BackColor = System.Drawing.Color.Transparent;
            this.labelBonjour.Font = new System.Drawing.Font("Harrington", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBonjour.Location = new System.Drawing.Point(1024, 109);
            this.labelBonjour.Name = "labelBonjour";
            this.labelBonjour.Size = new System.Drawing.Size(0, 40);
            this.labelBonjour.TabIndex = 2;
            // 
            // buttonProduits
            // 
            this.buttonProduits.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduits.Location = new System.Drawing.Point(340, 219);
            this.buttonProduits.Name = "buttonProduits";
            this.buttonProduits.Size = new System.Drawing.Size(250, 80);
            this.buttonProduits.TabIndex = 3;
            this.buttonProduits.Text = "Produits";
            this.buttonProduits.UseVisualStyleBackColor = true;
            this.buttonProduits.Click += new System.EventHandler(this.buttonProduits_Click);
            // 
            // buttonFournisseurs
            // 
            this.buttonFournisseurs.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFournisseurs.Location = new System.Drawing.Point(22, 360);
            this.buttonFournisseurs.Name = "buttonFournisseurs";
            this.buttonFournisseurs.Size = new System.Drawing.Size(250, 80);
            this.buttonFournisseurs.TabIndex = 6;
            this.buttonFournisseurs.Text = "Fournisseurs";
            this.buttonFournisseurs.UseVisualStyleBackColor = true;
            this.buttonFournisseurs.Click += new System.EventHandler(this.buttonFournisseurs_Click);
            // 
            // buttonMonCompte
            // 
            this.buttonMonCompte.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMonCompte.Location = new System.Drawing.Point(340, 360);
            this.buttonMonCompte.Name = "buttonMonCompte";
            this.buttonMonCompte.Size = new System.Drawing.Size(250, 80);
            this.buttonMonCompte.TabIndex = 7;
            this.buttonMonCompte.Text = "Mon compte";
            this.buttonMonCompte.UseVisualStyleBackColor = true;
            this.buttonMonCompte.Click += new System.EventHandler(this.buttonMonCompte_Click);
            // 
            // buttonVente
            // 
            this.buttonVente.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVente.Location = new System.Drawing.Point(22, 495);
            this.buttonVente.Name = "buttonVente";
            this.buttonVente.Size = new System.Drawing.Size(250, 80);
            this.buttonVente.TabIndex = 8;
            this.buttonVente.Text = "Ventes";
            this.buttonVente.UseVisualStyleBackColor = true;
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeconnexion.Location = new System.Drawing.Point(340, 495);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(250, 80);
            this.buttonDeconnexion.TabIndex = 9;
            this.buttonDeconnexion.Text = "Déconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = true;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // MenuAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1431, 743);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonVente);
            this.Controls.Add(this.buttonMonCompte);
            this.Controls.Add(this.buttonFournisseurs);
            this.Controls.Add(this.buttonProduits);
            this.Controls.Add(this.labelBonjour);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.buttonClients);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "MenuAccueil";
            this.Text = "MenuAccueil";
            this.Load += new System.EventHandler(this.MenuAccueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label labelBonjour;
        private System.Windows.Forms.Button buttonProduits;
        private System.Windows.Forms.Button buttonFournisseurs;
        private System.Windows.Forms.Button buttonMonCompte;
        private System.Windows.Forms.Button buttonVente;
        private System.Windows.Forms.Button buttonDeconnexion;
    }
}