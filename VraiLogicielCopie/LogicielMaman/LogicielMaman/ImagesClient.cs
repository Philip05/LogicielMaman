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
    public partial class ImagesClient : Form
    {
        private string[] tableauImages;
        private string[] tableauLabel;
        private string[] tableauDate;
        private int quantiteImageClient;
        public ImagesClient()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            quantiteImageClient = TrouverQuantiteImageClient();
            tableauImages = new string[quantiteImageClient];
            tableauLabel = new string[quantiteImageClient];
            tableauDate = new string[quantiteImageClient];
            AfficherLesImagesDuClient();
        }

        private int TrouverQuantiteImageClient()
        {
            SqlCommand cmd;
            string reponse="";
            SqlConnection con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
            string query1 = "SELECT COUNT(Id) FROM Images WHERE Client_Id = " + Commandes.idClient;
            cmd = new SqlCommand(query1, con);
            int i = 0;
            SqlDataReader Reader;
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    reponse = Reader.GetValue(0).ToString();
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();
            return Convert.ToInt32(reponse);
        }

        public void RemplirTableauImagesDuClient()
        {
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
            string query1 = "SELECT * FROM Images WHERE Client_Id = " + Commandes.idClient;
            cmd = new SqlCommand(query1, con);
            int i = 0;
            SqlDataReader Reader;
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    tableauImages[i] = Reader.GetValue(1).ToString();
                    tableauLabel[i] = Reader.GetValue(2).ToString();
                    tableauDate[i] = Reader.GetValue(4).ToString();
                    i++;
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private void AfficherLesImagesDuClient()
        {
            RemplirTableauImagesDuClient();
            int x = 10;
            int y = 10;
            int i = 0;
            int positionX = 0;
            int location = 0;
            int maxHeight = -1;
            int colonne = 0;
            foreach (string image in tableauImages)
            {
                PictureBox pic = new PictureBox();
               
                Label label = new Label();
                pic.Click += Pic_Click;
                pic.ImageLocation = image;
                label.Text = "Description : " + tableauLabel[i] + "\n" + " Date: " + tableauDate[i];
                pic.Image = System.Drawing.Image.FromFile(image);
                pic.Size = new Size(200,200);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;;
                if (y + pic.Width > this.ClientSize.Height)
                {
                    y = 10;
                    colonne++;
                    location += pic.Width;
                    positionX = location + 20 * colonne;;
                }
                else if (x < this.ClientSize.Width - 100)
                {
                    if (i != 0)
                    {
                        y += pic.Height + 60;
                    }
                }
                x = positionX;
                pic.Location = new Point(x, y);
                label.Location = new Point(x,y + pic.Height + 20);
                maxHeight = Math.Max(pic.Height, pic.Width);
                this.panelImagesClient.Controls.Add(pic);
                pic.BorderStyle = BorderStyle.FixedSingle;
                label.AutoSize = true;
                this.panelImagesClient.Controls.Add(label);
                i++;
            }
        }

        private void SelectImageWithPosition()
        {
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
            string query1 = "SELECT * FROM Images WHERE SourceImage = '" + Commandes.sourceImage + "'";
            cmd = new SqlCommand(query1, con);
            int i = 0;
            SqlDataReader Reader;
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Commandes.dateImage = Reader.GetValue(4).ToString();
                    Commandes.descriptionImage = Reader.GetValue(2).ToString();
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            Commandes.sourceImage = pic.ImageLocation;
            SelectImageWithPosition();
            VoirImage image = new VoirImage();
            image.Show();
        }
    }
}
