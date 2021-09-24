using System;
using System.Collections.Generic;

using static System.Console;

namespace AboutAbstract
{
    abstract class Army
    {
        public abstract int Hp { get; set; }
        public int Speed { get; set; }

        public abstract void Move();

        public virtual void Heal()
        {
            WriteLine("Heal!!");
        }
        public virtual void Attack()
        {
            WriteLine("Attack!!");
        }
    }

    class Soldier : Army
    {
        public override int Hp { get; set; }
        public Soldier()
        {
            this.Hp = 520;
        }

        public override void Move()
        {
            WriteLine($"move(speed : {this.Speed}");
        }

        public override void Attack()
        {
            base.Attack();
        }
    }

    class Healer : Army
    {
        public override int Hp { get; set; }
        public Healer()
        {
            this.Hp = 230;
        }

        public override void Move()
        {
            WriteLine($"move(speed : {this.Speed}");
        }

        public override void Heal()
        {
            base.Heal();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Army[] armyArr = new Army[2];
            armyArr[0] = new Soldier();
            armyArr[1] = new Healer();

            foreach(Army e in armyArr)
            {
                if(e is Soldier)
                {
                    WriteLine($"{ e.Hp}");
                    e.Move();
                    ((Soldier)e).Attack();                  //it's more safety
                }
                else
                {
                    WriteLine($"{e.Hp}");

                    e.Move();
                    e.Heal();
                }
            }
        }
    }
}
