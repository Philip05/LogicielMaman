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
    public partial class SupprimerFournisseur : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public SupprimerFournisseur()
        {
            InitializeComponent();
        }

        private void button2Non_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOui_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
            string query1 = "DELETE FROM Fournisseurs WHERE Id ='" + Commandes.idFournisseur + "'";
            string query2 = "DELETE FROM TelephoneFournisseurs WHERE Fournisseur_Id ='" + Commandes.idFournisseur + "'";
            string query3 = "DELETE FROM Produits WHERE Fournisseur_Id ='" + Commandes.idFournisseur + "'";
            con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
            con.Open();
            cmd = new SqlCommand(query2, con);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            cmd = new SqlCommand(query3, con);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            cmd = new SqlCommand(query1, con);
            cmd.ExecuteNonQuery();
            this.Close();
        }
    }
}
