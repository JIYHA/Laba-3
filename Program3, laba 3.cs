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
            if (k > 5)
                k %= 5;
            for (int i = 0; i < k; i++)
            {
                int tmp = a[0];
                a[0] = a[1];
                a[1] = a[2];
                a[2] = a[3];
                a[3] = a[4];
                a[4] = tmp;
                Console.Write("{0, 2}", a[i]);
            }
            //Console.Write(a[]);
            Console.ReadKey();
        }
    }
}
