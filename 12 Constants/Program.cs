using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Constants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //수식에서 변하지 않는값이며 변하는 값인 변수와 반대 개념
            //언제든지 변경될 수 있는 정보를 나타낼 때는 상수를 만들지 말 것
            //서비스의 가격, 제품 버전 번호, 회사의 브랜드 이름 저장하지 말 것
            //상수 정의는 const 키워드로 선언하며 변수 앞에 const 를 붙여 주면 됨 
            //const int MaxHp = 10; // 선언과 값할당을 동시에 할 것
            //const int MaxMp; 같이 선언만 하는 것은 불가
            // 선언 후 값을 할당하는 것을 "초기화" 라고 정의
            //int maxHp = 100;
            //maxHp = 120;
            //Console.WriteLine(maxHp);

            const int MaxHp = 100;
            //MaxHp = 120;
            Console.WriteLine(MaxHp);

            const string Monday = "Monday";
            Console.WriteLine(Monday);

            const float PI = 3.14f;
            Console.WriteLine(PI);

        }
    }
}
