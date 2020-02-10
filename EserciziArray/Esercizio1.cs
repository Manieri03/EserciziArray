using System;
using System.Collections.Generic;

namespace EserciziArray
{
    class Esercizio1
    {
       
        static void Main(string[] args)
        {
            const int TANTI = 10;
            Random random = new Random();
            
            HashSet<int> numeri = new HashSet<int>();
            List<int> duplicati = new List<int>();

            for (int i = 0; i < TANTI; i++)
            {
                Console.WriteLine("Inserisci un numero: ");
                int n = int.Parse(Console.ReadLine());
                if (numeri.Contains(n))
                {
                    duplicati.Add(n);
                }
                numeri.Add(n);
            }
            foreach(int doppioni in duplicati)
            {
                Console.WriteLine($"i doppioni sono :{doppioni}");
            }
            
            
            Console.ReadLine();
        }
        
    }
}
