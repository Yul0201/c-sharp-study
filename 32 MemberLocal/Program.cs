using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_MemberLocal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //멤버변수-클래스에 정의된 변수
            Car car = new Car("santa FE");
            Console.WriteLine("name : {0}", car.name);
            car.Move(3.2f);
            Console.WriteLine("speed: {0}", car.speed);
        }
    }
}
