using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS_Genealogi.Database;

namespace WS_Genealogi.Utiles
{
    internal class OutputHelper
    {
        //https://github.com/marcusjobb/net21/blob/main/OOA/SnyggkodDemo/SnyggkodDemo/SlarvigKod/HeroesAndVillians.cs
        private readonly List<Models.Person> names = new();

        public void ShowEverybody()
        {
            DisplayList(names, "Everybody");
        }
        public void SearchLastName()
        {
            Console.WriteLine("Search last name");
            Console.Write("Lastname: ");
            var input3 = Console.ReadLine();
            FindLastName(input3);
        }
        private void FindLastName(string input3)
        {
            var lname = names.Where(x => x.LastName.Contains(input3, StringComparison.InvariantCultureIgnoreCase)).ToList();
            DisplayList(lname, "Last name contains " + input3);
        }

        public void SearchFirstName()
        {
            Console.WriteLine("Search name");
            Console.Write("Name: ");
            var input2 = Console.ReadLine();
            FindFirstName(input2);
        }
        private void FindFirstName(string input2)
        {
            var fname = names.Where(x => x.Name.Contains(input2, StringComparison.InvariantCultureIgnoreCase)).ToList();
            DisplayList(fname, "First name contains " + input2);
        }

        private static void DisplayList(List<Models.Person> names, string name)
        {
            using (var reader = new PersonContext())
            {
            Console.WriteLine(name);
            foreach (var person in names.OrderBy(n => n.LastName).ThenBy(n => n.Name))
            {
                Console.WriteLine(person);
            }
                Console.WriteLine();
            }
        }
        
    }
}
