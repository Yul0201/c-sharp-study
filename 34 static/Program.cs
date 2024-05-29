using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _35_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //특정 개체가 아니라 형식 자체에 속하는 정적 맴버를 정의.
            //정적 맴버는 프로그램이 실행되는 동안 수명이 유지됨.
            //클래스 이름으로 엑세스 됨
            //생성된 인스턴스의 수와 상관 없이 정적 맴버는 항상 한 개만 있음
            //정적 메서드에서 비정적 메서드에 접근할 수 없음. 따라서 Main 메서드에서 비정적 메서드를 호출하거나 맴버에 엑세스 하기 위해 static 을 붙여옴


            //정적 변수 정의 - 변수 타입 앞에 static 한정자를 붙여줌

            var center1 = new CallCenter(201);
            var center2 = new CallCenter(202);

            Console.WriteLine(CallCenter.number); //정적 맴버는 클래스명으로 접근해야 함(액세스)

            //정적 메서드 호출
            CallCenter.Call();

            //인스턴스 메서드 호출
            center1.CallExtensionNumber(); //변수에 할당된 CallCenter 인스턴스의 맴버 메서드 호출
            center2.CallExtensionNumber();
        }
    }
}

//메서드 영역 - 코드에서 저장
//힙은 객체 메모리
//스택은 스레드
