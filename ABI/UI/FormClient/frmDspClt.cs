using ABI.ClasseMetier;
using ABI.UI.FormClient.FormContact;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataGridView;

namespace ABI
{
    public delegate void ClientHandler(ClientDB client);

    public partial class frmDspClient : ABI.FormClient
    {
        private ContactDB contact;
        private ClientDB client;
        public ClientHandler UpdatingClient;
        public ClientHandler DeletingClient;
        public ClientHandler ClosingTab;
        private Boolean isHitGridNoWhere;
        public Boolean IsModifed { get; private set; } = false;

        public ClientDB Client
        {
            get
            {
                return client;
            }
        }

        public frmDspClient(ClientDB client)
        {
            this.client = client;
            InitializeComponent();
        }

        public void btnFermerClient_Click(object sender, EventArgs e)
        {
            if (IsModifed)
            {
                DialogResult result = MessageBox.Show("Voulez-vous sauvegarder les modifications ?", "Modifications", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    btnModifierClient_Click(sender, e);
                    Close();
                }
                else if (result == DialogResult.No)
                {
                    Close();
                }
            } 
            else
            {
                ClosingTab?.Invoke(client);
                Close();
            }
        }

        private void frmDspClient_Load(object sender, EventArgs e)
        {
            fillUpForm();

            contactDBBindingSource.DataSource = client.ContactDB.GetList();
        }

        private void fillUpForm()
        {
            txtIdClient.Text = client.idClient.ToString();
            txtRaisonSocial.Text = client.raisonSocial;
            txtEffectif.Text = client.effectifs.ToString();
            txtCA.Text = client.ca.ToString();
            txtTelephone.Text = client.telephone;
            mTxtCodePostal.Text = client.codePostal;
            txtVille.Text = client.ville;
            txtRue.Text = client.rue;
            txtComment.Text = client.comment;
            cbxActivite.SelectedItem = client.activite;
            cbxNature.SelectedItem = client.nature;
            cbxType.SelectedItem = client.type;
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            if(btnModifierClient.Text == Tools.MODIFIER)
            {
                enableClient();
            }
            else
            {
                if (updateClient())
                {
                    UpdatingClient?.Invoke(client);
                    disableClient();
                }
            }
        }

        private Boolean updateClient()
        {
            if (isRaisonSocialValid() & isActiviteValid() & isTypeValid() & isNatureValid() & isEffectifValid()
                   & isVilleValid() & isEffectifValid() & isCodePostalValid() & isCAValid())
            {
                client.comment = txtComment.Text.Trim();
                client.raisonSocial = txtRaisonSocial.Text.Trim();
                client.type = cbxType.SelectedItem.ToString();
                client.activite = cbxActivite.SelectedItem.ToString();
                client.nature = cbxNature.SelectedItem.ToString();
                Int32 effectif = 0;
                Boolean isEffectifInt = Int32.TryParse(txtEffectif.Text.Trim(), out effectif);
                client.effectifs = effectif;
                Decimal chiffreAffaires = 0;
                Boolean isChiffreAffaireDecimal = Decimal.TryParse(txtCA.Text.Trim(), out chiffreAffaires);
                client.ca = chiffreAffaires;
                client.telephone = txtTelephone.Text.Trim();
                client.ville = txtVille.Text.Trim();
                client.codePostal = mTxtCodePostal.Text.Trim();
                client.rue = txtRue.Text.Trim();

                return true;
            }
            else return false;
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
            cbxActivite.Enabled = true;
            cbxNature.Enabled = true;
            cbxType.Enabled = true;
            btnModifierClient.Text = Tools.ENREGISTRER;
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
            cbxActivite.Enabled = false;
            cbxNature.Enabled = false;
            cbxType.Enabled = false;
            btnModifierClient.Text = Tools.MODIFIER;
            btnAnnulerModifClient.Visible = false;
            IsModifed = false;
        }

        private void btnAnnulerModificationClient_Click(object sender, EventArgs e)
        {
            fillUpForm();
            disableClient();
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous supprimer ce client ?", "Suppression de Client", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeletingClient?.Invoke(client);
                Close();
            }
            else if (result == DialogResult.No)
            {
                Close();
            }
        }
        
        private void grdContact_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in grdContact.SelectedRows)
            {
                if(row != null && row.Cells[0].Value != null)
                {
                    Int32 id;
                    Boolean b = Int32.TryParse(row.Cells[0].Value.ToString(), out id);
                    if (b)
                    {
                        contact = Data.db.ContactDB.Find(id);
                    }
                }
            }
        }

        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            frmNewContact fnc = new frmNewContact(client);
            fnc.saveNewContact += new ContactHandler(this.savingContact);
            fnc.ShowDialog();
        }
        private void savingContact(ContactDB contact)
        {
            this.contact = contact;
            Data.db.ContactDB.Add(contact);
            Data.db.SaveChanges();
        }

        private void btnSupprimerContact_Click(object sender, EventArgs e)
        {
            if (contact != null)
            {
                if (MessageBox.Show("Voulez-vous supprimer le contact " + contact.nom, "Supprimer un contact", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //Delete from the DB
                    Data.db.ContactDB.Remove(contact);
                    Data.db.SaveChanges();
                    //check if the grdContact isn't empty
                    if (grdContact.Rows.Count > 0)
                    {
                        //set the selected row to the first one
                        grdContact.Rows[0].Selected = true;
                    }
                    else
                    {
                        //if no more row in the gridView then set the client to null after deleting the last client
                        contact = null;
                    }
                }
            }
        }

        private void btnModifierContact_Click(object sender, EventArgs e)
        {
            if(contact != null) { 
                frmDspContact dspContact = new frmDspContact(ref contact);
                dspContact.updatingContact += new ContactHandler(this.UpdatingContact);
                dspContact.ShowDialog();
            }
        }

        private void UpdatingContact(ContactDB contact)
        {
            Data.db.SaveChanges();
            contactDBBindingSource.ResetBindings(false);
        }

        private void txtSearchContact_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearchContact.Text != String.Empty)
            {
                contactDBBindingSource.DataSource = client.ContactDB.GetList();
            }
        }

        private void grdContact_DoubleClick(object sender, EventArgs e)
        {
            if (contact != null && !isHitGridNoWhere)
            {
                btnModifierContact_Click(sender, e);
            }
        }

        private void grdContact_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (grdContact.HitTest(e.X, e.Y) == HitTestInfo.Nowhere)
                {
                    isHitGridNoWhere = true;
                }
                else isHitGridNoWhere = false;
            }
        }
    }
}
