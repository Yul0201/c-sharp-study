using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_2_Virtual_Override
{
    internal class TerranUnit
    {
        public string name;
        //생성자
        public TerranUnit()
        {
            Console.WriteLine("TerranUnit 클래스의 생성자");
        }

        public virtual void Attack()
        {
            Console.WriteLine("{0}이(가) 공격 합니다", this.name);
        }

        protected void Reload(string weaponName)
        {
            Console.WriteLine("{0}이(가) {1}을 장전을 합니다", this.name, weaponName);
        }
    }
}
