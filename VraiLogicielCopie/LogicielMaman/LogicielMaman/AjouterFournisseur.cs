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
    public partial class AjouterFournisseur : Form
    {
        DossierContainer ctx;
        private int idNouveauFournisseur;
        public AjouterFournisseur()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            ctx = new DossierContainer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjouterLeFournisseur();
            MessageBox.Show("Insertion du fournisseur réussie.");
            this.Hide();
        }

      //Methodes

        private void AjouterLeFournisseur()
        {
            Fournisseur fournisseur = new Fournisseur();
            fournisseur.Nom = textBoxNom.Text;
            fournisseur.Actif = true;
            fournisseur.Note = richTextBoxNote.Text;
            fournisseur.Adresse = textBoxAdresse.Text;
            fournisseur.Ville = textBoxVille.Text;
            fournisseur.Pays = textBoxPays.Text;
            fournisseur.CodePostal = textBoxCodePostal.Text;
            ctx.Fournisseurs.Add(fournisseur);
            ctx.SaveChanges();
            TrouverIdNouveauFournisseur();
            TelephoneFournisseur tel = new TelephoneFournisseur();
            Fournisseur fourns = (from fourn in ctx.Fournisseurs
                                   where fourn.Id == idNouveauFournisseur
                                   select fourn).FirstOrDefault();
            tel.Telephone = textBoxTelephone.Text;
            tel.Note = richTextBoxNote.Text;
            tel.Fournisseur = fourns;
            ctx.TelephoneFournisseurs.Add(tel);
            ctx.SaveChanges();
        }

        private void TrouverIdNouveauFournisseur()
        {
            idNouveauFournisseur = ctx.Fournisseurs.Max(f => f.Id);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
