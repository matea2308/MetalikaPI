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
    
    public partial class proizvod
    {
        public int ID_proizvod { get; set; }
        public string naziv_proizvoda { get; set; }
        public double cijena { get; set; }
        public string napomena { get; set; }
        public int ID_projekt { get; set; }
    
        public virtual projekt projekt { get; set; }
    }
}
