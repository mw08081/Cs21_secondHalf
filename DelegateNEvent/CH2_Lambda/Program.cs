using System;
using System.Collections.Generic;

using static System.Console;

namespace CH2_Lambda
{
    delegate bool Predicate(int num);
    delegate bool PredicateCondition(int num, List<int> spawnEnemy);

    class IntList
    {
        List<int> NumberList { get; set; }


        public IntList(int[] arr)
        {
            NumberList = new List<int>();

            foreach (int e in arr)
                NumberList.Add(e);
        }

        public void Print()
        {
            foreach (int e in this.NumberList)
                WriteLine(e);
        }

        public List<int> FindAll(Predicate match)
        {
            List<int> tmpList = new List<int>();

            foreach (int e in this.NumberList)
                if (match(e))
                    tmpList.Add(e);
            
            return tmpList;
        }

    }

    class EnemyIdManager
    {
        List<int> BoseList { get; set; }

        public EnemyIdManager()
        {
            this.BoseList = new List<int>() { 2365, 8456, 2845, 3825, 3816 };
        }

        public List<int> FindEnemey(PredicateCondition match, List<int> spawnList)
        {
            List<int> tmpList = new List<int>();

            if (null != match)
            {
                foreach(int e in this.BoseList)
                {
                    if (match(e, spawnList))
                        tmpList.Add(e);
                }
            }
            return tmpList;
        }
        
    }

    class Program
    { 
        static void Main(string[] args)
        {
            /*      Basic lambda function Test
             *      
             */
             
            List<int> intList = new List<int>() { 3524, 6546, 7447, 9483 };
            List<int> conditionList = intList.FindAll((num) => { return num >= 5000; });

            Write("Basic lambda function test : ");
            foreach (int e in conditionList)
                Write($"{e}, ");
            WriteLine();


            /*      Trying to make List<int>.FindAll(Predicate match)
             * 
             */
            IntList list = new IntList(new int[] { 1, 5, 10, 100, 200, 300 });
            List<int> predicateList = list.FindAll((num) =>
            {
                return num >= 100;
            });

            Write("Trying to make List<int>.FindAll(predicate match) : ");
            foreach (int e in predicateList)
                Write($"{e}, ");
            WriteLine();


            /*      Make Custom PredicateFunction
             * 
             */
            EnemyIdManager enemyIdManager = new EnemyIdManager();

            List<int> spawnList = new List<int>() { 2462, 7245, 9346, 2845, 7344, 2335, 8456, 3816 };
            PredicateCondition predicateCondition = new PredicateCondition((id, spawnList) =>
            {
                foreach (int e in spawnList)
                    if (id == e)
                        return true;

                return false;
            });

            List<int> boseList = enemyIdManager.FindEnemey(predicateCondition, spawnList);

            Write("Making Custom PredicateFunction Test : ");
            foreach (int e in boseList)
                Write($"{e}, ");
            WriteLine();
        }
    }
}
