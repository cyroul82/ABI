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
    public partial class FormGrdClient : Form
    {
        public FormGrdClient()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            frmNewClient fnc = new frmNewClient();
            fnc.ShowDialog();
        }

    }
}
