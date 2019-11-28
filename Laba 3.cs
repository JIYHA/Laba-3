using System;

namespace Лаба_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            int lim = 1;
            int N = int.Parse(Console.ReadLine());
            int[] nums = new int[N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                nums[i] = rand.Next(-30, 45);
                if (lim > 10)
                {
                    Console.Write("\n\n");
                    lim = 1;
                }
                lim++;
                Console.Write("{0,3} ", nums[i]);
            }
            Console.Write("\n\n");
            Array.Reverse(nums);
            for (int i = 0; i < N; i++)
            {
                if (nums[i] < 0)
                {
                    continue;
                }
                else if (lim > 10)
                {
                    Console.Write("\n\n");
                    lim = 1;
                }
                lim++;
                Console.Write("{0,3}", nums[i]);
            }
        }
    }
    
}
