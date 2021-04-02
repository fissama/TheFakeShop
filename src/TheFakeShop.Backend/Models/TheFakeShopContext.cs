using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace TheFakeShop.Backend.Models
{
    public partial class TheFakeShopContext : DbContext
    {
        public TheFakeShopContext()
        {
        }

        public TheFakeShopContext(DbContextOptions<TheFakeShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<ProductRating> ProductRatings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["DefaultConnection"]);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.ModifiedAt)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("Modified_at");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__Categorie__Paren__24927208");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedAt)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("Modified_at");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductName).HasMaxLength(200);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Products__Catego__276EDEB3");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.HasKey(e => e.PimageId)
                    .HasName("PK__ProductI__218DDF19CC37F016");

                entity.Property(e => e.PimageId).HasColumnName("PImageID");

                entity.Property(e => e.ImageLink)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedAt)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("Modified_at");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__ProductIm__Produ__2A4B4B5E");
            });

            modelBuilder.Entity<ProductRating>(entity =>
            {
                entity.HasKey(e => e.PratingId)
                    .HasName("PK__ProductR__2289446BBE5DFA2D");

                entity.Property(e => e.PratingId).HasColumnName("PRatingID");

                entity.Property(e => e.Content).HasMaxLength(500);

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName).HasMaxLength(20);

                entity.Property(e => e.ModifiedAt)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("Modified_at");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductRatings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__ProductRa__Produ__2D27B809");
            });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
