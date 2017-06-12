namespace LogicielMaman
{
    partial class InformationsProduit
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
            this.buttonMenu = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.labelQuantiteEnInventaire = new System.Windows.Forms.Label();
            this.labelPrixVendant = new System.Windows.Forms.Label();
            this.label4PrixCoutant = new System.Windows.Forms.Label();
            this.labelFournisseur = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrixVendant = new System.Windows.Forms.TextBox();
            this.textBoxFournisseur = new System.Windows.Forms.TextBox();
            this.textBoxPrixCoutant = new System.Windows.Forms.TextBox();
            this.textBoxQuantiteEnInventaire = new System.Windows.Forms.TextBox();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.comboBoxFournisseur = new System.Windows.Forms.ComboBox();
            this.dossierPatientsDataSet8 = new LogicielMaman.DossierPatientsDataSet8();
            this.fournisseursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fournisseursTableAdapter = new LogicielMaman.DossierPatientsDataSet8TableAdapters.FournisseursTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dossierPatientsDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonMenu.Location = new System.Drawing.Point(40, 12);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(249, 54);
            this.buttonMenu.TabIndex = 5;
            this.buttonMenu.Text = "Retourner au menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelTitre.Location = new System.Drawing.Point(505, 34);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(306, 32);
            this.labelTitre.TabIndex = 6;
            this.labelTitre.Text = "Informations du produit";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelNom.Location = new System.Drawing.Point(50, 182);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(72, 29);
            this.labelNom.TabIndex = 7;
            this.labelNom.Text = "Nom :";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelNote.Location = new System.Drawing.Point(49, 536);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(73, 29);
            this.labelNote.TabIndex = 8;
            this.labelNote.Text = "Note :";
            // 
            // labelQuantiteEnInventaire
            // 
            this.labelQuantiteEnInventaire.AutoSize = true;
            this.labelQuantiteEnInventaire.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantiteEnInventaire.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelQuantiteEnInventaire.Location = new System.Drawing.Point(50, 389);
            this.labelQuantiteEnInventaire.Name = "labelQuantiteEnInventaire";
            this.labelQuantiteEnInventaire.Size = new System.Drawing.Size(256, 29);
            this.labelQuantiteEnInventaire.TabIndex = 9;
            this.labelQuantiteEnInventaire.Text = "Quantité en inventaire :";
            // 
            // labelPrixVendant
            // 
            this.labelPrixVendant.AutoSize = true;
            this.labelPrixVendant.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrixVendant.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelPrixVendant.Location = new System.Drawing.Point(50, 323);
            this.labelPrixVendant.Name = "labelPrixVendant";
            this.labelPrixVendant.Size = new System.Drawing.Size(157, 29);
            this.labelPrixVendant.TabIndex = 10;
            this.labelPrixVendant.Text = "Prix vendant :";
            // 
            // label4PrixCoutant
            // 
            this.label4PrixCoutant.AutoSize = true;
            this.label4PrixCoutant.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4PrixCoutant.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4PrixCoutant.Location = new System.Drawing.Point(50, 243);
            this.label4PrixCoutant.Name = "label4PrixCoutant";
            this.label4PrixCoutant.Size = new System.Drawing.Size(154, 29);
            this.label4PrixCoutant.TabIndex = 11;
            this.label4PrixCoutant.Text = "Prix coutant :";
            // 
            // labelFournisseur
            // 
            this.labelFournisseur.AutoSize = true;
            this.labelFournisseur.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFournisseur.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelFournisseur.Location = new System.Drawing.Point(51, 463);
            this.labelFournisseur.Name = "labelFournisseur";
            this.labelFournisseur.Size = new System.Drawing.Size(156, 29);
            this.labelFournisseur.TabIndex = 12;
            this.labelFournisseur.Text = "Fournisseur :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(343, 181);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.ReadOnly = true;
            this.textBoxNom.Size = new System.Drawing.Size(329, 30);
            this.textBoxNom.TabIndex = 13;
            // 
            // textBoxPrixVendant
            // 
            this.textBoxPrixVendant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrixVendant.Location = new System.Drawing.Point(343, 322);
            this.textBoxPrixVendant.Name = "textBoxPrixVendant";
            this.textBoxPrixVendant.ReadOnly = true;
            this.textBoxPrixVendant.Size = new System.Drawing.Size(329, 30);
            this.textBoxPrixVendant.TabIndex = 14;
            // 
            // textBoxFournisseur
            // 
            this.textBoxFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFournisseur.Location = new System.Drawing.Point(343, 451);
            this.textBoxFournisseur.Name = "textBoxFournisseur";
            this.textBoxFournisseur.ReadOnly = true;
            this.textBoxFournisseur.Size = new System.Drawing.Size(329, 30);
            this.textBoxFournisseur.TabIndex = 16;
            // 
            // textBoxPrixCoutant
            // 
            this.textBoxPrixCoutant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrixCoutant.Location = new System.Drawing.Point(343, 243);
            this.textBoxPrixCoutant.Name = "textBoxPrixCoutant";
            this.textBoxPrixCoutant.ReadOnly = true;
            this.textBoxPrixCoutant.Size = new System.Drawing.Size(329, 30);
            this.textBoxPrixCoutant.TabIndex = 17;
            // 
            // textBoxQuantiteEnInventaire
            // 
            this.textBoxQuantiteEnInventaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantiteEnInventaire.Location = new System.Drawing.Point(343, 388);
            this.textBoxQuantiteEnInventaire.Name = "textBoxQuantiteEnInventaire";
            this.textBoxQuantiteEnInventaire.ReadOnly = true;
            this.textBoxQuantiteEnInventaire.Size = new System.Drawing.Size(329, 30);
            this.textBoxQuantiteEnInventaire.TabIndex = 19;
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNote.Location = new System.Drawing.Point(140, 552);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.ReadOnly = true;
            this.richTextBoxNote.Size = new System.Drawing.Size(589, 186);
            this.richTextBoxNote.TabIndex = 20;
            this.richTextBoxNote.Text = "";
            this.richTextBoxNote.DoubleClick += new System.EventHandler(this.richTextBoxNote_DoubleClick);
            this.richTextBoxNote.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBoxNote_KeyUp);
            // 
            // comboBoxFournisseur
            // 
            this.comboBoxFournisseur.DataSource = this.fournisseursBindingSource;
            this.comboBoxFournisseur.DisplayMember = "Nom";
            this.comboBoxFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFournisseur.FormattingEnabled = true;
            this.comboBoxFournisseur.Location = new System.Drawing.Point(343, 448);
            this.comboBoxFournisseur.Name = "comboBoxFournisseur";
            this.comboBoxFournisseur.Size = new System.Drawing.Size(329, 33);
            this.comboBoxFournisseur.TabIndex = 21;
            this.comboBoxFournisseur.ValueMember = "Nom";
            this.comboBoxFournisseur.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxFournisseur_KeyUp);
            // 
            // dossierPatientsDataSet8
            // 
            this.dossierPatientsDataSet8.DataSetName = "DossierPatientsDataSet8";
            this.dossierPatientsDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fournisseursBindingSource
            // 
            this.fournisseursBindingSource.DataMember = "Fournisseurs";
            this.fournisseursBindingSource.DataSource = this.dossierPatientsDataSet8;
            // 
            // fournisseursTableAdapter
            // 
            this.fournisseursTableAdapter.ClearBeforeFill = true;
            // 
            // InformationsProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 750);
            this.Controls.Add(this.comboBoxFournisseur);
            this.Controls.Add(this.richTextBoxNote);
            this.Controls.Add(this.textBoxQuantiteEnInventaire);
            this.Controls.Add(this.textBoxPrixCoutant);
            this.Controls.Add(this.textBoxFournisseur);
            this.Controls.Add(this.textBoxPrixVendant);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelFournisseur);
            this.Controls.Add(this.label4PrixCoutant);
            this.Controls.Add(this.labelPrixVendant);
            this.Controls.Add(this.labelQuantiteEnInventaire);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.buttonMenu);
            this.Name = "InformationsProduit";
            this.Text = "InformationsProduit";
            this.Load += new System.EventHandler(this.InformationsProduit_Load);
            this.Click += new System.EventHandler(this.InformationsProduit_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dossierPatientsDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseursBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelQuantiteEnInventaire;
        private System.Windows.Forms.Label labelPrixVendant;
        private System.Windows.Forms.Label label4PrixCoutant;
        private System.Windows.Forms.Label labelFournisseur;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrixVendant;
        private System.Windows.Forms.TextBox textBoxFournisseur;
        private System.Windows.Forms.TextBox textBoxPrixCoutant;
        private System.Windows.Forms.TextBox textBoxQuantiteEnInventaire;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.ComboBox comboBoxFournisseur;
        private DossierPatientsDataSet8 dossierPatientsDataSet8;
        private System.Windows.Forms.BindingSource fournisseursBindingSource;
        private DossierPatientsDataSet8TableAdapters.FournisseursTableAdapter fournisseursTableAdapter;
    }
}