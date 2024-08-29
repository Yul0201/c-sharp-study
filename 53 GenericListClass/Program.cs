using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _53_GenericListClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //인덱스로 액세스할 수 있는 강력한 형식의 개체 목록을 나타냄. 목록의 검색, 정렬 및 조작에 사용할 수 있는 메서드 제공
            //List<T>는 IList<T> 인터페이스를 구현하는 ArrayList 클래스와 비슷하지만 일반화 클래스임 (System.Collections.Generic 네임스페이스에 포함)
            //컴파일 타임 유형 검사를 제공하고 제네릭이기 때문에 boxing-unboxing을 수행하지 않음
            //요소는 인텍스를 전달하여 액세스 가능(ex. marines[0])
            //사용방법
            //System.Collections.Generic 추가
            //List<string> names; //List 객체가 관리하는 요소들의 타입 <string> 작성 /names 변수
            //names = new List<string>(); //인스턴스 생성

            //public void Add(T item); // 개체를 List<T>의 끝부분에 추가
            //public void clear(); //List<T> 요소 제거
            //public bool Contains(T item); //List<T> 요소 여부 확인
            //public bool Remove(T item); //List<T> 에서 맨 처음 발견되는 특정개체를 제거함. 제거면 t, 아니면 f
            ////속성
            //public int Count { get }; // List<T>에 포함된 요소수를 가지고 옴
            //public T this[int index] { get; set; } //지정한 인덱스에 있는 요소를 가져오거나 설정함

            Item item1 = new Item("장검");
            Item item2 = new Item("단검");
            Item item3 = new Item("활");
            Item item4 = new Item("도끼");

            Inventory inventory = new Inventory();
            inventory.AddItem(item1);
            inventory.AddItem(item2);
            inventory.AddItem(item3);
            inventory.AddItem(item4);

            inventory.DisplayItem();

            //Item item = inventory.GetItem("장검");
            //if (item != null)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //else
            //{
            //    ConsoleWriteLine("not found item");
            //}

            //Console.WriteLine(inventory.GetCount());

            //List<string> names = new List<string>();
            //names.Add("Hong");
            //names.Add("Lim");

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //for (int i = 0; i < names.Count; i++)
            //{
            //    string name = names[i];
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names.Count);
            //bool removed = names.Remove("Hong");
            //bool hasName = names.Contains("Hong");
            //Console.WriteLine(removed);
            //Console.WriteLine(names.Count);

        }
    }
}
