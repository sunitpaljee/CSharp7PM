using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class ConParam
    {
        int x;
        public ConParam(int a)
        {
            x = a;
        }
        public void Dsiplay()
        {
            Console.WriteLine("The value of x for current object is : {0}", x);
        }
        static void Main()
        {
            ConParam cp1 = new ConParam(10);
            ConParam cp2 = new ConParam(20);
            ConParam cp3 = new ConParam(30);
            cp1.Dsiplay();
            cp2.Dsiplay();
            cp3.Dsiplay();
            First first = new First(30, 10);
            first.Add();
            first.Sub();
            first.Mul();
            first.Div();
        }
    }
}
