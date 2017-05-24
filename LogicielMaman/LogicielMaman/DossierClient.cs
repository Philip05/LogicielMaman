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
        private ClientsPersonnes client;
        public DossierClient()
        {
            InitializeComponent();
            LoadDataProduitsClient();
            dataGridViewProduitsClient.Font = new Font("Arial", 12);
            dataGridViewProduitsClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //client = new ClientsPersonnes();
        }

        public void LoadDataProduitsClient()
        {
            SqlConnection con;
            SqlCommand cmd;

            using (con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString))
            {
                using (cmd = new SqlCommand("SELECT Produits.Nom,Achats.DateAchat,Achats.Quantite,Achats.Note FROM Achats INNER JOIN Produits ON Achats.Produits_Id = Produits.Id WHERE Client_Id = " + FormeClients.IdClient, con))
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
                }

                string Query = "SELECT * FROM Clients WHERE ID = " + FormeClients.IdClient;
                cmd = new SqlCommand(Query, con);
                SqlDataReader Reader;
                try
                {
                    con.Open();
                    Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        textBoxNomClient.Text = Reader.GetValue(1).ToString();
                        textBoxPrenomClient.Text = Reader.GetValue(2).ToString();
                        textBoxAdresseClient.Text = Reader.GetValue(3).ToString();
                        textBox4CourrielClient.Text = Reader.GetValue(5).ToString();
                        textBox5CodePostalClient.Text = Reader.GetValue(4).ToString();
                        textBoxVilleClient.Text = Reader.GetValue(9).ToString();
                        textBox8PaysClient.Text = Reader.GetValue(10).ToString();
                        textBoxDateInscriptionClient.Text = Reader.GetValue(6).ToString();
                        richTextBoxNoteClient.Text = Reader.GetValue(8).ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

    private void DossierClient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dossierPatientsDataSet3.Achats'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.achatsTableAdapter.Fill(this.dossierPatientsDataSet3.Achats);

        }

        private void sélectionnerProduitsClientToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.achatsTableAdapter.SélectionnerProduitsClient(this.dossierPatientsDataSet3.Achats);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridViewProduitsClient_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
