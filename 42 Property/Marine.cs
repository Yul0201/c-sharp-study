using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Property
{
    class Marine
    {
        //    private string name; //속성에서 사용할 맴버변수 정의

        //    public String Name; //변수와 동일하게 적어줌. 변수의 첫 글자는 대문자
        //    {
        //        get
        //        {
        //            return this.name;
        //        }
        //        set
        //        {
        //            this.name = value; //value 키워드는 set 접근자에서 필드에 할당되는 값
        //        }
        //    }

        //읽기 전용
        //get 접근자는 포함하지만 set 접근자는 포함하지 않음
        //쓰기 전용
        //set 접근자는 포함하지만 get 접근자는 포함하지 않음

        //자동구현 속성-필드가 필요 없음 (private string name; //속성에서 사용할 변수 정의 > 정의하지 않음)
        //public string Name
        //{
        //    get;
        //    set; //private 를 사용해서 외부에서 접근 못하게 가능 함 ex)private set;
        //}

        //개체 이니셜라이저 사용방법
        //자동 구현 속성



        //public string Name
        //{
        //    get;
        //    set;
        //}

        //public int Damage
        //{
        //    get;
        //    set;
        //}

        //속성이 아니어도 접근 가능한 필드도 개체 이니셜라이저 사용 가능
        public string name;
        public int damage;

        public Marine() //기본 생성자가 있다면 호출됨
        {
            Console.WriteLine("기본 생성자");
        }


        // 매개변수 있는 생성자(메서드 오버로딩)
        // 매개변수 있는 생성자가 있었다면 제거해도 됨. 개체 이니셜라이저를 통해 멤버를 초기화 할 수 있음
        // 인스턴스를 생성하고 단일 명령문에서 멤버 할당을 가능하게 해줌
        // 개체 이니셜라이저를 사용하면 인스턴스를 생성하고 할당문 줄을 추가하지 않고도 인스턴스의 모든 액세스 가능한 필드나 속성에 값을 할당할 수 있음
        // 개체 이니셜라이저 구문을 사용하여 인스턴스를 만들 수도 있음
        //class Marine
        //{
        //public string name;
        //public int damage;

        public Marine(string name)
        {
            this.name = name; //set 속성 사용
            Console.WriteLine("매개변수 있는 생성자");
        }


        //new Marine("홍길동"){damage = 1};

    }
}