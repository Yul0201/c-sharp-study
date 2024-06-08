using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_3_Constructor_Chaining

{

    internal class Program

    {

        static void Main(string[] args)

        {

            //생성자 연결은 생성자가 동일한 또는 기본 클래스의 다른 생성자를 호출하는 접근 방식
            //여러 생성자를 정의하는 클래스가 있을 때 사용

            //기본 생성자의 객체 연결

            //new Marine("마린1");

            //new Marine("마린2", 8);

            //new Marine("마린3", 8, 10);



            //객체의 생성자 상속 연결

            //new Marine();
            //new Marine("YUL");
            new Marine("Yul", 8);
        }

    }

}
