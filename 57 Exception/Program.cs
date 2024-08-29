using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //예외처리는 try, catch, finally, throw를 기반으로 함.
            //try - 특정 예외가 활성화된 코드 블록을 식별하며 뒤에 하나 이상의 catch 블록이 옴
            //catch - 문제를 처리하려는 프로그램의 위치에서 예외 처리기로 예외를 포착. catch 절은 2개 이상 사용 가능하며 이 경우 순서대로 검사되므로 순서가 중요함(더 구체적->덜 구체적)
            //finally - 예외가 발생했는지 여부에 관계없이 주어진 명령문 세트를 실행하는 데 사용
            //throw - 프로그램에서 명시적으로 예외를 생성할 수 있음
            // try-catch, try-finally, try-catch-finally 형식으로 작성 가능
            //부동소수점(Double, float)의 값을 0으로 나누면 예외가 throw 되지 않음(IEEE 754 산술에 따라 양의 무한대, 음의 무한대 또는 NaN(not a number)이 발생함)
            //try-catch-finally 는 try 블록에서 리소스를 얻어 사용하고 catch 블록에서 예외 상황을 처리하고 finally 블록에서 리소스를 해제함

            new APP();
        }
    }
}
