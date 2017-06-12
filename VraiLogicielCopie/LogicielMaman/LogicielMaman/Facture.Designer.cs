namespace LogicielMaman
{
    partial class Facture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facture));
            this.dataGridViewProduits = new System.Windows.Forms.DataGridView();
            this.labelPrenomClient = new System.Windows.Forms.Label();
            this.labelNomClient = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelProduitsAchetes = new System.Windows.Forms.Label();
            this.labelRepDate = new System.Windows.Forms.Label();
            this.labelRepPrenomClient = new System.Windows.Forms.Label();
            this.labelRepNomClient = new System.Windows.Forms.Label();
            this.labelVenduPar = new System.Windows.Forms.Label();
            this.labelRepVenduPar = new System.Windows.Forms.Label();
            this.labelRepTotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelRepAdresse = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelRepNumTel = new System.Windows.Forms.Label();
            this.labelNumTel = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.richTextBoxPosologie = new System.Windows.Forms.RichTextBox();
            this.labelExplications = new System.Windows.Forms.Label();
            this.buttonImprimer = new System.Windows.Forms.Button();
            this.printDocumentFacture = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogFacture = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProduits
            // 
            this.dataGridViewProduits.AllowUserToAddRows = false;
            this.dataGridViewProduits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProduits.BackgroundColor = System.Drawing.Color.Navy;
            this.dataGridViewProduits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduits.Location = new System.Drawing.Point(65, 147);
            this.dataGridViewProduits.Name = "dataGridViewProduits";
            this.dataGridViewProduits.RowTemplate.Height = 24;
            this.dataGridViewProduits.Size = new System.Drawing.Size(577, 429);
            this.dataGridViewProduits.TabIndex = 0;
            // 
            // labelPrenomClient
            // 
            this.labelPrenomClient.AutoSize = true;
            this.labelPrenomClient.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenomClient.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelPrenomClient.Location = new System.Drawing.Point(60, 57);
            this.labelPrenomClient.Name = "labelPrenomClient";
            this.labelPrenomClient.Size = new System.Drawing.Size(204, 29);
            this.labelPrenomClient.TabIndex = 26;
            this.labelPrenomClient.Text = "Prénom du client :";
            // 
            // labelNomClient
            // 
            this.labelNomClient.AutoSize = true;
            this.labelNomClient.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomClient.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelNomClient.Location = new System.Drawing.Point(60, 28);
            this.labelNomClient.Name = "labelNomClient";
            this.labelNomClient.Size = new System.Drawing.Size(169, 29);
            this.labelNomClient.TabIndex = 27;
            this.labelNomClient.Text = "Nom du client :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelDate.Location = new System.Drawing.Point(60, 86);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(79, 29);
            this.labelDate.TabIndex = 28;
            this.labelDate.Text = "Date : ";
            // 
            // labelProduitsAchetes
            // 
            this.labelProduitsAchetes.AutoSize = true;
            this.labelProduitsAchetes.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduitsAchetes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelProduitsAchetes.Location = new System.Drawing.Point(60, 115);
            this.labelProduitsAchetes.Name = "labelProduitsAchetes";
            this.labelProduitsAchetes.Size = new System.Drawing.Size(117, 29);
            this.labelProduitsAchetes.TabIndex = 29;
            this.labelProduitsAchetes.Text = "Produits :";
            // 
            // labelRepDate
            // 
            this.labelRepDate.AutoSize = true;
            this.labelRepDate.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepDate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRepDate.Location = new System.Drawing.Point(291, 86);
            this.labelRepDate.Name = "labelRepDate";
            this.labelRepDate.Size = new System.Drawing.Size(68, 29);
            this.labelRepDate.TabIndex = 31;
            this.labelRepDate.Text = "Date ";
            // 
            // labelRepPrenomClient
            // 
            this.labelRepPrenomClient.AutoSize = true;
            this.labelRepPrenomClient.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepPrenomClient.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRepPrenomClient.Location = new System.Drawing.Point(291, 57);
            this.labelRepPrenomClient.Name = "labelRepPrenomClient";
            this.labelRepPrenomClient.Size = new System.Drawing.Size(96, 29);
            this.labelRepPrenomClient.TabIndex = 32;
            this.labelRepPrenomClient.Text = "Prenom";
            // 
            // labelRepNomClient
            // 
            this.labelRepNomClient.AutoSize = true;
            this.labelRepNomClient.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepNomClient.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRepNomClient.Location = new System.Drawing.Point(291, 28);
            this.labelRepNomClient.Name = "labelRepNomClient";
            this.labelRepNomClient.Size = new System.Drawing.Size(61, 29);
            this.labelRepNomClient.TabIndex = 33;
            this.labelRepNomClient.Text = "Nom";
            // 
            // labelVenduPar
            // 
            this.labelVenduPar.AutoSize = true;
            this.labelVenduPar.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVenduPar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelVenduPar.Location = new System.Drawing.Point(78, 652);
            this.labelVenduPar.Name = "labelVenduPar";
            this.labelVenduPar.Size = new System.Drawing.Size(133, 29);
            this.labelVenduPar.TabIndex = 34;
            this.labelVenduPar.Text = "Vendu par :";
            // 
            // labelRepVenduPar
            // 
            this.labelRepVenduPar.AutoSize = true;
            this.labelRepVenduPar.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepVenduPar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRepVenduPar.Location = new System.Drawing.Point(217, 652);
            this.labelRepVenduPar.Name = "labelRepVenduPar";
            this.labelRepVenduPar.Size = new System.Drawing.Size(65, 29);
            this.labelRepVenduPar.TabIndex = 35;
            this.labelRepVenduPar.Text = "Caro";
            // 
            // labelRepTotal
            // 
            this.labelRepTotal.AutoSize = true;
            this.labelRepTotal.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepTotal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRepTotal.Location = new System.Drawing.Point(579, 586);
            this.labelRepTotal.Name = "labelRepTotal";
            this.labelRepTotal.Size = new System.Drawing.Size(61, 29);
            this.labelRepTotal.TabIndex = 36;
            this.labelRepTotal.Text = "total";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelTotal.Location = new System.Drawing.Point(462, 586);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(78, 29);
            this.labelTotal.TabIndex = 37;
            this.labelTotal.Text = "Total :";
            // 
            // labelRepAdresse
            // 
            this.labelRepAdresse.AutoSize = true;
            this.labelRepAdresse.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepAdresse.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRepAdresse.Location = new System.Drawing.Point(197, 729);
            this.labelRepAdresse.Name = "labelRepAdresse";
            this.labelRepAdresse.Size = new System.Drawing.Size(102, 29);
            this.labelRepAdresse.TabIndex = 39;
            this.labelRepAdresse.Text = "Adresse";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresse.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelAdresse.Location = new System.Drawing.Point(78, 729);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(113, 29);
            this.labelAdresse.TabIndex = 38;
            this.labelAdresse.Text = "Adresse :";
            // 
            // labelRepNumTel
            // 
            this.labelRepNumTel.AutoSize = true;
            this.labelRepNumTel.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepNumTel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRepNumTel.Location = new System.Drawing.Point(332, 691);
            this.labelRepNumTel.Name = "labelRepNumTel";
            this.labelRepNumTel.Size = new System.Drawing.Size(45, 29);
            this.labelRepNumTel.TabIndex = 41;
            this.labelRepNumTel.Text = "Tel";
            // 
            // labelNumTel
            // 
            this.labelNumTel.AutoSize = true;
            this.labelNumTel.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumTel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelNumTel.Location = new System.Drawing.Point(78, 691);
            this.labelNumTel.Name = "labelNumTel";
            this.labelNumTel.Size = new System.Drawing.Size(248, 29);
            this.labelNumTel.TabIndex = 40;
            this.labelNumTel.Text = "Numéro de téléphone :";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelMessage.Location = new System.Drawing.Point(78, 788);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(353, 29);
            this.labelMessage.TabIndex = 42;
            this.labelMessage.Text = "Merci! Passez une belle journée.";
            // 
            // richTextBoxPosologie
            // 
            this.richTextBoxPosologie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxPosologie.Location = new System.Drawing.Point(685, 74);
            this.richTextBoxPosologie.Name = "richTextBoxPosologie";
            this.richTextBoxPosologie.Size = new System.Drawing.Size(617, 744);
            this.richTextBoxPosologie.TabIndex = 43;
            this.richTextBoxPosologie.Text = "";
            // 
            // labelExplications
            // 
            this.labelExplications.AutoSize = true;
            this.labelExplications.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExplications.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelExplications.Location = new System.Drawing.Point(680, 28);
            this.labelExplications.Name = "labelExplications";
            this.labelExplications.Size = new System.Drawing.Size(156, 29);
            this.labelExplications.TabIndex = 44;
            this.labelExplications.Text = "Explications :";
            // 
            // buttonImprimer
            // 
            this.buttonImprimer.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonImprimer.Location = new System.Drawing.Point(924, 11);
            this.buttonImprimer.Name = "buttonImprimer";
            this.buttonImprimer.Size = new System.Drawing.Size(378, 46);
            this.buttonImprimer.TabIndex = 45;
            this.buttonImprimer.Text = "Créer et imprimer la facture";
            this.buttonImprimer.UseVisualStyleBackColor = true;
            this.buttonImprimer.Click += new System.EventHandler(this.buttonImprimer_Click);
            // 
            // printPreviewDialogFacture
            // 
            this.printPreviewDialogFacture.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogFacture.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogFacture.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogFacture.Document = this.printDocumentFacture;
            this.printPreviewDialogFacture.Enabled = true;
            this.printPreviewDialogFacture.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogFacture.Icon")));
            this.printPreviewDialogFacture.Name = "printPreviewDialogFacture";
            this.printPreviewDialogFacture.Visible = false;
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 1045);
            this.Controls.Add(this.buttonImprimer);
            this.Controls.Add(this.labelExplications);
            this.Controls.Add(this.richTextBoxPosologie);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelRepNumTel);
            this.Controls.Add(this.labelNumTel);
            this.Controls.Add(this.labelRepAdresse);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelRepTotal);
            this.Controls.Add(this.labelRepVenduPar);
            this.Controls.Add(this.labelVenduPar);
            this.Controls.Add(this.labelRepNomClient);
            this.Controls.Add(this.labelRepPrenomClient);
            this.Controls.Add(this.labelRepDate);
            this.Controls.Add(this.labelProduitsAchetes);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNomClient);
            this.Controls.Add(this.labelPrenomClient);
            this.Controls.Add(this.dataGridViewProduits);
            this.Name = "Facture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facture";
            this.Load += new System.EventHandler(this.Facture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduits;
        private System.Windows.Forms.Label labelPrenomClient;
        private System.Windows.Forms.Label labelNomClient;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelProduitsAchetes;
        private System.Windows.Forms.Label labelRepDate;
        private System.Windows.Forms.Label labelRepPrenomClient;
        private System.Windows.Forms.Label labelRepNomClient;
        private System.Windows.Forms.Label labelVenduPar;
        private System.Windows.Forms.Label labelRepVenduPar;
        private System.Windows.Forms.Label labelRepTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelRepAdresse;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelRepNumTel;
        private System.Windows.Forms.Label labelNumTel;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.RichTextBox richTextBoxPosologie;
        private System.Windows.Forms.Label labelExplications;
        private System.Windows.Forms.Button buttonImprimer;
        private System.Drawing.Printing.PrintDocument printDocumentFacture;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogFacture;
    }
}