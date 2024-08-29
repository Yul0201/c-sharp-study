using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _39_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //구조체 형식은 사용자 정의 형식이며 데이터와 관련 기능을 캡슐화 할 수 있는 값 형식임
            //동작을 거의 제공하지 않거나 작은 데이터 중심 형식을 설계하는데 사용
            //모든 구조체 형식은 하나 이상의 생성자를 갖음
            //모든 필드가 액세스 가능한 경우 new 연산자 없이 인스턴스화 가능

            //클래스와 다른점
            //구조체 - 값형식, 상속 불가능, 매개변수 없는 생성자를 포함할 수 없음, 맴버 메서드에 virtual,protected 사용 불가
            //언제 사용하나- 유형의 인스턴스가 작고 일반적으로 수명이 짧거나 다른 개체에 포함되는 경우 이 외 경우에는 클래스로 정의

            //구조체 정의
            //struct Position(구조체 형식 이름을 정함)
            //{
            // 필드 설정방법 - public int x(변수명):
            //}

            //생성자
            //struct Position
            //{
            //    public int x;   
            //    public int y;

            //    public Position(int x, int y) //매개변수 없는 생성자 안됨
            //    {
            //        this.x = x;
            //        this.y = y;
            //    }
            //}

            //함수 가능
            //PublicKey void SetOrigin()
            //{
            //    this.x = 0;
            //    this.y = 0;
            //}

            //인스턴스 가능
            //new Position(3,10);
            //new Position(); 해당 형식의 기본값을 생성하는 매개 변수 없는 암시적 생성자를 호출

            //Position pos = new Position(1,1);
            //Position pos = new Position(); //매개변수를 지정하지 않으면 필드를 기본값으로 초기화 하는 암시적 생성자가 호출됨
            //Position pos; //변수
            //pos.x = 1;
            //pos.y = 2;
            //Console.WriteLine(pos); //모든 필드가 채워지지 않아서 에러발생 

            //Position pos = new Position(1,1);
            //pos.SetOrigin();
            //Console.WriteLine("{0},{1}", pos.x, pos.y);

            int value = 5;
            Marine marine = new Marine(value);
            Console.WriteLine(value); //왜 그대로인가

            Position position = new Position(1, 1);
            Marine marine = new Marine(position);
            Console.WriteLine(position);//왜 변경된건가

            Console.WriteLine("마린의 현재 위치 : {0},{1}", marine.position.x, marine.position.y);
            marine.Move(new Position(2,3));
            Position pos = marine.GetPosition();
            Console.WriteLine("마린의 현재 위치 : {0},{1}", pos.x, pos.y);

        }
    }
}
