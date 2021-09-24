using System;
using System.Collections.Generic;

using static System.Console;

namespace AboutQueue
{
    class Program
    {
        static void ShowQueue(Queue<string> que)
        {
            string[] tmp = que.ToArray();

            WriteLine();
            foreach (string e in tmp)
                WriteLine($"{e}");
        }

        static void Main(string[] args)
        {
            Queue<string> waitingQue = new Queue<string>();

            waitingQue.Enqueue("minwoo");
            waitingQue.Enqueue("jack");

            waitingQue.Dequeue();
            WriteLine($"{waitingQue.Dequeue()}");

            waitingQue.Enqueue("chanwoo");
            waitingQue.Enqueue("ACUQA DI PARMA");

            WriteLine($"{waitingQue.Peek()}");
            WriteLine($"{waitingQue.Peek()}");

            /*  Peek() only reference firstData
             *  
            foreach (string e in waitingQue)
                WriteLine($"{waitingQue.Peek()}");
            */

            ShowQueue(waitingQue);
        }
    }
}
