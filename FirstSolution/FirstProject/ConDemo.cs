using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class ConDemo
    {
        int x;
        string s;
        bool b;
        public ConDemo()    // Default cons/ Implicit cons/ Parameerteless
        {
            Console.WriteLine("Constructor called");    
        }
        public void Demo()
        {
            Console.WriteLine("Method called for int : {0},  for string : {1}, for bool : {2}", x, s, b);
        }
        static void Main(string[] args)
        { 
            ConDemo cd1 = new ConDemo();        // calling the cons
            ConDemo cd2 = new ConDemo();
            ConDemo cd3 = cd2;
            cd1.Demo();
            cd2.Demo();
            cd3.Demo();
            Console.ReadLine();
        }

    }
}
