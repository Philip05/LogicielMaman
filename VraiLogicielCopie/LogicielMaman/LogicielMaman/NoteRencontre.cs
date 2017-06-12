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
    public partial class NoteRencontre : Form
    {
        private SqlConnection con = new SqlConnection(Properties.Settings.Default.DossierPatientsConnectionString);
        public NoteRencontre()
        {
            InitializeComponent();
        }

        private void NoteRencontre_Load(object sender, EventArgs e)
        {
            SqlCommand cmd;

            string Query = "SELECT * FROM Rencontres WHERE ID = " + Commandes.idRencontre;
            cmd = new SqlCommand(Query, con);
            SqlDataReader Reader;
            try
            {
                con.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    labelRepDate.Text = Reader.GetValue(1).ToString();
                    richTextBoxNote.Text = Reader.GetValue(2).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
