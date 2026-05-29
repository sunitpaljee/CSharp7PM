using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    public abstract class Figure
    {
        public double width, height, radius;
        public const float pi = 3.14f;
        public abstract double GetArea();
        public abstract double GetParimeter();
    }
}
