using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var는 변수 선언 시 형식을 직접 선언한 것처럼 컴파일러가 형식을 결정합니다.
            //var hp = 10; var 키워드로 hp 변수 선언하고 값 할당
            //var 키워드 사용 시 주의사항
            // var armor;  -> 정의만 해서는 안됨 var armor = 12; 와 같은 값할당 필수

            /*
            int hp;
            hp = 10;
            Console.WriteLine(hp);

            float damage = 12.3f;
            Console.WriteLine(damage);

            string name = "홍길동";
            Console.WriteLine(name);

            bool isTest = true;
            Console.Write(isTest);

            char word;
            word = 'a';
            Console.WriteLine(word);

            object obj = new object();
            Console.WriteLine(obj);
            */

            var hp = 10;
            Console.WriteLine(hp);

            var damage = 12.3f;
            Console.WriteLine(damage);

            var name = "홍길동";
            Console.WriteLine(name);

            var word = 'a';
            Console.WriteLine(word);

            var isTest = true;
            Console.WriteLine(isTest);

            var obj = new object();
            Console.WriteLine(obj);



        }
    }
}
