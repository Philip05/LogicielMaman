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
    public partial class RencontresClient : Form
    {
        public RencontresClient()
        {
            InitializeComponent();
            dataGridViewRencontres.Font = new Font("Arial", 16);
            Commandes.LoadElements("SELECT Id,DateRencontre, Note FROM Rencontres WHERE Client_Id = " + Commandes.idClient, dataGridViewRencontres);
            dataGridViewRencontres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void RencontresClient_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewRencontres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
            dataGridViewRencontres.Rows[e.RowIndex].Cells[0];
            Commandes.idRencontre = cell.Value.ToString();

            NoteRencontre note = new NoteRencontre();
            note.Show();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Commandes.LoadElements("SELECT DateRencontre,Note FROM Rencontres WHERE DateRencontre LIKE '%" + textBoxRechercher.Text.ToString() + "%' AND Client_Id = " + Commandes.idClient,dataGridViewRencontres);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
