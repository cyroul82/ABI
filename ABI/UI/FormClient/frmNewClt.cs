using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABI
{

    public delegate void NewClientHandler(ClientDB client, Boolean toShow);
    public partial class frmNewClt : FormClient
    {
        private ClientDB client;
        public NewClientHandler newClient;
        public frmNewClt()
        {
            client = new ABI.ClientDB();
            InitializeComponent();
        }
        /// <summary>
        /// Click on Ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            if (isClientValid())
            {
                newClient?.Invoke(client, false);

                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Click on Annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelClient_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSavePreview_Click(object sender, EventArgs e)
        {
            if (isClientValid())
            {
                if (newClient != null)
                {
                    this.newClient(client, true);
                }
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Check all the required parameters
        /// </summary>
        /// <returns></returns>
        private Boolean isClientValid()
        {
            if (isRaisonSocialValid() & isActiviteValid() & isTypeValid() & isNatureValid() & isEffectifValid()
                   & isVilleValid() & isEffectifValid() & isCodePostalValid() & isCAValid())
            {
                String raisonSocial = txtRaisonSocial.Text.Trim();
                String type = cbxType.SelectedItem.ToString();
                String activity = cbxActivite.SelectedItem.ToString();
                String nature = cbxNature.SelectedItem.ToString();
                Int32 effectif = 0;
                Boolean isEffectifInt = Int32.TryParse(txtEffectif.Text.Trim(), out effectif);
                Decimal chiffreAffaires = 0;
                Boolean isChiffreAffaireDecimal = Decimal.TryParse(txtCA.Text.Trim(), out chiffreAffaires);
                String telephone = txtTelephone.Text.Trim();
                String ville = txtVille.Text.Trim();
                String codePostal = mTxtCodePostal.Text.Trim();
                String rue = txtRue.Text.Trim();
                String comment = txtComment.Text.Trim();

                client.raisonSocial = raisonSocial;
                client.type = type;
                client.activite = activity;
                client.nature = nature;
                client.effectifs = effectif;
                client.ca = chiffreAffaires;
                client.comment = comment;
                client.telephone = telephone;
                client.rue = rue;
                client.codePostal = codePostal;
                client.ville = ville;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
