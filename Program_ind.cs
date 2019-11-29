
using System;

namespace Program7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length:");
            int N = int.Parse(Console.ReadLine());
            int[] nums = new int[N];
            Random rand = new Random();
             int S = 0;
            for (int i = 0; i < N; i++)
            {
                nums[i] = rand.Next(-30, 45);
                
                Console.Write("{0,3} ", nums[i]);
            }
            Console.Write("\n\n");

            int prev = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                try
                {
                    if (Math.Abs(Math.Abs(nums[i]) - Math.Abs(prev)) <= 5)
                    {
                        S++;
                    }
                    prev = nums[i];
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("i "+i+" prev is "+prev);
                }
                
            }
            Console.WriteLine("S is: "+S);
            Console.Write("\n\n");
        }
    }   
}
    
