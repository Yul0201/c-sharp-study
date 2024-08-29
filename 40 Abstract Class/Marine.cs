using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Abstact_Class
{
    class Marine : StarcraftUnit
    {
        public Marine()
        {
            Console.WriteLine("Marine 클래스의 생성자");
        }

        //public override void Destory()
        //{
        //    Console.WriteLine("Marine 클래스의 Destroy 메서드");
        //}

        //public override void Destroy() //추상메서드는 암시적 가상 메서드 이므로 상속
        //{
        //    //Console.WriteLine("Marine 클래스의 Destory 메서드 호출됨");
        //}

        //public override void Destroy()
        //{
        //    base.Destroy(); //base 키워드로 부모 클래스의 메서드를 호출
        //    Console.WriteLine("Marine 클래스의 Destroy 메서드 호출");
        //}

        //추상클래스를 상속받은 파생 클래스 Marine 에서는 추상 메서드를 재정의 해야함

        public override void Destroy()
        {
            //base.Destroy(); //base 키워드로 부모 클래스의 메서드를 호출할 수 있지만 추상메서드는 호출할 수 없음
            Console.WriteLine("Marine 클래스의 Destroy 메서드 호출");
        }
    }
}

