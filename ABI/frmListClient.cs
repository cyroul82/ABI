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
    public partial class frmListClient : Form
    {
        public frmListClient()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            frmNewClient fc = new ABI.frmNewClient();
            fc.ShowDialog();
        }

        private void tvClient_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            frmListIntervenant fli = new frmListIntervenant();
            FormMain fm = this.MdiParent as FormMain;
            if(fm != null)
            {
                fli.MdiParent = fm;
                fli.Show();
            }
            
        }
    }
}
