namespace LogicielMaman
{
    partial class AjouterProduitClient
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
            this.dataGridViewAjourProduitsClients = new System.Windows.Forms.DataGridView();
            this.dossierPatientsDataSet5 = new LogicielMaman.DossierPatientsDataSet5();
            this.dossierPatientsDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelProduitClient = new System.Windows.Forms.Label();
            this.buttonAjouterProduitSelectionne = new System.Windows.Forms.Button();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.numericUpDownQuantite = new System.Windows.Forms.NumericUpDown();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAjourProduitsClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossierPatientsDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossierPatientsDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAjourProduitsClients
            // 
            this.dataGridViewAjourProduitsClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAjourProduitsClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAjourProduitsClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAjourProduitsClients.Location = new System.Drawing.Point(436, 95);
            this.dataGridViewAjourProduitsClients.Name = "dataGridViewAjourProduitsClients";
            this.dataGridViewAjourProduitsClients.RowTemplate.Height = 24;
            this.dataGridViewAjourProduitsClients.Size = new System.Drawing.Size(926, 599);
            this.dataGridViewAjourProduitsClients.TabIndex = 0;
            // 
            // dossierPatientsDataSet5
            // 
            this.dossierPatientsDataSet5.DataSetName = "DossierPatientsDataSet5";
            this.dossierPatientsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dossierPatientsDataSet5BindingSource
            // 
            this.dossierPatientsDataSet5BindingSource.DataSource = this.dossierPatientsDataSet5;
            this.dossierPatientsDataSet5BindingSource.Position = 0;
            // 
            // labelProduitClient
            // 
            this.labelProduitClient.AutoSize = true;
            this.labelProduitClient.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduitClient.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelProduitClient.Location = new System.Drawing.Point(634, 39);
            this.labelProduitClient.Name = "labelProduitClient";
            this.labelProduitClient.Size = new System.Drawing.Size(487, 32);
            this.labelProduitClient.TabIndex = 1;
            this.labelProduitClient.Text = "Ajouer un produit au dossier du client";
            // 
            // buttonAjouterProduitSelectionne
            // 
            this.buttonAjouterProduitSelectionne.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterProduitSelectionne.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonAjouterProduitSelectionne.Location = new System.Drawing.Point(31, 71);
            this.buttonAjouterProduitSelectionne.Name = "buttonAjouterProduitSelectionne";
            this.buttonAjouterProduitSelectionne.Size = new System.Drawing.Size(275, 109);
            this.buttonAjouterProduitSelectionne.TabIndex = 2;
            this.buttonAjouterProduitSelectionne.Text = "Ajouter le produit sélectionné\r\n              \r\n+\r\n";
            this.buttonAjouterProduitSelectionne.UseVisualStyleBackColor = true;
            this.buttonAjouterProduitSelectionne.Click += new System.EventHandler(this.buttonAjouterProduitSelectionne_Click);
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Location = new System.Drawing.Point(31, 350);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(344, 331);
            this.richTextBoxNote.TabIndex = 3;
            this.richTextBoxNote.Text = "";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelNote.Location = new System.Drawing.Point(25, 287);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(233, 32);
            this.labelNote.TabIndex = 4;
            this.labelNote.Text = "Ajouter une note :";
            // 
            // numericUpDownQuantite
            // 
            this.numericUpDownQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQuantite.Location = new System.Drawing.Point(31, 232);
            this.numericUpDownQuantite.Name = "numericUpDownQuantite";
            this.numericUpDownQuantite.Size = new System.Drawing.Size(261, 30);
            this.numericUpDownQuantite.TabIndex = 5;
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantite.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelQuantite.Location = new System.Drawing.Point(25, 183);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(131, 32);
            this.labelQuantite.TabIndex = 6;
            this.labelQuantite.Text = "Quantité :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Harrington", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(12, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Retourner à l\'accueil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AjouterProduitClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 736);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelQuantite);
            this.Controls.Add(this.numericUpDownQuantite);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.richTextBoxNote);
            this.Controls.Add(this.buttonAjouterProduitSelectionne);
            this.Controls.Add(this.labelProduitClient);
            this.Controls.Add(this.dataGridViewAjourProduitsClients);
            this.Name = "AjouterProduitClient";
            this.Text = "AjouterProduitClient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAjourProduitsClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossierPatientsDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossierPatientsDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAjourProduitsClients;
        private System.Windows.Forms.BindingSource dossierPatientsDataSet5BindingSource;
        private DossierPatientsDataSet5 dossierPatientsDataSet5;
        private System.Windows.Forms.Label labelProduitClient;
        private System.Windows.Forms.Button buttonAjouterProduitSelectionne;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantite;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.Button button1;
    }
}