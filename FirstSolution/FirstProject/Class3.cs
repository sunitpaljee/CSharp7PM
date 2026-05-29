using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace FirstProject
{
    internal class Class3ForStudent
    {
        static void Main()
        {
            //goto;
            //    breck;
            //continue
            //    return;

            //    int a=0;
            //xyz:      // label
            //    Console.WriteLine("Number = " + a);
            //    a++;
            //    if (a < 5)
            //    {
            //        goto xyz;
            //    }
            //    Console.WriteLine("loop finish");

        abc:
            Console.WriteLine("Hello");
            goto abc;
        }
    }
}
