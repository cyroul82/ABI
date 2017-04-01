using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABI
{
    public delegate void UpdatedClientHandler(Client client);
    public partial class frmDspClient : ABI.FormClient
    {
        public event UpdatedClientHandler Updated;
        private const String MODIFIER = "Modifier";
        private const String ENREGISTRER = "Enregistrer";
        public Boolean IsModifed { get; private set; } = false;
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
            DialogResult result = MessageBox.Show("Voulez-vous sauvegarder les modifications ?", "Modifications", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                btnModifierClient_Click(sender, e);
                Close();
            }
            else if (result == DialogResult.No)
            {
                Close();
            }
            
            
        }

        private void frmDspClient_Load(object sender, EventArgs e)
        {
            fillUpForm();
        }

        private void fillUpForm()
        {
            txtNumero.Text = client.IdClient.ToString();
            txtRaisonSocial.Text = client.RaisonSocial;
            txtEffectif.Text = client.Effectifs.ToString();
            txtCA.Text = client.ChiffreAffaires.ToString();
            txtTelephone.Text = client.Telephone;
            mTxtCodePostal.Text = client.Adresse.CodePostal;
            txtVille.Text = client.Adresse.Ville;
            txtRue.Text = client.Adresse.Rue;
            txtComment.Text = client.Comment;
            cbxActivity.SelectedItem = client.Activite;
            cbxNature.SelectedItem = client.Nature;
            cbxType.SelectedItem = client.TypeSociete;
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            if(btnModifierClient.Text == MODIFIER)
            {
                enableClient();
            }
            else
            {
                if (updateClient(client.IdClient))
                {
                    Updated?.Invoke(client);
                    disableClient();
                }
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
            IsModifed = true;
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
            IsModifed = false;
        }

        private void btnAnnulerModif_Click(object sender, EventArgs e)
        {
            fillUpForm();
            disableClient();
        }

    }
}
