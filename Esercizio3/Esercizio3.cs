using System;

namespace Esercizio3
{
    class Esercizio3
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] numeri = new double [30];

            for(int i = 0; i < numeri.Length; i++)
            {
                numeri[i]= random.Next(0, 999);
            }
        }
    }
}
