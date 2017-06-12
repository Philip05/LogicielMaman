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
    public partial class DossierClient : Form
    {
        private DossierContainer ctx;
        private SqlConnection con;
        private string sexe;
        private string typeTelephone;
        private bool modifierInformationsClient;
        private bool actif;

        public DossierClient()
        {
            InitializeComponent();
            con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
            LoadDataProduitsClient();
            ctx = new DossierContainer();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            dataGridViewProduitsClient.Font = new Font("Arial", 16);
            dataGridViewProduitsClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modifierInformationsClient = false;
            if(actif == false)
            {
                MessageBox.Show("Ce client a été désactivé.");
            }
        }

        private void DossierClient_Click(object sender, EventArgs e)
        {
            ToolStripItem click = (ToolStripItem)sender;
            if (click.Name == "Réactiver le client.")
            {
                MessageBox.Show("Ce client a été désactivé");
            }
        }

        private string Sexe()
        {
            string sexe1 = "";
            SqlConnection con1;
            con1 = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
            string Query = "SELECT Categorie FROM Sexes WHERE Id = " + int.Parse(sexe);
            SqlCommand cmd = new SqlCommand(Query, con1);
            SqlDataReader Reader;
            try
            {
                con1.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    sexe1 = Reader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con1.Close();
            return sexe1;
        }

        public void LoadDataProduitsClient()
        {
            SqlDataReader Reader;
            SqlCommand cmd;
            //Grille de produits du client.
            using (cmd = new SqlCommand("SELECT Achats.Id,Produits.Nom,Achats.DateAchat,Achats.Quantite FROM Achats INNER JOIN Produits ON Achats.Produits_Id = Produits.Id WHERE Client_Id = " + Commandes.idClient, con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dataGridViewProduitsClient.DataSource = dt;
                    }
                }
                con.Close();
            }

            //Client.
            string Query = "SELECT * FROM Clients WHERE ID = " + Commandes.idClient;
            cmd = new SqlCommand(Query, con);
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    textBoxNomClient.Text = Reader.GetValue(1).ToString();
                    textBoxPrenomClient.Text = Reader.GetValue(2).ToString();
                    textBoxAdresseClient.Text = Reader.GetValue(3).ToString();
                    textBoxCourrielClient.Text = Reader.GetValue(5).ToString();
                    textBox5CodePostalClient.Text = Reader.GetValue(4).ToString();
                    textBoxVilleClient.Text = Reader.GetValue(9).ToString();
                    textBox8PaysClient.Text = Reader.GetValue(10).ToString();
                    textBoxDateInscriptionClient.Text = Reader.GetValue(6).ToString();
                    textBoxPathologie.Text = Reader.GetValue(11).ToString();
                    richTextBoxNoteClient.Text = Reader.GetValue(8).ToString();
                    sexe = Reader.GetValue(12).ToString();
                    actif = Convert.ToBoolean(Reader.GetValue(7));
                    textBoxSexe.Text = Sexe();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            //Telephone
            string Query2 = "SELECT * FROM TelephoneClients WHERE Client_Id = " + Commandes.idClient;
            cmd = new SqlCommand(Query2, con);
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    textBoxTelephone.Text = Reader.GetValue(1).ToString();
                    richTextBoxNoteTelephone.Text = Reader.GetValue(2).ToString();
                    typeTelephone = Reader.GetValue(4).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            con.Close();

            //Type Telephone
            string Query3 = "SELECT Lieu FROM TypeTelephones WHERE Id = " + Convert.ToInt32(typeTelephone);
            cmd = new SqlCommand(Query3, con);
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    labelTypeTelephone.Text = "(" + Reader.GetValue(0).ToString() + ")";
                }
            }
            catch
            {
                MessageBox.Show("Impossible de trouver le type de téléphone.");
            }
            con.Close();
        }


        private void buttonRetournerMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAjouterProduit_Click(object sender, EventArgs e)
        {
            AjouterProduitClient produit = new AjouterProduitClient();
            produit.Show();
        }

        private void dataGridViewProduitsClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProduitClient client = new ProduitClient();
            client.Show();
        }

        private void buttonRencontres_Click(object sender, EventArgs e)
        {
            RencontresClient client = new RencontresClient();
            client.Show();
        }

        private void buttonNouvelleRencontre_Click(object sender, EventArgs e)
        {
            NouvelleRencontre rencontre = new NouvelleRencontre();
            rencontre.Show();
        }

        private void AjouterDesImagesAuClient()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Sélectionnez les images à ajouter.";
            ofd.Multiselect = true;
            ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            DialogResult dr = ofd.ShowDialog();
            Commandes.tableauImagesImportees = ofd.FileNames;
            Image image = new Image();

            for (int i = 0; i < Commandes.tableauImagesImportees.Length; i++)
            {
                Commandes.sourceImage = Commandes.tableauImagesImportees[i];
                DescriptionImage description = new DescriptionImage();
                description.Show();
            }
        }

        private void buttonAjouterImages_Click(object sender, EventArgs e)
        {
            AjouterDesImagesAuClient();
        }

        private void buttonVoirImages_Click(object sender, EventArgs e)
        {
            ImagesClient image = new ImagesClient();
            image.Show();
        }

        private void TextboxDoubleClick(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.DoubleClick += new EventHandler(Tb_DoubleClick);
                    tb.KeyUp += Tb_KeyUp;
                }
                else
                {
                    TextboxDoubleClick(ctrl);
                }
            }
        }

        private void RichTextboxDoubleClick(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is RichTextBox)
                {
                    RichTextBox rtb = (RichTextBox)ctrl;
                    rtb.DoubleClick += Rtb_DoubleClick;
                    rtb.KeyUp += Rtb_KeyUp;
                }
                else
                {
                    TextboxDoubleClick(ctrl);
                }
            }
        }

        private void Rtb_KeyUp(object sender, KeyEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            if(modifierInformationsClient == true)
            {
                if(e.KeyCode == Keys.Enter)
                {
                    if(rtb.Name == richTextBoxNoteClient.Name)
                    {
                        Commandes.UpdateDatabaseInformations("UPDATE Clients SET Note = '" + richTextBoxNoteClient.Text + "' WHERE Id = " + Commandes.idClient);
                    }
                    if(rtb.Name == richTextBoxNoteTelephone.Name)
                    {
                        Commandes.UpdateDatabaseInformations("UPDATE TelephoneClients SET Note = '" + richTextBoxNoteTelephone.Text + "' WHERE Client_Id = " + Commandes.idClient);
                    }
                    rtb.ReadOnly = true;
                }
            }
        }

        private void Rtb_DoubleClick(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            rtb.ReadOnly = false;
            modifierInformationsClient = true;
        }

        private void Tb_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
                if (modifierInformationsClient == true)
                {
                    if (tb.Name == textBoxNomClient.Name)
                    {
                        Commandes.UpdateDatabaseInformations("UPDATE Clients SET Nom = '" + textBoxNomClient.Text + "' WHERE Id = " + Commandes.idClient);
                    }
                    else if (tb.Name == textBoxCourrielClient.Name)
                    {
                        Commandes.UpdateDatabaseInformations("UPDATE Clients SET Courriel = '" + textBoxCourrielClient.Text + "' WHERE Id = " + Commandes.idClient);
                    }
                    else if (tb.Name == textBoxPrenomClient.Name)
                    {
                        Commandes.UpdateDatabaseInformations("UPDATE Clients SET Prenom = '" + textBoxPrenomClient.Text + "' WHERE Id = " + Commandes.idClient);
                    }
                    else if (tb.Name == textBox8PaysClient.Name)
                    {
                        Commandes.UpdateDatabaseInformations("UPDATE Clients SET Pays = '" + textBox8PaysClient.Text + "' WHERE Id = " + Commandes.idClient);
                    }
                    else if (tb.Name == textBox5CodePostalClient.Name)
                    {
                        Commandes.UpdateDatabaseInformations("UPDATE Clients SET CodePostal = '" + textBox5CodePostalClient.Text + "' WHERE Id = " + Commandes.idClient);
                    }
                    else if (tb.Name == textBoxAdresseClient.Name)
                    {
                        Commandes.UpdateDatabaseInformations("UPDATE Clients SET Adresse = '" + textBoxAdresseClient.Text + "' WHERE Id = " + Commandes.idClient);
                    }
                    else if (tb.Name == textBoxTelephone.Name)
                    {
                        Commandes.UpdateDatabaseInformations("UPDATE TelephoneClients SET Telephone = '" + textBoxTelephone.Text + "' WHERE Client_Id = " + Commandes.idClient);
                    }
                    else if (tb.Name == textBoxVilleClient.Name)
                    {
                        Commandes.UpdateDatabaseInformations("UPDATE Clients SET Ville = '" + textBoxVilleClient.Text + "' WHERE Id = " + Commandes.idClient);
                    }
                    else if (tb.Name == textBoxPathologie.Name)
                    {
                        Commandes.UpdateDatabaseInformations("UPDATE Clients SET Pathologie = '" + textBoxPathologie.Text + "' WHERE Id = " + Commandes.idClient);
                    }
                }
                tb.ReadOnly = true;
                modifierInformationsClient = false;
                LoadDataProduitsClient();
            }
        }

        private void Tb_DoubleClick(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.ReadOnly = false;
            modifierInformationsClient = true;
        }

        private void supprimerLeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerClient supprimer = new SupprimerClient();
            supprimer.Show();
        }

        private void désactiverLeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (actif == true)
            {
                DesactiverClient desactiver = new DesactiverClient();
                desactiver.Show();
            }
            else
            {
                MessageBox.Show("Ce client est déjà désactivé");
            }
        }

        private void réactiverLeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(actif == true)
            {
                MessageBox.Show("Ce client est déja actif.");
            }
            else
            {
                Commandes.UpdateDatabaseInformations("UPDATE Clients SET Active = '" + true + "' WHERE Id = '" + Commandes.idClient + "'");
                MessageBox.Show("Client réactivé.");
                this.Close();
            }
        }

        private void DossierClient_Load(object sender, EventArgs e)
        {
            RichTextboxDoubleClick(this);
            TextboxDoubleClick(this);
        }

        private void buttonFacture_Click(object sender, EventArgs e)
        {
            Facture facture = new Facture();
            facture.Show();
        }
    }
}
