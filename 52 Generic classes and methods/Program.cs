using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_Generic_classes_and_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //일반화란 개별적인 것이나 특수한 것의 공통점을 찾아 일반적인 것으로 만드는 것
            //.net에 형식 매개 변수 개념을 도입하여 하나 이상의 형식 지정을 연기하는 클래스 및 메서드를 설계할 수 있도록 함 -> 이것을 통해 런타임 캐스트 또는 박싱 작업의 비용이나 위험에서 안전한 단일 클래스 작성
            //언제 사용되는가 -> 여러데이터 형식에 대해 동일한 로직을 적용 해야 할 때/ 컬렉션 타입에서 다양한 데이터 형식을 저장하고 관리할 때 / 데이터 형식에 따라 다른 연산을 수행해야 할 때
            //제네릭 클래스 : 클래스 이름 뒤의 꺾쇠 괄호 안에 형식 매개 변수를 사용하여 정의
            //제네릭 클래스 인스턴스화 가능
            //제네릭 클래스 특성 : 재사용성 / 기본 클래스가 될 수 있으며 파생될 수도 있음
            //제네릭 필드 : 제네릭 클래스에는 제네릭 필드가 포함될 수 있음. 그러나 초기화는 할 수 없음

            //DataStorage<int> storage = new DataStorage<int>();
            //storage.Data = 100; //  타입만 다르고 값 1개를 저장하고 있는 개체를 만들기 위해 3개의 클래스를 사용했으며 제네릭은 이 문제를 해결할 수 있음

            //DataStorage2<string> storage2 = new DataStorage2<string>();
            //storage2.Data = "Hong";

            //DataStorage3<item> storage3 = new DataStorage3<item>();
            //storage3.Data = new Item("장검");


            //DataStorage2 storage2 = new DataStorage2();
            //storage2.Data = "Hong";

            //DataStorage3 storage3 = new DataStorage3();
            //storage3.Data = new Item("장검");

            Inventory inven = new Inventory();
            inven.AddItem<Weapon>(new Weapon("장검"));
            inven.AddItem<Armor>(new Armor("사슬갑옷"));
            inven.AddItem<Potion>(new Potion("하급체력 물약"));

            //제네릭을 사용하지 않으면 weapon, armor, potion 메서드를 각각 생성했어야 함

        }
    }
}