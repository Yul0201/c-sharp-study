using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Abstact_Class
{
    class StarcraftObject
    {
        public StarcraftObject()
        {
            Console.WriteLine("StarcraftObject 생성자 ");
        }

        //public abstract void Destory(); //추상클래스의 추상 메서드를 제거

        public virtual void Destroy()
        {
            Console.WriteLine("StarcraftObject 일반 클래스의 Destroy 메서드");
        }
    }
}

