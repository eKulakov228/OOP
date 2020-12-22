using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            A classA = new A();
            Console.WriteLine("Значение свойства с: " + classA.c);
            Console.ReadKey();
        }
    }

    class A
    {
        private int a = 3;
        private int b = 5;

        public int c
        {
            get { return a *= (a + b); }
        }
    }
}