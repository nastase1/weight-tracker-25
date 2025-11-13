using Microsoft.EntityFrameworkCore;
using WeigtTracker.Domain.Entities;

namespace WeightTracker.Infrastructure.Context
{
    public class WeightTrackerDbContext : DbContext
    {
        public WeightTrackerDbContext(DbContextOptions<WeightTrackerDbContext> options)
            : base(options)
        {
        }

        public WeightTrackerDbContext()
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Records> Records { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);
                entity.Property(e => e.Username).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.PasswordHash).IsRequired();
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("datetime('now')");
            });

            modelBuilder.Entity<Records>(entity =>
            {
                entity.HasKey(e => e.RecordId);
                entity.Property(e => e.Weight).HasColumnType("decimal(5,2)");
                entity.Property(e => e.Height).HasColumnType("decimal(5,2)");
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("datetime('now')");

                entity.HasOne(e => e.User)
                    .WithMany()
                    .HasForeignKey(e => e.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}