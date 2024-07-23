using ChatCommon;
using Microsoft.EntityFrameworkCore;

namespace ChatDB
{
    public class TestContext : DbContext
    {
        public virtual DbSet<UserEntity> User { get; set; }
        public virtual DbSet<MessageEntity> Message { get; set; }
        public TestContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder./*LogTo(Console.WriteLine).*/UseLazyLoadingProxies().UseNpgsql("Host=localhost;Username=postgres;Password=1;Database=ChatDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MessageEntity>(entity => {
                entity.HasKey(x => x.Id).HasName("massage_pkey");
                entity.ToTable("Message");
                entity.Property(x => x.Id).HasColumnName("id");
                entity.Property(x => x.Text).HasColumnName("text");
                entity.Property(x => x.FromUserId).HasColumnName("from_user_id");
                entity.Property(x => x.ToUserId).HasColumnName("to_user_id");

                entity.HasOne(x => x.FromUser)
                    .WithMany(x => x.FromMessages).HasForeignKey(x => x.FromUserId).HasConstraintName("messages_from_user_id_fkey");
                entity.HasOne(x => x.ToUser)
                    .WithMany(x => x.ToMessages).HasForeignKey(x => x.ToUserId).HasConstraintName("messages_to_user_id_fkey");
            });

            modelBuilder.Entity<UserEntity>(entity => {
                entity.HasKey(x => x.Id).HasName("user_pkey");
                entity.ToTable("User");
                entity.Property(x => x.Id).HasColumnName("id");
                entity.Property(x => x.Name).HasMaxLength(50).HasColumnName("name");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
