using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _19_arithmetic_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //후위증가 연산자 - 피 연산자 값을 다른 연산에 먼저 사용하고 값을 1증가 시킴
            int i = 3;
            Console.WriteLine (i);
            Console.WriteLine(i++);
            Console.WriteLine (i);

            //전위증가 연산자 - 피연산자 값을 1증가시키고 다른 연산에 사용합니다.
            float a = 1.5;
            Console.WriteLine (a);
            Console.WriteLine(++a);
            Console.WriteLine(a);

            //후위 감소 연산자 - 피연산자 값을 다른 연산에 먼저 사용하고 값을 1감소 시킴
            int i = 3;
            Console.WriteLine(i);
            Console.WriteLine (i--);
            Console.WriteLine(i);

            //전위 감소 연산자 - 피연산자 값을 1감소 시키고 다른 연산에 사용합니다.
            float a = 1.5:
            console.WriteLine(a);
            Console.WriteLine(--a);
            Console.WriteLine(a);

            //단항
            // +연산자 - 피연산자의 값을 반환
            Console.WriteLine(+4); //output :4 

            //부동 소수점 형식(float) - 실수를 컴퓨터 상에서 근사하여 표현할 때 소수점의 위치를 고정하지 않고 그 위치를 나타내는 수를 따로 적는 것
            Console.WriteLine(5-4.3f); // output : 0.6999998

            //부동 소수점 나머지 -  float 피 연산자의 경우 x 및 y에 대한 x%y의 결과는 다음과 같은 z 값임. 0이 아닌 경우 z의 부호는 x의 부호와 동일
            Console.WriteLine(-5.2f % 2.0f); //output: -1.2

            //복합할당 - 이진 연산자(operator)의 경우 양식의 복합 할당 식
            //x operator =y 식은 다음과 동일 x = x operator y (x 는 한번만 계산)
            int a = 5;
            a += 9;
            Console.WriteLine(a);  //Output = 14

            int a = 5;
            a = a + 9;
            Console.WriteLine(a); //output = 14

            //산술연산자는 우선 순위 있음
            //높음   후위증가 X++ 및 감소 x-- 연산자
            //       전위증가 ++x 및 감소 --X 및 단항 + 및 - 연산자
            //       곱하기* , / 및 % 연산자
            //낮음   가감 + 및 - 연산자


        }

    }
}
