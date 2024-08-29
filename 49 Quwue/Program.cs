using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Quwue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //큐는 자료구조의 한가지로 먼저 집어 넣은 데이터가 먼저 나오는 FIFO 구조로 저장하는 형식 (!= Stack_LIFO)

            //Enqueue(Object) 개체를 Queue의 끝 부분에 추가
            //Dequeue() Queue의 시작 부분에서 개체를 제거하고 반환
            //peek() queue 의 시작 부분에서 개체를 제거하지 않고 반환함
            
            //속성
            //Count -Queue에 포함된 요소 수를 가지고 옴
            //System.Collections 네임스페이스의 클래스는 구체적 형식의 개체가 아니라 Object 형식의 개체로 요소를 저장
            //컬렉션은 클래스이므로 해당 컬렉션에 요소를 추가하려면 먼저 인스턴스화 해야 함

            Queue queue = new Queue();
            queue.Enqueue("Hong");
            queue.Enqueue(null);
            queue.Enqueue(1);
            queue.Enqueue(true);
            queue.Enqueue('h');

            //Console.WriteLine(queue.Count);
            //foreach (object obj in queue) 
            //{ 
            //Console.WriteLine("->{0}", obj);
            //}

            //object element = queue.Dequeue();
            //Console.WriteLine("element: {0}", element);
            //Console.WriteLine(queue.Count);

            object element = queue.Peek();
            Console.WriteLine("element: {0}", element);
            Console.WriteLine(queue.Count);
        }
    }
}
