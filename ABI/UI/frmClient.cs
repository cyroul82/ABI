using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI.UI
{
    public partial class frmClient : Form    
    {
        private Client client;
        public frmClient()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNewClient fnc = new frmNewClient();
            fnc.ShowDialog();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                frmDspClient fdc = new frmDspClient();
                fdc.Dock = DockStyle.Fill;
                fdc.TopLevel = false;
                TabPage tp = new TabPage(client.RaisonSocial);
                tp.Controls.Add(fdc);
                tabControlClientDetail.Controls.Add(tp);
                fdc.Show();
            }
            else
            {
                MessageBox.Show("Selectionner un client", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void grdClient_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = grdClient.SelectedRows[0];
            Client c = row.DataBoundItem as Client;
            if(c != null)
            {
                c = client;
            }
        }
    }
}
