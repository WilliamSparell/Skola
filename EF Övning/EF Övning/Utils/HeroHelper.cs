using EF_Övning.Database;
using EF_Övning.Modeller;
using Microsoft.EntityFrameworkCore;

namespace EF_Övning.Utils
{
    internal class HeroHelper
    {
        public static Hero FindOrCreateHero(string name, string alias = "")
        {
            using (var db = new HeroContext())
            {
                var hero = db.Heroes.
                Include("Powers").
                FirstOrDefault(

                h => h.RealName == name || // Sök på namnet eller
                (alias != "" && h.Alias == alias) // Sök på alias om ej ””

                );
                if (hero == null) // om hjälten inte finns, skapa den
                {
                    hero = new Hero { RealName = name, Alias = alias };
                    db.Heroes.Add(hero);
                    db.SaveChanges(); // objektet uppdateras med ID efter save
                }
                return hero;
            }
        }
        public static Hero AddPower(Hero hero, string superPower)
        {
            using (var db = new HeroContext())
            {
                db.Heroes.Attach(hero); // Se till att databasen förstår att vi
                                        // använder en Hero från databasen
                var power = db.Powers.Include("Heroes").FirstOrDefault(p => p.Description ==
                superPower);
                if (power == null)
                {
                    power = new Power { Description = superPower };
                    db.Powers.Add(power);
                    db.SaveChanges();
                }
                if (hero.Powers == null) hero.Powers = new List<Power>();
                // Dubbelchecka att power inte finns redan
                if (hero.Powers.FirstOrDefault(p => p.ID == power.ID) == null)
                {
                    hero.Powers.Add(power);
                    db.Heroes.Update(hero);
                    db.SaveChanges();
                }
            }
            return hero;
        }
        public static Hero DeletePower(Hero hero, string superPower)
        {
            using (var db = new HeroContext())
            {
                db.Heroes.Attach(hero); // Se till att databasen förstår att vi använder
                                        // en Hero från databasen
                var power = db.Powers.Include("Heroes").
                FirstOrDefault(p => p.Description == superPower);
                if (power == null) return hero;
                if (hero.Powers == null) return hero;
                if (hero.Powers.Any(p => p.ID == power.ID)) // Any funkar söker som
                                                            // FirstOrDefault och returnerar en bool
                {
                    hero.Powers.Remove(power);
                    db.Update(hero);
                    db.SaveChanges();
                }
            }
            return hero;
        }
    }
}
