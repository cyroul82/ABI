//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABI
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContactDB
    {
        public int idContact { get; set; }
        public int idClient { get; set; }
        public string nom { get; set; }
        public string fonction { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
    
        public virtual ClientDB ClientDB { get; set; }
    }
}
