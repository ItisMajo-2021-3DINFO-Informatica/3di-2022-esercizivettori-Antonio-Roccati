using System;

namespace EseriziVettoriRoccati1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("esercizio 1");
            const int dimensione = 400;
            Random generatore = new Random();
            int[] Vettore = new int[dimensione];
            for (int i = 0; i < dimensione; i++)
            {
                Vettore[i] = generatore.Next(1, 101);
            }
            for (int i = 0; i < dimensione; i++)
            {
                Console.WriteLine(Vettore[i]);
            }

        }
    }
}
