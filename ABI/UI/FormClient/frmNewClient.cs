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

        private void btnAddClient_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelClient_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {

            String raisonSocial = txtRaisonSocial.Text.Trim();
            String type = cbxType.SelectedItem.ToString();
            String activity = cbxActivity.SelectedItem.ToString();
            String nature = cbxNature.SelectedItem.ToString();
            Int32 effectif = 0;
            Boolean isEffectifInt = Int32.TryParse(txtEffectif.Text.Trim(), out effectif);
            Decimal chiffreAffaires = 0;
            Boolean isChiffreAffaireDecimal = Decimal.TryParse(txtCA.Text.Trim(), out chiffreAffaires);

            //Create the address
            String ville = txtVille.Text.Trim();
            String codePostal = mTxtCodePostal.Text.Trim();
            String rue = txtRue.Text.Trim();
            Adresse adresse = new Adresse(rue, ville, codePostal);

            String comment = txtComment.Text.Trim();

            if(raisonSocial != "")
            {
                if(type != "")
                {
                    if (activity != "")
                    {
                        if(nature != "")
                        {
                            if (isEffectifInt)
                            {
                                if(isChiffreAffaireDecimal)
                                {
                                    Int32 idClient = Donnees.clientNumber++;
                                    Client client = new Client(idClient, raisonSocial, type, activity,
                                                                  nature, effectif, chiffreAffaires, adresse, comment);
                                    Donnees.listClient.Add(client);
                                }
                                
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vérifier les données", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            
        }
    }
}
