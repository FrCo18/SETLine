﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SETLine
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SETLineBDEntities : DbContext
    {
        public SETLineBDEntities()
            : base("name=SETLineBDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<ConnectedClients> ConnectedClients { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<PlaceOrder> PlaceOrder { get; set; }
        public virtual DbSet<Rates> Rates { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }
    }
}
