namespace LogicielMaman
{
    partial class SupprimerClient
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
            this.buttonOui = new System.Windows.Forms.Button();
            this.labelTitre = new System.Windows.Forms.Label();
            this.button2Non = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOui
            // 
            this.buttonOui.Location = new System.Drawing.Point(93, 169);
            this.buttonOui.Name = "buttonOui";
            this.buttonOui.Size = new System.Drawing.Size(75, 23);
            this.buttonOui.TabIndex = 0;
            this.buttonOui.Text = "Oui";
            this.buttonOui.UseVisualStyleBackColor = true;
            this.buttonOui.Click += new System.EventHandler(this.buttonOui_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Location = new System.Drawing.Point(24, 29);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(358, 85);
            this.labelTitre.TabIndex = 1;
            this.labelTitre.Text = "Supprimer le client ?\r\n\r\n***ATTENTION*** Ceci supprimera tous les téléphones, \r\nl" +
    "es achats et le regroupement des images du \r\nclient dans le logiciel.\r\n";
            // 
            // button2Non
            // 
            this.button2Non.Location = new System.Drawing.Point(221, 169);
            this.button2Non.Name = "button2Non";
            this.button2Non.Size = new System.Drawing.Size(75, 23);
            this.button2Non.TabIndex = 2;
            this.button2Non.Text = "Non";
            this.button2Non.UseVisualStyleBackColor = true;
            this.button2Non.Click += new System.EventHandler(this.button2Non_Click);
            // 
            // SupprimerClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 251);
            this.Controls.Add(this.button2Non);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.buttonOui);
            this.Name = "SupprimerClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupprimerClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOui;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button button2Non;
    }
}