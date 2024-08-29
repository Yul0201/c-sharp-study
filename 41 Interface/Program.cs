using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //사용자 정의 형식이며 추상화(여러 사물 또는 개념 따위의 개별자들로부터 공통점을 파악하고 추려내는 것)를 구현하는 방법 중 하나임.다중 상속을 하기 위함임
            //인터페이스 정의(메서드 정의만 포함_인터페이스에 정의된 메서드는 본문을 가질 수 없음)
            //interface Izerg // I대문자를 사용해서 인터페이스임을 표현
            //{
            //string name; //인터페이스는 필드를 포함할 수 없음
            //void Burrow(); //정의만 할 수 있음. 내부에 선언된 모든 메서드는 추상 메서드임
            //private/public/protected void Burrow(); //접근제한자 사용불가 (public은 암시적이므로 명시적 사용불가)
            //}

            //클래스 또는 구조체는 :을 사용하여 하나 이상의 인터페이스를 구현할 수 있음. 인터페이스를 구현하는 클래스는 인터페이스에 선언된 모든 메서드를 구현해야 함

            //Hydralisk hydralisk = new Hydralisk();
            //hydralisk.Burrow();
            //hydralisk.RecoveryHp();

            //new Izerg(); 인터페이스는 인스턴스 생성 불가
            //Izerg izerg = new Hydralisk(); // 업캐스팅(암시적)
            //izerg.Burrow(); //izerg 변수값은 HydraLisk 인스턴스임
            //izerg.RecoveryHp();

            IMetamorph hydralisk = new Hydralisk();
            hydralisk.Morph("러커");
        }
    }
}
