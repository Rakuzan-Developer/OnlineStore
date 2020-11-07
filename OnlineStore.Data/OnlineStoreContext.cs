using OnlineStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace OnlineStore.Data
{
    public class OnlineStoreContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users  { get; set; }
        public DbSet<Product> Products { get; set; }

        public OnlineStoreContext()
            :base("OnlineStoreDbContext")
        {                
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
