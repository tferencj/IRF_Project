﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Beadando
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IRF_databaseEntities2 : DbContext
    {
        public IRF_databaseEntities2()
            : base("name=IRF_databaseEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kolcsonze> Kolcsonzes { get; set; }
        public virtual DbSet<Konyv> Konyvs { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
    }
}
