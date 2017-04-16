using ABI.ClasseMetier;
using ABI.UI.FormClient.FormContact;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABI
{
    public delegate void ClientHandler(ClientDB client);

    public partial class frmDspClient : ABI.FormClient
    {
        private ContactDB contact;
        public ClientHandler UpdatingClient;
        public ClientHandler DeletingClient;

        public Boolean IsModifed { get; private set; } = false;
        public frmDspClient(ClientDB client): base(client)
        {
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
                if (updateClient(client.idClient))
                {
                    UpdatingClient?.Invoke(client);
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
        
        //Contact
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
            grdContact.Rows[grdContact.Rows.Count - 1].Selected = true;
           
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
        }

        private void txtSearchContact_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearchContact.Text != String.Empty)
            {
                var query = from item in client.ContactDB
                            group item by new { item} into g select g.toList();
                //((DataView)grdContact.DataSource).RowFilter = "Nom like '%" + txtSearchContact.Text + "%'";
                contactDBBindingSource.DataSource = client.ContactDB.GetList();
            }
        }
    }
}
