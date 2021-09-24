using System;
using static System.Console;

namespace AboutAsIsKeyword
{
    class Mammal
    {
        protected int mammalID;

        public Mammal(int _mammalID)
        {
            WriteLine("New Mammal (id : {0})", _mammalID);

            this.mammalID = _mammalID;
        }

        public void Next()
        {
            WriteLine("새끼를 낳았습니다");
        }
    }

    class Cat : Mammal
    {
        int maxAge;

        public Cat(int _mammalID, int _maxAge)
            : base(_mammalID)
        {
            WriteLine("New Cat(max age : {0})", _maxAge);

            this.maxAge = _maxAge;
        }

        public void Print()
        {
            WriteLine("Cat maxAge {0}", this.maxAge);
        }
    }

    class Dog : Mammal
    {
        int maxAge;

        public Dog(int _mammalID, int _maxAge)
            : base(_mammalID)
        {
            WriteLine("New Dog(max age : {0})", _maxAge);

            this.maxAge = _maxAge;
        }

        public void Print()
        {
            WriteLine("Dog maxAge {0}", this.maxAge);
        }
    }

    class Program
    {
        static void PrintMaxAge(Mammal mal)
        {
            if (mal is Cat)
            {
                WriteLine("mew");

                Cat tmp = mal as Cat;
                if (tmp != null)
                    tmp.Print();
            }
            else if (mal is Dog)
            {
                WriteLine("wal");

                Dog tmp = mal as Dog;
                if (tmp != null)
                    tmp.Print();
            }
            else
                mal.Next();

        }

        static void Main(string[] args)
        {
            const int CatMammalID = 1324;
            const int CatMaxAge = 50;

            const int DogMammalID = 4684;
            const int DogMaxAge = 22;


            Cat c1 = new Cat(CatMammalID, CatMaxAge);
            Dog d1 = new Dog(DogMammalID, DogMaxAge);

            PrintMaxAge(c1);
            PrintMaxAge(d1);


        }
    }
}
