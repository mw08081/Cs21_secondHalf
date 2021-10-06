using System;
using static System.Console;

namespace StructExtensionMethod
{
    public struct point                                         //if u dont assign public, ErrorMSG occur because of difficulty reference to Struct point
    {
        public double x;
        public double y;
    }

    public static class PointExtension
    {
        public static double PrintDistance(this point pt) 
        {
            return (pt.x.Pow(2) + pt.y.Pow(2)).Sqrt();
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
            point pt = new point();
            pt.x = 3.0;
            pt.y = 4.0;

            WriteLine($"x : {pt.x}, y : {pt.y}");
            WriteLine($"O to pt distance : {pt.PrintDistance()}");


        }
    }
}
