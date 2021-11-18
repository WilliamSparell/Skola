using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SQL_inlämning.SQLConnection;

namespace SQL_inlämning
{
    internal class Menu
    {
        public void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("Vilken information vill du se?");
                Console.WriteLine("1. Hur många länder finns?");
                Console.WriteLine("2. Är alla usernames och passwords unika?");
                Console.WriteLine("3. Hur många är från Norden respektive Skandinavien");
                Console.WriteLine("4. Vilket är det vanligaste namnet");
                Console.WriteLine("5. Lista de tio första användarna vars namn börjar på (ditt val)");
                Console.WriteLine("6. Visa alla användare vars för- och efternamn har samma begynnelsebokstav");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Write("Antal länder är: ");
                    var sql = "select Count(DISTINCT country) from Mackaroo_data";
                }
            }
        }
    }
}
