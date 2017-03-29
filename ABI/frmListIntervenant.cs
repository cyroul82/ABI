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
            frmDspClient fdc = new frmDspClient();
            fdc.ShowDialog();
        }
    }
}
