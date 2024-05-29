using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Overloading
{
    internal class Hero
    {
        //생성자
        public Hero() 
        {
            Console.WriteLine("매개변수가 없는 기본 생성자");
        }


        //생성자 오버로딩
        public Hero(string name)
        {
            Console.WriteLine("매개변수가 1개 있는 생성자");
        }

        //생성자 오버로딩
        public Hero(string name, int damage, int maxHp)
        {
            Console.WriteLine(" 매개변수가 3개 있는 생성자");
        }
    }
}
