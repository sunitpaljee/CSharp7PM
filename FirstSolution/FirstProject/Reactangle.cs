using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class Reactangle : Figure
    {
        public Reactangle(double width, double hight)
        {
            this.width = width;
            base.height = hight;            
        }

        public override double GetArea()
        {
            return width * height;
        }

        public override double GetParimeter()
        {
            return 2*(width*height);
        }
    }
}
