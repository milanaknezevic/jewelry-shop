//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HCI_PRODAVNICA_NAKITAnew
{
    using System;
    using System.Collections.Generic;
    
    public partial class nakit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nakit()
        {
            this.kupovina_stavka = new HashSet<kupovina_stavka>();
        }
    
        public int nakit_id { get; set; }
        public double gramaza { get; set; }
        public decimal cijena { get; set; }
        public string naziv { get; set; }
        public int kolicina { get; set; }
        public string ZAPOSLENI_JMBG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kupovina_stavka> kupovina_stavka { get; set; }
        public virtual zaposleni zaposleni { get; set; }
    }
}