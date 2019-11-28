using System;

namespace Program5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[5, 5];
            int[,] B = new int[5, 5];

            Random rand = new Random();
            Console.Write("Массив А:");
            Console.WriteLine("\n\n");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = rand.Next(10);
                    Console.Write("{0, 2}  ", A[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("Массив B:");
            Console.WriteLine("\n\n");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = rand.Next(10);

                    Console.Write("{0, 2}  ", B[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            int[,] r = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {

                    for (int j = 0; j < 5; j++)
                    {
                        r[i, k] += A[i, j] * B[j, i];
                        Console.Write("{0,2}", r[i, j]);
                    }
                }
            }
        }
    }
}
