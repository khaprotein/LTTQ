﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test3_lttq
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanlyDoanhthuphimEntities : DbContext
    {
        public QuanlyDoanhthuphimEntities()
            : base("name=QuanlyDoanhthuphimEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Phim> Phims { get; set; }
        public virtual DbSet<phim2d> phim2d { get; set; }
        public virtual DbSet<phim3d> phim3d { get; set; }
    }
}
