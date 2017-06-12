namespace LogicielMaman
{
    partial class AjouterProduit
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.labelQuantiteEnStock = new System.Windows.Forms.Label();
            this.labelPrixVendant = new System.Windows.Forms.Label();
            this.labelPrixCoutant = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.comboBoxFournisseur = new System.Windows.Forms.ComboBox();
            this.fournisseursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dossierPatientsDataSet6 = new LogicielMaman.DossierPatientsDataSet6();
            this.labelFournisseur = new System.Windows.Forms.Label();
            this.textBoxQteInventaire = new System.Windows.Forms.TextBox();
            this.textBoxPrixVendant = new System.Windows.Forms.TextBox();
            this.textBoxPrixCoutant = new System.Windows.Forms.TextBox();
            this.buttonAjouterProduit = new System.Windows.Forms.Button();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.fournisseursTableAdapter = new LogicielMaman.DossierPatientsDataSet6TableAdapters.FournisseursTableAdapter();
            this.buttonRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossierPatientsDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(517, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un produit";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelNote.Location = new System.Drawing.Point(92, 590);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(260, 32);
            this.labelNote.TabIndex = 1;
            this.labelNote.Text = "Note sur le produit :";
            // 
            // labelQuantiteEnStock
            // 
            this.labelQuantiteEnStock.AutoSize = true;
            this.labelQuantiteEnStock.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantiteEnStock.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelQuantiteEnStock.Location = new System.Drawing.Point(77, 407);
            this.labelQuantiteEnStock.Name = "labelQuantiteEnStock";
            this.labelQuantiteEnStock.Size = new System.Drawing.Size(296, 32);
            this.labelQuantiteEnStock.TabIndex = 2;
            this.labelQuantiteEnStock.Text = "Quantité en inventaire :";
            // 
            // labelPrixVendant
            // 
            this.labelPrixVendant.AutoSize = true;
            this.labelPrixVendant.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrixVendant.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelPrixVendant.Location = new System.Drawing.Point(77, 337);
            this.labelPrixVendant.Name = "labelPrixVendant";
            this.labelPrixVendant.Size = new System.Drawing.Size(183, 32);
            this.labelPrixVendant.TabIndex = 3;
            this.labelPrixVendant.Text = "Prix vendant :";
            // 
            // labelPrixCoutant
            // 
            this.labelPrixCoutant.AutoSize = true;
            this.labelPrixCoutant.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrixCoutant.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelPrixCoutant.Location = new System.Drawing.Point(77, 250);
            this.labelPrixCoutant.Name = "labelPrixCoutant";
            this.labelPrixCoutant.Size = new System.Drawing.Size(178, 32);
            this.labelPrixCoutant.TabIndex = 4;
            this.labelPrixCoutant.Text = "Prix coutant :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelNom.Location = new System.Drawing.Point(77, 161);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(84, 32);
            this.labelNom.TabIndex = 5;
            this.labelNom.Text = "Nom :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(381, 161);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(465, 30);
            this.textBoxNom.TabIndex = 6;
            // 
            // comboBoxFournisseur
            // 
            this.comboBoxFournisseur.DataSource = this.fournisseursBindingSource;
            this.comboBoxFournisseur.DisplayMember = "Nom";
            this.comboBoxFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFournisseur.FormattingEnabled = true;
            this.comboBoxFournisseur.Location = new System.Drawing.Point(381, 505);
            this.comboBoxFournisseur.Name = "comboBoxFournisseur";
            this.comboBoxFournisseur.Size = new System.Drawing.Size(465, 33);
            this.comboBoxFournisseur.TabIndex = 7;
            // 
            // fournisseursBindingSource
            // 
            this.fournisseursBindingSource.DataMember = "Fournisseurs";
            this.fournisseursBindingSource.DataSource = this.dossierPatientsDataSet6;
            // 
            // dossierPatientsDataSet6
            // 
            this.dossierPatientsDataSet6.DataSetName = "DossierPatientsDataSet6";
            this.dossierPatientsDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelFournisseur
            // 
            this.labelFournisseur.AutoSize = true;
            this.labelFournisseur.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFournisseur.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelFournisseur.Location = new System.Drawing.Point(92, 505);
            this.labelFournisseur.Name = "labelFournisseur";
            this.labelFournisseur.Size = new System.Drawing.Size(180, 32);
            this.labelFournisseur.TabIndex = 8;
            this.labelFournisseur.Text = "Fournisseur :";
            // 
            // textBoxQteInventaire
            // 
            this.textBoxQteInventaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQteInventaire.Location = new System.Drawing.Point(375, 419);
            this.textBoxQteInventaire.Name = "textBoxQteInventaire";
            this.textBoxQteInventaire.Size = new System.Drawing.Size(471, 30);
            this.textBoxQteInventaire.TabIndex = 10;
            // 
            // textBoxPrixVendant
            // 
            this.textBoxPrixVendant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrixVendant.Location = new System.Drawing.Point(375, 337);
            this.textBoxPrixVendant.Name = "textBoxPrixVendant";
            this.textBoxPrixVendant.Size = new System.Drawing.Size(471, 30);
            this.textBoxPrixVendant.TabIndex = 11;
            // 
            // textBoxPrixCoutant
            // 
            this.textBoxPrixCoutant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrixCoutant.Location = new System.Drawing.Point(375, 253);
            this.textBoxPrixCoutant.Name = "textBoxPrixCoutant";
            this.textBoxPrixCoutant.Size = new System.Drawing.Size(471, 30);
            this.textBoxPrixCoutant.TabIndex = 12;
            // 
            // buttonAjouterProduit
            // 
            this.buttonAjouterProduit.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterProduit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonAjouterProduit.Location = new System.Drawing.Point(1255, 134);
            this.buttonAjouterProduit.Name = "buttonAjouterProduit";
            this.buttonAjouterProduit.Size = new System.Drawing.Size(293, 266);
            this.buttonAjouterProduit.TabIndex = 13;
            this.buttonAjouterProduit.Text = "Ajouter le produit";
            this.buttonAjouterProduit.UseVisualStyleBackColor = true;
            this.buttonAjouterProduit.Click += new System.EventHandler(this.buttonAjouterProduit_Click);
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNote.Location = new System.Drawing.Point(107, 647);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(679, 209);
            this.richTextBoxNote.TabIndex = 14;
            this.richTextBoxNote.Text = "";
            // 
            // fournisseursTableAdapter
            // 
            this.fournisseursTableAdapter.ClearBeforeFill = true;
            // 
            // buttonRetour
            // 
            this.buttonRetour.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonRetour.Location = new System.Drawing.Point(12, 14);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(304, 57);
            this.buttonRetour.TabIndex = 25;
            this.buttonRetour.Text = "Retourner à la liste de produits";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // AjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1839, 889);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.richTextBoxNote);
            this.Controls.Add(this.buttonAjouterProduit);
            this.Controls.Add(this.textBoxPrixCoutant);
            this.Controls.Add(this.textBoxPrixVendant);
            this.Controls.Add(this.textBoxQteInventaire);
            this.Controls.Add(this.labelFournisseur);
            this.Controls.Add(this.comboBoxFournisseur);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelPrixCoutant);
            this.Controls.Add(this.labelPrixVendant);
            this.Controls.Add(this.labelQuantiteEnStock);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AjouterProduit";
            this.Text = "AjouterProduit";
            this.Load += new System.EventHandler(this.AjouterProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fournisseursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossierPatientsDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelQuantiteEnStock;
        private System.Windows.Forms.Label labelPrixVendant;
        private System.Windows.Forms.Label labelPrixCoutant;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.ComboBox comboBoxFournisseur;
        private System.Windows.Forms.Label labelFournisseur;
        private System.Windows.Forms.TextBox textBoxQteInventaire;
        private System.Windows.Forms.TextBox textBoxPrixVendant;
        private System.Windows.Forms.TextBox textBoxPrixCoutant;
        private System.Windows.Forms.Button buttonAjouterProduit;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private DossierPatientsDataSet6 dossierPatientsDataSet6;
        private System.Windows.Forms.BindingSource fournisseursBindingSource;
        private DossierPatientsDataSet6TableAdapters.FournisseursTableAdapter fournisseursTableAdapter;
        private System.Windows.Forms.Button buttonRetour;
    }
}