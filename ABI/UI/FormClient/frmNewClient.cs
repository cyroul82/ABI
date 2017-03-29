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
            
            String raisonSocial = txtRaisonSocial.Text;
            String type = cbxType.SelectedItem.ToString();
            String activity = cbxActivity.SelectedItem.ToString();
            String nature = cbxNature.SelectedItem.ToString();
            Int32 effectif = 0;
            Boolean isEffectifAnInt = Int32.TryParse(txtEffectif.Text, out effectif);
            
            //Create the address
            String ville = txtVille.Text;
            String codePostal = txtCodePostal.Text;
            String rue = txtRue.Text;
            Adresse adresse = new Adresse(rue, ville, codePostal);
            
        


            //Client client = new ABI.Client(txtRaisonSocial.Text, cbxType.SelectedItem.ToString(), cbxActivity.SelectedItem.ToString(),
            //                              cbxNature.SelectedItem.ToString(), txtEffectif.Text)
        }
    }
}
