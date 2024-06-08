using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_inheritance
{
    class Marine : TerranUnit
    {
        public int damage;
        //생성자
        public Marine()
        {
            Console.WriteLine("Marine 클래스 생성자");
        }

        public void Attack(TerranUnit target)
        {
            target.Hit(this.damage);
        }
    }
}
