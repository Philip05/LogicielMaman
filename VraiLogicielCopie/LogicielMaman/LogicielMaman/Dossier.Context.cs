﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DossierContainer : DbContext
    {
        public DossierContainer()
            : base("name=DossierContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<TelephoneClient> TelephoneClients { get; set; }
        public virtual DbSet<TypeTelephone> TypeTelephones { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }
        public virtual DbSet<Fournisseur> Fournisseurs { get; set; }
        public virtual DbSet<TelephoneFournisseur> TelephoneFournisseurs { get; set; }
        public virtual DbSet<Sexe> Sexes { get; set; }
        public virtual DbSet<Achat> Achats { get; set; }
        public virtual DbSet<Rencontre> Rencontres { get; set; }
        public virtual DbSet<Administrateur> Administrateurs { get; set; }
        public virtual DbSet<Image> Images { get; set; }
    }
}