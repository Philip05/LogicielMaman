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
    public partial class EnleverProduitInventaire : Form
    {
        public EnleverProduitInventaire()
        {
            InitializeComponent();
        }

        private void buttonOui_Click(object sender, EventArgs e)
        {
            Commandes.UpdateDatabaseInformations(@"UPDATE Produits SET QuantiteEnStock = QuantiteEnStock -" + Commandes.quantiteProduitAchat + "WHERE Id = " + Commandes.produitId);
            MessageBox.Show("Ajout réussi.");
            this.Hide();
        }

        private void buttonNon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
