using System;

namespace AboutCustomException
{
    class Program
    {
        class MyException : Exception
        {
            public int Num { get; set; }

            public MyException()
                :base()
            {

            }

            public MyException(int _num)
            {
                this.Num = _num;
            }
        }

        static void Main(string[] args)
        {
            

            try
            {
                int num = int.Parse(Console.ReadLine());

                if (!(num >= 1 && num <= 9))
                    throw new MyException(num);
            }
            catch(MyException e) when(e.Num <= 0)
            {
                Console.WriteLine("plz input bigger then 0");
                Console.WriteLine(e.StackTrace);
            }
            catch(MyException e) when(e.Num >= 10)
            {
                Console.WriteLine("plz input smaller then 10");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("u input right Number");
            }





        }
    }
}
