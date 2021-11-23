using EF_Övning.Database;
using EF_Övning.Modeller;
using EF_Övning.Utils;
using Microsoft.EntityFrameworkCore;

namespace EF_Övning
{
    class Program
    {
        private static void Main()
        {
            using (var db = new HeroContext())
            {
                foreach (var hero in db.Heroes.Include("Powers"))
                {
                    Console.WriteLine($"{hero.Alias}");
                    foreach (var power in hero.Powers)
                    {
                        Console.Write($"{power.Description}, ");
                    }
                    Console.WriteLine();
                }
                foreach (var power in db.Powers.Include("Heroes"))
                {
                    Console.WriteLine($"{power.Description}");
                    foreach (var hero in power.Heroes)
                    {
                        Console.Write($"{hero.Alias}, ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
