using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABI
{
    public partial class frmNewClient : ABI.FormClient
    {

        
        public frmNewClient()
        {
            InitializeComponent();
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            if (saveClient())
            {
                DialogResult = DialogResult.OK;
            }
                
        }

        private void btnAnnulerClient_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (saveClient())
            {
                DialogResult = DialogResult.Yes;
            }
        }
    }
}
