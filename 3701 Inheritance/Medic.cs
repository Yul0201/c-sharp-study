using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_inheritance
{

    class Medic : TerranUnit
    {
        public int healValue;

        public Medic()
        {
            Console.WriteLine("Medic 클래스 생성자");
        }


        public void Heal(TerranUnit target)
        {
            target.AddHp(this.healValue);
        }
    }
}

namespace _37_inheritance
{
    internal class StarcraftUnit
    {
        public string name;
        //생성자
        public StarcraftUnit()
        {
            Console.WriteLine("StarcraftUnit 생성자");
        }
    }
}

