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
    public partial class InformationsProduit : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public InformationsProduit()
        {
            InitializeComponent();
            con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
            LoadContent();
            comboBoxFournisseur.Hide();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TextboxDoubleClick(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.DoubleClick += Tb_DoubleClick;
                    tb.KeyUp += Tb_KeyUp;
                }
                else
                {
                    TextboxDoubleClick(ctrl);
                }
            }
        }

        private void Tb_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
                if (tb.Name == textBoxNom.Name)
                {
                    Commandes.UpdateDatabaseInformations("UPDATE Produits SET Nom = '" + textBoxNom.Text + "' WHERE Id = " + Commandes.produitId);
                }
                else if (tb.Name == textBoxPrixCoutant.Name)
                {
                    Commandes.UpdateDatabaseInformations("UPDATE Produits SET PrixCoutant = '" + textBoxPrixCoutant.Text + "' WHERE Id = " + Commandes.produitId);
                }
                else if (tb.Name == textBoxPrixVendant.Name)
                {
                    Commandes.UpdateDatabaseInformations("UPDATE Produits SET PrixVendant = '" + textBoxPrixVendant.Text + "' WHERE Id = " + Commandes.produitId);
                }
                else if (tb.Name == textBoxQuantiteEnInventaire.Name)
                {
                    Commandes.UpdateDatabaseInformations("UPDATE Produits SET QuantiteEnStock = '" + textBoxQuantiteEnInventaire.Text + "' WHERE Id = " + Commandes.produitId);
                }
                tb.ReadOnly = true;
            }
        }

        private void Tb_DoubleClick(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.ReadOnly = false;
            textBoxFournisseur.Hide();
            comboBoxFournisseur.Show();
            comboBoxFournisseur.Text = textBoxFournisseur.Text;
        }

        public void LoadContent()
        {
            SqlCommand cmd;
            string query = "SELECT  Produits.Nom,Produits.QuantiteEnStock,Produits.Note,Produits.PrixCoutant,Produits.PrixVendant,Fournisseurs.Nom FROM Produits INNER JOIN Fournisseurs ON Produits.Fournisseur_Id = Fournisseurs.Id WHERE Produits.Id = " + Commandes.produitId;
            cmd = new SqlCommand(query, con);
            SqlDataReader Reader;
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    textBoxNom.Text = Reader.GetValue(0).ToString();
                    textBoxPrixCoutant.Text = Reader.GetValue(3).ToString();
                    textBoxPrixVendant.Text = Reader.GetValue(4).ToString();
                    textBoxQuantiteEnInventaire.Text = Reader.GetValue(1).ToString();
                    textBoxFournisseur.Text = Reader.GetValue(5).ToString();
                    richTextBoxNote.Text = Reader.GetValue(2).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void richTextBoxNote_DoubleClick(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            rtb.ReadOnly = false;
        }

        private void richTextBoxNote_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Commandes.UpdateDatabaseInformations("UPDATE Produits SET Note = '" + richTextBoxNote.Text + "' WHERE Id = " + Commandes.produitId);
            }
        }

        private void InformationsProduit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dossierPatientsDataSet8.Fournisseurs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.fournisseursTableAdapter.Fill(this.dossierPatientsDataSet8.Fournisseurs);
            TextboxDoubleClick(this);
        }

        private void comboBoxFournisseur_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int comboBoxId = Commandes.SelectIDComboBox("SELECT Id FROM Fournisseurs WHERE Nom = '" + comboBoxFournisseur.Text + "'");
                Commandes.UpdateDatabaseInformations("UPDATE Produits SET Fournisseur_Id = '" + comboBoxId + "' WHERE Id = " + Commandes.produitId);
                textBoxFournisseur.Text = comboBoxFournisseur.Text;
                comboBoxFournisseur.Hide();
                textBoxFournisseur.Show();
            }
        }

        private void InformationsProduit_Click(object sender, EventArgs e)
        {
            comboBoxFournisseur.Hide();
            textBoxFournisseur.Show();
        }
    }
}
