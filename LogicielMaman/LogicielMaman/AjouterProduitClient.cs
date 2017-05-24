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
    public partial class AjouterProduitClient : Form
    {
        public static int produitId;
        public static int quantiteProduitAchat;
        public AjouterProduitClient()
        {
            InitializeComponent();
            LoadProduits();
            dataGridViewAjourProduitsClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void LoadProduits()
        {
            SqlConnection con;
            SqlCommand cmd;

            using (con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString))
            {
                using (cmd = new SqlCommand("SELECT Produits.Nom,Produits.QuantiteEnStock,Produits.Note,Produits.PrixVendant,Fournisseurs.Nom FROM Produits INNER JOIN Fournisseurs ON Produits.Fournisseur_Id = Fournisseurs.Id", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridViewAjourProduitsClients.DataSource = dt;
                        }
                    }
                }
                con.Close();
            }
        }

        public int ObtenirIdProduit(int x)
        {
            int ligne = dataGridViewAjourProduitsClients.CurrentCell.RowIndex;
            string constring = Properties.Settings.Default.DossierPatientsConnectionString;
            string nom = dataGridViewAjourProduitsClients.Rows[x].Cells[0].Value.ToString();
            string note = dataGridViewAjourProduitsClients.Rows[x].Cells[2].Value.ToString();
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
            dataGridViewAjourProduitsClients.Rows[x].Cells[0];
            string Query = @"SELECT * FROM Produits WHERE Nom = '" + nom + "' AND Note = '" + note + "'";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader Reader;
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    produitId = Convert.ToInt32(Reader.GetValue(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return produitId;
        }

        private void buttonAjouterProduitSelectionne_Click(object sender, EventArgs e)
        {
            int ligne = dataGridViewAjourProduitsClients.CurrentCell.RowIndex;
            produitId = ObtenirIdProduit(ligne);
            quantiteProduitAchat = Convert.ToInt32(numericUpDownQuantite.Value);
            string constring = Properties.Settings.Default.DossierPatientsConnectionString;
            string Query = @"INSERT INTO Achats (Note,DateAchat,Quantite,Client_Id,Produits_Id) VALUES (@Note,@DateAchat,@Quantite,@Client_Id,@Produits_Id)";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, con);

            //Aller chetcher les données.
            cmd.Parameters.Add("@Note", SqlDbType.VarChar, 80).Value = richTextBoxNote.Text;
            cmd.Parameters.Add("@DateAchat", SqlDbType.VarChar, 80).Value = DateTime.Today;
            cmd.Parameters.Add("@Quantite", SqlDbType.VarChar, 80).Value = numericUpDownQuantite.Value;
            cmd.Parameters.Add("Client_Id", SqlDbType.VarChar, 80).Value = FormeClients.IdClient;
            cmd.Parameters.Add("@Produits_Id", SqlDbType.VarChar, 80).Value = produitId;
            con.Open();
            cmd.ExecuteNonQuery();

            EnleverProduitInventaire i = new EnleverProduitInventaire();
            i.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
