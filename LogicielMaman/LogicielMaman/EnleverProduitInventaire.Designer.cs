namespace LogicielMaman
{
    partial class EnleverProduitInventaire
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
            this.buttonOui = new System.Windows.Forms.Button();
            this.buttonNon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enlever le produit de l\'inventaire?";
            // 
            // buttonOui
            // 
            this.buttonOui.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOui.Location = new System.Drawing.Point(53, 78);
            this.buttonOui.Name = "buttonOui";
            this.buttonOui.Size = new System.Drawing.Size(94, 37);
            this.buttonOui.TabIndex = 1;
            this.buttonOui.Text = "Oui";
            this.buttonOui.UseVisualStyleBackColor = true;
            this.buttonOui.Click += new System.EventHandler(this.buttonOui_Click);
            // 
            // buttonNon
            // 
            this.buttonNon.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNon.Location = new System.Drawing.Point(195, 78);
            this.buttonNon.Name = "buttonNon";
            this.buttonNon.Size = new System.Drawing.Size(94, 37);
            this.buttonNon.TabIndex = 2;
            this.buttonNon.Text = "Non";
            this.buttonNon.UseVisualStyleBackColor = true;
            this.buttonNon.Click += new System.EventHandler(this.buttonNon_Click);
            // 
            // EnleverProduitInventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 167);
            this.Controls.Add(this.buttonNon);
            this.Controls.Add(this.buttonOui);
            this.Controls.Add(this.label1);
            this.Name = "EnleverProduitInventaire";
            this.Text = "EnleverProduitInventaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOui;
        private System.Windows.Forms.Button buttonNon;
    }
}