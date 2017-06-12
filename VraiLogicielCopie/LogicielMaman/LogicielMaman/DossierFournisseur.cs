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
    public partial class DossierFournisseur : Form
    {
        private SqlConnection con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
        private bool actif;
        public DossierFournisseur()
        {
            InitializeComponent();
            LoadContent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        public void LoadContent()
        {
            SqlCommand cmd;
            string query = "SELECT * FROM Fournisseurs WHERE Id = " + Commandes.idFournisseur;
            cmd = new SqlCommand(query, con);
            SqlDataReader Reader;
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    textBoxNom.Text = Reader.GetValue(1).ToString();
                    textBoxAdresse.Text = Reader.GetValue(2).ToString();
                    textBoxVille.Text = Reader.GetValue(5).ToString();
                    textBoxCodePostal.Text = Reader.GetValue(7).ToString();
                    textBoxPays.Text = Reader.GetValue(6).ToString();
                    actif = Convert.ToBoolean(Reader.GetValue(3).ToString());
                    if(Reader.GetValue(3).ToString() == "True")
                    {
                        textBoxEtatFournisseur.Text = "Fournisseur disponible";
                    }
                    else
                    {
                        textBoxEtatFournisseur.Text = "Fournisseur non-disponible";
                    }
                    richTextBoxNote.Text = Reader.GetValue(4).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            //Telephone
            string query1 = "SELECT Telephone,Note FROM TelephoneFournisseurs WHERE Fournisseur_Id = " + Commandes.idFournisseur;
            cmd = new SqlCommand(query1, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBoxTelephone.Text = reader.GetValue(0).ToString();
                    richTextBoxNoteTelephone.Text = reader.GetValue(1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void buttonRetournerMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RichTextboxDoubleClick(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is RichTextBox)
                {
                    RichTextBox rtb = (RichTextBox)ctrl;
                    rtb.DoubleClick += Rtb_DoubleClick;
                    rtb.KeyUp += Rtb_KeyUp;
                }
                else
                {
                    RichTextboxDoubleClick(ctrl);
                }
            }
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
             if(e.KeyCode == Keys.Enter)
            {
                if(tb.Name == textBoxAdresse.Name)
                {
                    Commandes.UpdateDatabaseInformations("UPDATE Fournisseurs SET Adresse = '" + textBoxAdresse.Text + "' WHERE Id = '" + Commandes.idFournisseur +"'");
                } 
                else if(tb.Name == textBoxCodePostal.Name)
                {
                    Commandes.UpdateDatabaseInformations("UPDATE Fournisseurs SET CodePostal = '" + textBoxCodePostal.Text + "' WHERE Id = '" + Commandes.idFournisseur + "'");
                }
                else if (tb.Name == textBoxNom.Name)
                {
                    Commandes.UpdateDatabaseInformations("UPDATE Fournisseurs SET Nom = '" + textBoxNom.Text + "' WHERE Id = '" + Commandes.idFournisseur + "'");
                }
                else if (tb.Name == textBoxPays.Name)
                {
                    Commandes.UpdateDatabaseInformations("UPDATE Fournisseurs SET Pays = '" + textBoxPays.Text + "' WHERE Id = '" + Commandes.idFournisseur + "'");
                }
                else if (tb.Name == textBoxTelephone.Name)
                {
                    Commandes.UpdateDatabaseInformations("UPDATE TelephoneFournisseurs SET Telephone = '" + textBoxTelephone.Text + "' WHERE Id = '" + Commandes.idFournisseur + "'");
                }
                else if (tb.Name == textBoxVille.Name)
                {
                    Commandes.UpdateDatabaseInformations("UPDATE Fournisseurs SET Ville = '" + textBoxVille.Text + "' WHERE Id = '" + Commandes.idFournisseur + "'");
                }
            }
        }

        private void Tb_DoubleClick(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.ReadOnly = false;
        }

        private void Rtb_KeyUp(object sender, KeyEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;

            if(e.KeyCode == Keys.Enter)
            {
                if(rtb.Name == richTextBoxNote.Name)
                {
                    Commandes.UpdateDatabaseInformations("UPDATE Fournisseurs SET Note = '" + richTextBoxNote.Text + "'");
                }
                else if( rtb.Name == richTextBoxNoteTelephone.Name)
                {
                    Commandes.UpdateDatabaseInformations("UPDATE TelephoneFournisseurs SET Note = '" + richTextBoxNoteTelephone.Text + "'");
                }
            }
        }

        private void Rtb_DoubleClick(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            rtb.ReadOnly = false;
        }

        private void supprimerLeFournnisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerFournisseur supprimer = new SupprimerFournisseur();
            supprimer.Show();
        }

        private void désactiverLeFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commandes.UpdateDatabaseInformations("UPDATE Fournisseurs SET Actif = '" + false + "' WHERE Id = '" + Commandes.idFournisseur + "'");
            MessageBox.Show("Fournisseur désactivé.");
            this.Close();
        }

        private void réactiverLeFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (actif == true)
            {
                MessageBox.Show("Ce fournisseur est déja actif.");
            }
            else
            {
                Commandes.UpdateDatabaseInformations("UPDATE Fournisseurs SET Actif = '" + true + "' WHERE Id = '" + Commandes.idFournisseur + "'");
                MessageBox.Show("Fournisseur réactivé.");
                this.Close();
            }
        }

        private void DossierFournisseur_Load(object sender, EventArgs e)
        {
            TextboxDoubleClick(this);
            RichTextboxDoubleClick(this);
        }
    }
}
