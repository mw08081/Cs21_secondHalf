using System;

using static System.Console;

namespace AboutCatch
{
    class Program
    {
        static int GetNum1()
        {
            int tmp = int.Parse(ReadLine());
            if (tmp >= 100)
                throw new Exception("plz input number that under 100");


            WriteLine("goto Main()...");
            return tmp;
        }
        static int GetNum2()
        {
            int tmp = int.Parse(ReadLine());



            WriteLine("goto Main()...");
            return tmp;
        }
        static int GetNum3()
        {
            int tmp = int.Parse(ReadLine());



            WriteLine("goto Main()...");
            return tmp;
        }

        static void Main(string[] args)
        {
            int num1, num2, num3;

            try
            {
                /*
                 * u dont have to write thorwKeyword always
                 * if occur error, automatically throw ExceptionMessage
                 * 
                 * But if u want to throw exceptionMessage at no CompileError
                 * For example, method can throw exceptionMessage 
                 *              when someone input value of out of fixed range value
                 *              that isn't compile Error(GetNum1 Function)
                 */


                num1 = GetNum1();
                num2 = GetNum2();
                num3 = GetNum3();
            }
            catch(Exception e)
            {
                WriteLine($"{e.Message}");
            }
        }
    }
}
