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
        private DossierContainer ctx;
        private int idNouveauClient;
        public ButtonRetournerMenu()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            ctx = new DossierContainer();
        }

        private void AjouterClient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dossierPatientsDataSet7.TypeTelephones'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeTelephonesTableAdapter.Fill(this.dossierPatientsDataSet7.TypeTelephones);
            // TODO: cette ligne de code charge les données dans la table 'dossierPatientsDataSet4.Sexes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sexesTableAdapter.Fill(this.dossierPatientsDataSet4.Sexes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAjouterClient_Click(object sender, EventArgs e)
        {
            AjouterLeClient();
            MessageBox.Show("Insertion du client réussie.");
            this.Hide();
        }


        //Méthodes

        private void AjouterLeClient()
        {
            Client client = new Client();
            int comboBoxId = Commandes.SelectIDComboBox("SELECT Id FROM Sexes WHERE Categorie = '" + comboBoxSexe.Text + "'");
            int idtypeTelephone = Commandes.SelectIDComboBox("SELECT Id FROM TypeTelephones WHERE Lieu = '" + comboBoxTypeTelephone.Text + "'");
            Sexe sexes = (from sexe in ctx.Sexes
                          where sexe.Id == comboBoxId
                          select sexe).FirstOrDefault();
            client.Nom = textBoxNom.Text;
            client.Prenom = textBoxPrenom.Text;
            client.Adresse = textBoxAdresse.Text;
            client.CodePostal = textBoxCodePostal.Text;
            client.Courriel = textBoxCourriel.Text;
            client.DateInscription = DateTime.Today;
            client.Active = true;
            client.Ville = textBoxVille.Text;
            client.Pays = textBoxPays.Text;
            client.Note = richTextBoxNote.Text;
            client.Pathologie = textBoxPathologie.Text;
            client.Sexe = sexes;
            ctx.Clients.Add(client);
            ctx.SaveChanges();
            TelephoneClient tels = new TelephoneClient();
            TrouverIdNouveauClient();
            Client clis = (from cli in ctx.Clients
                           where cli.Id == idNouveauClient
                           select cli).FirstOrDefault();
            TypeTelephone types = (from type in ctx.TypeTelephones
                                   where type.Id == idtypeTelephone
                                   select type).FirstOrDefault();
            tels.Telephone = textBoxTelephone.Text;
            tels.Note = richTextBoxNoteTelephone.Text;
            tels.Client = clis;
            tels.TypeTelephones = types;
            ctx.TelephoneClients.Add(tels);
            ctx.SaveChanges();
        }

        private void TrouverIdNouveauClient()
        {
            idNouveauClient = ctx.Clients.Max(p => p.Id);
        }
    }
}
