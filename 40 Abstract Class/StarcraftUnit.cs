using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Abstact_Class
{
    abstract class StarcraftUnit : StarcraftObject // 추상클래스에서 추상클래스를 상속    
    {
        public string name;
        public StarcraftUnit()
        {
            Console.WriteLine("StarcraftUnit 생성자");
        }

        //public abstract void Destroy(); //추상메서드이며 본문이 있으면 안됨. 따라서 { }를 삭제하고 ; 로 메서드 종료. 추상메서든 암시적 가상 메서드
        //{
        //Console.WriteLine("Destroy 메서드 호출"); 일반 메서드 호출 시
        //}

        //public override void Destory()
        //{
        //    base.Destroy();
        //    Console.WriteLine("StarcraftUnit 클래스의 Destory 메서드 호출");
        //}

        public override abstract void Destroy(); //부모클래스가 일반 클래스라면 가상 메서드를 추상 메서드로 재정의 가능
        //{
        //    base.Destroy();
        //}
    }
}

