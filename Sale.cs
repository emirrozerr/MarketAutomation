//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketAutomation
{
    using System;
    using System.Collections.Generic;

    public partial class Sale
    {
        public int Id { get; set; }
        public Nullable<int> productId { get; set; }
        public Nullable<int> customerId { get; set; }
        public Nullable<int> salePrice { get; set; }
        public Nullable<int> quantity { get; set; }
        public string saleType { get; set; }
        public Nullable<int> profit { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
