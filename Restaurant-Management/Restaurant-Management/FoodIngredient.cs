//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant_Management
{
    using System;
    using System.Collections.Generic;
    
    public partial class FoodIngredient
    {
        public int ID { get; set; }
        public int StoreItem_id { get; set; }
        public int MenuItem_id { get; set; }
        public Nullable<decimal> Quantity { get; set; }
    
        public virtual MenuItem MenuItem { get; set; }
        public virtual StoreItem StoreItem { get; set; }
    }
}
