using EF_Övning.Modeller;
using Microsoft.EntityFrameworkCore;

namespace EF_Övning.Database
{
    internal class HeroContext : DbContext
    {
        private const string DatabaseName = "Heroes";
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Power> Powers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            $@"Server=(localdb)\mssqllocaldb;Database={DatabaseName};Trusted_Connection=True;");
        }
    }
}
