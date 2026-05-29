using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    public class First
    {
        int x, y;   // class variable
        public First(int x, int y) // Exiplict cons/ Parameertrized
        {
            this.x = x;
            this.y = y;
        }
        public void Add()
        {
            Console.WriteLine(x+y);
        }
        public void Sub()
        {
            Console.WriteLine(x - y);
        }
        public void Mul()
        {
            Console.WriteLine(x * y);
        }
        public void Div()
        {
            Console.WriteLine(x / y);
        }
    }
}
