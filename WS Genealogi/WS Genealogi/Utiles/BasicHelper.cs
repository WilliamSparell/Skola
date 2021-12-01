using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static string FixUp(string input)
        {
            input.Trim();

            if (input.Length == 1)
                System.Console.WriteLine(char.ToUpper(input[0]));
            else
                System.Console.WriteLine(char.ToUpper(input[0]) + input.Substring(1));

            return input;
        }
    }
}
