using ABI.ClasseMetier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ABI
{
    public delegate void SaveNewContact(Contact contact);
    public partial class frmNewContact : ABI.FormContact
    {
        private Contact contact;
        private Client client;
        public event SaveNewContact saveNewContact;
        public frmNewContact(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            addContact();            
            if(saveNewContact != null && contact != null)
            {   
                saveNewContact(contact);
                this.DialogResult = DialogResult.OK;
            }
                    }

        public void addContact()
        {
            Int32 id = client.ListContacts.Count + 1;
            String nom = txtContactName.Text;
            String fonction = txtContactType.Text;
            String email = txtContactEmail.Text;
            String telephone = txtContactTelephone.Text;

            contact = new Contact(id, nom, fonction, email, telephone);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
