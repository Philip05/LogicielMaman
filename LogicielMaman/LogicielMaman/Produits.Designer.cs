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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(473, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste de produits";
            // 
            // dataGridViewProduits
            // 
            this.dataGridViewProduits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduits.Location = new System.Drawing.Point(107, 133);
            this.dataGridViewProduits.Name = "dataGridViewProduits";
            this.dataGridViewProduits.RowTemplate.Height = 24;
            this.dataGridViewProduits.Size = new System.Drawing.Size(1019, 573);
            this.dataGridViewProduits.TabIndex = 1;
            // 
            // Produits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 731);
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
        private System.Windows.Forms.DataGridView dataGridViewProduits;
    }
}