namespace LogicielMaman
{
    partial class Fournisseurs
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
            this.labelRencontres = new System.Windows.Forms.Label();
            this.dataGridViewFournisseurs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonAjouterFournisseur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFournisseurs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRencontres
            // 
            this.labelRencontres.AutoSize = true;
            this.labelRencontres.Font = new System.Drawing.Font("Harrington", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRencontres.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRencontres.Location = new System.Drawing.Point(566, 9);
            this.labelRencontres.Name = "labelRencontres";
            this.labelRencontres.Size = new System.Drawing.Size(266, 39);
            this.labelRencontres.TabIndex = 2;
            this.labelRencontres.Text = "Mes fournisseurs";
            // 
            // dataGridViewFournisseurs
            // 
            this.dataGridViewFournisseurs.AllowUserToAddRows = false;
            this.dataGridViewFournisseurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFournisseurs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFournisseurs.BackgroundColor = System.Drawing.Color.Navy;
            this.dataGridViewFournisseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFournisseurs.Location = new System.Drawing.Point(388, 179);
            this.dataGridViewFournisseurs.Name = "dataGridViewFournisseurs";
            this.dataGridViewFournisseurs.ReadOnly = true;
            this.dataGridViewFournisseurs.RowTemplate.Height = 24;
            this.dataGridViewFournisseurs.Size = new System.Drawing.Size(1144, 687);
            this.dataGridViewFournisseurs.TabIndex = 3;
            this.dataGridViewFournisseurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFournisseurs_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(382, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rechercher un fournisseur :";
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRechercher.Location = new System.Drawing.Point(763, 132);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(769, 30);
            this.textBoxRechercher.TabIndex = 5;
            this.textBoxRechercher.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxRechercher_KeyUp);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonMenu.Location = new System.Drawing.Point(2, 9);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(216, 61);
            this.buttonMenu.TabIndex = 7;
            this.buttonMenu.Text = "Retourner au menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonAjouterFournisseur
            // 
            this.buttonAjouterFournisseur.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterFournisseur.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonAjouterFournisseur.Location = new System.Drawing.Point(60, 217);
            this.buttonAjouterFournisseur.Name = "buttonAjouterFournisseur";
            this.buttonAjouterFournisseur.Size = new System.Drawing.Size(255, 315);
            this.buttonAjouterFournisseur.TabIndex = 8;
            this.buttonAjouterFournisseur.Text = "Ajouter un fournisseur +";
            this.buttonAjouterFournisseur.UseVisualStyleBackColor = true;
            this.buttonAjouterFournisseur.Click += new System.EventHandler(this.buttonAjouterFournisseur_Click);
            // 
            // Fournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1837, 878);
            this.Controls.Add(this.buttonAjouterFournisseur);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.textBoxRechercher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFournisseurs);
            this.Controls.Add(this.labelRencontres);
            this.Name = "Fournisseurs";
            this.Text = "Mes fournisseurs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFournisseurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRencontres;
        private System.Windows.Forms.DataGridView dataGridViewFournisseurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonAjouterFournisseur;
    }
}