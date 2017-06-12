using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace LogicielMaman
{
    public partial class Facture : Form
    {
        private SqlConnection con1;
        private Bitmap memoryImage;
        private DataTable dt;
        private DateTime dateAndTime;

        public Facture()
        {
            InitializeComponent();
            con1 = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
            dataGridViewProduits.Font = new System.Drawing.Font("Arial", 12);
            dateAndTime = DateTime.Now;
        }

        private void LoadTableElements()
        {
            SqlCommand cmd;
            string query = "SELECT Produits.Nom Produits,Quantite,Produits.PrixVendant FROM Achats INNER JOIN Produits ON Achats.Produits_Id = Produits.Id WHERE Client_Id  = '" + Commandes.idClient + "' AND DateAchat = '" + DateTime.Today + "'";
            using (cmd = new SqlCommand(query, con1))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dataGridViewProduits.DataSource = dt;
                    }
                }
                con1.Close();
            }
        }

        private void test()
        {
            foreach (DataGridViewRow row in dataGridViewProduits.Rows)
            {
                row.Cells[dataGridViewProduits.Columns["Prix"].Index].Value = (Convert.ToDouble(row.Cells[dataGridViewProduits.Columns["Quantite"].Index].Value) * Convert.ToDouble(row.Cells[dataGridViewProduits.Columns["PrixVendant"].Index].Value)).ToString();
                dataGridViewProduits.Refresh();
            }
        }

        private void LoadLabelInformations()
        {
            string query1 = "SELECT * FROM Clients WHERE Id = " + Commandes.idClient;
            string query2 = "SELECT * FROM Administrateurs WHERE Id = " + Commandes.idAdministrateur;
            SqlCommand cmd = new SqlCommand(query1, con1);
            SqlDataReader Reader;
            try
            {
                con1.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    labelRepNomClient.Text = Reader.GetValue(1).ToString();
                    labelRepPrenomClient.Text = Reader.GetValue(2).ToString();
                    labelRepDate.Text = dateAndTime.ToString("dd/MM/yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con1.Close();

            cmd = new SqlCommand(query2, con1);
            try
            {
                con1.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    labelRepVenduPar.Text = Reader.GetValue(2).ToString() + " " + Reader.GetValue(1).ToString();
                    labelRepNumTel.Text = Reader.GetValue(7).ToString();
                    labelRepAdresse.Text = Reader.GetValue(8).ToString() + ", " + Reader.GetValue(9).ToString() + ", " + Reader.GetValue(10).ToString() + ", " + Reader.GetValue(11).ToString();
                    labelRepDate.Text = DateTime.Today.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con1.Close();
        }

        private void Facture_Load(object sender, EventArgs e)
        {
            LoadLabelInformations();
            LoadTableElements();
            dataGridViewProduits.Columns.Add("Prix", "Prix");
            test();
            labelRepTotal.Text = CalculateSum() + " $";
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(1296, 1092, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            printPreviewDialogFacture.ShowDialog();
        }

        private string CalculateSum()
        {
            int sum = 0;
            for (int i = 0; i < dataGridViewProduits.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridViewProduits.Rows[i].Cells[3].Value);

            }
            return sum.ToString();
        }

        private void buttonImprimer_Click(object sender, EventArgs e)
        {
            buttonImprimer.Hide();
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridViewProduits.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridViewProduits.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridViewProduits.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\FacturesClientMyBusiness\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            Document pdfDoc = new Document();
            try
            {
                //Create pdfDocument.
                PdfWriter.GetInstance(pdfDoc, new FileStream(folderPath + "/" + Commandes.nomClient + "_" + Commandes.prenomClient + "_" + dateAndTime.ToString("dd-MM-yyyy") + ".pdf", FileMode.Create));
                pdfDoc.Open();

                //Create values to insert in pdf.
                string title = @"Facture";
                title = title.Replace(Environment.NewLine, String.Empty).Replace("  ", String.Empty);
                Chunk beginning = new Chunk(title);
                Phrase p1 = new Phrase(beginning);
                Chunk nomclient = new Chunk("Nom du client: " + Commandes.nomClient);
                Chunk prenomClient = new Chunk("Prénom du client: " + Commandes.prenomClient);
                Chunk prenomVendeur = new Chunk("Vendu par: " + Commandes.PrenomAdministrateurConnecte + " " + Commandes.NomAdministrateurConnecte);
                Chunk telVendeur = new Chunk("Téléphone: " + Commandes.TelephoneAdministrateurConnecte);
                Chunk adresseVendeur = new Chunk("Adresse: " + Commandes.AdresseAdministrateurConnecte);
                Chunk date = new Chunk("Date: " + (dateAndTime.ToString("dd/MM/yyyy")));
                Chunk PrixTotal = new Chunk("Total: " + CalculateSum() + "$");
                Chunk posologieTitle = new Chunk("Posologie: ");
                Chunk posologieExplications = new Chunk(richTextBoxPosologie.Text);
                Chunk message = new Chunk("Merci. Passez une belle journée.");

                //fonts
                iTextSharp.text.Font titlebill = FontFactory.GetFont("Segoe UI", 18.0f, BaseColor.BLACK);

                //Insert title.
                Paragraph p = new Paragraph();
                p.Font = titlebill;
                p.Alignment = Element.ALIGN_CENTER;
                p.Add(title);
                p.Add(new Paragraph("\n"));
                p.Add(new Paragraph("\n"));
                pdfDoc.Add(p);

                //Insert client's informations.
                Phrase infosClient = new Phrase();
                infosClient.Add(prenomClient);
                infosClient.Add(new Paragraph("\n"));
                infosClient.Add(nomclient);
                infosClient.Add(new Paragraph("\n"));
                infosClient.Add(date);
                pdfDoc.Add(infosClient);

                //Insert the list of products bought by the client.
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable.WidthPercentage = 90;
                pdfDoc.Add(pdfTable);

                //Insert the total of the bill.
                Paragraph sum = new Paragraph();
                sum.Add(new Paragraph("\n"));
                sum.Alignment = Element.ALIGN_RIGHT;
                sum.Add(PrixTotal);
                sum.Add(new Paragraph("\n"));
                pdfDoc.Add(sum);

                //Insert posologie
                Paragraph posologie = new Paragraph();
                posologie.Add(new Paragraph("\n"));
                posologie.Add(posologieTitle);
                posologie.Add(new Paragraph("\n"));
                posologie.Add(posologieExplications);
                pdfDoc.Add(posologie);

                //Insert seller's informations.
                Phrase infosVendeur = new Phrase();
                infosVendeur.Add(new Paragraph("\n"));
                infosVendeur.Add(new Paragraph("\n"));
                infosVendeur.Add(prenomVendeur);
                infosVendeur.Add(new Paragraph("\n"));
                infosVendeur.Add(telVendeur);
                infosVendeur.Add(new Paragraph("\n"));
                infosVendeur.Add(adresseVendeur);
                pdfDoc.Add(infosVendeur);

                //Insert final message.
                Paragraph messageP = new Paragraph();
                messageP.Alignment = Element.ALIGN_CENTER;
                messageP.Add(new Paragraph("\n"));
                messageP.Add(message);
                pdfDoc.Add(messageP);
            }
            catch (DocumentException dex)
            {
                throw (dex);
            }
            catch (IOException ioex)
            {
                throw (ioex);
            }
            finally
            {
                pdfDoc.Close();
                OpenNewPdf(folderPath + "/" + Commandes.nomClient + "_" + Commandes.prenomClient + "_" + dateAndTime.ToString("dd-MM-yyyy") + ".pdf");
                this.Close();
            }
        }

        /// <summary>
        /// Open the create bill.
        /// </summary>
        /// <param name="folderPath">Folder where the bill was registered.</param>
        private void OpenNewPdf(string folderPath)
        {
            try
            {
                System.Diagnostics.Process.Start(folderPath);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}

