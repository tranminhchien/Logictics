using Logictics.DAL.Seed;
using Logictics.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Logictics.DAL.EFContext
{
    public class LogicticsDbContext : DbContext
    {

        public LogicticsDbContext()
        {
        }

        public LogicticsDbContext(DbContextOptions<LogicticsDbContext> options)
            : base(options)
        {
        }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<UserAdmin>(entity =>
            {
                entity.ToTable("UserAdmin");
                entity.HasKey(x => x.Id);
                

                entity.Property(e => e.PassWord)
                      .HasMaxLength(150)
                      .IsUnicode(false);

                entity.Property(e => e.Role)
                      .HasMaxLength(50)
                      .IsUnicode(false);

                entity.Property(e => e.Status)
                      .HasMaxLength(50)
                      .IsUnicode(false);

                entity.Property(e => e.UserName)
                      .HasMaxLength(150)
                      .IsUnicode(false);

            
            });
            modelBuilder.Seed();
 

           
            base.OnModelCreating(modelBuilder);

        }

       
        public virtual DbSet<UserAdmin> UserAdmin { get; set; }
      

    }
}
