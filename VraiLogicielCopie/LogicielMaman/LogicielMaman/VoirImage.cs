using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicielMaman
{
    public partial class VoirImage : Form
    {
        System.Drawing.Image img;

        public VoirImage()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            LoadInformations();
        }

        private void LoadInformations()
        {
            pictureBoxImage.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            img = System.Drawing.Image.FromFile(Commandes.sourceImage);
            pictureBoxImage.Image = img;
            labelRepEmplacement.Text = Commandes.sourceImage;
            labelRepDateEnregistrement.Text = Commandes.dateImage;
            richTextBoxDescription.Text = Commandes.descriptionImage;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
