using System;
using System.Collections.Generic;

using static System.Console;

namespace CH4_Action
{
    class Program
    {
        static void UnoAction(Action PrintMenu)
        {
            PrintMenu();
        }

        static void DosAction(Action printMenu, Action<int> squring)
        {
            int num = int.Parse(ReadLine());

            printMenu();
            squring(num);
        }

        static void Main(string[] args)
        {
            /*
            Action ac1 = () =>
            {
                WriteLine("Print Menu");
            };

            Action<int> ac2 = (num) =>
            {
                WriteLine($"{num * num}");
            };

            Action<double, int> ac3 = (dNum, iNum) =>
            {
                dynamic tmp = dNum + iNum;

                WriteLine($"{tmp}({tmp.GetType()})");
            };

            ac1();
            ac2(3);
            ac3(3.14, 3);
            */

            /*
             *          if u write lambdaFunction in specificFunction for parameter, 
             *              u dont need to write ';' at end of {}
             *              
             *          But if u write lambdaFunction as follows, u should write ';' at end of {}
             *          
             *          1. 
             *          Action ac = () => 
             *          {
             *              ...
             *          };
             *          
             *          2. 
             *          PredicateCondition predicateCondition = new PredicateCondition((id, spawnList) =>
             *          {
             *                foreach (int e in spawnList)
             *                       if (id == e)
             *                            return true;
             *
             *                return false;
             *          });
             */

            UnoAction(() => { WriteLine("Hello!!"); });
            DosAction(
                () =>
            {
                WriteLine("HelloWorld");
            },
                (num) =>
            {
                WriteLine($"{num * num}");
            });

        }
    }
}
