using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace print
{
    public partial class Form1 : Form
    {
        int t = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void PrintHelpPage()
        {
            // Create a WebBrowser instance. 
            WebBrowser webBrowserForPrinting = new WebBrowser();

            // Add an event handler that prints the document after it loads.
            webBrowserForPrinting.DocumentCompleted +=
                new WebBrowserDocumentCompletedEventHandler(PrintDocument);

            // Set the Url property to load the document.
            webBrowserForPrinting.Url = new Uri(@"file:///D:/fichiers/pdf/agneau,%20cotelette%20(cru).pdf");
        }

        private void PrintDocument(object sender,
            WebBrowserDocumentCompletedEventArgs e)
        {
            // Print the document now that it is fully loaded.
            ((WebBrowser)sender).Print();

            // Dispose the WebBrowser now that the task is complete. 
            ((WebBrowser)sender).Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintHelpPage();
        }
    }
}
