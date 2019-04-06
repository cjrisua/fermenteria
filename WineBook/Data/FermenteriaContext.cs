using Microsoft.EntityFrameworkCore;
using WineBook.Models;

namespace WineBook.Data
{
    public class FermenteriaContext : DbContext
    {
        public FermenteriaContext(DbContextOptions<FermenteriaContext> options)
            : base(options)
        {

        }

        public DbSet<Winery> Wineries { get; set; }
        public DbSet<Brewery> Breweries { get; set; }
        public DbSet<Container> Containers { get; set; }
        public DbSet<Producer> Producers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Winery>().ToTable("Winery");
            modelBuilder.Entity<Brewery>().ToTable("Brewery");
            modelBuilder.Entity<Container>().ToTable("Container");
            modelBuilder.Entity<Producer>().ToTable("Producer");
        }
    }
}
