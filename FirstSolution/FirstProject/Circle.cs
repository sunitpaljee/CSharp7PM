using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class Circle : Figure
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return pi * radius * radius;
        }

        public override double GetParimeter()
        {
            return 2 * pi * radius;
        }
    }
}
