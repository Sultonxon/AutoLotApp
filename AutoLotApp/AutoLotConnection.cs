using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AutoLotApp
{
    public partial class AutoLotConnection : DbContext
    {
        public AutoLotConnection()
            : base("name=AutoLotConnection")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Invertory> Invertories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invertory>().HasMany(e => e.Orders).WithRequired(e => e.Invertory).WillCascadeOnDelete(false);
            //modelBuilder.Entity<Customer>().HasMany(e => e.Orders).WithRequired(e => e.Customer).WillCascadeOnDelete(false);
        }
    }
}
