using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS_Genealogi.Database;

namespace WS_Genealogi.Utiles
{
    internal class BasicHelper
    {
        public static void Write(string sentence)
        {
            Console.WriteLine(sentence);
        }
        public static string WriteAndInput(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }

        public static void ShowListOfPeopleOnTheFreakingDatabaseTable() // :D
        {
            // Först behöver du databaskoppling
            using (var db = new PersonContext())
            {
                // foreacha hela listan av person (exempelvis)
                foreach (var item in db.Persons)
                {
                    Console.WriteLine(item);
                }
                //
                // :)
                // Då skriver den ut WS Genealogi.PersonContext.Person
                // men...  du kan lägga en ToString i Person som returnerar en string med namn och övrig data
                // då kan du köra med bara (item)
            }



        }
        
    }
}
