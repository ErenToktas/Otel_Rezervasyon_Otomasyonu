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
    
    public partial class TBLPERSONEL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLPERSONEL()
        {
            this.TBLBANKAHAREKET = new HashSet<TBLBANKAHAREKET>();
            this.TBLCARIHAREKET = new HashSet<TBLCARIHAREKET>();
            this.TBLCARIKONUKHAREKET = new HashSet<TBLCARIKONUKHAREKET>();
            this.TBLKASAHAREKET = new HashSet<TBLKASAHAREKET>();
            this.TBLURUN = new HashSet<TBLURUN>();
        }
    
        public int PERSONELID { get; set; }
        public string ADSOYAD { get; set; }
        public string PERSONELTC { get; set; }
        public string ADRES { get; set; }
        public string TELEFON { get; set; }
        public string MAIL { get; set; }
        public string KANGRUBU { get; set; }
        public Nullable<System.DateTime> ISEGIRISTARIH { get; set; }
        public Nullable<System.DateTime> ISCIKISTARIH { get; set; }
        public Nullable<int> DEPARTMAN { get; set; }
        public Nullable<int> GOREV { get; set; }
        public string YETKI { get; set; }
        public string SIFRE { get; set; }
        public string KIMLIKON { get; set; }
        public string KIMLIKARKA { get; set; }
        public string EHLIYET { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<int> DURUM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBANKAHAREKET> TBLBANKAHAREKET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCARIHAREKET> TBLCARIHAREKET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCARIKONUKHAREKET> TBLCARIKONUKHAREKET { get; set; }
        public virtual TBLDEPARTMAN TBLDEPARTMAN { get; set; }
        public virtual TBLDURUM TBLDURUM { get; set; }
        public virtual TBLGOREV TBLGOREV { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKASAHAREKET> TBLKASAHAREKET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLURUN> TBLURUN { get; set; }
    }
}