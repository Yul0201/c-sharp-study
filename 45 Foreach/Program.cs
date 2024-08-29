using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //컬렉션(배열 또는 목록)의 요소를 반복하는데 사용됨.
            //배열에 있는 각 요소에 접근

            // for 문으로 접근
            //int[] numbers = { 1, 3, 5, 7 };

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //foreach 문으로 정의
            //foreach (int number in numbers) //num 변수는 읽기 전용 지역 변수이므로 요소를 수정하지 말 것
            //{
            //    Console.WriteLine(number);
            //}

            marine[] marines = new marine[]
            {
                new marine("hong"),
                new marine("lim"),
                new marine("jang")
            };

            for (int i = 0; i < marines.Length; i++)
            {
                Marine marine = marines[i];
                Console.WriteLine(marine.name);
            }

            //foreach (Marine marine in marines)
            //{
            //    Console.WriteLine(marine.name);
            //}

            //MarineGroup group = new MarineGroup(marines);
            //foreach (Marine marine in group)
            //{
            //    Console.WriteLine(marine.name);
            //}

        }
    }
}
