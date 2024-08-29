using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Interface
{
    internal class Hydralisk : Izerg, IMetamorph
    {
        public void Burrow()
        {
            Console.WriteLine("Burrow 개체가 숨는 메서드");
        }

        public void RecoveryHp()
        {
            Console.WriteLine("RecoveryHp 체력을 재생하는 메서드");
        }

        public void Morph(string name)
        {
            Console.WriteLine("{0}으로 변형됩니다",name);
        }
    }
}
