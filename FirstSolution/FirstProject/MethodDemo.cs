using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    public class MethodDemo
    {
        // Method without any parameter and return type
        public void Test1()     // static in behavior
        {
            int m = 5;
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", m, i, m*i);
            }
        }
        // Method without return type with parameter
        public void Test2(int m, int n)     // dynamic in behavior
        {
            //int m = 5;
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", m, i, m * i);
            }
        }
        // Method without any parameter but return type
        public string Test3()     // static in behavior
        {
            string str = "Hello, How are you ?";
            str = str.ToUpper();
            return str;
        }
        // Method with parameter and return type
        public string Test4(string str)     // dynamic in behavior
        {
            str = str.ToUpper();
            return str;
        }

        //static void Main()
        //{
        //    MethodDemo m1 = new MethodDemo();
        //    m1.Test1();
        //    m1.Test2(20, 10);
        //    Console.WriteLine(m1.Test3());
        //    Console.WriteLine(m1.Test4("Sunit, is every thing good"));
        //    Console.ReadLine();
        //}
    }
}
