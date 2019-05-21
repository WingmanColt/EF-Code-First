using CodeFirtst.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirtst
{
    class myContext : DbContext
    {

            DbSet<User> Users { get; set; }
            DbSet<File> Files { get; set; }
            DbSet<Date> Date { get; set; }
            DbSet<Date> DateFile { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
                builder.UseSqlServer(Config.connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Date>().HasMany(x => x.Files);
            modelBuilder.Entity<File>().HasMany(x => x.Date);
            modelBuilder.Entity<DateFile>().HasKey(x => new { x.DateId, x.FileId });

            base.OnModelCreating(modelBuilder);
        }

    }
    
}
