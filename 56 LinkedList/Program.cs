using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //연결리스트는 일련의 노드 그룹으로 구성된 선형 데이터 구조 (다음노드에 대한 참조(링크)를 포함하는 노드로 구성)
            //노드 구성 - 데이터(각 노드는 데이터를 저장함) / 주소(노드는 주소를 포함)

            //LinkedList 특징
            //1.동적 컬렉션으로 요소를 빠르게 삽입하고 제거 가능
            //2.ICollection<T>, IEnumerable<T> 등 인터페이스를 구현하며 열거자를 지원
            //3.목록에서 노드를 제거하고 다시 삽입 가능. 이 때 힙메모리에 추가 개체가 할당되지 않음
            string[] names = { "Hong", "Lim" };
            LinkedList<string> linkedList = new LinkedList<string>(names);
            //Console.WriteLine(linkedlist.Count);
            LinkedListNode<string> node = linkedList.AddFirst("Jang");
            Console.WriteLine(linkedList.Count);

            foreach (string name in linkedList)
            {
                Console.WriteLine(name);
            }

            //LinkedList<string> linkedlist = new LinkedList<string>();
            //Console.WriteLine(linkedlist.Count);
        }
    }
}
