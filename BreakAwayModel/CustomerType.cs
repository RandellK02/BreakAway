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
    
    public partial class CustomerType
    {
        public CustomerType()
        {
            this.Customers = new HashSet<Customer>();
        }
    
        public int CustomerTypeID { get; set; }
        public string Type { get; set; }
    
        public virtual ICollection<Customer> Customers { get; set; }
    }
}