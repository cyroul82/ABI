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
    public partial class frmMdiParent : Form
    {
        ABI.UI.frmListClt commercial;
        public frmMdiParent()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (commercial == null)
            {
                commercial = new ABI.UI.frmListClt();
                commercial.FormClosing += new FormClosingEventHandler(this.commercial_Closing);
                commercial.MdiParent = this;
                commercial.Dock = DockStyle.Fill;
                commercial.Show();
            }
            else commercial.Activate();
        }

        private void commercial_Closing(object sender, FormClosingEventArgs e)
        {
            commercial = null;
        }
    }
}
