using System;
using System.Collections.Generic;

namespace Esercizio3
{
    class Esercizio3
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numeri = new int[30];
            int[] pari = new int[30];

            for (int i = 0; i < numeri.Length; i++)
            {
                numeri[i]=random.Next(0, 1000);
                if (numeri[i] % 2 == 0)
                {
                    pari[i] = numeri[i];
                }

            }
            Array.Sort(pari);
            for(int i = 0; i < numeri.Length; i++)
            {
                Console.WriteLine($"{pari[i]}");
            }
            Console.ReadLine();

        }
    }
}
