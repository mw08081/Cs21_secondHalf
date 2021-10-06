using System;

using static System.Console;

namespace ExtensionMethod
{
    public static class intExtension
    {
        public static int Pow(this int powValue, int powCnt)
        {
            int tmp = 1;

            for (int i = 0; i < powCnt; i++)
                tmp *= powValue;

            return tmp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"int.pow(3,3) = {3.Pow(3)}");
            WriteLine($"int.pow(5,3) = {5.Pow(3)}");
        }
    }
}
