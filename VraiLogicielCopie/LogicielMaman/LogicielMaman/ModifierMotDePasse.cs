using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicielMaman
{
    public partial class ModifierMotDePasse : Form
    {
        private DossierContainer ctx;
        public ModifierMotDePasse()
        {
            InitializeComponent();
            ctx = new DossierContainer();
        }

        private void buttonRetourAccueil_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
        
            if (textBoxAncienPasse.Text == Commandes.motDePasseAdministrateur)
            {
                if(textBox1NouveauPasse.Text == textBoxConfirmerNouveauMotDePasse.Text)
                {
                    ModifierLeMotDePasse();
                }
                else
                {
                    MessageBox.Show("Les nouveaux mots de passe ne sont pas identiques.");
                    textBoxAncienPasse.Clear();
                    textBox1NouveauPasse.Clear();
                    textBoxConfirmerNouveauMotDePasse.Clear();
                }
            }
            else
            {
                MessageBox.Show("Votre ancien mot de passe n'est pas valide.");
                textBoxAncienPasse.Clear();
                textBox1NouveauPasse.Clear();
                textBoxConfirmerNouveauMotDePasse.Clear();
            }
        }

        private void ModifierLeMotDePasse()
        {
            var query =
              from admin in ctx.Administrateurs
              where admin.Id == Commandes.idAdministrateur
              select admin;

            foreach (Administrateur admin in query)
            {
                admin.MotDePasse = textBox1NouveauPasse.Text;
            }

            try
            {
                ctx.SaveChanges();
                MessageBox.Show("Modification réussie.");
                Commandes.motDePasseAdministrateur = textBoxConfirmerNouveauMotDePasse.Text;
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
