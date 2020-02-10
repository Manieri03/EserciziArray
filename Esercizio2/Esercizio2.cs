using System;
using System.Collections.Generic;
using System.Linq;

namespace Esercizio2
{
    class Esercizio2
    {
        static void Main(string[] args)
        {
            {
                const int TANTI = 10;
                List<int> numeri = new List<int>(TANTI);
                Random random = new Random();
                
                for (int i = 0; i < TANTI; i++)
                {
                    numeri.Add (random.Next(1, 20));
                    
                }
                numeri.Sort();
                foreach (int n in numeri)
                {
                    Console.WriteLine($"Ecco una lista di numeri ordinata in modo crescente: {n}");
                }
                Console.ReadLine();
            }
        }
    }
}
