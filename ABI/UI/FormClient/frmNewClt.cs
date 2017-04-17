using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABI
{

    public delegate void SaveNewClient(ClientDB client);
    public partial class frmNewClient : FormClient
    {
        public SaveNewClient saveNewClient;
        public SaveNewClient saveAndOpenClient;
        public frmNewClient()
        {
            InitializeComponent();
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            if (saveClient())
            {
                if(saveNewClient != null)
                {
                    this.saveNewClient(Client);
                }
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
                if (saveAndOpenClient != null)
                {
                    this.saveAndOpenClient(Client);
                }
                DialogResult = DialogResult.OK;
            }
        }
    }
}
