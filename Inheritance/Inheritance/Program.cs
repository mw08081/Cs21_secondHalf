using System;

using static System.Console;

namespace AboutVirtual
{
    class Mammal
    {
        protected int mammalId;

        public Mammal(int _mammalId)
        {
            this.mammalId = _mammalId;

            WriteLine($"mammal id {this.mammalId}");
        }


        public virtual void run()
        {

            WriteLine("Base Run()");
        }
          
    }

    class Dog : Mammal
    {
        public int maxAge;

        public Dog(int _mammalId, int _maxAge)
            : base(_mammalId)
        {
            this.maxAge = _maxAge;

            WriteLine($"Dog maxAge : {this.maxAge}");
        }

        //Becase of "//", if dog Class call run Method ,  maybe call baseClass' runMethod
        //public override void run()
        //{
        //    WriteLine("dog is running...");
        //}

    }


    class Cat : Mammal
    {
        public int maxAge;

        public Cat(int _mammalId, int _maxAge)
            : base(_mammalId)
        {
            this.maxAge = _maxAge;

            WriteLine($"Cat maxAge : {this.maxAge}");
        }

        public override void run()
        {
            WriteLine("cat is running...");
        }

    }

    class Program
    {
        private static void MammalRun(Mammal[] mammals, int max)
        {
            for (int i = 0; i < max; i++)
            {
                //this code can be used at u didnt write override run function Code on Base Class 
                /*
                if(mammals[i] is Dog)
                {
                    Dog tmp = mammals[i] as Dog;

                    tmp.run(); 
                }
                else
                {
                    Cat tmp = mammals[i] as Cat;

                    tmp.run();
                }
                */

                //if u didnt write override keyworld on DerivedClass, this code might call BaseClass' Run() function
                mammals[i].run();
            }
        }
        static void Main(string[] args)
        {
            Mammal[] mammalArr = new Mammal[3];

            int max = 0;

            mammalArr[0] = new Dog(827, 25); max++;
            mammalArr[1] = new Cat(395, 50); max++;

            Dog d1 = new Dog(342, 50);

            d1.run();

            MammalRun(mammalArr, max);


        }
    }
}
