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
    public partial class ProduitClient : Form
    {
        private int idProduitFournisseur;
        private SqlConnection con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
        public ProduitClient()
        {
            InitializeComponent();
            LoadClient();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void ProduitClient_Load(object sender, EventArgs e)
        {

        }

        public void LoadClient()
        {
            SqlCommand cmd;
            string query1 = "SELECT * FROM Achats WHERE ID = " + Commandes.idProduitClient;
            cmd = new SqlCommand(query1, con);
            SqlDataReader Reader;
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    richTextBoxNote.Text = Reader.GetValue(1).ToString();
                    labelRepAchat.Text = Reader.GetValue(2).ToString();
                    labelRepQuantite.Text = Reader.GetValue(3).ToString();
                    idProduitFournisseur = Convert.ToInt32(Reader.GetValue(5));
                }
                Reader.Close();
            }
            catch 
            {
                MessageBox.Show("Cette case est vide.");
            }
            con.Close();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void richTextBoxNote_DoubleClick(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            rtb.ReadOnly = false;
        }

        private void richTextBoxNote_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Commandes.UpdateDatabaseInformations("UPDATE Achats SET Note = '" + richTextBoxNote.Text + "' WHERE Id = '" + Commandes.idClient + "'");
                this.Close();
            }
        }
    }
}
