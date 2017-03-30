using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
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

        private void txtRaisonSocial_Validated(object sender, EventArgs e)
        {
            if (isRaisonSocialValid())
            {
                errorProviderRaisonSocial.SetError(txtRaisonSocial, String.Empty);
            }
            else
            {
                errorProviderRaisonSocial.SetError(txtRaisonSocial, "Raison Social est requis.");
            }
        }

        private bool isRaisonSocialValid()
        {
            return (txtRaisonSocial.Text.Length > 0);
        }
    }
}
