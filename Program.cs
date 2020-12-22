using System;

namespace lab1
{
    
    class A
    {
        public int a;
        public int b;
        public int c
        {
            get { return a *= (a + b); }
            set { a = value; }
        }
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public A() { }
    }

    class B : A
    {
        public int d;

        public int c2
        {
            get
            {
                while (d < 10)
                    d = d + a + b;
                return d;
            }
            set { c2 = value; }
        }

        public int i;
        public int[] arr;

        public B(int a, int c2)
        {
            arr = new int[a];

            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = c2 * i;
            }
            foreach (int i in arr)
                Console.WriteLine("Значения массива: " + i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A classA = new A(2, 1);
            B classB = new B(5, 2);
            Console.WriteLine("Свойство с2: " + classB.c2);
        }
    }
}