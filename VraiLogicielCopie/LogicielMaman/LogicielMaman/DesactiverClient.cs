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
    public partial class DesactiverClient : Form
    {
        public DesactiverClient()
        {
            InitializeComponent();
        }

        private void button2Non_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOui_Click(object sender, EventArgs e)
        {
            Commandes.UpdateDatabaseInformations("UPDATE Clients SET Active = '" + false + "' WHERE Id = '" + Commandes.idClient + "'");
            this.Close();
        }
    }
}
