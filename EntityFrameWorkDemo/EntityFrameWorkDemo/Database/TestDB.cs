using EntityFrameWorkDemo.Models;
using Microsoft.EntityFrameworkCore;
using EntityFrameWorkDemo.Models;

namespace EntityFrameWorkDemo.Database
{
    internal class TestDB : DbContext
    {
        DbSet<HiScore> HiScores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DBtest1;Trusted_Connection=True;");
        }
    }
}
