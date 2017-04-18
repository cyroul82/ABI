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

        private Boolean saveClient()
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

                Client.raisonSocial = raisonSocial;
                Client.type = type;
                Client.activite = activity;
                Client.nature = nature;
                Client.effectifs = effectif;
                Client.ca = chiffreAffaires;
                Client.comment = comment;
                Client.telephone = telephone;
                Client.rue = rue;
                Client.codePostal = codePostal;
                Client.ville = ville;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
