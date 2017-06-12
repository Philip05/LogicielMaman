namespace LogicielMaman
{
    partial class ProduitClient
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
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelRepQuantite = new System.Windows.Forms.Label();
            this.labelRepAchat = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNote.Location = new System.Drawing.Point(132, 531);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.ReadOnly = true;
            this.richTextBoxNote.Size = new System.Drawing.Size(1046, 303);
            this.richTextBoxNote.TabIndex = 0;
            this.richTextBoxNote.Text = "";
            this.richTextBoxNote.DoubleClick += new System.EventHandler(this.richTextBoxNote_DoubleClick);
            this.richTextBoxNote.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBoxNote_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(273, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Détails du produit ";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelNote.Location = new System.Drawing.Point(128, 488);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(91, 32);
            this.labelNote.TabIndex = 2;
            this.labelNote.Text = "Note :";
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantite.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelQuantite.Location = new System.Drawing.Point(275, 223);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(250, 32);
            this.labelQuantite.TabIndex = 3;
            this.labelQuantite.Text = "Quantité achetée :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelDate.Location = new System.Drawing.Point(275, 139);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(225, 32);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date de l\'achat :";
            // 
            // labelRepQuantite
            // 
            this.labelRepQuantite.AutoSize = true;
            this.labelRepQuantite.Font = new System.Drawing.Font("HelvLight", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepQuantite.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRepQuantite.Location = new System.Drawing.Point(538, 223);
            this.labelRepQuantite.Name = "labelRepQuantite";
            this.labelRepQuantite.Size = new System.Drawing.Size(0, 28);
            this.labelRepQuantite.TabIndex = 7;
            // 
            // labelRepAchat
            // 
            this.labelRepAchat.AutoSize = true;
            this.labelRepAchat.Font = new System.Drawing.Font("HelvLight", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepAchat.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRepAchat.Location = new System.Drawing.Point(538, 139);
            this.labelRepAchat.Name = "labelRepAchat";
            this.labelRepAchat.Size = new System.Drawing.Size(0, 28);
            this.labelRepAchat.TabIndex = 8;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(216, 371);
            this.buttonMenu.TabIndex = 9;
            this.buttonMenu.Text = "Retourner au dossier du client";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // ProduitClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1327, 871);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelRepAchat);
            this.Controls.Add(this.labelRepQuantite);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelQuantite);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxNote);
            this.Name = "ProduitClient";
            this.Text = "ProduitClient";
            this.Load += new System.EventHandler(this.ProduitClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelRepQuantite;
        private System.Windows.Forms.Label labelRepAchat;
        private System.Windows.Forms.Button buttonMenu;
    }
}