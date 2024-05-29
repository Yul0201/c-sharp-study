using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Overloading
{
    internal class Calculator
    {
        //생성자

        public Calculator()
        {

        }

        //메서드 오버로딩
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;

        }

        //다른 매개변수의 수
        public int Add(int a, int b, int c)
        {
            int result = a + b + c;
            return result;
        }


        public int Subtract(int a, int b)
        {
            int result = a - b;
            return result;
        }

        //다른 타입의 매개변수
        public int Subtract(float a, float b)
        {
            int result = Convert.ToInt32(a - b);
            return result;
        }

        public int Subtract (int a, float b)
        {
            int result = a - (int)b;
            return result;
        }

        // 다른 타입의 매개변수의 순서가 다른 경우
        public int Multiple(int a, float b)
        {
            int result = a*(int)b;
            return result;
        }

        public int Multiple(float a, int b)
        {
            int result = (int)a*b;
            return result;

        }

        //반환 타입이 다른 것은 오버로딩으로 허용하지 않음
        public float Divide(int a, int b)
        {
            return a / b;
        }

        //public int Divide(int a, int b)
        //{
        //  return a / b;
        //}
    }
}