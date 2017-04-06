using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI
{
    public class Adresse
    {
        public Int32 IdClient { get; set; }
        public String Ville { get; set; }
        public String Rue { get; set; }
        public String CodePostal { get; set; }

        public Adresse(Int32 idClient, String rue, String codePostal, String ville)
        {
            IdClient = idClient;
            Ville = ville;
            Rue = rue;
            CodePostal = codePostal;
        }

        public override string ToString()
        {
            return Rue + " " + CodePostal + " " + Ville;
        }

    }
}
