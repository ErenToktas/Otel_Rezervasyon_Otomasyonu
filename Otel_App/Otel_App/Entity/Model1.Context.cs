﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Otel_App.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OtelEntities : DbContext
    {
        public OtelEntities()
            : base("name=OtelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBLBANKA> TBLBANKA { get; set; }
        public virtual DbSet<TBLBANKAHAREKET> TBLBANKAHAREKET { get; set; }
        public virtual DbSet<TBLBIRIM> TBLBIRIM { get; set; }
        public virtual DbSet<TBLCARI> TBLCARI { get; set; }
        public virtual DbSet<TBLCARIHAREKET> TBLCARIHAREKET { get; set; }
        public virtual DbSet<TBLCARIKONUKHAREKET> TBLCARIKONUKHAREKET { get; set; }
        public virtual DbSet<TBLCARITUR> TBLCARITUR { get; set; }
        public virtual DbSet<TBLDEPARTMAN> TBLDEPARTMAN { get; set; }
        public virtual DbSet<TBLDURUM> TBLDURUM { get; set; }
        public virtual DbSet<TBLGOREV> TBLGOREV { get; set; }
        public virtual DbSet<TBLISLEM> TBLISLEM { get; set; }
        public virtual DbSet<TBLKASA> TBLKASA { get; set; }
        public virtual DbSet<TBLKASAHAREKET> TBLKASAHAREKET { get; set; }
        public virtual DbSet<TBLKURLAR> TBLKURLAR { get; set; }
        public virtual DbSet<TBLODALAR> TBLODALAR { get; set; }
        public virtual DbSet<TBLPERSONEL> TBLPERSONEL { get; set; }
        public virtual DbSet<TBLREZERVASYON> TBLREZERVASYON { get; set; }
        public virtual DbSet<TBLTELEFON> TBLTELEFON { get; set; }
        public virtual DbSet<TBLURUN> TBLURUN { get; set; }
        public virtual DbSet<TBLURUNGRUP> TBLURUNGRUP { get; set; }
        public virtual DbSet<TBLUYRUK> TBLUYRUK { get; set; }
    }
}
