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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grilleClients)).BeginInit();
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
            this.grilleClients.AutoGenerateColumns = false;
            this.grilleClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilleClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grilleClients.BackgroundColor = System.Drawing.Color.Navy;
            this.grilleClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilleClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn});
            this.grilleClients.DataSource = this.clientsBindingSource;
            this.grilleClients.Location = new System.Drawing.Point(709, 127);
            this.grilleClients.Name = "grilleClients";
            this.grilleClients.ReadOnly = true;
            this.grilleClients.RowTemplate.Height = 24;
            this.grilleClients.Size = new System.Drawing.Size(584, 571);
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
            this.buttonAjouterClient.Location = new System.Drawing.Point(206, 96);
            this.buttonAjouterClient.Name = "buttonAjouterClient";
            this.buttonAjouterClient.Size = new System.Drawing.Size(279, 59);
            this.buttonAjouterClient.TabIndex = 1;
            this.buttonAjouterClient.Text = "Ajouter un client +";
            this.buttonAjouterClient.UseVisualStyleBackColor = true;
            this.buttonAjouterClient.Click += new System.EventHandler(this.buttonAjouterClient_Click);
            // 
            // labelListeClients
            // 
            this.labelListeClients.AutoSize = true;
            this.labelListeClients.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListeClients.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelListeClients.Location = new System.Drawing.Point(705, 66);
            this.labelListeClients.Name = "labelListeClients";
            this.labelListeClients.Size = new System.Drawing.Size(214, 32);
            this.labelListeClients.TabIndex = 2;
            this.labelListeClients.Text = "Liste des clients";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 513);
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
            this.buttonRetourAccueil.Size = new System.Drawing.Size(294, 64);
            this.buttonRetourAccueil.TabIndex = 5;
            this.buttonRetourAccueil.Text = "Retourner à l\'accueil";
            this.buttonRetourAccueil.UseVisualStyleBackColor = true;
            this.buttonRetourAccueil.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1367, 725);
            this.Controls.Add(this.buttonRetourAccueil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelListeClients);
            this.Controls.Add(this.buttonAjouterClient);
            this.Controls.Add(this.grilleClients);
            this.Name = "FormeClients";
            this.Text = "FormeClients";
            this.Load += new System.EventHandler(this.FormeClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilleClients)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonRetourAccueil;
    }
}