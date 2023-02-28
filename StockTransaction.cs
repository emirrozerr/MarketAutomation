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
    
    public partial class StockTransaction
    {
        public int Id { get; set; }
        public int productId { get; set; }
        public Nullable<int> productUnitPrice { get; set; }
        public Nullable<int> productQuantity { get; set; }
        public Nullable<int> supplierId { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}