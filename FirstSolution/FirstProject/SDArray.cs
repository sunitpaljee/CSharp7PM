using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class SDArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];

            Console.WriteLine();

            int x = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(arr[i] + " ");
                Console.WriteLine();
            }
            for (int i = 0; i < 4; i++) 
            {
                x += 5; // x = x+5;
                arr[i] = x;
            }
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(arr[i] + " ");
            //    Console.WriteLine();
            //}
            Console.WriteLine(" ---------- Aceessing usung foreach -----------");
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
           
        }
    }
}
