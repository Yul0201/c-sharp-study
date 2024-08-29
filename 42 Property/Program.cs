using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Property
{
    class Program
    {
        //속성(=메서드 속성을 가지고 있음)이란 필드의 값을 읽거나 쓰거나 계산하는 매커니즘을 제공하는 멤버
        //get 속성 접근자는 속성값을 반환하는데 사용
        //set 속성 접근자는 개 값을 할당하는 데 사용
        //value 키워드는 set 접근자가 할당하는 값을 정의

        //속성 정의
        static void Main(string[] args)
        {
            //기본 생성자 출력 시 사용
            //Marine marine = new Marine { Name = "jill" }; //개체 이니셜라이저

            //Console.WriteLine("name : {0}", marine.Name); // get 속성 반환

            //매개변수 있는 생성자
            //Marine marine = new Marine("홍길동") { Damage= 1}; //개체 이니셜라이저를 통해 속성에 접근
            //Console.WriteLine("name : {0}, damage : {1}", marine.Name, marine.Damage);

            //접근 가능한 필드로 개체 이니셜라이저 사용하는 방법
            Marine marine = new Marine("홍길동") { name = "임꺽정", damage = 1 };
            Console.WriteLine("{0},{1}", marine.name, marine.damage);
        }


    }
}
