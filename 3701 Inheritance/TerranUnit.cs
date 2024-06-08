using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_inheritance
{
    class TerranUnit : StarcraftUnit
    {
        protected int hp;
        protected int maxHp;

        //TerranUnit 생성자
        public TerranUnit()
        {
            Console.WriteLine("TerranUnit 클래스 생성자");
        }
        public void Init(string name, int maxHp)
        {

            this.name = name;

            this.maxHp = maxHp;
            this.hp = this.maxHp;

        }
        public void Hit(int damage)
        {
            this.hp -= damage;

            Console.WriteLine("{0}이 피해 {1}를 받았습니다.", this.name, damage);
        }

        public int GetHp()
        {
            return this.hp;
        }

        public void AddHp(int heal)
        {
            this.hp += heal;

            Console.WriteLine("{0}의 체력이 회복 되었습니다.", this.name);
            if (this.hp >= maxHp)
            {
                this.hp = this.maxHp;
            }
        }
    }

}