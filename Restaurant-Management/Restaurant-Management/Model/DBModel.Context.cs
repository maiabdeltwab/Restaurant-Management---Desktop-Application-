﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant_Management.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RestaurantEntities : DbContext
    {
        public RestaurantEntities()
            : base("name=RestaurantManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FoodIngredient> FoodIngredients { get; set; }
        public DbSet<ItemShipment> ItemShipments { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderType> OrderTypes { get; set; }
        public DbSet<RestaurantConsumption> RestaurantConsumptions { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<StoreConsumption> StoreConsumptions { get; set; }
        public DbSet<StoreItem> StoreItems { get; set; }
        public DbSet<StoreItemType> StoreItemTypes { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierPhone> SupplierPhones { get; set; }
        public DbSet<UserPhone> UserPhones { get; set; }
        public DbSet<UserPrivilege> UserPrivileges { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<SaveLogin> SaveLogins { get; set; }
    }
}
