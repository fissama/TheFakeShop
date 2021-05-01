using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderHeader> OrderHeaders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<ProductRating> ProductRatings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=TheFakeShop;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at")
                    .HasDefaultValueSql("(CURRENT_TIMESTAMP)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__Categorie__Paren__25869641");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderDeta__Order__5CD6CB2B");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__OrderDeta__Produ__5DCAEF64");
            });

            modelBuilder.Entity<OrderHeader>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__OrderHea__C3905BAFA14617AF");

                entity.ToTable("OrderHeader");

                entity.HasIndex(e => e.CustomerEmail, "UC_CustomerEmail")
                    .IsUnique();

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at")
                    .HasDefaultValueSql("(CURRENT_TIMESTAMP)");

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullAddress).HasMaxLength(200);

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at")
                    .HasDefaultValueSql("(CURRENT_TIMESTAMP)");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductName).HasMaxLength(200);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Products__Catego__29572725");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.HasKey(e => e.PimageId)
                    .HasName("PK__ProductI__218DDF19817897A7");

                entity.Property(e => e.PimageId).HasColumnName("PImageID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at")
                    .HasDefaultValueSql("(CURRENT_TIMESTAMP)");

                entity.Property(e => e.ImageLink)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__ProductIm__Produ__2D27B809");
            });

            modelBuilder.Entity<ProductRating>(entity =>
            {
                entity.HasKey(e => e.PratingId)
                    .HasName("PK__ProductR__2289446B75C425AE");

                entity.Property(e => e.PratingId).HasColumnName("PRatingID");

                entity.Property(e => e.Content).HasMaxLength(500);

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at")
                    .HasDefaultValueSql("(CURRENT_TIMESTAMP)");

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName).HasMaxLength(20);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductRatings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__ProductRa__Produ__30F848ED");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
