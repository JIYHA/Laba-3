﻿using System;

namespace Program6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[5, 5];
            int min = array1[0, 0];
            int[] array = new int[5];
            Random rand = new Random();
            int sumR = 0;
            int element = 0;
            Console.WriteLine("ARRAY");
            for (int i = 0; i < 5; i++)
            {
                array[i] = rand.Next(1, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n Operation 1 \n");
            Console.WriteLine("Sum1 =" + sum1(array));
            Console.WriteLine("\n Operation 2 \n");
            Console.WriteLine("Sum2 = " + sum2(array, sumR, element));
            Console.WriteLine("\n Operation 3 \n");
            Console.WriteLine("minim = " + minim(array));
            Console.WriteLine("\n Operation 4 \n");
            int[] arr = { 5, 1, 5, 3, 2, 5, -5, 0, 9, 3 };
            var min1 = Min(arr);
            Console.WriteLine(min1);
            Console.ReadKey();

            static int sum1(int[] array)
            {
                int sum1 = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum1 += array[i];
                }
                return sum1;
            }

            static int sum2(int[] array, int sumR, int element)
            {
                if (element >= array.Length)
                {
                    return sumR;
                }
                else
                {
                    sumR += array[element];
                    element++;
                }
                return sum2(array, sumR, element);
            }
            static int minim(int[] array)
            {
                int min = 100;
                for (int i = 0; i < array.Length; i++)
                {
                    if (min> array[i])
                    min = array[i];
                }
                return min;
            }
             static int Min(int[] array, int i = 0)
            {
            if (array[i] == array[array.Length - 1])
            {
                return array[array.Length - 1];
            }                                                                              
            return array[i] + Min(array, i + 1);
        }
    }
}
