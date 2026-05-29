using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace FirstProject
{
    internal class Class1
    {
        static void Main()
        {
            Console.WriteLine("Second Program in VS");
            MethodDemo m1 = new MethodDemo();
            
            m1.Test1();
            m1.Test2(20, 10);
            Console.WriteLine(m1.Test3());
            Console.WriteLine(m1.Test4("Sunit, is every thing good"));
            Console.ReadLine();
        }
    }
}
