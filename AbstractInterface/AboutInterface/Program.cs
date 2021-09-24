using System;
using System.Collections.Generic;

using static System.Console;

namespace AboutInterface
{
    interface IMammal
    {
        public int MammalId { get; set; }
        public int Age { get; set; }

        void Speak();

    }

    class Dog : IMammal
    {
        public float SmellDetectability { get; set; }
        public int MammalId { get; set; }
        public int Age { get; set; }

        public Dog(int _mammalId, int _age)
        {
            this.SmellDetectability = 3.24f;
            this.MammalId = _mammalId;
            this.Age = _age;
        }

        public void Speak()
        {
            WriteLine("wall");
        }
    }

    class Cat : IMammal
    {
        public int MammalId { get; set; }
        public int Age { get; set; }

        public Cat(int _mammalId, int _age)
        {
            this.MammalId = _mammalId;
            this.Age = _age;
        }

        public void Speak()
        {
            WriteLine("meow");
        }
    }
    class Program
    {
        static void AddMammal(List<IMammal> mammals, int _op)
        {
            int _id, _age;

            Write("input id : ");
            _id = int.Parse(ReadLine());
            Write("input age : ");
            _age = int.Parse(ReadLine());

            switch (_op)
            {
                case 1:
                    mammals.Add(new Dog(_id, _age));
                    break;
                case 2:
                    mammals.Add(new Cat(_id, _age));
                    break;

                default:
                    break;
            }

        }
        static void Main(string[] args)
        {
            /* 
             * interface can not be used making instace */

            IMammal[] mammalArr = new IMammal[] { new Dog(3937, 11), new Dog(682,19) };
            IMammal[] mammalArr2 = new IMammal[2];

            /* So U shold better using System.Collection.Generic(List ... etc), 
             * if u want to make dynamic size collectionList */

            List<IMammal> mammals = new List<IMammal>();

            while(true)
            {
                Write("input option : (Exit to input 3");
                int tmp = int.Parse(ReadLine());

                switch(tmp)
                {
                    case 1:
                        Write("input option : ");
                        int op = int.Parse(ReadLine());

                        AddMammal(mammals, op);
                        break;
                    case 2:
                        foreach(IMammal e in mammals)
                        {
                            Dog tmpClass = e as Dog;
                            if (tmpClass != null)
                            {
                                WriteLine($"Dog({tmpClass.MammalId}) : {tmpClass.Age}, {tmpClass.SmellDetectability}");
                                e.Speak();
                            }                                
                            else
                            {
                                WriteLine($"Cat({e.MammalId}) : {e.Age}");
                                e.Speak();
                            } 
                        }
                        break;
                    case 3:
                        return;
                }
            }

            



        }
    }
}
