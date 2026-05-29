using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class SDArray2
    {
        static void Main(string[] args)
        {
            int a;
            a= 5;
            bool b = false;

            var c = "Sunit";
            var d = 5;

            int[] arr = { 11, 42, 53, 24, 35, 26, 57, 38, 9, 10, 11, 120, 103, 4 };
            foreach (int item in arr)
            {
                Console.Write(item + "\t");                
            }
            Console.WriteLine("------------------------");
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine("------------------------");
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine("------------------------");
            int[] arr2 = new int [14];
            Array.Copy(arr, arr2, 11);
            foreach (var item in arr2)
            {
                Console.Write(item + "\t");
            }

            var iarr = new int[] { 24, 35, 26, 57, 38, 9, 10, 11, 120 };
            var sarr = new string[] { "Rajesh", "Subhash", "Mark", "Raj" };
            foreach (var item in iarr)
            {
                Console.Write(item + " ");
            }
            foreach (var item in sarr)
            {
                Console.Write(item + "\t");
            }
        }
    }
}
