﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DMS.DAL.DatabaseContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MainEntities : DbContext
    {
        public MainEntities()
            : base("name=MainEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bra01branches> bra01branches { get; set; }
        public virtual DbSet<cfg01configurations> cfg01configurations { get; set; }
        public virtual DbSet<dep01department> dep01department { get; set; }
        public virtual DbSet<des01designations> des01designations { get; set; }
        public virtual DbSet<emp01employee> emp01employee { get; set; }
        public virtual DbSet<lvl01employee_levels> lvl01employee_levels { get; set; }
        public virtual DbSet<test> tests { get; set; }
        public virtual DbSet<UserCode> UserCodes { get; set; }
        public virtual DbSet<usr05users> usr05users { get; set; }
        public virtual DbSet<destination> destinations { get; set; }
        public virtual DbSet<gallery> galleries { get; set; }
    }
}
