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
        public Produits()
        {
            InitializeComponent();
            LoadProduits();
        }

        public void LoadProduits()
        {
            SqlConnection con;
            SqlCommand cmd;

            using (con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString))
            {
                using (cmd = new SqlCommand("SELECT Produits.Nom,Produits.QuantiteEnStock,Produits.Note,Produits.PrixCoutant,Produits.PrixVendant,Fournisseurs.Nom FROM Produits INNER JOIN Fournisseurs ON Produits.Fournisseur_Id = Fournisseurs.Id", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridViewProduits.DataSource = dt;
                        }
                    }
                }
                con.Close();
            }
        }
    }
}
