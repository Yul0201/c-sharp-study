using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_static

{

    public class CallCenter

    {

        //정적 맴버 변수 정의

        public static string number;

        //인스턴스 맴버 변수 정의
        public int extensionNumber; //내선번호

        //정적 생성자

        static CallCenter()

        {

            //정적 생성자에서 정적 필드(맴버 변수)를 초기화 할 수 있음
            CallCenter.number = "1588-0000";

            //정적 생성자는 public, private 과 같은 접근 제한자를 쓸 수 없음. 또한 매개변수를 정의할 수 없음

            Console.WriteLine("콜센터 정적 생성자");

        }

        //인스턴스 생성자 - 인스턴스가 생성된 후 호출되는 생성자

        public CallCenter(int extensionNumber) //매개변수로 내선번호 전달

        {

            this.extensionNumber = extensionNumber; //this 키워드를 사용해 클래스의 현재 인스턴스의 맴버변수에 접근(맴법 엑세스 연산자 사용 .(점) 연산자)

            Console.WriteLine("콜센터 인스턴스 생성자");
            Console.WriteLine("내선번호 : {0}", this.extensionNumber); //생성된 인스턴스는 다른 내선번호를 가지게 만듦

        }

        //정적 맴버 메서드
        public static void Call()
        {
            Console.WriteLine("상담 가능한 상담사룰 찾고 있습니다.");
            Console.WriteLine("qkqh");
        }

        //인스턴스 맴버 메서드 (내선번호로 전화 걸기)
        public void CallExtensionNumber()
        {
            Console.WriteLine("내선번호({0})로 전화를 겁니다.", this.extensionNumber);
        }
    }
}
