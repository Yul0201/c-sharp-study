using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_3_Constructor_Chaining
{
    internal class TerranUnit
    {
        protected string name;
        protected int damage;

        public TerranUnit()
        {
            Console.WriteLine("TerranUnit의 생성자");
        }

        public TerranUnit(string name) : this(name, 0)
        {
            this.name = name;
            Console.WriteLine("매개 변수 1개 있는 TerranUnit의 생성자");
        }

        public TerranUnit(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
            Console.WriteLine("매개 변수 2개 있는 TerranUnit의 생성자");
        }
    }
}

