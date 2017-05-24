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
            string constring = Properties.Settings.Default.DossierPatientsConnectionString;
            string Query = @"UPDATE Produits SET QuantiteEnStock = QuantiteEnStock -" + AjouterProduitClient.quantiteProduitAchat + "WHERE Id = " + AjouterProduitClient.produitId;
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ajout réussi.");
            this.Hide();
            AjouterProduitClient j = new AjouterProduitClient();
            j.Hide();
        }

        private void buttonNon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
