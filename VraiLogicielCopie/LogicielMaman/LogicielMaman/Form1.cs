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
        AdministrateurPersonne administrateur;
        public Form1()
        {
            InitializeComponent();
            administrateur = new AdministrateurPersonne();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void buttonConnectionAdministrateur_Click(object sender, EventArgs e)
        {
            SelectAdmin();
        }

        private void SelectAdmin()
        {
            string constring = Properties.Settings.Default.DossierPatientsConnectionString;;
            string Query = "SELECT * FROM Administrateurs WHERE NomUtilisateur = '" + textBoxNomAdministrateur.Text + "'";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader Reader;
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Commandes.idAdministrateur = Convert.ToInt32(Reader.GetValue(0));
                    Commandes.NomAdministrateurConnecte = Reader.GetValue(1).ToString();
                    Commandes.PrenomAdministrateurConnecte = Reader.GetValue(2).ToString();
                    Commandes.TelephoneAdministrateurConnecte = Reader.GetValue(7).ToString();
                    Commandes.AdresseAdministrateurConnecte = Reader.GetValue(8).ToString() + ", " + Reader.GetValue(9).ToString() + ", " + Reader.GetValue(10).ToString() +", " + Reader.GetValue(11).ToString();
                    Commandes.NomAdministrateurConnecte = Reader.GetValue(1).ToString();
                    Commandes.motDePasseAdministrateur = Reader.GetValue(5).ToString();
                    Commandes.NomUtilisateurAdministrateurConnecte = Reader.GetValue(6).ToString();
                    if (Commandes.motDePasseAdministrateur == textBoxMotDePasseAdministrateur.Text && Commandes.NomUtilisateurAdministrateurConnecte == textBoxNomAdministrateur.Text)
                    {
                        Commandes.changerEtatUsager("True",Commandes.idAdministrateur);
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

        private void TextboxEnterPress(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.KeyUp += Tb_KeyUp;
                }
                else
                {
                    TextboxEnterPress(ctrl);
                }
            }
        }

        private void Tb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectAdmin();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextboxEnterPress(this);
        }
    }
}
