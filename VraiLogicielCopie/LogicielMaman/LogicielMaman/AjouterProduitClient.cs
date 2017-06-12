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
        DossierContainer ctx;
        public AjouterProduitClient()
        {
            InitializeComponent();
            LoadTableInformations();
            dataGridViewAjourProduitsClients.Font = new Font("Arial", 16);
            dataGridViewAjourProduitsClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            ctx = new DossierContainer();
        }

        private void buttonAjouterProduitSelectionne_Click(object sender, EventArgs e)
        {
            AjouterAchat();
            EnleverProduitInventaire enlever = new EnleverProduitInventaire();
            enlever.Show();
            this.Hide();
        }

        //Méthodes

        private void AjouterAchat()
        {
            Achat achat = new Achat();
            int ligne = dataGridViewAjourProduitsClients.CurrentCell.RowIndex;
            string nom = dataGridViewAjourProduitsClients.Rows[ligne].Cells[0].Value.ToString();
            string note = dataGridViewAjourProduitsClients.Rows[ligne].Cells[2].Value.ToString();
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
            dataGridViewAjourProduitsClients.Rows[ligne].Cells[0];
            Produit produit = (from pro in ctx.Produits
                               where pro.Nom == nom && pro.Note == note
                               select pro).FirstOrDefault();
            Client clis = (from cli in ctx.Clients
                           where cli.Id == Commandes.idClient
                           select cli).FirstOrDefault();
            //Commandes.produitId = int.Parse(produit);
            achat.Produits = produit;
            Commandes.quantiteProduitAchat = Convert.ToInt32(numericUpDownQuantite.Value);
            Commandes.produitId = produit.Id;
            achat.Note = richTextBoxNote.Text;
            achat.Quantite = Convert.ToDouble(numericUpDownQuantite.Value);
            achat.Client = clis;
            achat.DateAchat = DateTime.Today;
            ctx.Achats.Add(achat);
            ctx.SaveChanges();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBoxRechercher_KeyUp(object sender, KeyEventArgs e)
        {
            LoadTableInformationsBySearch();
        }

        private void LoadTableInformations()
        {
            Commandes.LoadElements("SELECT Produits.Nom,Produits.QuantiteEnStock,Produits.Note,Produits.PrixVendant,Fournisseurs.Nom FROM Produits INNER JOIN Fournisseurs ON Produits.Fournisseur_Id = Fournisseurs.Id", dataGridViewAjourProduitsClients);
        }

        private void LoadTableInformationsBySearch()
        {
            Commandes.LoadElements("SELECT Produits.Nom,Produits.QuantiteEnStock,Produits.Note,Produits.PrixVendant,Fournisseurs.Nom FROM Produits INNER JOIN Fournisseurs ON Produits.Fournisseur_Id = Fournisseurs.Id WHERE Produits.Nom LIKE '%" + textBoxRechercher.Text +"%'", dataGridViewAjourProduitsClients);
        }
    }
}
