using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_2_Virtual_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Virtual 키워드는 기본 클래스에서 정의된 메서드를 파생 클래스에서 재정의 하도록 허용. static, abstract,private 한정자와 함께 사용할 수 없음
            //Override 한정자는 상속된 메서드의 구현을 확장하거나 수정하는 데 필요.
            //base 키워드는 파생 클래스 내에서 기본 클래스의 맴버에 액세스 하는데 사용

            Marine marine = new Marine();
            marine.name = "마린1";

            Firebat firebat = new Firebat();
            firebat.name = "파이어뱃1";

            marine.Attack();
            firebat.Attack();
        }
    }
}
