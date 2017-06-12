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
    public partial class FormeClients : Form
    {
        private SqlConnection con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
        public FormeClients()
        {
            InitializeComponent();
            grilleClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grilleClients.Font = new Font("Arial", 16);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void FormeClients_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dossierPatientsDataSet9.Clients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientsTableAdapter2.Fill(this.dossierPatientsDataSet9.Clients);
            // TODO: cette ligne de code charge les données dans la table 'dossierPatientsDataSet1.Clients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientsTableAdapter1.Fill(this.dossierPatientsDataSet1.Clients);
            // TODO: cette ligne de code charge les données dans la table 'dossierPatientsDataSet.Clients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientsTableAdapter.Fill(this.dossierPatientsDataSet.Clients);

        }

        public int ObtenirIDClient(int x)
        {
            string prenom = grilleClients.Rows[x].Cells[1].Value.ToString();
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
            grilleClients.Rows[x].Cells[0];
            string Query = "SELECT * FROM Clients WHERE Prenom = '" + prenom + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader Reader;
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while(Reader.Read())
                {
                    Commandes.idClient = Convert.ToInt32(Reader.GetValue(0));
                    Commandes.prenomClient = Reader.GetValue(2).ToString();
                    Commandes.nomClient = Reader.GetValue(1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return Commandes.idClient;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
            grilleClients.Rows[e.RowIndex].Cells[e.ColumnIndex];
            ObtenirIDClient(e.RowIndex);
            DossierClient j = new DossierClient();
            j.Show();
        }

        private void grilleClients_KeyPress(object sender, KeyPressEventArgs e)
        {
            DossierClient j = new DossierClient();
            j.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAjouterClient_Click(object sender, EventArgs e)
        {
            ButtonRetournerMenu ajouter = new ButtonRetournerMenu();
            ajouter.Show();
        }

        private void textBoxRechercher_KeyUp(object sender, KeyEventArgs e)
        {
            Commandes.LoadElements("SELECT Clients.Nom,Clients.Prenom,Clients.Adresse,Clients.Pathologie FROM Clients WHERE Clients.Nom LIKE '%" + textBoxRechercher.Text + "%' OR Clients.Prenom LIKE '%" + textBoxRechercher.Text + "%' OR Clients.Pathologie = '" + textBoxRechercher + "'", grilleClients);
        }
    }
}
