//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Beadando
{
    using System;
    using System.Collections.Generic;
    
    public partial class Konyv
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Konyv()
        {
            this.Kolcsonzes = new HashSet<Kolcsonze>();
        }
    
        public int Konyv_Id { get; set; }
        public string Nev { get; set; }
        public string Szerzo { get; set; }
        public int Kiadas_datum { get; set; }
        public string Kiado { get; set; }
        public string Nyelv { get; set; }
        public int Oldalszam { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kolcsonze> Kolcsonzes { get; set; }
    }
}
