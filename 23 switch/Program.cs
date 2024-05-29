using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _23_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //지정된 일치 표현식을 기반으로 조건 중 하나의 코드를 실행. 일치식은 char, 문자열, bool, 정수 및 숫자형식 또는 열거형 형식 중 하나여야 하며 case 레이블에는 상수식만 사용
            //switch 문은 하나 이상의 case 블록 및 기본 블록과 쌍을 이룸
            //옵션이 여러개 있을 때 if-else 문 대신 사용 가능
            /*
            switch (Expression) //일치표현식
            {
                case Expression_value1; //case 레이블

                    //case 블록문. 일치 표현식 값과 일치하는 값에 대해 case 코드 블록이 실행됨
                    //             일치 표현식 값과 일치하지 않으면 기본 블록 코드가 실행됨

                    break; //switch 문 종료

                case Expression_value2;


                    break;

                    default;

                    //기본 블록

                    break;

            */
            // 열거 형식 값을 표현식으로 사용
            Enum Seasons
                    {
                        None,
                        Spring,
                        Summer,
                        Autumn,
                        Winter

            Seasons favorite = Seasons.Summer;

                        switch (Seasons.Summner)
                        {
                            case Seasons.Spring:
                                Console.WriteLine("tree and Plant");

                            case Seasons.Summer:
                                Console.WriteLine("poor");

                            case Seasons.Autumn:
                                Console.WriteLine("leaves");

                            case Seasons.Winter:
                                Console.WriteLine("snow");

                                break;


                        }
                    }
            }
        }
    }
}
