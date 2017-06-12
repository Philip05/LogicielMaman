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
    public partial class NouvelleRencontre : Form
    {
        private SqlConnection con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
        public NouvelleRencontre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = @"INSERT INTO Rencontres (Note,DateRencontre,Client_Id) VALUES (@Note,@DateRencontre,@Client_Id)";
            SqlCommand cmd = new SqlCommand(Query, con);

            //Aller chetcher les données.
            cmd.Parameters.Add("@Note", SqlDbType.VarChar, 15000).Value = richTextBoxNote.Text;
            cmd.Parameters.Add("@DateRencontre", SqlDbType.VarChar, 80).Value = DateTime.Today;
            cmd.Parameters.Add("Client_Id", SqlDbType.VarChar, 80).Value = Commandes.idClient;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Rencontre enregistrée.");
            this.Hide();
        }

        private void buttonRetournerMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
