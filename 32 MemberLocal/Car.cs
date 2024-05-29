using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_MemberLocal
{
    
    class Car
    {
        public string name;
        //string name; //멤버변수는 클래스에 선언된 변수. 인스턴스가 메모리에 있는 동안 접근 가능
        //void Move(int moveSpeed) // 지역변수(매개변수). 매개변수는 메서드에 정의된 변수이므로 지역변수 임
        /*{
            float limitSpeed = 5f; //지역변수
        }*/
        public float speed;

        public Car(string carName) 
        {   
            name = carName;
            Console.WriteLine("{0}가 생성되었습니다",carName);
        }

        public void Move(float moveSpeed)
        {   
            speed = moveSpeed;
            Console.WriteLine("{0} 속도로 이동합니다. ", moveSpeed);
        }
    }
}
