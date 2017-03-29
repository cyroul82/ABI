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
    public partial class frmIntervention : Form
    {
        public frmIntervention()
        {
            InitializeComponent();
        }

        private void frmIntervention_Load(object sender, EventArgs e)
        {

        }

        private void btnNewDoc_Click(object sender, EventArgs e)
        {
            folderBrowserDialogDocument.ShowDialog();
        }
    }
}
