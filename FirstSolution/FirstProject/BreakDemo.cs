using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class BreakDemo
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {   
                Console.WriteLine(i);
                if (i == 50)
                    break;
            }
            //
            Console.WriteLine("Break called");
        }
    }
}
