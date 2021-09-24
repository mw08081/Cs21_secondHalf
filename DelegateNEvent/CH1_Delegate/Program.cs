using System;

using static System.Console;

namespace CH1_Delegate
{
    class Program
    {
        delegate void delegateFunc(int num);

        static void Doubling(int num)
        {
            WriteLine($"{num + num}");
        }
        static void Squaring(int num)
        {
            WriteLine($"{num * num}");
        }
        

        static void Main(string[] args)
        {
            delegateFunc dF;
            dF = new delegateFunc(Doubling);

            dF(4);

            dF += Squaring;
            dF(5);

            dF -= Doubling;
            dF(6);

            dF = delegate {
	

        	};
        }
    }
}
