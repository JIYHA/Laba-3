using System;

namespace Program7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            int N = Convert.ToInt32(Console.ReadLine());
            int f1 = 1;
            int f2 = 1;
            Console.WriteLine();
            Console.WriteLine("{0}  \n{1}", f1, f2);
            int sum = 0;
            Fibonachi(N, f1, f2, sum);
            Console.ReadKey();
            static int Fibonachi(int index, int num1, int num2, int sum)
            {
                if (index == 0)
                {
                    return 0;
                }
                sum = num1 + num2;
                Console.WriteLine(sum);
                return Fibonachi(index - 1, num2, sum, sum);
            }
        }
    }
    
}
