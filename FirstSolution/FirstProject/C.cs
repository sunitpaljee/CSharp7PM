using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class C : IA, IB
    {
        void IA.Show()
        {
            Console.WriteLine("A Show method");
        }
        void IB.Show()
        {
            Console.WriteLine("B Show method");
        }
        static void Main()
        {
            C c = new C();
            ((IA)c).Show();
            ((IB)c).Show();

        }
    }
}
