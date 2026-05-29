using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class TestFigure
    {
        static void Main()
        {


            Reactangle r = new Reactangle(2, 3);
            Console.WriteLine(r.GetArea());
            Console.WriteLine(r.GetParimeter());

            Circle c = new Circle(5);
            Console.WriteLine(c.GetArea());
            Console.WriteLine(c.GetParimeter());
        }
    }
}
