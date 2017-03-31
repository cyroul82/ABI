using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABI
{
    public partial class frmDspClient : ABI.FormClient
    {
        private Client client;
        public frmDspClient(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNewContact fnc = new frmNewContact();
            fnc.ShowDialog();
        }
    }
}
