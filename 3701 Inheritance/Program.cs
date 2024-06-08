using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //캡슐화 및 다형성과 함께 상속은 객체 지향 프로그래밍의 세가지 주요 특성 중 하나입니다.
            //다른 클래스에 정의된 동작을 재사용, 확장 및 수정하는 새 클래스를 만들 수 있음
            //상속을 사용하는 이유 - 코드 기능을 재사용하고 구현 시간을 단축
            //새 클래스를 만들 때 기존 클래스의 필드와 메서드를 재사용 함


            //맴버가 상속되는 클래스를 기본 클래스(부모)라고 하고 해당 맴버를 상속하는 클래스를 파생 클라스(자식)라고 함
            //class 자식이름 : 부모이름 ":" 기호로 상속함
            //{

            //}

            //protected 접근제한자 - protected 멤버는 해당 클래스 내에서 파생 클래스 인스턴스가 액세스 할 수 있음(부모클래스에서 정의된 맴버에 파생클래스만 접근 가능하고 외부에서는 접근 불가)

            Marine marineA = new Marine();
            marineA.Init("마린A", 10);
            marineA.damage = 2;

            Marine marineB = new Marine();
            marineB.Init("마린B", 10);
            marineB.damage = 2;

            Medic medic = new Medic();
            medic.healValue = 3;

            marineB.Attack(marineA);

            Console.WriteLine("마린A의 체력 : {0}", marineA.GetHp());
            Console.WriteLine("마린B의 체력 : {0}", marineB.GetHp());

            medic.Heal(marineA);

            Console.WriteLine("마린A의 체력 : {0}", marineA.GetHp());
            Console.WriteLine("마린B의 체력 : {0}", marineB.GetHp());
        }
    }
}
