using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace baitapltw.Models
{
    public partial class BookManagerContext : DbContext
    {
        public BookManagerContext()
            : base("name=BookManagerContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasOptional(e => e.Category)
                .WithRequired(e => e.Product);
        }
    }
}
