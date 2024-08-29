using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //인덱서에서는 클래스나 구조체의 인스턴스를 배열처럼 인덱싱할 수 있음
            //인텍싱 값은 형식이나 인스턴스 멤버를 명시적으로 지정하지 않고 설정하고 검색할 수 있음
            //인덱서는 내부 컬렉션 또는 배열을 캡슐화하는데 주로 사용되는 형식에서 자주 구현됨
            //인덱스 매개 변수 형식을 정수로 제한되지 않음. 문자열 사용 

            //NameCollection collection = new NameCollection(5);
            //collection[0] = "Hong";
            //Console.WriteLine("->{0}", collection[0]);

            Marine[] marines =
            {
                new Marine("Hong"),
                new Marine("Lim"),
                new Marine("Jang")
            };
            MarineGroup group = new MarineGroup(marines);
            //Console.WriteLine("->{0}", group[0]);

            foreach (Marine marine in group)
            {
                Console.WriteLine("->{0}", marine.Name);
            }

        }
    }
}
