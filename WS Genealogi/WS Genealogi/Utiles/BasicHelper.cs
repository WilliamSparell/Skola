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
            
            using (var db = new PersonContext())
            {
                
                foreach (var item in db.Persons)
                {
                    Console.WriteLine(item);
                }
                
            }



        }
        
    }
}
