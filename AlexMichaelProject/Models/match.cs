//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlexMichaelProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class match
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public match()
        {
            this.tickets = new HashSet<ticket>();
        }
    
        public int matchID { get; set; }
        public string teamA { get; set; }
        public string teamB { get; set; }
        public string stadium { get; set; }
        public string league { get; set; }
        public System.DateTime date { get; set; }
    
        public virtual team team { get; set; }
        public virtual team team1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ticket> tickets { get; set; }
    }
}