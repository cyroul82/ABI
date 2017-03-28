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
        public FormMain()
        {
            InitializeComponent();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrdClient fgc = new FormGrdClient();
            fgc.MdiParent = this;
            fgc.Show();
            
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
