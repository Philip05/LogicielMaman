namespace LogicielMaman
{
    partial class FormeClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormeClients));
            this.grilleClients = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathologieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dossierPatientsDataSet9 = new LogicielMaman.DossierPatientsDataSet9();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dossierPatientsDataSet = new LogicielMaman.DossierPatientsDataSet();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dossierPatientsDataSet1 = new LogicielMaman.DossierPatientsDataSet1();
            this.clientsTableAdapter = new LogicielMaman.DossierPatientsDataSetTableAdapters.ClientsTableAdapter();
            this.buttonAjouterClient = new System.Windows.Forms.Button();
            this.labelListeClients = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clientsTableAdapter1 = new LogicielMaman.DossierPatientsDataSet1TableAdapters.ClientsTableAdapter();
            this.buttonRetourAccueil = new System.Windows.Forms.Button();
            this.labelRechercher = new System.Windows.Forms.Label();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter2 = new LogicielMaman.DossierPatientsDataSet9TableAdapters.ClientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grilleClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossierPatientsDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossierPatientsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossierPatientsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grilleClients
            // 
            this.grilleClients.AllowUserToAddRows = false;
            this.grilleClients.AutoGenerateColumns = false;
            this.grilleClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilleClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grilleClients.BackgroundColor = System.Drawing.Color.Navy;
            this.grilleClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilleClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.pathologieDataGridViewTextBoxColumn});
            this.grilleClients.DataSource = this.clientsBindingSource2;
            this.grilleClients.Location = new System.Drawing.Point(605, 216);
            this.grilleClients.Name = "grilleClients";
            this.grilleClients.ReadOnly = true;
            this.grilleClients.RowTemplate.Height = 24;
            this.grilleClients.Size = new System.Drawing.Size(1137, 717);
            this.grilleClients.TabIndex = 0;
            this.grilleClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.grilleClients.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grilleClients_KeyPress);
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pathologieDataGridViewTextBoxColumn
            // 
            this.pathologieDataGridViewTextBoxColumn.DataPropertyName = "Pathologie";
            this.pathologieDataGridViewTextBoxColumn.HeaderText = "Pathologie";
            this.pathologieDataGridViewTextBoxColumn.Name = "pathologieDataGridViewTextBoxColumn";
            this.pathologieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientsBindingSource2
            // 
            this.clientsBindingSource2.DataMember = "Clients";
            this.clientsBindingSource2.DataSource = this.dossierPatientsDataSet9;
            // 
            // dossierPatientsDataSet9
            // 
            this.dossierPatientsDataSet9.DataSetName = "DossierPatientsDataSet9";
            this.dossierPatientsDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.dossierPatientsDataSet;
            // 
            // dossierPatientsDataSet
            // 
            this.dossierPatientsDataSet.DataSetName = "DossierPatientsDataSet";
            this.dossierPatientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.dossierPatientsDataSet1;
            // 
            // dossierPatientsDataSet1
            // 
            this.dossierPatientsDataSet1.DataSetName = "DossierPatientsDataSet1";
            this.dossierPatientsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAjouterClient
            // 
            this.buttonAjouterClient.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterClient.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonAjouterClient.Location = new System.Drawing.Point(400, 9);
            this.buttonAjouterClient.Name = "buttonAjouterClient";
            this.buttonAjouterClient.Size = new System.Drawing.Size(348, 99);
            this.buttonAjouterClient.TabIndex = 1;
            this.buttonAjouterClient.Text = "Ajouter un client +";
            this.buttonAjouterClient.UseVisualStyleBackColor = true;
            this.buttonAjouterClient.UseWaitCursor = true;
            this.buttonAjouterClient.Click += new System.EventHandler(this.buttonAjouterClient_Click);
            // 
            // labelListeClients
            // 
            this.labelListeClients.AutoSize = true;
            this.labelListeClients.Font = new System.Drawing.Font("Harrington", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListeClients.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelListeClients.Location = new System.Drawing.Point(907, 9);
            this.labelListeClients.Name = "labelListeClients";
            this.labelListeClients.Size = new System.Drawing.Size(247, 39);
            this.labelListeClients.TabIndex = 2;
            this.labelListeClients.Text = "Liste des clients";
            this.labelListeClients.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 460);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonRetourAccueil
            // 
            this.buttonRetourAccueil.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetourAccueil.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonRetourAccueil.Location = new System.Drawing.Point(1, 0);
            this.buttonRetourAccueil.Name = "buttonRetourAccueil";
            this.buttonRetourAccueil.Size = new System.Drawing.Size(296, 58);
            this.buttonRetourAccueil.TabIndex = 5;
            this.buttonRetourAccueil.Text = "Retourner au menu";
            this.buttonRetourAccueil.UseVisualStyleBackColor = true;
            this.buttonRetourAccueil.UseWaitCursor = true;
            this.buttonRetourAccueil.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelRechercher
            // 
            this.labelRechercher.AutoSize = true;
            this.labelRechercher.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRechercher.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRechercher.Location = new System.Drawing.Point(811, 127);
            this.labelRechercher.Name = "labelRechercher";
            this.labelRechercher.Size = new System.Drawing.Size(281, 32);
            this.labelRechercher.TabIndex = 6;
            this.labelRechercher.Text = "Rechercher un client :";
            this.labelRechercher.UseWaitCursor = true;
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRechercher.Location = new System.Drawing.Point(1098, 130);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(400, 30);
            this.textBoxRechercher.TabIndex = 7;
            this.textBoxRechercher.UseWaitCursor = true;
            this.textBoxRechercher.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxRechercher_KeyUp);
            // 
            // clientsTableAdapter2
            // 
            this.clientsTableAdapter2.ClearBeforeFill = true;
            // 
            // FormeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1838, 945);
            this.Controls.Add(this.textBoxRechercher);
            this.Controls.Add(this.labelRechercher);
            this.Controls.Add(this.buttonRetourAccueil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelListeClients);
            this.Controls.Add(this.buttonAjouterClient);
            this.Controls.Add(this.grilleClients);
            this.Name = "FormeClients";
            this.Text = "FormeClients";
            this.Load += new System.EventHandler(this.FormeClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilleClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossierPatientsDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossierPatientsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossierPatientsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilleClients;
        private DossierPatientsDataSet dossierPatientsDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private DossierPatientsDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonAjouterClient;
        private System.Windows.Forms.Label labelListeClients;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DossierPatientsDataSet1 dossierPatientsDataSet1;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private DossierPatientsDataSet1TableAdapters.ClientsTableAdapter clientsTableAdapter1;
        private System.Windows.Forms.Button buttonRetourAccueil;
        private System.Windows.Forms.Label labelRechercher;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private DossierPatientsDataSet9 dossierPatientsDataSet9;
        private System.Windows.Forms.BindingSource clientsBindingSource2;
        private DossierPatientsDataSet9TableAdapters.ClientsTableAdapter clientsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathologieDataGridViewTextBoxColumn;
    }
}