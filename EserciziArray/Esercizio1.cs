using System;

namespace EserciziArray
{
    class Esercizio1
    {
       
        static void Main(string[] args)
        {
            const int TANTI = 50;
            double[] numeri = new double[TANTI];
            Random random = new Random();
            for(int i = 0; i < numeri.Length; i++)
            {
                numeri[i] = random.Next(1, 20);
                int count = 0;
                for (int j = 0; j < numeri.Length; j++)
                {
                    if (numeri[i] == numeri[j])
                    {
                        count = count + 1;
                    }
                }
                Console.WriteLine(numeri[i] + " si ripete " + count + " volte");
            }
            Console.ReadLine();
        }
        
    }
}
