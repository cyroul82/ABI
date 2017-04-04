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
        private Contact contact;
        public frmDspContact(ref Contact contact)
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
            txtContactEmail.Text = contact.Email;
            txtContactIdClient.Text = contact.IdContact.ToString();
            txtContactName.Text = contact.Nom;
            txtContactTelephone.Text = contact.Telephone;
            txtContactFonction.Text = contact.Fonction;
        }

        private void getContact()
        {
            contact.Email = txtContactEmail.Text;
            contact.Nom = txtContactName.Text;
            contact.Telephone = txtContactTelephone.Text;
            contact.Fonction = txtContactFonction.Text;
        }

        private void btnEnregistrerContact_Click(object sender, EventArgs e)
        {
            getContact();
            DialogResult = DialogResult.OK;

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
