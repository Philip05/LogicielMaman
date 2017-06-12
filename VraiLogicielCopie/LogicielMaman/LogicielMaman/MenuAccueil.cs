using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicielMaman
{
    public partial class MenuAccueil : Form
    {
        public MenuAccueil()
        {
            InitializeComponent();
            labelBonjour.Text = "Bonjour " + Commandes.NomUtilisateurAdministrateurConnecte;
        }

        private void MenuAccueil_Load(object sender, EventArgs e)
        {

        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            FormeClients f = new FormeClients();
            f.Show();
        }

        private void buttonProduits_Click(object sender, EventArgs e)
        {
            Produits produit = new Produits();
            produit.Show();
        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            Commandes.changerEtatUsager("False",Commandes.idAdministrateur);
            Close();
        }

        private void buttonFournisseurs_Click(object sender, EventArgs e)
        {
            Fournisseurs fournisseurs = new Fournisseurs();
            fournisseurs.Show();
        }

        private void buttonMonCompte_Click(object sender, EventArgs e)
        {
            CompteAdminitrateur compte = new CompteAdminitrateur();
            compte.Show();
        }
    }
}
