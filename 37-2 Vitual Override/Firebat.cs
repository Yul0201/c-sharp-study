using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_2_Virtual_Override
{
    internal class Firebat : TerranUnit
    {
        //생성자
        public Firebat()
        {
            Console.WriteLine("Firebat 클래스의 생성자");
        }

        public override void Attack()
        {
            //base.Attack();
            base.Reload("화염방사기"); //화염방사기 장전
            Console.WriteLine("{0}이(가) 화염 방사기로 공격합니다.", this.name);
        }
    }
}