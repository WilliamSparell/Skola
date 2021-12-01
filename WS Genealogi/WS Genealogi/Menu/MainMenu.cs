using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WS_Genealogi.Utiles.BasicHelper;
using static WS_Genealogi.Utiles.PersonHelper;

namespace WS_Genealogi.Menu
{
    internal class MainMenu
    {
        public void StartMenu()
        {
            Write("1. Skapa Person");
            Write("2. Remove Person");
            Write("3. Add Parents to person");
            string input = Console.ReadLine();

            if (input == "1")
                CreatePerson();
            if (input == "2")
                DeletePerson();
            

        }

        private static void DeletePerson()
        {
            string name = WriteAndInput("Skriv in namn: ");
            string lastName = WriteAndInput("Skriv in efternamn: ");

            FindAndDeletePerson(name, lastName);
        }

        private static void CreatePerson()
        {
            string name = WriteAndInput("Skriv in namn: ");
            string lastName = WriteAndInput("Skriv in efternamn: ");
            
            FindOrCreatePerson(name, lastName);
        }
    }
}
