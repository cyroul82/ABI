using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI
{
    public class Client
    {
        //private Adresse adresse;
        private Int32 idClient;
        private String raisonSocial;
        private String typeSociete;
        private String activite;
        private String nature;
        private Int32 effectifs;
        private Decimal chiffreAffaires;
        private String comment;
        private String telephone;
        private List<Intervenant> listIntervenant;

        //public Adresse Adresse
        //{
        //    get
        //    {
        //        return adresse;
        //    }

        //    set
        //    {
        //        adresse = value;
        //    }
        //}

        public Int32 IdClient
        {
            get
            {
                return idClient;
            }

            set
            {
                idClient = value;
            }
        }

        public String RaisonSocial
        {
            get
            {
                return raisonSocial;
            }

            set
            {
                raisonSocial = value;
            }
        }

        public String TypeSociete
        {
            get
            {
                return typeSociete;
            }

            set
            {
                typeSociete = value;
            }
        }

        public String Activite
        {
            get
            {
                return activite;
            }

            set
            {
                activite = value;
            }
        }

        public String Nature
        {
            get
            {
                return nature;
            }

            set
            {
                nature = value;
            }
        }

        public Int32 Effectifs
        {
            get
            {
                return effectifs;
            }

            set
            {
                effectifs = value;
            }
        }

        public Decimal ChiffreAffaires
        {
            get
            {
                return chiffreAffaires;
            }

            set
            {
                chiffreAffaires = value;
            }
        }

        public String Comment
        {
            get
            {
                return comment;
            }

            set
            {
                comment = value;
            }
        }

        internal List<Intervenant> ListIntervenant
        {
            get
            {
                return listIntervenant;
            }

            set
            {
                listIntervenant = value;
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

        //public Client(Int32 idClient, String raisonSocial, String typeSociete, 
        //                String activite, String nature, Int32 effectifs, 
        //                Decimal chiffreAffaires, Adresse adresse, String comment, String telephone)
        //{           
        //    this.IdClient = idClient;
        //    this.RaisonSocial = raisonSocial;
        //    this.TypeSociete = typeSociete;
        //    this.Activite = activite;
        //    this.Nature = nature;
        //    this.Effectifs = effectifs;
        //    this.chiffreAffaires = chiffreAffaires;
        //    this.Adresse = adresse;
        //    this.Comment = comment;
        //    this.telephone = telephone;
        //    ListIntervenant = new List<Intervenant>();
        //}
        public Client(Int32 idClient, String raisonSocial, String typeSociete,
                        String activite, String nature, Int32 effectifs,
                        Decimal chiffreAffaires, String comment, String telephone)
        {
            this.IdClient = idClient;
            this.RaisonSocial = raisonSocial;
            this.TypeSociete = typeSociete;
            this.Activite = activite;
            this.Nature = nature;
            this.Effectifs = effectifs;
            this.chiffreAffaires = chiffreAffaires;
            //this.Adresse = new Adresse("une rue", "83700", "ST Raph") ;
            this.Comment = comment;
            this.telephone = telephone;
            ListIntervenant = new List<Intervenant>();
        }
    }
}
