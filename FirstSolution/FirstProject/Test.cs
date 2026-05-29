using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class Test
    {
        static void Main()
        {
            int num = 10;
            Console.WriteLine(num.GetType());
            Object obj = num;
            Console.WriteLine(obj.GetType());
        }

    }
}
