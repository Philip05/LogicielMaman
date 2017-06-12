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
    public partial class SupprimerClient : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public SupprimerClient()
        {
            InitializeComponent();
        }

        private void button2Non_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOui_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Clients WHERE Id ='" + Commandes.idClient + "'";
            string query2 = "DELETE FROM TelephoneClients WHERE Client_Id ='" + Commandes.idClient + "'";
            string query3 = "DELETE FROM Images WHERE Client_Id ='" + Commandes.idClient + "'";
            string query4 = "DELETE FROM Achats WHERE Client_Id ='" + Commandes.idClient + "'";
            string query5 = "DELETE FROM Rencontres WHERE Client_Id ='" + Commandes.idClient + "'";
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
            cmd = new SqlCommand(query4, con);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            cmd = new SqlCommand(query5, con);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
        }
    }
}
