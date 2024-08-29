using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //같은 형식의 변수가 여러 개 있다면 배열을 사용

            //정수형 배열 생성
            //사용방법
            //int[] numbers = new int[5];
            //> int number0;
            //  int number1;
            //  int number2;
            //  int number3;
            //  int number4;

            //배열을 생성한다는 것은 배열 인스턴스를 생성하는 것
            //생성된 배열 인스턴스를 변수에 할당하는 방법
            //정수형 배열 변수 선언
            //int[] numbers; //int(배열요소의 형식을 적고) numbers(변수명)
            //int[] numbers = new int[5];  //정수형 배열 변수에 배열 인스턴스 할당, 기본값은 0

            //Console.WriteLine(numbers.Length); // 요소의 총 수를 가지고 옴
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //문자열 배열 인스턴스
            //참조요소는 null로 설정
            //string[] names = new string[5];
            //names[1] = "jack";
            //for (int i = 0; i < names.Length; i++) 
            //{
            //Console.WriteLine("->{0}", names[i]);
            //}
            //결과 names null null null null null //기본값은 null

            //배열은 단일차원, 다차원 또는 가변 일수 있음
            //차원수와 각 차원의 길이는 배열 인스턴스가 생성될 때 설정. 차원 수와 각 차원의 길이는 인스턴스의 수명 동안 변경할 수 없음
            //배열 요소 형식은 배열 형식을 비롯한 어떤 형식도 가능
            //배열 형식은 Array 추상 기본 형식에서 파생된 참조 형식임

            //배열 초기화 - 배열을 선언할 때 배열의 요소를 초기화할 수 있음. 길이 지정자는 초기화 목록의 요소 수에 따라 유추되므로 필요하지 않음
            //int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            // > numbers 1 2 3 4 5

            //암시적으로 형식화된 배열
            //선언 시 배열을 초기화할 때 new 식과 배열 형식을 피할 수 있음
            //int[] numbers = { 1, 2, 3, 4, 5 };
            // > numbers 1 2 3 4 5

            //배열 변수를 만들지 않고 선언할 수 있지만 이 변수에 새 배열을 할당할 때는 new 연산자를 사용해야 함
            //int[] numbers; //배열 변수 선언
            //numbers = new int[] {1,3,5,7,9}; 

            //인덱스를 사용하여 배열의 데이터를 검색/할당할 수 있음

            //인덱스를 사용하여 데이터 검색
            //int[] numbers = new int[] { 1, 3, 5, 7, 9 };
            //Console.WriteLine(numbers[0]);

            //인덱스를 사용하여 데이터 할당
            //int[] numbers = new int[] { 1, 3, 5, 7, 9 };
            //numbers[0] = 2; 
            // { 2, 3, 5, 7, 9 }

            //for 문으로 배열요소를 출력
            //    int[] numbers = new int[] {1,2,3,4,5};

            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            Marine[] marines = new Marine[3];

            marines[0] = new Marine();
            marines[1] = new Marine();
            marines[2] = new Marine();

            for (int i = 0; i < marines.Length; i++)
            {
                marines[i] = new Marine(); //다음과 같이 for 문안에 배열의 요소에 값을 할당할 수 있음
                //Console.WriteLine(marines[i]);
            }

            Console.WriteLine(marines[0]);
            Console.WriteLine(marines[1]);
            Console.WriteLine(marines[2]);
        }
    }
}
