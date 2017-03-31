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
    public partial class frmListIntervenant : Form
    {
        public frmListIntervenant()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //frmDspClient fdc = new frmDspClient();
            //fdc.ShowDialog();
        }

        private void bntAddIntervenant_Click(object sender, EventArgs e)
        {
            frmNewContact fnc = new frmNewContact();
            fnc.ShowDialog();

        }

        private void btnNewIntervention_Click(object sender, EventArgs e)
        {
            frmIntervention fi = new frmIntervention();
            FormMain fm = this.MdiParent as FormMain;
            if (fm != null)
            {
                fi.MdiParent = fm;
                fi.Show();
            }
            

        }
    }
}
