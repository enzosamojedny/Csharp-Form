using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Coderhouse_MAIN.models;
using Microsoft.EntityFrameworkCore;


namespace C__Coderhouse_MAIN.database
{
    public partial class DatabaseContext : DbContext
    {
        public virtual DbSet<models.Products> Products { get; set; }

        public virtual DbSet<models.Users> Users { get; set; }

        public virtual DbSet<models.Sales> Sales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString: "Server=.; Database=NewCodeDB; Trusted_Connection=True;TrustServerCertificate=true;");
            }
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>(entity =>
            {
                entity.ToTable("Products");
                entity.Property(e => e.Cost).HasColumnType("money");
                entity.Property(e => e.Description).IsUnicode(false);
                entity.Property(e => e.SellPrice).HasColumnType("money");
                entity.HasOne(d => d.IdUserNavigation)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.UserID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Products_Users");
            });
            modelBuilder.Entity<ProductSold>(entity =>
            {
                entity.HasOne(d => d.IdProductNavigation)
                .WithMany(p => p.ProductSold)
                .HasForeignKey(d => d.ProductID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProductSold_Products");

                entity.HasOne(d => d.IdSaleNavigation)
                .WithMany(p => p.ProductSold)
                .HasForeignKey(d => d.SaleID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProductSold_Sale");
            });
            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users");
                entity.Property(e => e.LastName).IsUnicode(false);
                entity.Property(e => e.Password).IsUnicode(false);
                entity.Property(e => e.Email).IsUnicode(false);
                entity.Property(e => e.Name).IsUnicode(false);
                entity.Property(e => e.Username).IsUnicode(false);
            });
            modelBuilder.Entity<Sales>(entity =>
            {
                entity.HasOne(d => d.IdUserNavigation)
                .WithMany(p => p.Sales)
                .HasForeignKey(d => d.UserID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Sales_Users");
            });
            OnModelCreatingPartial(modelBuilder);

        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
