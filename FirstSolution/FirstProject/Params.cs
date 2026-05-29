using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class Params
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Console.Write(item + "\t");
            }
        }
    }
}
