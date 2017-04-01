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

        public const String MODIFIER = "Modifier";
        public const String ENREGISTRER = "Enregistrer";
        public frmDspClient(Client client)
        {
            InitializeComponent();
            base.client = client;
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
            txtNumero.Text = base.client.IdClient.ToString();
            txtRaisonSocial.Text = base.client.RaisonSocial;
            txtEffectif.Text = base.client.Effectifs.ToString();
            txtCA.Text = base.client.ChiffreAffaires.ToString();
            txtTelephone.Text = base.client.Telephone;
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            if(btnModifierClient.Text == MODIFIER)
            {
                enableClient();
            }
            else
            {
                disableClient();
                
            }
        }

        private void enableClient()
        {
            mTxtCodePostal.Enabled = true;
            txtCA.Enabled = true;
            txtComment.Enabled = true;
            txtComment.Enabled = true;
            txtEffectif.Enabled = true;
            txtRaisonSocial.Enabled = true;
            txtRue.Enabled = true;
            txtTelephone.Enabled = true;
            txtVille.Enabled = true;
            cbxActivity.Enabled = true;
            cbxNature.Enabled = true;
            cbxType.Enabled = true;
            btnModifierClient.Text = ENREGISTRER;
            btnAnnulerModifClient.Visible = true;
        }

        private void disableClient()
        {
            mTxtCodePostal.Enabled = false;
            txtCA.Enabled = false;
            txtComment.Enabled = false;
            txtComment.Enabled = false;
            txtEffectif.Enabled = false;
            txtRaisonSocial.Enabled = false;
            txtRue.Enabled = false;
            txtTelephone.Enabled = false;
            txtVille.Enabled = false;
            cbxActivity.Enabled = false;
            cbxNature.Enabled = false;
            cbxType.Enabled = false;
            btnModifierClient.Text = MODIFIER;
            btnAnnulerModifClient.Visible = false;
        }

        private void btnAnnulerModif_Click(object sender, EventArgs e)
        {
            disableClient();
        }

    }
}
