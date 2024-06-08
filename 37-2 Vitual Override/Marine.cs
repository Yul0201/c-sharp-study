using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_2_Virtual_Override
{
    internal class Marine : TerranUnit
    {
        //생성자
        public Marine()
        {
            Console.WriteLine("Marine 클래스의 생성자");
        }

        public override void Attack()
        {
            //base.Attack();
            base.Reload("총"); // 총 장전
            Console.WriteLine("{0}이(가) 총으로 공격합니다.", this.name);
        }
    }
}
