using System;

namespace Räkna_omekrets_och_area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definiera
            float sidaA = 3.5f;
            float sidaB = 2.4f;
            float sidaC = 2.2f;

            //Bearbeta
            float omkrets = sidaA + sidaB + sidaC;
            float area = (sidaB * sidaC) / 2;
              
            //Presentera
            Console.WriteLine("Omkretsen är " + omkrets);
            Console.WriteLine("Arean är " + area);
        }
    }
}
