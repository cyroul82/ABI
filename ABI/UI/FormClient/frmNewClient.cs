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

        public Client ClientCreated { get; private set; } = null;
        public frmNewClient()
        {
            InitializeComponent();
        }

        private void createClient()
        {
            if (isRaisonSocialValid() & isActiviteValid() & isTypeValid() & isNatureValid() & isEffectifValid()
                & isVilleValid() & isEffectifValid() & isCodePostalValid() & isCAValid())
            {
                String raisonSocial = txtRaisonSocial.Text.Trim();
                String type = cbxType.SelectedItem.ToString();
                String activity = cbxActivity.SelectedItem.ToString();
                String nature = cbxNature.SelectedItem.ToString();
                Int32 effectif = 0;
                Boolean isEffectifInt = Int32.TryParse(txtEffectif.Text.Trim(), out effectif);
                Decimal chiffreAffaires = 0;
                Boolean isChiffreAffaireDecimal = Decimal.TryParse(txtCA.Text.Trim(), out chiffreAffaires);
                String telephone = txtTelephone.Text.Trim();
                //Create the address
                String ville = txtVille.Text.Trim();
                String codePostal = mTxtCodePostal.Text.Trim();
                String rue = txtRue.Text.Trim();
                Adresse adresse = new Adresse(rue, ville, codePostal);

                String comment = txtComment.Text.Trim();
                Int32 idClient = Donnees.clientNumber++;

                ClientCreated = new Client(idClient, raisonSocial, type, activity, nature, effectif, chiffreAffaires, /*adresse,*/ comment, telephone);
                Donnees.listClient.Add(ClientCreated);
            }
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            createClient();
            DialogResult = DialogResult.OK;
        }

        private void btnAnnulerClient_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            createClient();
            DialogResult = DialogResult.Yes;
        }
    }
}
