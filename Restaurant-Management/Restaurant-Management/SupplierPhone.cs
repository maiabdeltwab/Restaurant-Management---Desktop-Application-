//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant_Management
{
    using System;
    using System.Collections.Generic;
    
    public partial class SupplierPhone
    {
        public int ID { get; set; }
        public string Phone { get; set; }
        public int Supplier_ID { get; set; }
    
        public virtual Supplier Supplier { get; set; }
    }
}
