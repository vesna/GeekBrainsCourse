using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Infrastructure.Persistence.Contexts
{
    public class ChatContext : DbContext 
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseLazyLoadingProxies().UseNpgsql("Host=localhost;Username=postgres;Password=1;Database=ChatDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MessageEntity>(entity => {
                entity.HasKey(x => x.Id).HasName("massages_pkey");
                entity.ToTable("Messages");
                entity.Property(x => x.Id).HasColumnName("id");
                entity.Property(x => x.Text).HasColumnName("text");
                entity.Property(x => x.FromUserId).HasColumnName("from_user_id");
                entity.Property(x => x.ToUserId).HasColumnName("to_user_id");

                entity.HasOne<UserEntity>().WithMany().HasForeignKey(x => x.FromUserId).HasConstraintName("messages_from_user_id_fkey");
                entity.HasOne<UserEntity>().WithMany().HasForeignKey(x => x.ToUserId).HasConstraintName("messages_to_user_id_fkey");
            });

            modelBuilder.Entity<UserEntity>(entity => {
                entity.HasKey(x => x.Id).HasName("users_pkey");
                entity.ToTable("Users");
                entity.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
                entity.Property(x => x.Name).HasMaxLength(50).HasColumnName("name");
                entity.HasIndex(x => x.Name).IsUnique();
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
