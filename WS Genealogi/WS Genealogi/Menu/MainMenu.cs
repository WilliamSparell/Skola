using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS_Genealogi.Utiles;
using static WS_Genealogi.Utiles.BasicHelper;
using static WS_Genealogi.Utiles.PersonHelper;

namespace WS_Genealogi.Menu
{
    internal class MainMenu
    {
        public void StartMenu()
        {
            Write("1. Skapa Person");
            Write("2. Radera Person");
            Write("3. Lista Personer");
            string input = Console.ReadLine();

            if (input == "1")
                CreatePerson();
            if (input == "2")
                DeletePerson();
            if (input == "3") 
                ListPerson();

            


        }

        private static void ListPerson()
        {
            OutputHelper output = new();
            Write("Vill du.....");
            Write("1. Söka på förnaman");
            Write("2. Söka på efternamn");
            Write("3. Lista alla");
            string input2 = Console.ReadLine();
            if (input2 == "1")
                output.SearchFirstName();
            if (input2 == "2")
                output.SearchLastName();
            if (input2 == "3")
                output.ShowEverybody();
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
