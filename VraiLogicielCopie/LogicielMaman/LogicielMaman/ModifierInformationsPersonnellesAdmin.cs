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
    public partial class ModifierInformationsPersonnellesAdmin : Form
    {
        DossierContainer ctx;
        public ModifierInformationsPersonnellesAdmin()
        {
            InitializeComponent();
            ctx = new DossierContainer();
        }

        private void buttonEnregistrerModifications_Click(object sender, EventArgs e)
        {
            var query =
              from admin in ctx.Administrateurs
              where admin.Id == Commandes.idAdministrateur
              select admin;

            foreach (Administrateur admin in query)
            {
                admin.Nom = textBoxNouveauNom.Text;
                admin.Prenom = textBox1NouveauPrenom.Text;
                admin.NomUtilisateur = textBoxNouveauNomUtilisateur.Text;
            }

            try
            {
                ctx.SaveChanges();
                MessageBox.Show("Ajout réussi.");
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void buttonRetourAccueil_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonModifierMotDePasse_Click(object sender, EventArgs e)
        {
            ModifierMotDePasse modifier = new ModifierMotDePasse();
            modifier.Show();
        }
    }
}
