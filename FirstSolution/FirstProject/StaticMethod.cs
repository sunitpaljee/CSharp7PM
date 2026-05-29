using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class StaticMethod
    {
        int x = 100;
        static int y = 200;
        static void Add()
        {
            StaticMethod obj = new StaticMethod();
            //int d = 
                
           
            Console.WriteLine(obj.x + y);
          //  Console.WriteLine( "instacse method" + d);
        }
        void AddNums1(int x, int y) 
        {
            StaticMethod obj = new StaticMethod();
            int d = obj.AddNums(20, 5);
            Console.WriteLine(d);
            Add();
        }
        int AddNums(int m, int n)
        {
            return m + n;
        }
        static void Main()
        {
            StaticMethod obj1 = new StaticMethod();
            Add();
            Console.WriteLine("-------- auto call------");
            obj1.AddNums1(20, 5);
            Console.ReadLine();
        }
    }
}
