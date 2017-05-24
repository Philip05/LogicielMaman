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
    public partial class Form1 : Form
    {
        private static string id;
        AdministrateurPersonne administrateur;
        public Form1()
        {
            InitializeComponent();
            administrateur = new AdministrateurPersonne();
        }

        private void buttonConnectionAdministrateur_Click(object sender, EventArgs e)
        {
            SelctionnerUsager();
        }

        private void SelctionnerUsager()
        {
            string usager;
            string motDePasse;
            string constring = Properties.Settings.Default.DossierPatientsConnectionString;;
            string Query = "SELECT * FROM Administrateurs WHERE Prenom = '" + textBoxNomAdministrateur.Text + "'";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader Reader;
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    id = Reader.GetValue(0).ToString();
                    usager = Reader.GetValue(2).ToString();
                    motDePasse = Reader.GetValue(5).ToString();
                    if (motDePasse == textBoxMotDePasseAdministrateur.Text && usager == textBoxNomAdministrateur.Text)
                    {
                        changerEtatUsager("True");
                        AdministrateurPersonne.NomAdministrateurConnecte = Reader.GetValue(6).ToString();
                        this.Hide();
                        MenuAccueil menu = new MenuAccueil();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Cet administrateur n'existe pas.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cet utilisateur n'existe pas");
            }
            con.Close();
        }

        public static void changerEtatUsager(string etat)
        {
            string constring = Properties.Settings.Default.DossierPatientsConnectionString;
            string Query = @"UPDATE Administrateurs SET Connecte = '" + etat + "' WHERE Id = " + int.Parse(id);
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
