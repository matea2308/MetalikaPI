//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Metalika.Podatkovni_sloj
{
    using System;
    using System.Collections.Generic;
    
    public partial class tip_korisnika
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tip_korisnika()
        {
            this.korisnik = new HashSet<korisnik>();
        }
    
        public int ID_tip_korisnika { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }
        public string omogucen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<korisnik> korisnik { get; set; }
    }
}
