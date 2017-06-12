namespace LogicielMaman
{
    partial class RencontresClient
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
            this.dataGridViewRencontres = new System.Windows.Forms.DataGridView();
            this.labelRencontres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRencontres)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRencontres
            // 
            this.dataGridViewRencontres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRencontres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRencontres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRencontres.Location = new System.Drawing.Point(162, 146);
            this.dataGridViewRencontres.Name = "dataGridViewRencontres";
            this.dataGridViewRencontres.ReadOnly = true;
            this.dataGridViewRencontres.RowTemplate.Height = 24;
            this.dataGridViewRencontres.Size = new System.Drawing.Size(1363, 778);
            this.dataGridViewRencontres.TabIndex = 0;
            this.dataGridViewRencontres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRencontres_CellClick);
            // 
            // labelRencontres
            // 
            this.labelRencontres.AutoSize = true;
            this.labelRencontres.Font = new System.Drawing.Font("Harrington", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRencontres.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRencontres.Location = new System.Drawing.Point(700, 9);
            this.labelRencontres.Name = "labelRencontres";
            this.labelRencontres.Size = new System.Drawing.Size(335, 40);
            this.labelRencontres.TabIndex = 1;
            this.labelRencontres.Text = "Rencontres du client ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(435, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rechercher rencontre par date : ";
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRechercher.Location = new System.Drawing.Point(863, 108);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(561, 30);
            this.textBoxRechercher.TabIndex = 3;
            this.textBoxRechercher.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonMenu.Location = new System.Drawing.Point(3, 9);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(216, 61);
            this.buttonMenu.TabIndex = 8;
            this.buttonMenu.Text = "Retourner au dossier du client";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // RencontresClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1839, 879);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.textBoxRechercher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRencontres);
            this.Controls.Add(this.dataGridViewRencontres);
            this.Name = "RencontresClient";
            this.Text = "RencontresClient";
            this.Load += new System.EventHandler(this.RencontresClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRencontres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRencontres;
        private System.Windows.Forms.Label labelRencontres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.Button buttonMenu;
    }
}