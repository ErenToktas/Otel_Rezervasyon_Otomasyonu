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
    
    public partial class TBLDEPARTMAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLDEPARTMAN()
        {
            this.TBLGOREV = new HashSet<TBLGOREV>();
            this.TBLPERSONEL = new HashSet<TBLPERSONEL>();
        }
    
        public int DEPARTMANID { get; set; }
        public string DEPARTMANAD { get; set; }
        public string TELEFON { get; set; }
        public Nullable<int> DURUM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLGOREV> TBLGOREV { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPERSONEL> TBLPERSONEL { get; set; }
    }
}
