using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_1_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //캡슐화, 다형성, 상속은 주요 특성. 다른 클래스에 정의된 동작을 재사용, 확장 및 수정하는 새 클래스 생성 가능
            //맴버가 상속되는 클래스를 기본 클래스(부모)라 하고 맴버를 상속하는 클래스를 파생클래스(자식)라 함
            //기호로 상속 가능 -> class 파생클래스(자식) : 부모클래스(부모)
            //인스턴스 생성하고 맴버 액세스 연산자 (객체.맴버변수명)를 통해서 맴버 접근 가능하며 부모클래스에서 정의된 메서드도 사용 가능(marine(객체).Attack(메서드명)), 그러나 부모가 둘은 안됨
            //상속을 하는 이유는 코드를 재사용 및 빠르게 하기 위해서임. 새 클래스를 만들 때 기존 클래스의 필드와 메서드를 재사용
            //protected 접근제한자 : protected 멤버는 해당 클래스 내에서 파생 클래스 인스턴스가 액세스 할 수 있음. 부모클래스에서 정의된 맴버에 파생클래스만 접근 가능하고 외부에서는 접근 불가
            //
        }
    }
}
