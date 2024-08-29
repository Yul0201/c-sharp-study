using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_Generic_classes_and_methods
{
    public class Item
    {
        public string Name {  get; set; }
        public Item(string name) // 생성자 매개변수로 전달 받은 값을 속성에 할당
        {
            this.Name = name;
        }
    }
}
