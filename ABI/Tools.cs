using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI
{
    public static class Tools
    {
        public const String MODIFIER = "Modifier";
        public const String ENREGISTRER = "Enregistrer";
        public const String IDCLIENT = "idClient";
        public const String IDCONTACT = "idContact";
        public const String NOM = "Nom";
        public const String FONCTION = "Fonction";
        public const String EMAIL = "Email";
        public const String TELEPHONE = "Téléphone";

        public const String RAISONSOCIALE = "RaisonSociale";
        public const String TYPE = "Type";
        public const String ACTIVITE = "Activite";
        public const String NATURE = "Nature";
        public const String EFFECTIF = "Effectif";
        public const String CHIFFREAFFAIRES = "ChiffreAffaires";
        public const String VILLE = "Ville";
        public const String COMMENTAIRE = "Commentaires";

        public const String PUBLIC = "Public";
        public const String PRIVE = "Privé";

        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }
}
