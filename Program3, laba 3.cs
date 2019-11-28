using System;

namespace laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1, 2, 3, 4, 5");
            int[] a ={ 1, 2, 3, 4, 5 };
            int n = 5;
            int k = Convert.ToInt32(Console.ReadLine());
            if (k>5)
                k %= 5;
            for (int i = k; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }
    }
}
