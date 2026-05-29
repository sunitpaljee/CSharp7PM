using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class ReturnDemo
    {
        static void Main()
        {
            
            Console.WriteLine("Enter a integer value : ");
            int m = int.Parse(Console.ReadLine());
            Display();
            if (m == 0)
                return;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", m, i, m * i);
            }
            Console.WriteLine("End of Program");
        }
        static void Display()
        {
            Console.WriteLine("Table of the number");
        }
    }
}