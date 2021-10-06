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

    public static class doubleExtension
    {
        public static double Pow(this double powValue, int powCnt)
        {
            double tmp = 1;

            for (int i = 0; i < powCnt; i++)
                tmp *= powValue;

            return tmp;
        }

        public static double Sqrt(this double sqrtValue)
        {
            double x = 2;

            for (int i = 0; i < 10; i++)
                x = (x + (sqrtValue / x)) / 2;

            return x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"int.pow(3,3) = {3.Pow(3)}");
            WriteLine($"int.pow(5,3) = {5.Pow(3)}");

            WriteLine($"double.pow(2.5,2) = {2.5.Pow(2)}");
            WriteLine($"double.sqrt(2) = {2.0.Sqrt()}");
        }
    }
}
