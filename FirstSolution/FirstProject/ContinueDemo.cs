using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class ContinueDemo
    {
        static void Main()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i == 5 || i == 15 || i == 20 || i == 50)
                    continue;
                Console.WriteLine(i);
            }
            Console.WriteLine("End of Program");
        }
    }
}
