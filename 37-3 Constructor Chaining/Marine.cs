using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_3_Constructor_Chaining
{
    internal class Marine : TerranUnit

    {
        //상속의 chaining
        public Marine() : base()  //없으면 암시적으로 동작
        {
            Console.WriteLine("Marine 의 생성자");
        }

        public Marine(string name) : base(name)
        {
            Console.WriteLine("매개변수 1개 있는 Marine 생성자 : {0}", this.name);
        }

        public Marine(string name, int damage) : base(name, damage)
        {
            Console.WriteLine("매개변수 2개 있는 Marine 생성자, name : {0}, damage: {1}", this.name, this.damage);
        }


        //기본생성자의 chaining
        //private string name;

        //private int damage;

        //private int maxHp;


        //public Marine(string name) : this(name, 0, 0)

        //{

        //    //this.name = name;

        //    Console.WriteLine("2");

        //}


        //public Marine(string name, int damage) : this(name, damage, 0)

        //{

        //    Console.WriteLine("3");

        //    //this.name = name;

        //    //this.damage = damage;

        //}


        //public Marine(string name, int damage, int maxHp) //매개변수 수가 가장 많은 생성자에서만 할당

        //{

        //    Console.WriteLine("1");


        //    this.name = name;

        //    this.damage = damage;

        //    this.maxHp = maxHp;

        //}

    }

}
