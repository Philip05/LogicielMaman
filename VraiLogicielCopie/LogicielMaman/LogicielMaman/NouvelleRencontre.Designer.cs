namespace LogicielMaman
{
    partial class NouvelleRencontre
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
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.buttonRetournerMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(126, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notes :";
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNote.Location = new System.Drawing.Point(52, 124);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(1526, 791);
            this.richTextBoxNote.TabIndex = 1;
            this.richTextBoxNote.Text = "";
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnregistrer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonEnregistrer.Location = new System.Drawing.Point(1095, 12);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(301, 106);
            this.buttonEnregistrer.TabIndex = 2;
            this.buttonEnregistrer.Text = "Enregistrer la rencontre";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRetournerMenu
            // 
            this.buttonRetournerMenu.Font = new System.Drawing.Font("Harrington", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetournerMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonRetournerMenu.Location = new System.Drawing.Point(1, 1);
            this.buttonRetournerMenu.Name = "buttonRetournerMenu";
            this.buttonRetournerMenu.Size = new System.Drawing.Size(206, 55);
            this.buttonRetournerMenu.TabIndex = 23;
            this.buttonRetournerMenu.Text = "Retourner au menu";
            this.buttonRetournerMenu.UseVisualStyleBackColor = true;
            this.buttonRetournerMenu.Click += new System.EventHandler(this.buttonRetournerMenu_Click);
            // 
            // NouvelleRencontre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1612, 965);
            this.Controls.Add(this.buttonRetournerMenu);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.richTextBoxNote);
            this.Controls.Add(this.label1);
            this.Name = "NouvelleRencontre";
            this.Text = "NouvelleRencontre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Button buttonRetournerMenu;
    }
}