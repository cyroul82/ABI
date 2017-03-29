using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI
{
    public partial class FormMain : Form
    {
        GestionCommercial gestionCommercial;
        public FormMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void enregistreEvenementsGestionClient()
        {
            if(gestionCommercial != null)
            {
            }
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormGrdClient fgc = new FormGrdClient();
            //fgc.MdiParent = this;
            //fgc.Show();
            gestionCommercial = new GestionCommercial();
            gestionCommercial.MdiParent = this;
            gestionCommercial.Dock = DockStyle.Left;
            gestionCommercial.Show();


        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
