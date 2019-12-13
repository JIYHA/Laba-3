
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
            
            //1
            Console.WriteLine("Spiral");
            int[,] nums = new int[9,9];
            int k = 0;
            int lim = 1;
            for (int j = 0; j < nums.GetLength(1);j++ )
            {
                if (k==0)
                {
                for (int i = 0; i < nums.GetLength(0); i++)
                {
                    nums[i, j] = 1+i;
                    if (lim > 9)
                    {
                        Console.Write("\n\n");
                        lim = 1;
                    }
                    lim++;

                    Console.Write("{0,3} ", nums[i,j]);
                }
                k++;
                }


            }
            //Console.Write("\n\n");
            Console.ReadKey();
            
        }
    }   
}
 //using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace ConsoleApplication1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Pleas, weat");
//            int[,] A = new int[9, 9];
//            int N = 0;
//            for ( int k = 1;k < 6; k++)
//            {
//                for (int i = -1+k; i<10-k; i++)
//                {
//                    A[i,-1+k]=N+1;
//                    N += 1;
//                    if (i==A.GetLength(0)-k)


//                    for (int j = -1+k; j<10-k; j++)
//                    {
//                        A[9-k,j]=N + 1;
//                        N += 1;
//                        if (j==A.GetLength(1)-k)


//                            for (i = A.GetLength(0) - k; i > -1 + k; i--)
//                            {
//                                A[i, -1 + k] = N + 1;
//                                N += 1;
//                                if ( i==-1+k)


//                                    for (j = A.GetLength(1) - k; j > k; j--)
//                                    {
//                                        A[9 - k, j] = N + 1;
//                                        N += 1;
//                                        Console.Write("{0,3}", A[i, j]);
//                                    }
//                            }
//                    }
 
//                }
//            }
//            Console.ReadKey();
        
//        }
//    }
//}   
