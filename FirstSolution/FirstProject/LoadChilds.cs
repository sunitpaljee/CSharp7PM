using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    public class LoadChilds : LoadParents
    {
        public void Test(int x)     // overloading
        {
            Console.WriteLine("Child class test method");
        }
        public override void show()     // Overriding
        {
            Console.WriteLine("Child show method");
        }

        public new  void Display()      // Hiding or Shadowing
        {
            Console.WriteLine("child display method");
        }
        static void Main()
        {
            LoadChilds c = new LoadChilds();
            c.Test();
            c.Test(50);
            c.show();       // child
            c.Display();
            Console.WriteLine("------Parents --------");
            LoadParents p = new LoadParents();
            p.show();
            p.Display();
        }
    }
}
