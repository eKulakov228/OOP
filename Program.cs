using System;

namespace lab4
{

    class A
    {
        public int a = 2, b = 3;
        private bool state = false;

        public A()
        {
            a = 2;
            b = 3;
            state = false;
        }

        public bool State
        {
            set
            {
                state = value;
            }
        }
        public float c
        {
            get
            {
                if (state)
                {
                    return a / b;
                }
                else
                {
                    return a - b;
                }
            }
        }
    }

    class B : A
    {
        private float d;
        public float[] arr1;
        private float[] arr2 = { 0.5f, 1.5f, 2.5f, 3.5f, 4.5f };

        public float this[int index]
        {
            get { return arr1[index]; }
            set { arr1[index] = value; }
        }

        public float this[short index]
        {
            get { return arr2[index]; }
            set { arr2[index] = value; }
        }

        public B(float d)
        {
            this.d = d;
        }

        public B() : base()
        {
            arr1 = new float[(int)a];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = c2 * i;
            }
        }

        public float c2
        {
            get
            {
                if (d > 2)
                {
                    return base.c + d;
                }
                else
                {
                    return base.c - d;
                }
            }
        }
    }

    class C<T>
    {
        public static string staticField;
        public T currentValue;
    }

    public class Program
    {
        static void Main(string[] args)
        {
            B classB = new B();
            Console.WriteLine("First array: ");
            for (int i = 0; i < classB.a; i++)
            {
                Console.WriteLine(classB[i]);
            }
            Console.WriteLine("Second array: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(classB[(short)i]);
            }

            C<int> classC1 = new C<int>();
            C<string> classC2 = new C<string>();
            C<int>.staticField = "New static value";
            classC1.currentValue = 13;
            classC2.currentValue = "String";

        }
    }
}