using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The value of PI : {0}", MathHelper.pi);

            double sum = MathHelper.Add(20, 10);
            Console.WriteLine("Sum :" + sum);
        }
    }
}
