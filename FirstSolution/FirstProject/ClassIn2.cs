using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class ClassIn2 : ClassIn1
    {
        public ClassIn2()
        {
            Console.WriteLine("class2 cons called");
        }
        public void Test3()
        {
            Console.WriteLine("Third Method");
        }


        static void Main(string[] args)
        {
            Object obj = new Object();
            ClassIn1 c1 = new ClassIn1();
            ClassIn2 c = new ClassIn2();
            ClassIn1 p = c;

           // ClassIn2 obj = (ClassIn2)p;
            //ClassIn2 obj = p as ClassIn2;

            c.Test1();
            c.Test2();
            c.Test3();
            p.Test1();
            p.Test2();
            // p.Test3();      // Invalid
            // obj.Test3();
            Console.WriteLine(obj.GetType());
            
            Console.WriteLine(c1.GetType());
            Console.WriteLine(c.GetType());
            // Console.WriteLine(obj.ToString());
            Console.WriteLine(c.Equals(p));     // True
            Console.WriteLine(c.Equals(c1));    // False
            Console.WriteLine(obj.Equals(c));
            Console.WriteLine(p.GetHashCode());
            string a = "Sunit";
            Console.WriteLine(a.GetHashCode());
        }
    }
    }
