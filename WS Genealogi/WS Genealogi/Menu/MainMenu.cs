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
            while (true)
            {
            Write("1. Skapa Person");
            Write("2. Radera Person");
            Write("3. Lista Personer");
            Write("4. Uppdatera Person");
            string input = Console.ReadLine();

            if (input == "1")
                CreatePerson();
            if (input == "2")
                DeletePerson();
            if (input == "3") 
                ShowListOfPeopleOnTheFreakingDatabaseTable();
            if (input == "4")
                UpdatePerson();
            }

            


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
            int.TryParse(WriteAndInput("Skriv in födelseår: "), out int birthYear);
            
            FindOrCreatePerson(name, lastName, birthYear);
        }
        private static void UpdatePerson()
        {
            string name = WriteAndInput("Skriv in namn: ");
            string lastName = WriteAndInput("Skriv in efternamn: ");

            FindAndUpdatePerson(name, lastName);
        }
    }
}
