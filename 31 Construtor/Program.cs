using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _31_Construtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //클래스 내부에 정의된 특수한 메서드(속성을 초기화 하는 것. 예를 들어 클래스에서 차를 정의하고 속성은 생성자를 통해서 빨간차, 파란차로 정의)
            //생성자는 이름이 해당 형식의 이름과 동일한 메서드이며 메서드 이름과 매개 변수 목록만 포함되고 반환 형식은 포함되지 않습니다.
            //일반 생성자는 정의 후 호출을 통해 실행되나 생성자 메서드는 객체 생성 시 자동으로 호출

            //매개변수가 있는 생성자일 경우 인수를 전달해야 함


            Car acar = new Car("santa Fe");
            acar.IsEqualsWithParam("bjhjh Fe");
        }
    }
}
