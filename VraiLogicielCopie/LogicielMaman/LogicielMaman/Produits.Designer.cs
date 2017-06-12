namespace LogicielMaman
{
    partial class Produits
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
            this.dataGridViewProduits = new System.Windows.Forms.DataGridView();
            this.textBoxRecherher = new System.Windows.Forms.TextBox();
            this.labelRechercher = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonAjouterProduit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(765, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des produits";
            // 
            // dataGridViewProduits
            // 
            this.dataGridViewProduits.AllowUserToAddRows = false;
            this.dataGridViewProduits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProduits.BackgroundColor = System.Drawing.Color.Navy;
            this.dataGridViewProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduits.Location = new System.Drawing.Point(62, 186);
            this.dataGridViewProduits.Name = "dataGridViewProduits";
            this.dataGridViewProduits.ReadOnly = true;
            this.dataGridViewProduits.RowTemplate.Height = 24;
            this.dataGridViewProduits.Size = new System.Drawing.Size(1569, 663);
            this.dataGridViewProduits.TabIndex = 1;
            this.dataGridViewProduits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduits_CellClick);
            // 
            // textBoxRecherher
            // 
            this.textBoxRecherher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecherher.Location = new System.Drawing.Point(890, 123);
            this.textBoxRecherher.Name = "textBoxRecherher";
            this.textBoxRecherher.Size = new System.Drawing.Size(687, 30);
            this.textBoxRecherher.TabIndex = 2;
            this.textBoxRecherher.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxRecherher_KeyUp);
            // 
            // labelRechercher
            // 
            this.labelRechercher.AutoSize = true;
            this.labelRechercher.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRechercher.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRechercher.Location = new System.Drawing.Point(513, 120);
            this.labelRechercher.Name = "labelRechercher";
            this.labelRechercher.Size = new System.Drawing.Size(305, 32);
            this.labelRechercher.TabIndex = 3;
            this.labelRechercher.Text = "Rechercher un produit :";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonMenu.Location = new System.Drawing.Point(3, 3);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(249, 54);
            this.buttonMenu.TabIndex = 4;
            this.buttonMenu.Text = "Retourner au menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonAjouterProduit
            // 
            this.buttonAjouterProduit.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterProduit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonAjouterProduit.Location = new System.Drawing.Point(299, 3);
            this.buttonAjouterProduit.Name = "buttonAjouterProduit";
            this.buttonAjouterProduit.Size = new System.Drawing.Size(272, 94);
            this.buttonAjouterProduit.TabIndex = 5;
            this.buttonAjouterProduit.Text = "Ajouter un produit +";
            this.buttonAjouterProduit.UseVisualStyleBackColor = true;
            this.buttonAjouterProduit.Click += new System.EventHandler(this.buttonAjouterProduit_Click);
            // 
            // Produits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1840, 879);
            this.Controls.Add(this.buttonAjouterProduit);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelRechercher);
            this.Controls.Add(this.textBoxRecherher);
            this.Controls.Add(this.dataGridViewProduits);
            this.Controls.Add(this.label1);
            this.Name = "Produits";
            this.Text = "Produits";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewProduits;
        private System.Windows.Forms.TextBox textBoxRecherher;
        private System.Windows.Forms.Label labelRechercher;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonAjouterProduit;
    }
}