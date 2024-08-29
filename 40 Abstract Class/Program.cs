using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Abstact_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //추상이랑 여러 사물 또는 개념 따위의 개별자들로 부터 공통점을 파악하고 추려 내는 것을 일컬음
            //일반적으로 여러 파생 클래스에서 공유할 수 있는 기본 클래스의 공통적인 정의를 제공하는 것
            //멤버를 구현할 수 있음
            //추상 메서드는 암시적으로 가상 메서드 임. 추상메서드 선언은 추상 클래스에서만 허용
            //추상클래스의 파생 클래스에서는 모든 추상 메서드를 구현해야 함
            //추상 클래스는 또 다른 추상 클래스를 상속할 수 있음
            //추상 클래스는 일반 클래스를 상속할 수 있음
            // 추상클래스의 기본 클래스가 가상 메서드를 정의하고 있다면 추상 메서드로 재정의 할 수 있음

            //추상클래스의 정의
            //abstract class unit(클래스 이름)
            //{
            //Public abstract void Destroy(); //메서드의 반환 형식 앞에 abstract 키워드를 추가하면 추상 메서드가 정의됨
            //}

            //맴버메서드 정의
            //abstract class unit(클래스 이름)
            //{
            //Public void Destroy();
            //{

            //}
            //}

            //직접 인스턴스화 할 수 없음
            //new Unit;

            Marine marine = new Marine();
            //marine.name = " Yul";

            //Console.WriteLine(marine.name);
            //marine.Destroy();

            //marine.Destory(); //starcratObject 추상 클래스 메서드 호출부

            marine.Destroy(); //일반 클래스의 메서드 호출
        }
    }
}
