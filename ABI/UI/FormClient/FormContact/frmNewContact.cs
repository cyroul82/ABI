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
    
    public partial class frmNewContact : ABI.FormContact
    {
        private ContactDB contact;
        private ClientDB client;
        public event ContactHandler saveNewContact;
        public frmNewContact(ClientDB client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            addContact();
            if (contact != null)
            {
                if (isNameValid())
                {
                    saveNewContact?.Invoke(contact);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    lblError.Visible = true;
                    //MessageBox.Show("Le contact doit avoir un nom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void addContact()
        {
            String nom = txtContactName.Text.Trim();
            String fonction = txtContactFonction.Text;
            String email = txtContactEmail.Text;
            String telephone = txtContactTelephone.Text;
            //client.CompteurContacts++;

            //contact = new Contact(client.idClient, nom, fonction, email, telephone);
            contact = new ContactDB();
            contact.nom = nom;
            contact.fonction = fonction;
            contact.email = email;
            contact.telephone = telephone;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
