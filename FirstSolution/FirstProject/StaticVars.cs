using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class StaticVars
    {
        int x = 100;
        static int y =200;
        const float pi = 3.14f;
        readonly bool flag;
        readonly int a;
        

        public StaticVars(int  x, bool flag)
        {
            this.x= x;
            this.flag = flag;
            a = 30;
            a = 50;
        }

        static string greet()
        {
            return "Hello Sunit";
        }
        string greet1()
        {
            
            //return "Hello Sunit";
            string a = greet();
            return a;
        }

        static void Main(string[] args) 
        {
            string str = greet();
            
            Console.WriteLine(str);
            Console.WriteLine(y);
            y = 300;
           // pi = 5.234f;
            Console.WriteLine(y);
            Console.WriteLine(pi);
            StaticVars s1 = new StaticVars(50, true);
            
            string str1 = s1.greet1();
            Console.WriteLine(str1);
            //s1.flag = false;
            StaticVars s2 = new StaticVars(150, false);
            Console.WriteLine(s1.x + " " + s2.x);
            Console.WriteLine(s1.flag + " " + s2.flag);
            Console.WriteLine("readonly variable " + s1.a);
            Console.WriteLine("readonly variable " + s2.a);
            //s2.a = 30;
            Console.ReadLine();
        }

    }
}
