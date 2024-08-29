using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_Generic_classes_and_methods
{
    public class Weapon : Item
    {
        public Weapon(string name) : base(name) //매개변수 있는 부모 생성자를 재정의 함
        {

        }
    }
}
