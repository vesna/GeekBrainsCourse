using Microsoft.EntityFrameworkCore;
using StoreMarket002.Models;

namespace StoreMarket002.Contexts
{
    public class StoreContext : DbContext
    {
        public virtual DbSet<StoreModel> Stores { get; set; }
        public virtual DbSet<ProductModel> Products { get; set; }
        public virtual DbSet<CategoryModel> Categories { get; set; }
        private string _connectionString;

        public StoreContext() { }

        public StoreContext(string connectionString) {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder./*LogTo(Console.WriteLine).*/UseLazyLoadingProxies().UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>(entity => {
                entity.HasKey(x => x.Id).HasName("products_pkey");
                entity.ToTable("Products");
                entity.Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnName("name");
                entity.HasIndex(x => x.Name).IsUnique();
                entity.Property(x => x.Description).HasMaxLength(250).HasColumnName("description");
                entity.HasMany(s => s.Stores).WithMany(s => s.Products);
                entity.HasOne(c => c.Category).WithMany(p => p.Products).HasForeignKey(c => c.CategoryId).HasConstraintName("products_from_category_id_fkey");

            });

            modelBuilder.Entity<CategoryModel>(entity => {
                entity.HasKey(x => x.Id).HasName("categories_pkey");
                entity.ToTable("Categories");
                entity.Property(x => x.Name).IsRequired().HasMaxLength(100).HasColumnName("name");
                entity.HasIndex(x => x.Name).IsUnique();
                entity.Property(x => x.Description).HasMaxLength(250).HasColumnName("description");
                
            });

            modelBuilder.Entity<StoreModel>(entity => {
                entity.HasKey(x => x.Id).HasName("stores_pkey");
                entity.ToTable("Stores");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
