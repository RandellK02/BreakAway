//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BreakAwayModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Destination
    {
        public Destination()
        {
            this.PrimaryPrefCustomers = new HashSet<Customer>();
            this.SecondaryPrefCustomers = new HashSet<Customer>();
            this.Trips = new HashSet<Trips>();
            this.Lodgings = new HashSet<Lodging>();
        }
    
        public int DestinationID { get; set; }
        public string DestinationName { get; set; }
    
        public virtual ICollection<Customer> PrimaryPrefCustomers { get; set; }
        public virtual ICollection<Customer> SecondaryPrefCustomers { get; set; }
        public virtual ICollection<Trips> Trips { get; set; }
        public virtual ICollection<Lodging> Lodgings { get; set; }
    }
}
