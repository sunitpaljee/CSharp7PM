using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class LoadCon
    {
        int x;
        public LoadCon()
        {
            this.x = 10;
        }
        public LoadCon(int x)
        {
            this.x = x;
        }
        public void Display()
        {
            Console.WriteLine("Value of x is : {0}", x);
        }
        static void Main(string[] args)
        {
            LoadCon l1= new LoadCon();
            LoadCon l2= new LoadCon(510);
            l1.Display();
            l2.Display();
        }
    }
}
