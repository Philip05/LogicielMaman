using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicielMaman
{
    public partial class DescriptionImage : Form
    {
        SqlConnection con;
        public DescriptionImage()
        {
            InitializeComponent();
            pictureBoxImage.Image = System.Drawing.Image.FromFile(Commandes.sourceImage);
            pictureBoxImage.ImageLocation = Commandes.sourceImage;
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            string Query = @"INSERT INTO Images (SourceImage,Description,Client_Id,Date) VALUES (@SourceImage,@Description,@Client_Id,@Date)";
            SqlCommand cmd = new SqlCommand(Query, con);
            Commandes.descriptionImage = richTextBoxDescription.Text;
            cmd.Parameters.Add("@SourceImage", SqlDbType.VarChar, 80).Value = pictureBoxImage.ImageLocation;
            cmd.Parameters.Add("@Description", SqlDbType.VarChar, 80).Value = Commandes.descriptionImage;
            cmd.Parameters.Add("@Client_Id", SqlDbType.Int, 80).Value = Commandes.idClient;
            cmd.Parameters.Add("Date", SqlDbType.Date, 80).Value = DateTime.Today;
            con.Open();
            cmd.ExecuteNonQuery();
            this.Hide();
        }
    }
}
