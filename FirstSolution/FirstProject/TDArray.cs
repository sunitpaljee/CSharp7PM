using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class TDArray
    {
        static void Main(string[] args)
        {
            int[,] arr = new int [4,5];
            int a = 0;
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //    Console.WriteLine("\n");
            //}

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    a += 10; //a = a + 10;
                    arr[i,j] = a;
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            var iarr = new []
            {
                new [] {1,2,4,2},
                new [] {3,5,6},
                new [] {7,8,9},
            };

            var sarr = new[] {
                new [] {"One" , "Two", "Three"},
                new [] {"Red", "Green", "Blue" }
                };

            //foreach (var item in sarr)
            //{
            //    Console.WriteLine(item[]);
            //}
            Console.WriteLine(sarr[0][0]);
            Console.WriteLine(sarr[1][2]);

        }
    }
}
