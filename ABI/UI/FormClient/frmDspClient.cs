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
        public Client Client { get; private set; }
        public frmDspClient(Client client)
        {
            InitializeComponent();
            this.Client = client;
        }

        

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNewContact fnc = new frmNewContact();
            fnc.ShowDialog();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDspClient_Load(object sender, EventArgs e)
        {
            txtNumero.Text = Client.IdClient.ToString();
            txtRaisonSocial.Text = Client.RaisonSocial;
            txtEffectif.Text = Client.Effectifs.ToString();
            txtCA.Text = Client.ChiffreAffaires.ToString();
            txtTelephone.Text = Client.Telephone;
            

        }
    }
}
