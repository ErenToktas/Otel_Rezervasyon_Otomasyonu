//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class TBLKASAHAREKET
    {
        public int KASAHAREKETID { get; set; }
        public Nullable<int> KASAID { get; set; }
        public string KASABELGENO { get; set; }
        public Nullable<decimal> GIREN { get; set; }
        public Nullable<decimal> CIKAN { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<int> ISLEM { get; set; }
        public Nullable<int> PERSONEL { get; set; }
        public Nullable<int> DURUM { get; set; }
    
        public virtual TBLDURUM TBLDURUM { get; set; }
        public virtual TBLISLEM TBLISLEM { get; set; }
        public virtual TBLKASA TBLKASA { get; set; }
        public virtual TBLPERSONEL TBLPERSONEL { get; set; }
    }
}
