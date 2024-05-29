using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _36_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //메서드 오버로딩은 다형성을 구현하는 방법 중 하나이며 동일한 이름을 가진 여러 메서드를 정의 하는 것
            //메서드 오버로딩을 하는 방법- 매개변수의 수 변경, 다른 타입의 매개변수 사용, 서로 다른 타입의 매개변수 순서 변경


            //주의사항 - 반환 타입이 다른 메서드에서의 오버로딩을 허용하지 않음
            /*
            Public int Add (int a, int b)
            {
                return a + b;
            }

            Public float Add(int a, int b)
            {
                return a + b;
            }
            */

            //Calculator calc = new Calculator();
            //int result = calc.Add(1, 2);
            //Console.WriteLine(result);

            //result = calc.Add(1, 2, 3);
            //Console.WriteLine(result);

            //calc.Subtract(1.3f, 1.5f);
            //calc.Subtract(5, 1.5f);
            //calc.Subtract(10, 5);

            //calc.Multiple(1.5f, 2);
            //calc.Multiple(2, 1.5f);

            //생성자 오버로딩

            Hero hong = new Hero();
            Hero lim = new Hero("임꺽정");
            Hero jang = new Hero("장길산",3,10);

        }
    }
}
