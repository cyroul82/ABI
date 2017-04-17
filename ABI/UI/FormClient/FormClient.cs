using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI
{
    public partial class FormClient : Form
    {
        private ClientDB client;
        private const String REQUIS = "Requis";

        public ClientDB Client
        {
            get
            {
                return client;
            }

            protected set
            {
                client = value;
            }
        }

        public FormClient()
        {
            InitializeComponent();
        }

        public FormClient(ClientDB client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void mTxtCodePostal_MaskInputRejetected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mTxtCodePostal.MaskFull)
            {
                toolTipCodePostal.ToolTipTitle = "Erreur";
                toolTipCodePostal.Show("Entrez seulement 5 chiffres", mTxtCodePostal, 1000);
            }
            else
            {
                toolTipCodePostal.ToolTipTitle = "Erreur";
                toolTipCodePostal.Show("Seulement des Chiffres !", mTxtCodePostal, 0);
                errorProviderCodePostal.SetError(mTxtCodePostal, "chiffres");
            }
        }

        private void mTxtCodePostal_KeyDown(object sender, KeyEventArgs e)
        {
            toolTipCodePostal.Hide(mTxtCodePostal);
            errorProviderCodePostal.SetError(mTxtCodePostal, String.Empty);
        }

        protected Boolean isCodePostalValid()
        {
            if (mTxtCodePostal.Text.Trim().Length == 0 || errorProviderCodePostal.GetError(mTxtCodePostal) != String.Empty)
            {
                errorProviderCodePostal.SetError(mTxtCodePostal, "chiffres");
                return false;
            }
            else
            {
                errorProviderCodePostal.SetError(mTxtCodePostal, String.Empty);
                return true;
            }
        }

        protected Boolean isVilleValid()
        {
            if(txtVille.Text.Trim().Length > 0)
            {
                errorProviderVille.SetError(txtVille, String.Empty);
                return true;
            }
            else
            {
                errorProviderVille.SetError(txtVille, REQUIS);
                return false;
            }
        }

        private void txtVille_Validated(object sender, EventArgs e)
        {
            isVilleValid();
        }

        protected Boolean isRaisonSocialValid()
        {
            if (txtRaisonSocial.Text.Trim().Length > 0)
            {
                errorProviderRaisonSocial.SetError(txtRaisonSocial, String.Empty);
                return true;
            }
            else
            {
                errorProviderRaisonSocial.SetError(txtRaisonSocial, REQUIS);
                return false;
            }
        }

        private void txtRaisonSocial_Validated(object sender, EventArgs e)
        {
            isRaisonSocialValid();
        }

        protected Boolean isActiviteValid()
        {
            if(cbxActivite.SelectedIndex == -1)
            {
                errorProviderActivite.SetError(cbxActivite, REQUIS);
                return false;
            }
            else
            {
                errorProviderActivite.SetError(cbxActivite, String.Empty);
                return true;
            }
        }
        private void cbxActivity_Validated(object sender, EventArgs e)
        {
            isActiviteValid();
        }

        protected Boolean isTypeValid()
        {
            if(cbxType.SelectedIndex == -1)
            {
                errorProviderType.SetError(cbxType, REQUIS);
                return false;
            }
            else
            {
                errorProviderType.SetError(cbxType, String.Empty);
                return true;
            }
        }
        private void cbxType_Validated(object sender, EventArgs e)
        {
            isTypeValid();
        }
        
        protected Boolean isNatureValid()
        {
            if (cbxNature.SelectedIndex == -1)
            {
                errorProviderNature.SetError(cbxNature, REQUIS);
                return false;
            }
            else
            {
                errorProviderNature.SetError(cbxNature, String.Empty);
                return true;
            }
        }


        private void cbxNature_Validated(object sender, EventArgs e)
        {
            isNatureValid();
        }

        protected Boolean isEffectifValid()
        {
            String s = txtEffectif.Text.Trim();
            Int32 effectif;
            if (s.Length == 0 || !Int32.TryParse(s, out effectif) | effectif == 0)
            {
                errorProviderEffectif.SetError(txtEffectif, REQUIS);
                return false;
            }
            else
            {
                errorProviderEffectif.SetError(txtEffectif, String.Empty);
                return true;
            }
        }
        private void txtEffectif_Validated(object sender, EventArgs e)
        {
            isEffectifValid();
        }

        protected Boolean isCAValid()
        {
            String s = txtCA.Text.Trim();
            Decimal ca;
            if(s.Length == 0 || !Decimal.TryParse(s,out ca) | ca == 0)
            {
                errorProviderCA.SetError(txtCA, REQUIS);
                return false;
            }
            else
            {
                errorProviderCA.SetError(txtCA, String.Empty);
                return true;
            }
        }
        private void txtCA_Validated(object sender, EventArgs e)
        {
            isCAValid();
        }

        protected Boolean saveClient()
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
                Int32 idClient = ++Data.clientNumber;

                client = new ClientDB();
                client.raisonSocial = raisonSocial;
                client.type = type;
                client.activite = activity;
                client.nature = nature;
                client.ca = chiffreAffaires;
                client.rue = rue;
                client.codePostal = codePostal;
                client.ville = ville;
                client.effectifs = effectif;
                client.comment = comment;
                client.telephone = telephone;

                return true;
            }
            else       
            {
                return false;
            }
        }

        protected Boolean updateClient(Int32 idClient)
        {
            if (isRaisonSocialValid() & isActiviteValid() & isTypeValid() & isNatureValid() & isEffectifValid()
                   & isVilleValid() & isEffectifValid() & isCodePostalValid() & isCAValid())
            {

                for (Int32 i = 0; i < Data.db.ClientDB.ToList().Count; i++)
                {
                    ClientDB c = Data.db.ClientDB.ToList()[i];
                    if (c.idClient == idClient)
                    {
                        c.comment = txtComment.Text.Trim();
                        c.raisonSocial = txtRaisonSocial.Text.Trim();
                        c.type = cbxType.SelectedItem.ToString();
                        c.activite = cbxActivite.SelectedItem.ToString();
                        c.nature = cbxNature.SelectedItem.ToString();
                        Int16 effectif = 0;
                        Boolean isEffectifInt = Int16.TryParse(txtEffectif.Text.Trim(), out effectif);
                        c.effectifs = effectif;
                        Decimal chiffreAffaires = 0;
                        Boolean isChiffreAffaireDecimal = Decimal.TryParse(txtCA.Text.Trim(), out chiffreAffaires);
                        c.ca = chiffreAffaires;
                        c.telephone = txtTelephone.Text.Trim();
                        c.ville = txtVille.Text.Trim();
                        c.codePostal = mTxtCodePostal.Text.Trim();
                        c.rue = txtRue.Text.Trim();
                    }
                }
                return true;
            }
            else return false;
        }
    }
}
