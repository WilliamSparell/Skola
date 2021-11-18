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
                Console.WriteLine("5. Lista de tio första användarna vars namn börjar på A");
                Console.WriteLine("6. Visa alla användare vars för- och efternamn har samma begynnelsebokstav");
                string input = Console.ReadLine();

                if (input == "1")
                    Input1();
                if (input == "2")
                    Input2();
                if (input == "3")
                    Input3();
                if (input == "4")
                    Input4();

            }
        }

        private static void Input4()
        { 
            Console.Clear();
            SqlConn("SELECT TOP 1 country FROM Mackaroo_data GROUP BY country ORDER BY COUNT(*) DESC");
        }

        private static void Input3()
        {
            Console.Clear();
            SqlConn("SELECT Count(country) FROM Mackaroo_data WHERE country = 'Sweden' OR country = 'Norway' OR country = 'Denmark' OR country = 'Iceland' OR country = 'Finland'");
            SqlConn("SELECT Count(country) FROM Mackaroo_data WHERE country = 'Sweden' OR country = 'Norway' OR country = 'Denmark'");
        }

        private static void Input2()
        {
                Console.Clear();
                SqlConn("select Count(DISTINCT username), Count(DISTINCT password) from Mackaroo_data");
        }

        private static void Input1()
        {
                Console.Clear();
                SqlConn("select Count(DISTINCT country) from Mackaroo_data");
        }
    }
}
