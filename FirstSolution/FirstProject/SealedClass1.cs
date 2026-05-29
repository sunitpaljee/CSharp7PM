using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    public abstract class SealedClass1
    {
        int a;
        public virtual void Test()
        {
            Console.WriteLine("Hello");
        }
        public abstract void Show();
    }

    public class TestClass1 : SealedClass1
    {
        public override void Show()
        {
            Console.WriteLine("Implemented");
        }
        public override void Test()
        {
            Console.WriteLine("Hi");
         //base.Test();
        }

    }
    }
