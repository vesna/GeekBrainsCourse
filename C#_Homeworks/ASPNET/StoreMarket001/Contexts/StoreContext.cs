using Microsoft.EntityFrameworkCore;
using StoreMarket001.Models;

namespace StoreMarket001.Contexts
{
    public class StoreContext : DbContext
    {
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        public StoreContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder./*LogTo(Console.WriteLine).*/UseLazyLoadingProxies().UseNpgsql("Host=localhost;Username=postgres;Password=1;Database=StoreDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity => {
                entity.HasKey(x => x.Id).HasName("products_pkey");
                entity.ToTable("Products");
                entity.Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnName("name");
                entity.HasIndex(x => x.Name).IsUnique();
                entity.Property(x => x.Description).HasMaxLength(250).HasColumnName("description");
                entity.HasMany(s => s.Stores).WithMany(s => s.Products);
                entity.HasOne(c => c.Category).WithMany(p => p.Products).HasForeignKey(c => c.CategoryId).HasConstraintName("products_from_category_id_fkey");

            });

            modelBuilder.Entity<Category>(entity => {
                entity.HasKey(x => x.Id).HasName("categories_pkey");
                entity.ToTable("Categories");
                entity.Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnName("name");
                entity.HasIndex(x => x.Name).IsUnique();
                entity.Property(x => x.Description).HasMaxLength(250).HasColumnName("description");
                
            });

            modelBuilder.Entity<Store>(entity => {
                entity.HasKey(x => x.Id).HasName("stores_pkey");
                entity.ToTable("Stores");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
