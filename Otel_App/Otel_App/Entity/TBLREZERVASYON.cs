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
    
    public partial class TBLREZERVASYON
    {
        public int REZERVASYONID { get; set; }
        public Nullable<int> CARI { get; set; }
        public Nullable<System.DateTime> GIRISTARIH { get; set; }
        public Nullable<System.DateTime> CIKISTARIH { get; set; }
        public string KISI { get; set; }
        public Nullable<int> ODA { get; set; }
        public string REZERVASYONADSOYAD { get; set; }
        public string TELEFON { get; set; }
        public string MAIL { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<int> DURUM { get; set; }
    
        public virtual TBLCARI TBLCARI { get; set; }
        public virtual TBLDURUM TBLDURUM { get; set; }
        public virtual TBLODALAR TBLODALAR { get; set; }
    }
}