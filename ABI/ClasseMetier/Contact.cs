using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI.ClasseMetier
{
    public class Contact
    {
        private Int32 idContact;
        private String nom;
        private String fonction;
        private String email;
        private String telephone;

        public Contact(int idContact, string nom, string fonction, string email, string telephone)
        {
            this.idContact = idContact;
            this.nom = nom;
            this.fonction = fonction;
            this.email = email;
            this.telephone = telephone;
        }

        public int IdContact
        {
            get
            {
                return idContact;
            }

            set
            {
                idContact = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Fonction
        {
            get
            {
                return fonction;
            }

            set
            {
                fonction = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

        public override string ToString()
        {
            return idContact + " " + nom + " " + fonction + " " + email + " " + telephone;
        }
    }
}
