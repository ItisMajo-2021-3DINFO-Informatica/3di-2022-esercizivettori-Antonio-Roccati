using System;

namespace EsercizioRoccati2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("esercizio 2");
            const int dimensione = 100;
            Random generatore = new Random();
            int[] Vettore = new int[dimensione];
            for (int i = 0; i < dimensione; i++)
            {
                Vettore[i] = generatore.Next(1, 101);
            }
            for (int i = 0; i >= 50; i++)
            {
                Console.WriteLine(Vettore[i]);
            }
        }
    }
}
