//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BatAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Species
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Species()
        {
            this.Bats = new HashSet<Bat>();
        }
    
        public int SpeciesId { get; set; }
        public string CommonName { get; set; }
        public string SpeciesName { get; set; }
        public string Genus { get; set; }
        public string Family { get; set; }
        public string FunFact { get; set; }
        public string PicURL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bat> Bats { get; set; }
    }
}