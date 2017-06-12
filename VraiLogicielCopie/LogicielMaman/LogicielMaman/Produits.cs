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
    public partial class Produits : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public Produits()
        {
            InitializeComponent();
            con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
            dataGridViewProduits.Font = new Font("Arial", 16);
            Commandes.LoadElements("SELECT Produits.Id, Produits.Nom,Produits.QuantiteEnStock,Produits.Note,Produits.PrixCoutant,Produits.PrixVendant,Fournisseurs.Nom FROM Produits INNER JOIN Fournisseurs ON Produits.Fournisseur_Id = Fournisseurs.Id", dataGridViewProduits);
            dataGridViewProduits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBoxRecherher_KeyUp(object sender, KeyEventArgs e)
        {
            Commandes.LoadElements("SELECT Produits.Id, Produits.Nom,Produits.QuantiteEnStock,Produits.Note,Produits.PrixCoutant,Produits.PrixVendant,Fournisseurs.Nom FROM Produits INNER JOIN Fournisseurs ON Produits.Fournisseur_Id = Fournisseurs.Id WHERE Produits.Nom LIKE '%" + textBoxRecherher.Text + "%' OR QuantiteEnStock LIKE '%" + textBoxRecherher.Text + "%'",dataGridViewProduits);
        }

        private void buttonAjouterProduit_Click(object sender, EventArgs e)
        {
            AjouterProduit produit = new AjouterProduit();
            produit.Show();
        }

        public int ObtenirIDProduit(int x)
        {
            Commandes.produitId = Convert.ToInt32(dataGridViewProduits.Rows[x].Cells[0].Value.ToString());
            return Commandes.produitId;
        }

        private void dataGridViewProduits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
            dataGridViewProduits.Rows[e.RowIndex].Cells[e.ColumnIndex];
            ObtenirIDProduit(e.RowIndex);
            InformationsProduit informations = new InformationsProduit();
            informations.Show();
        }
    }
}
