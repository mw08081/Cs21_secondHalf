using System;
using System.Collections.Generic;

using static System.Console;

namespace AboutGeneric
{
    class GenericClass<T>
    {
        private T[] Arr { get; set; }

        public GenericClass(T[] _len)
        {
            Arr = _len;
        }

        public void Print()
        {
            foreach (T e in this.Arr)
                WriteLine($"{e}({e.GetType()})");
        }
    }


    class Program
    {
        static void Print<T>(T val)
        {
            WriteLine($"{val}({val.GetType()})");
        }
        static void Print<T>(T[] val)
        {
            foreach (T e in val)
                WriteLine($"{e}({e.GetType()})");
        }

        static void Main(string[] args)
        {
            Print(3);
            Print("minwoo");
            Print<int>(3);
            Print<string>("minwoo");

            int[] intArr = new int[3] { 1, 2, 3 };
            Print(intArr);


            WriteLine();
            GenericClass<int> genericClass = new GenericClass<int>(intArr);
            genericClass.Print();

        }
    }
}
