using System;
using System.Collections.Generic;

using static System.Console;

namespace AboutStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            WriteLine($"{stack.Pop()}");

            stack.Push(4);
            WriteLine($"{stack.Pop()}");

            foreach (int e in stack)
                WriteLine($"{e}");
        }
    }
}
