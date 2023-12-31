using Microsoft.EntityFrameworkCore;
using System;
using Ticketing._01Core.Domin;
namespace Ticketing._03DBContext
{
    public class TicketDbContext : DbContext
    {
        #region AddDbSets
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=TicketingDb;User Id=sa;Password=hKh@zay!0;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().Property(c => c.Id).UseIdentityColumn(1000, 1);
            modelBuilder.Entity<Ticket>().Property(c => c.DateCreated).HasDefaultValueSql("GetDate()");
        }
    }
}
