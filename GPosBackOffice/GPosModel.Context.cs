﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GPosBackOffice
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GPosEntities : DbContext
    {
        public GPosEntities()
            : base("name=GPosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<udt_Client> udt_Client { get; set; }
        public virtual DbSet<udt_CNV_PaymentType> udt_CNV_PaymentType { get; set; }
        public virtual DbSet<udt_CNV_TransactionType> udt_CNV_TransactionType { get; set; }
        public virtual DbSet<udt_CNV_UnitType> udt_CNV_UnitType { get; set; }
        public virtual DbSet<udt_CONF_Global> udt_CONF_Global { get; set; }
        public virtual DbSet<udt_Product> udt_Product { get; set; }
        public virtual DbSet<udt_ProductCategory> udt_ProductCategory { get; set; }
        public virtual DbSet<udt_Sta_Register> udt_Sta_Register { get; set; }
    }
}
