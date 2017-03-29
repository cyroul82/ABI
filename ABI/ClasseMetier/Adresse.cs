using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI
{
    public class Adresse
    {
        public String Ville { get; set; }
        public String Rue { get; set; }
        public String CodePostal { get; set; }

        public Adresse(String rue, String codePostal, String ville)
        {
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
