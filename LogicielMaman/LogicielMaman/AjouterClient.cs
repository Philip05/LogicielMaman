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
    public partial class ButtonRetournerMenu : Form
    {
        public ButtonRetournerMenu()
        {
            InitializeComponent();
        }

        private void AjouterClient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dossierPatientsDataSet4.Sexes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sexesTableAdapter.Fill(this.dossierPatientsDataSet4.Sexes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAjouterClient_Click(object sender, EventArgs e)
        {
            string constring = Properties.Settings.Default.DossierPatientsConnectionString; ;
            string Query = @"INSERT INTO Clients (Nom,Prenom,Adresse,CodePostal,Courriel,DateInscription,Active,Note,Ville,Pays,Pathologie,Sexe_Id) VALUES (@Nom,@Prenom,@Adresse,@CodePostal,@Courriel,@DateInscription,@Active,@Note,@Ville,@Pays,@Pathologie,@Sexe_Id)";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, con);

            //Aller chetcher les données.
            int comboBoxId = comboBoxSexe.Items.Count;
            cmd.Parameters.Add("@Nom", SqlDbType.VarChar, 80).Value = textBoxNom.Text;
            cmd.Parameters.Add("@Prenom", SqlDbType.VarChar, 80).Value = textBoxPrenom.Text;
            cmd.Parameters.Add("@Adresse", SqlDbType.VarChar, 80).Value = textBoxAdresse.Text;
            cmd.Parameters.Add("CodePostal", SqlDbType.VarChar, 80).Value = textBoxCodePostal.Text;
            cmd.Parameters.Add("@Courriel", SqlDbType.VarChar, 80).Value = textBoxCourriel.Text;
            cmd.Parameters.Add("@DateInscription", SqlDbType.VarChar, 80).Value = DateTime.Today;
            cmd.Parameters.Add("@Active", SqlDbType.Bit, 80).Value = true;
            cmd.Parameters.Add("@Note", SqlDbType.VarChar, 80).Value = richTextBoxNote.Text;
            cmd.Parameters.Add("@Ville", SqlDbType.VarChar, 80).Value = textBoxVille.Text;
            cmd.Parameters.Add("@Pays", SqlDbType.VarChar, 80).Value = textBoxPays.Text;
            cmd.Parameters.Add("@Pathologie", SqlDbType.VarChar, 80).Value = textBoxPathologie.Text;
            cmd.Parameters.Add("@Sexe_Id", SqlDbType.Int, 80).Value = comboBoxId;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insertion du client réussie.");
            this.Hide();
        }
    }
}
