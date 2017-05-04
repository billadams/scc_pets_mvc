using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCCPetsMVC.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("name=CustomerContext") { }

        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Defines ID is primary key an auto increment
            modelBuilder.Entity<Customer>().HasKey(x => x.id);
            modelBuilder.Entity<Customer>().Property(x => x.id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            base.OnModelCreating(modelBuilder);
        }
    }
}