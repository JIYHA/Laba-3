
using System;

namespace Program7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number that you need: ");
            int NumOfElement = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(Fibonacci(NumOfElement));
        }
            static int Fibonacci(int NumOfElement)
		    {
		        if (NumOfElement == 0)
		        {
		            return 0;
		        }
		        else if (NumOfElement == 1)
		        {
		            return 1;
		        }
		        else
		        {
		            return Fibonacci(NumOfElement - 1) + Fibonacci(NumOfElement - 2);
		        }
		    }
        }
    }
