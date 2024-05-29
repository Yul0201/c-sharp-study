using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(초기화;조건;반복자) { }
            //초기화 : 루프 진입 전 한번만 실행되는 초기화 섹션, for 문 외부에서 액세스 불가
            //조건 : 다음 반복 여부 결정
            //반복자 : 루프의 본문을 실행할 때마나 수행되는 작업을 정의하는 반복자

            for (int i = 0; i < 3; i++)  //반복자 섹션에는 세미콜론; 이 없다
            {
                Console.WriteLine("Hello");
            }


        }
    }
}
