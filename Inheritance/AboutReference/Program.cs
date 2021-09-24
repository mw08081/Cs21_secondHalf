using System;
using static System.Console;

namespace AboutReference
{
    class Base
    {
        public int refNum;

        public Base(int _refNum)
        {
            this.refNum = _refNum;
        }

        public void Print()
        {
            WriteLine($"this.refNum : {this.refNum}");
        }

    }

    struct Point
    {
        public int x;
        public int y;

        public Point(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public void Print()
        {
            WriteLine($"x : {this.x}, y : {this.y}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base baseClass = new Base(30);
            Base copyClass = baseClass;

            baseClass.Print();
            copyClass.Print();

            copyClass.refNum += 20;

            baseClass.Print();
            copyClass.Print();


            Point point = new Point(3,5);
            Point copyPoint = point;

            point.Print();
            copyPoint.Print();

            copyPoint.x += 2;

            point.Print();
            copyPoint.Print();

        }
    }
}
