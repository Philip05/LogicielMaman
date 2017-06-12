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
    public partial class CompteAdminitrateur : Form
    {
        private SqlConnection con;
        public CompteAdminitrateur()
        {
            InitializeComponent();
            con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
            LoadInformations();
        }

        private void LoadInformations()
        {
            SqlCommand cmd;
            string Query = "SELECT * FROM Administrateurs WHERE Id = " + Commandes.idAdministrateur;
            cmd = new SqlCommand(Query, con);
            SqlDataReader Reader;
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    labelRepNom.Text = Reader.GetValue(1).ToString();
                    labelRepPrenom.Text = Reader.GetValue(2).ToString();
                    labelRepDateInscription.Text = Reader.GetValue(3).ToString();
                    textBoxRepMotDePasse.Text = Reader.GetValue(5).ToString();
                    labelRepNomUtilisateur.Text = Reader.GetValue(6).ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void buttonModifierInfosPersonnels_Click(object sender, EventArgs e)
        {
            ModifierInformationsPersonnellesAdmin modifier = new ModifierInformationsPersonnellesAdmin();
            modifier.Show();
        }

        private void buttonRetourAccueil_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
