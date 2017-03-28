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
        //Variable to avoid open twice the from AddClient
        Boolean isAddClientFormOpened = false;
        //Object FormClient
        FormClient fc;
        public FormMain()
        {
            InitializeComponent();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAddClientFormOpened)
            {
                fc.Activate();
            }else
            {
                fc = new FormClient();
                fc.MdiParent = this;
                fc.Show();
            }
            
            
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
