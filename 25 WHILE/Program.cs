using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int I = 0; //변수 I 값을 0으로 초기화
            while (I<3) // BOOL 식이 TRUE 일 경우
            {
                Console.WriteLine("HELLO WORLD");
                I++; //후위증가연산자로 다음번 실행 시 + 처리
            }
        }
    }
}
