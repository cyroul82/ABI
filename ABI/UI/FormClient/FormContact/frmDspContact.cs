using ABI.ClasseMetier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABI.UI.FormClient.FormContact
{
    public partial class frmDspContact : ABI.FormContact
    {
        private ContactDB contact;
        public ContactHandler updatingContact;
        public frmDspContact(ref ContactDB contact)
        {
            InitializeComponent();
            this.contact = contact;
        }

        private void frmDspContact_Load(object sender, EventArgs e)
        {
            setContact();
        }

        private void setContact()
        {
            txtContactEmail.Text = contact.email;
            txtContactIdClient.Text = contact.idContact.ToString();
            txtContactName.Text = contact.nom;
            txtContactTelephone.Text = contact.telephone;
            txtContactFonction.Text = contact.fonction;
        }

        private void getContact()
        {
            contact.email = txtContactEmail.Text;
            contact.nom = txtContactName.Text;
            contact.telephone = txtContactTelephone.Text;
            contact.fonction = txtContactFonction.Text;
        }

        private void btnEnregistrerContact_Click(object sender, EventArgs e)
        {
            getContact();
            if (contact != null)
            {
                if (isNameValid())
                {
                    updatingContact?.Invoke(contact);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Le contact doit avoir un nom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
