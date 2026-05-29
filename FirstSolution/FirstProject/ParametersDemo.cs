using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class ParametersDemo
    {

        void AddNums(int x, int y = 100, int z = 50)
        {
            Console.WriteLine(x+y+z);
        }

        void Math1(int x, int y, ref int a, ref int b)
        {
            a = x + y;
            b = x - y;
        }
        void Math2(int x, int y, out int a, out int b)
        {
            a = x + y;
            b = x - y;
        }

        static void Main()
        {
            int r = 0, s= 0;
            int m=15, n=10;
            
            ParametersDemo p1= new ParametersDemo();
            p1.AddNums(10,20,30);
            p1.Math1(20,10, ref r, ref s);
            // Console.WriteLine("Add of two no : {0} and Subs of two no :{1}", r, s);
            Console.WriteLine("Add of two no :" + r + "and Subs of two no :" + s);
            p1.Math2(20, 10, out m, out n);
            Console.WriteLine( "Add of two no : {0} and Subs of two no :{1}",m, n);
            Console.ReadLine();
        }


    }
}
