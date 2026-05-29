using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class RideDemo
    {
        public void Test()
        {
            Console.WriteLine(1);
        }
        public void Test(int x)
        {
            // Old Logic will 
            Console.WriteLine(3);
        }
    }
    class A : RideDemo
    {
        public void Test()
        {
            Console.WriteLine(2);
        }
        public void Test(int x)
        {
            // New Logic
            Console.WriteLine("Please ente one nu");
            //int m = int.Parse(Console.ReadLine());
            //Console.WriteLine(m);
        }
        static void Main(string[] args) 
        {
            A a = new A();
            a.Test();

           
                Console.Write("Enter a decimal number: ");
                int decimalNumber = Convert.ToInt32(Console.ReadLine());

                string binary = Convert.ToString(decimalNumber, 2);

                Console.WriteLine("Binary equivalent: " + binary);
         

        }
    }
}
