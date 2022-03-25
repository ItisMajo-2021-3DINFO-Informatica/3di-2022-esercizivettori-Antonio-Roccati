using System;

namespace RoccatoGol
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gol = new int[8];
            
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Gol giornata " + (i + 1) + ": ");
                
                gol[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < 8; i++)
            {
              
                Console.WriteLine($"gol[{i}]={gol[i]}");

            }
            int Max = int.MinValue;
            int giornataMax = 0;
            for (int i = 0; i < 8; i++)
            {
                if (gol[i] > Max)
                {
                    Max = gol[i]; giornataMax = i;
                }

            }

            Console.WriteLine("La giornata in cui si sono fatti più gol è " + giornataMax + " numero di gol " + Max);
            int Min = int.MaxValue;
            int giornataMin = 0;
            for (int i = 0; i < 8; i++)
            {
                if (gol[i] < Min)
                {
                    Min = gol[i]; giornataMin = i;
                }

            }

            Console.WriteLine("La giornata in cui si sono fatti meno gol è " + giornataMin + " numero di gol " + Min);
            int somma;
            somma = (gol[0] + gol[1] + gol[2] + gol[3] + gol[4] + gol[5] + gol[6] + gol[7]) / 8;
            Console.WriteLine("La media dei gol nelle 8 giornate del campionato è  " + somma);


        }
    }
}
