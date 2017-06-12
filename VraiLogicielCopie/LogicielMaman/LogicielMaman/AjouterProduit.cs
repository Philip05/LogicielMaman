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
    public partial class AjouterProduit : Form
    {
        DossierContainer ctx;
        public AjouterProduit()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            ctx = new DossierContainer();
        }

        private void buttonAjouterProduit_Click(object sender, EventArgs e)
        {
            AjouterLeProduit();
            MessageBox.Show("Insertion du produit réussie");
            this.Hide();
        }

        //Méthodes

        private void AjouterLeProduit()
        {
            int comboBoxId = Commandes.SelectIDComboBox("SELECT Id FROM Fournisseurs WHERE Nom = '" + comboBoxFournisseur.Text + "'");
            Produit produit = new Produit();
            Fournisseur fourns = (from fourn in ctx.Fournisseurs
                                  where fourn.Id == comboBoxId
                                  select fourn).FirstOrDefault();
            produit.Nom = textBoxNom.Text;
            produit.PrixCoutant = Convert.ToDouble(textBoxPrixCoutant.Text);
            produit.PrixVendant = Convert.ToDouble(textBoxPrixVendant.Text);
            produit.QuantiteEnStock = Convert.ToInt32(textBoxQteInventaire.Text);
            produit.Note = richTextBoxNote.Text;
            produit.Fournisseur = fourns;
            ctx.Produits.Add(produit);
            ctx.SaveChanges();
        }

        private void AjouterProduit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dossierPatientsDataSet6.Fournisseurs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.fournisseursTableAdapter.Fill(this.dossierPatientsDataSet6.Fournisseurs);
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
