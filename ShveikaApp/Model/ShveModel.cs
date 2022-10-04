using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ShveikaApp.Model
{
    public partial class ShveModel : DbContext
    {
        public ShveModel()
            : base("name=ShveModel")
        {
        }

        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderPickupPoint> OrderPickupPoint { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(e => e.Product)
                .WithMany(e => e.Order)
                .Map(m => m.ToTable("OrderProduct").MapLeftKey("OrderID").MapRightKey("ProductArticleNumber"));

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.UserRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Supplier)
                .HasForeignKey(e => e.ProductSupplierID);
        }
    }
}
