﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HCI_PRODAVNICA_NAKITAnew
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mydbEntities8 : DbContext
    {
        public mydbEntities8()
            : base("name=mydbEntities8")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<kupac> kupac { get; set; }
        public virtual DbSet<kupovina_stavka> kupovina_stavka { get; set; }
        public virtual DbSet<nakit> nakit { get; set; }
        public virtual DbSet<zaposleni> zaposleni { get; set; }
    }
}
