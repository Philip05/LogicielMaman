namespace LogicielMaman
{
    partial class VoirImage
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
            this.labelDateEnregistrement = new System.Windows.Forms.Label();
            this.labelRepDateEnregistrement = new System.Windows.Forms.Label();
            this.labelEmplacement = new System.Windows.Forms.Label();
            this.labelRepEmplacement = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDateEnregistrement
            // 
            this.labelDateEnregistrement.AutoSize = true;
            this.labelDateEnregistrement.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateEnregistrement.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelDateEnregistrement.Location = new System.Drawing.Point(8, 144);
            this.labelDateEnregistrement.Name = "labelDateEnregistrement";
            this.labelDateEnregistrement.Size = new System.Drawing.Size(254, 29);
            this.labelDateEnregistrement.TabIndex = 1;
            this.labelDateEnregistrement.Text = "Date d\'enregistrement :";
            // 
            // labelRepDateEnregistrement
            // 
            this.labelRepDateEnregistrement.AutoSize = true;
            this.labelRepDateEnregistrement.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepDateEnregistrement.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRepDateEnregistrement.Location = new System.Drawing.Point(14, 202);
            this.labelRepDateEnregistrement.Name = "labelRepDateEnregistrement";
            this.labelRepDateEnregistrement.Size = new System.Drawing.Size(51, 24);
            this.labelRepDateEnregistrement.TabIndex = 2;
            this.labelRepDateEnregistrement.Text = "Date";
            // 
            // labelEmplacement
            // 
            this.labelEmplacement.AutoSize = true;
            this.labelEmplacement.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmplacement.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelEmplacement.Location = new System.Drawing.Point(8, 273);
            this.labelEmplacement.Name = "labelEmplacement";
            this.labelEmplacement.Size = new System.Drawing.Size(165, 29);
            this.labelEmplacement.TabIndex = 3;
            this.labelEmplacement.Text = "Emplacement :";
            // 
            // labelRepEmplacement
            // 
            this.labelRepEmplacement.AutoSize = true;
            this.labelRepEmplacement.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepEmplacement.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRepEmplacement.Location = new System.Drawing.Point(8, 349);
            this.labelRepEmplacement.Name = "labelRepEmplacement";
            this.labelRepEmplacement.Size = new System.Drawing.Size(57, 24);
            this.labelRepEmplacement.TabIndex = 4;
            this.labelRepEmplacement.Text = "place";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(8, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Description :";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(12, 469);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(302, 397);
            this.richTextBoxDescription.TabIndex = 6;
            this.richTextBoxDescription.Text = "";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonMenu.Location = new System.Drawing.Point(-2, 3);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(230, 59);
            this.buttonMenu.TabIndex = 9;
            this.buttonMenu.Text = "Retourner à la liste des founisseurs";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(530, 98);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(1259, 756);
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // VoirImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1914, 878);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRepEmplacement);
            this.Controls.Add(this.labelEmplacement);
            this.Controls.Add(this.labelRepDateEnregistrement);
            this.Controls.Add(this.labelDateEnregistrement);
            this.Controls.Add(this.pictureBoxImage);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "VoirImage";
            this.Text = "VoirImage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDateEnregistrement;
        private System.Windows.Forms.Label labelRepDateEnregistrement;
        private System.Windows.Forms.Label labelEmplacement;
        private System.Windows.Forms.Label labelRepEmplacement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.PictureBox pictureBoxImage;
    }
}