using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _31_Construtor
{
    internal class Car
    {
        private string Name
        {
            get;
        } //멤버 변수

        //생성자 메서드
        //외부에서 전달된 인수(문자열 값)은 매개변수이며 carName에 할당됨
        public Car(string carName)
        {
            Name = carName;
        }

        public void CheckParams()
        {
            Console.WriteLine("test output");
            Console.WriteLine("매개변수 : {0}", Name); //매개변수 출력
        }

        public bool IsEqualsWithParam(string param)
        {
            return Name.Equals(param);
        }
    }
}

        //매개변수가 있는 생성자 메서드 정의
        //string name; //멤버변수

       //Public Car(string carName) //매개변수
            //{
            //    name = carName;
        //}