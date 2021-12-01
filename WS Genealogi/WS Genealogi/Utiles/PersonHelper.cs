using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS_Genealogi.Database;
using WS_Genealogi.Models;

namespace WS_Genealogi.Utiles
{
    internal class PersonHelper
    {
        // Jäklar vad snyggt! Bra lösning!
        public static Person FindOrCreatePerson(string name, string lastname)
        {
            using (var db = new PersonContext())
            {
                var person = db.Persons.
                FirstOrDefault(

                p => p.Name == name && // Sök på namnet
                (lastname == p.LastName)
                );
                if (person == null) // om personen inte finns, skapa den
                {
                    person = new Person { Name = name, LastName = lastname };
                    db.Persons.Add(person);
                    db.SaveChanges(); 
                    Console.WriteLine("Personen är nu skapad!");
                }
                return person;
            }
        }

        public static Person FindAndDeletePerson(string name, string lastname)
        {
            using (var db = new PersonContext())
            {
                var person = db.Persons.
                FirstOrDefault(

                p => p.Name == name && 
                (lastname == p.LastName)
                );
                if (person != null) // om personen finns, ta bort den
                {
                    db.Persons.Remove(person);
                    db.SaveChanges();
                    Console.WriteLine("Personen är nu borta!");
                }
                return person;
            }
        }

        
        
        
    }
}
