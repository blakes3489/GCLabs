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
    
    public partial class Bat
    {
        public int BatId { get; set; }
        public string Name { get; set; }
        public Nullable<byte> Age { get; set; }
        public bool IsAlive { get; set; }
        public Nullable<int> SpeciesId { get; set; }
        public Nullable<int> LocationId { get; set; }
    
        public virtual Species Species { get; set; }
    }
}
