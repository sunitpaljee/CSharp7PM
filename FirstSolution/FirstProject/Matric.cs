using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class Matric
    {
        int a,b,c,d;
        public Matric(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b; 
            this.c = c; 
            this.d = d;
        }
        public override string ToString()
        {
            return a + " " + b + "\n" + c + " " + d + "\n";
        }
        public static Matric operator + (Matric m1, Matric m2)
        {
            Matric obj = new Matric(m1.a + m2.a, m1.b + m2.b, m1.c + m2.c, m1.d + m2.d);
           return obj;
        }
        public static Matric operator - (Matric m1, Matric m2)
        {
            Matric obj = new Matric(m1.a - m2.a, m1.b - m2.b, m1.c - m2.c, m1.d - m2.d);
            return obj;
        }

    }
}
