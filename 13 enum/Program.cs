using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_enum
{
    class Program
    {
        // 이 곳에서 열거형식 정의
        enum Season 
        {
            Spring = 100,     
            Summer = 200,
            Autumn = 300,
            Winter = 400
        }


        static void Main(string[] args)
        {
            //변수 앞에는 변수 타입이 붙음. ->  int, float, string, char, bool, object
            //값에는 종류가 있고 종류에 따라 사용하는 키워드가 다름. 미리 정의되어 있는 키워드 외에사용자가 직접 타입을 만들수 있음.
            //상수를 묶어 열거형이라는 이름으로 사용자 정의 타입을 만들어볼 예정
            //열거형은 상수들의 집합 
            //enum 키워드를 정의하고 열거형 멤버의 이름을 지정
            //기본적으로 열거형 멤버의 연결된 상수 값은 int 형식임
            //0으로 시작하고 정의된 텍스트 순서에 따라 1씩 증가
            //연결된 상수 값을 명시적으로 지정 가능
            //열거형식 정의는 class 내부 또는 namespace 내부에서 할 것

            /*
            Enum Season //의미있는 이름으로 짓기
                {
                Spring,   // 상수들
                Summer,
                Autumn,
                Winter
                }
            

            Enum State
            {
                Idle = 0,
                Attack = 100,
                Run = 200,
                Die = 300;
            }
            */

            //정의된 열거형 Season 타입의 변수를 선언하는 방법
            Season season; // 열거형식 변수 정의, Season (변수타입) season (변수명) 
            season = Season.Spring;
            Console.WriteLine(season);


        }
    }
}
