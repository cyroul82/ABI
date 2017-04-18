using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABI
{

    public delegate void SaveNewClient(ClientDB client, Boolean toShow);
    public partial class frmNewClt : FormClient
    {
        public SaveNewClient saveNewClient;
        public frmNewClt():base()
        {
            InitializeComponent();
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            if (saveClient())
            {
                if(saveNewClient != null)
                {
                    this.saveNewClient(Client, false);
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
                if (saveNewClient != null)
                {
                    this.saveNewClient(Client, true);
                }
                DialogResult = DialogResult.OK;
            }
        }
    }
}
