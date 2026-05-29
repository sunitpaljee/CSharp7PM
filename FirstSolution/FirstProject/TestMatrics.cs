using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class TestMatrics
    {
        static void Main(string[] args)
        {
            Matric m1 = new Matric(5, 6, 7, 8);
            Matric m2 = new Matric(3, 4, 5, 6);
            Matric m3 = new Matric(1, 2, 3, 4);
            Matric m4 = (m1 + m2 ) + m3;
            Matric m5 = (m1 - m2 ) - m3;
            Console.WriteLine(m1.ToString());
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.WriteLine(m5);

        }
    }
}
