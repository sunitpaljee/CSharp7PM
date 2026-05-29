using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class AbsChild : AbsParent
    {
        public override void Div(int x, int y)
        {
            Console.WriteLine(x*y);
        }

        public override void Mul(int x, int y)
        {
            Console.WriteLine(x/y);
        }
        static void Main()
        {
            AbsParent abs = new AbsChild();
            abs.Add(100, 50);
            abs.Sub(100, 50);
            abs.Mul(100, 50);
            abs.Div(100, 50);
        }
    }
}
