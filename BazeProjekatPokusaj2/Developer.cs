//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BazeProjekatPokusaj2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Developer : Zaposleni
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Developer()
        {
            this.UgovoreniProizvodi = new HashSet<UgovoreniProizvod>();
        }
    
        public string PreferiranaTehnologija { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UgovoreniProizvod> UgovoreniProizvodi { get; set; }
    }
}
