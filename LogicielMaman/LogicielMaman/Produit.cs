//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogicielMaman
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produit()
        {
            this.Achat = new HashSet<Achat>();
        }
    
        public int Id { get; set; }
        public string Nom { get; set; }
        public double PrixCoutant { get; set; }
        public double PrixVendant { get; set; }
        public int QuantiteEnStock { get; set; }
        public string Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Achat> Achat { get; set; }
        public virtual Fournisseur Fournisseur { get; set; }
    }
}
