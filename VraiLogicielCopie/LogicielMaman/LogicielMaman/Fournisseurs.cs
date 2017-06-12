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
    public partial class Fournisseurs : Form
    {
        private SqlConnection con;
        public Fournisseurs()
        {
            InitializeComponent();
            dataGridViewFournisseurs.Font = new Font("Arial", 16);
            con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
            Commandes.LoadElements("SELECT Nom,Adresse,Pays,CodePostal,Note FROM Fournisseurs", dataGridViewFournisseurs);
            dataGridViewFournisseurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void textBoxRechercher_KeyUp(object sender, KeyEventArgs e)
        {
            Commandes.LoadElements("SELECT Nom,Adresse,Pays,CodePostal,Note FROM Fournisseurs WHERE Nom LIKE '%" + textBoxRechercher.Text + "%' OR Adresse LIKE '%" + textBoxRechercher.Text + "%' OR Ville LIKE '%" + textBoxRechercher.Text + "%' OR Pays LIKE '%" + textBoxRechercher.Text + "%'", dataGridViewFournisseurs);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAjouterFournisseur_Click(object sender, EventArgs e)
        {
            AjouterFournisseur ajout = new AjouterFournisseur();
            ajout.Show();
        }

        public int ObtenirIdFournisseur(int x)
        {
            string test = dataGridViewFournisseurs.Rows[x].Cells[0].Value.ToString();
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
            dataGridViewFournisseurs.Rows[x].Cells[0];
            string Query = "SELECT Id FROM Fournisseurs WHERE Nom = '" + test + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader Reader;
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Commandes.idFournisseur = Convert.ToInt32(Reader.GetValue(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return Commandes.idFournisseur;
        }

        private void dataGridViewFournisseurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
            dataGridViewFournisseurs.Rows[e.RowIndex].Cells[e.ColumnIndex];
            ObtenirIdFournisseur(e.RowIndex);
            DossierFournisseur dossier = new DossierFournisseur();
            dossier.Show();
        }
    }
}
