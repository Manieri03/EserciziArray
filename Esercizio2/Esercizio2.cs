using System;
using System.Linq;

namespace Esercizio2
{
    class Esercizio2
    {
        static void Main(string[] args)
        {
            {
                const int TANTI = 10;
                double[] numeri = new double[TANTI];
                Random random = new Random();
                
                for (int i = 0; i < numeri.Length; i++)
                {
                    numeri[i] = random.Next(1, 20);
                    
                    for (int j = i + 1; j < numeri.Length; j++)   //TENTATIVO CON SELECTION SORT NON FUNZIONANTE
                        if (numeri[j] < numeri[i])
                            i = j;

                    double temp = numeri[i];
                    numeri[i] = numeri[i];

                    Console.WriteLine(numeri[i]);

                }
                Console.ReadLine();
            }
        }
    }
}
