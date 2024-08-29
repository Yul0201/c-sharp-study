using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_Generic_classes_and_methods
{
    internal class Inventory
    {
        public Inventory() 
        {

        }

        //None 제네릭 클래스에서 제네릭 메서드를 정의하려면 꺽쇠괄호로 정의 가능. 형식 매개변수 T는 정식 매개변수 T를 구체화 함
        public void AddItem<T>(T item) where T : Item //T형식을 제한하는 방법
        {
            Console.WriteLine(item.Name);
        }
    }
}
