using System;
using System.Collections.Generic;

using static System.Console;

namespace AboutDynamic
{
    class Program
    {
        static T AddArray<T>(T[] arrDatas)
        {
            //T temp = 0; Occur Error! (Because T's dataType is fixed on runTime,
            //             but u input already fixed dataType Value(0) in unfixed dataType Value T)
            //object temp = 0; Occur boxing, unboxing(unnecessary work)

            //default input value 0 in valueType variableValue
            //        input value null in referenceType variableValue
            Write($"Default(T) Type : {default(T).GetType()}\nSo dynamic temp value(Type) : ");
            dynamic temp = default(T);
            WriteLine($"{temp}({temp.GetType()})");
            
            for (int i = 0; i < arrDatas.Length; i++)
                temp += arrDatas[i];

            return temp;
        }

        static T SumArray<T>(T[] arrDatas)
        {
            Write($"Default(T) Type : {default(T).GetType()}\nSo T temp value(Type) : ");
            T temp = default(T);
            WriteLine($"{temp}({temp.GetType()})");

            /*
             * Although u knows T's dataType, compiler knows when compile
             * and code doesn't know <temp += arrDatas[i]> 's dataType
             * 
             * So u needs to reduce probability of castingError
             * (dynamaic)casting is way to reduce probability of castingError
             * because dataType will changes more bigger side, if u attach castingOperator on eitherSide
             * 
             * 
             * for (int i = 0; i < arrDatas.Length; i++)
             *   temp += (dynamic)arrDatas[i];
            */

            for (int i = 0; i < arrDatas.Length; i++)
                temp = (dynamic)temp + arrDatas[i];

            return temp;
        }

        static void PrintArray<T>(T[] arrDatas)
        {
            foreach (T e in arrDatas)
                WriteLine("Data : {0}", e);
        }

        static void Main(string[] args)
        {
            int[] intArray = new int[3] { 1, 2, 3 };
            double[] doubleArray = new double[3] { 1.35, 6.43, 7.45 };

            WriteLine($"total Value : {AddArray(intArray)}\n");
            WriteLine($"total Value : {AddArray(doubleArray)}\n");

            WriteLine($"Total Value(SumArray) : {SumArray(intArray)}\n");
            WriteLine($"Total Value(SumArray) : {SumArray(doubleArray)}\n");

            PrintArray(intArray);
        }
    }
}
