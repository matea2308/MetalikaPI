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
    
    public partial class korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public korisnik()
        {
            this.izdatnica = new HashSet<izdatnica>();
            this.radni_nalog = new HashSet<radni_nalog>();
            this.primka = new HashSet<primka>();
            this.projekt = new HashSet<projekt>();
        }
    
        public int ID_korisnik { get; set; }
        public string korisnicko_ime { get; set; }
        public string zaporka { get; set; }
        public System.DateTime datum_registracije { get; set; }
        public string omogucen { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public System.DateTime datum_rodjenja { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }
        public int ID_tip_korisnika { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<izdatnica> izdatnica { get; set; }
        public virtual tip_korisnika tip_korisnika { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<radni_nalog> radni_nalog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<primka> primka { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<projekt> projekt { get; set; }
    }
}
