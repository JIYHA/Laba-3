using System;

namespace laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Enter you k");
            int k = Convert.ToInt32(Console.ReadLine());
            k %=5;
            for (int i = 0; i < k; i++)
            {
                int tmp = 0;
                tmp = a[0];
                for (int j = 0; j < a.GetLength(0)-1; j++)
                {
                    a[j] = a[j + 1];
                }
                a[a.Length - 1] = tmp;
            }
            Console.WriteLine();
            for ( int i = 0; i< a.Length; i++)
            {
                  Console.Write("{0, 2}", a[i]);
            }
            Console.ReadKey();
        }
    }
}
