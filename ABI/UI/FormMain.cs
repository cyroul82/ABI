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
        frmListClient gestionCommercial;
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


        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gestionCommercial == null)
            {
                gestionCommercial = new frmListClient();
                gestionCommercial.MdiParent = this;
                gestionCommercial.Dock = DockStyle.Left;
                gestionCommercial.Show();
            }
            else gestionCommercial.Activate();
        }
    }
}
