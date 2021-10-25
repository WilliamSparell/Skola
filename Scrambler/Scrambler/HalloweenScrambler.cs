using System;
using System.Collections.Generic;

namespace Scrambler
{
    class HalloweenScrambler
    {
        private readonly List<string> words;
        private static Random rnd = new Random();

        private string currentWord = "";
        private string scrambledWord = "";

        public HalloweenScrambler()
        {
            words = new()
            {
                "spöke",
                "pumpa",
                "zombie",
                "monster",
                "alien",
                "rymdvarelse",
                "mummie",
                "dödskalle",
                "grav",
                "köpcentra",
                "vampyr",
                "spindel",
                "fladdermus",
                "godis",
                "bus eller godis"
            };
        }
        private void Swap(int num1, int num2)
        {
            var letters = scrambledWord.ToCharArray();
            var tmp = letters[num1];
            letters[num1] = letters[num2];
            letters[num2] = tmp;
            scrambledWord = new string(letters);
        }
        private void ScrambledWord()
        {
            for (int Scramble = 0; Scramble < currentWord.Length; Scramble++)
            {
                var pos = rnd.Next(currentWord.Length);
                Swap(Scramble, pos);
            }
        }
        private string Centre(string v)
        {
            int CellWidth = 5;
            while (v.Length < CellWidth)
            {
                v = " " + v + " ";
            }
            return v;
        }
        private void ShowScrambledWord()
        {
            var top = "|";
            var middle = "+";
            var bottom = "|";
            var separator = "|";
            for (var i = 0; i < scrambledWord.Length; i++)
            {
                top += Centre((i + 1).ToString()) + "|";
                middle += "-----+";
                separator += " |";
                bottom += Centre(scrambledWord[i].ToString()) + "|";
            }
            Console.WriteLine(middle);
            Console.WriteLine(top);
            Console.WriteLine(middle);
            Console.WriteLine(separator);
            Console.WriteLine(bottom);
            Console.WriteLine(separator);
            Console.WriteLine(middle);
        }
        private void SelectWord()
        {
            currentWord = words[rnd.Next(words.Count)];
            scrambledWord = currentWord;
        }
        private bool IsOK(int num)
        {
            return (num >= 1) && (num <= scrambledWord.Length);
        }
        private void ShowInput()
        {
            var num1 = 0;
            var num2 = 0;
            bool check = false;
            do
            {
                Console.WriteLine("Ange bokstäverna som ska byta plats, exempel 4,2");
                var input = Console.ReadLine();
                var split = input.Split(',');
                _ = int.TryParse(split[0], out num1);
                _ = int.TryParse(split[1], out num2);
                check = IsOK(num1) && IsOK(num2);
            } while (!check);
            num1--;
            num2--;
            Swap(num1, num2);
        }
        internal void Run()
        {
            SelectWord();
            ScrambledWord();
            int counter = 0;
            while (scrambledWord != currentWord)
            {
                Console.Clear();
                ShowScrambledWord();
                Console.WriteLine();
                counter++;
                ShowInput();
            }
            Console.Clear();
            Console.WriteLine("Du klarade det på " + counter + " försök");
            Console.WriteLine("Ordet var " + scrambledWord);
        }
    }
}
