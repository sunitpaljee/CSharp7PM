using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    internal class LoadDemo
    {
        public void Show()
        {
            Console.WriteLine(1);
        }
		public void Show(int x) 
        {
            Console.WriteLine(2);
        }
		public void Show(string s)
        {
            Console.WriteLine(3);
        }
        public void Show(int x, string s)
        {
            Console.WriteLine(4);
        }
		public void Show(string s, int x)
        {
            Console.WriteLine(5);
            Console.WriteLine();
        }


        //public string Show()      // Invalid
        //{
        //    Console.WriteLine(6);
        //}
        static void Main(string[] args)
        {
            LoadDemo loadDemo = new LoadDemo();
            loadDemo.Show();
            loadDemo.Show(1);
            loadDemo.Show("Hello");
            loadDemo.Show(2, "Hello");
            loadDemo.Show("Hello", 5);
        }

    }
}
