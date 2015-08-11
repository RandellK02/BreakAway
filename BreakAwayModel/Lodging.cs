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
    
    public partial class Lodging
    {
        public Lodging()
        {
            this.Trips = new HashSet<Trips>();
        }
    
        public int LodgingID { get; set; }
        public string LodgingName { get; set; }
        public int ContactID { get; set; }
        public Nullable<int> DestinationID { get; set; }
        public bool Resort { get; set; }
        public string ResortChainOwner { get; set; }
        public bool LuxuryResort { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual ICollection<Trips> Trips { get; set; }
        public virtual Destination Destination { get; set; }
    }
}
