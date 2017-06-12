namespace LogicielMaman
{
    partial class NoteRencontre
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
            this.labelNote = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelRepDate = new System.Windows.Forms.Label();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelNote.Location = new System.Drawing.Point(25, 121);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(277, 32);
            this.labelNote.TabIndex = 0;
            this.labelNote.Text = "Note de la rencontre :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Harrington", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelDate.Location = new System.Drawing.Point(442, 40);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(339, 40);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date de la rencontre :";
            // 
            // labelRepDate
            // 
            this.labelRepDate.AutoSize = true;
            this.labelRepDate.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepDate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRepDate.Location = new System.Drawing.Point(830, 40);
            this.labelRepDate.Name = "labelRepDate";
            this.labelRepDate.Size = new System.Drawing.Size(0, 32);
            this.labelRepDate.TabIndex = 3;
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNote.Location = new System.Drawing.Point(12, 180);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(1431, 677);
            this.richTextBoxNote.TabIndex = 4;
            this.richTextBoxNote.Text = "";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonMenu.Location = new System.Drawing.Point(12, 11);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(216, 61);
            this.buttonMenu.TabIndex = 8;
            this.buttonMenu.Text = "Retourner au dossier du client";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // NoteRencontre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 869);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.richTextBoxNote);
            this.Controls.Add(this.labelRepDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNote);
            this.Name = "NoteRencontre";
            this.Text = "NoteRencontre";
            this.Load += new System.EventHandler(this.NoteRencontre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelRepDate;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.Button buttonMenu;
    }
}