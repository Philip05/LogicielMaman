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
    public class Commandes
    {
        public static int produitId;
        public static int quantiteProduitAchat;
        public static int idAdministrateur;
        public static int idClient;
        public static string idProduitClient;
        public static string idRencontre;
        public static string NomUtilisateurAdministrateurConnecte;
        public static int idFournisseur;
        public static SqlConnection con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
        public static string motDePasseAdministrateur;
        public static string[] tableauImagesImportees;
        public static string descriptionImage;
        public static string sourceImage;
        public static string dateImage;
        public static string nomClient;
        public static string prenomClient;
        public static string NomAdministrateurConnecte;
        public static string PrenomAdministrateurConnecte;
        public static string AdresseAdministrateurConnecte;
        public static string TelephoneAdministrateurConnecte;

        public static void LoadElements(string commande, DataGridView grille)
        {
            SqlCommand cmd;

            using (cmd = new SqlCommand(commande, con))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        grille.DataSource = dt;
                    }
                }

                con.Close();
            }
        }

        public static void UpdateDatabaseInformations(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void changerEtatUsager(string etat, int idAdministrateur)
        {
            string constring = Properties.Settings.Default.DossierPatientsConnectionString;
            string Query = @"UPDATE Administrateurs SET Connecte = '" + etat + "' WHERE Id = " + idAdministrateur;
            SqlCommand cmd = new SqlCommand(Query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static int SelectIDComboBox(string commande)
        {
            int id = 0;
            string Query = commande;
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader Reader;
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    id = Convert.ToInt32(Reader.GetValue(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return id;
        }
    }
}
