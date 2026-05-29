using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class FirstDemo
    {
        int n = 100;
        static void Main()
        {
            FirstDemo f1 = new FirstDemo();
            f1.n = 50;
            //  FirstDemo f2 = new FirstDemo();
            FirstDemo f2 = f1;
            f1 = null;
            Console.WriteLine(f2.n);    // valid
           // Console.WriteLine(f1,n);    // Invalid

            Console.ReadLine();


            // f1  ---- > X  n =100    < ----- f2

            

        }
    }
}
