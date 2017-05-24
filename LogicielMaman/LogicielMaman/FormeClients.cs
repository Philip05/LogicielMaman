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
        public static int IdClient;
        public FormeClients()
        {
            InitializeComponent();
            grilleClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grilleClients.Font = new Font("Arial", 12);
        }

        private void FormeClients_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dossierPatientsDataSet1.Clients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientsTableAdapter1.Fill(this.dossierPatientsDataSet1.Clients);
            // TODO: cette ligne de code charge les données dans la table 'dossierPatientsDataSet.Clients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientsTableAdapter.Fill(this.dossierPatientsDataSet.Clients);

        }

        public int ObtenirIDClient(int x)
        {
            string constring = Properties.Settings.Default.DossierPatientsConnectionString;
            string test = grilleClients.Rows[x].Cells[1].Value.ToString();
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
            grilleClients.Rows[x].Cells[0];
            string Query = "SELECT Id FROM Clients WHERE Prenom = '" + test + "'";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader Reader;
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while(Reader.Read())
                {
                    IdClient = Convert.ToInt32(Reader.GetValue(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return IdClient;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
            grilleClients.Rows[e.RowIndex].Cells[e.ColumnIndex];
            ObtenirIDClient(e.RowIndex);
            //MessageBox.Show(cell.Value.ToString());
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
    }
}
