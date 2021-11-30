using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS_Familjeträd.Database;
using WS_Familjeträd.Migrations;

namespace WS_Familjeträd.Utiles
{
    internal class PersonHelper
    {
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
                    db.SaveChanges(); // objektet uppdateras med ID efter save
                }
                return person;
            }
        }
    }
}
