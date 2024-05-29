using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Debug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //syntax 오류(구문오류)
            //잘못된 문법의 사용으로 발생하는 오류. 구문 오류는 컴파일 과정에서 검사되기 때문에 오류를 수정하지 않으면 실행 할 수 없다
            //Console.WriteLine("Hello World!");

            //logical 오류(논리 오류)
            //프로그램이 부정확하게 동작하게 하지만 비정상적으로 종료 또는 충돌 시키지는 않는 버그
            /*int korean = 76;
            int english = 87;
            int average = korean + english / 2;
            Console.WriteLine(average);
            */

            //runtime 오류
            //프로그램이 실행 중일 때 발생하며 프로그램이 비정상적인 동작 또는 종료될 수 있음 e.g. 0으로 나누기, 없는 파일 접근 하기
            int a = 28;
            int b = 0;
            int c = a / b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }
    }
}
