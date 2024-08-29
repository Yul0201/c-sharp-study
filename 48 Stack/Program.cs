using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //스택은 한쪽 끝에서만 자료를 넣거나 뺄 수 있는 선형 구조(LIFO_last in first out)
                //push(object) 개체를 stack 의 맨 위에 삽입
                //pop() stack의 맨 위에서 개체를 제거하고 반환
                //peek() stack의 맨 위에서 개체를 제거하지 않고 반환
            //속성
                // count - stack에 포함된 요소 수를 가져움
            Stack stack = new Stack();
            stack.Push("hong");
            stack.Push("lim");
            //stack.Push(null);
            //Console.WriteLine("before: {0}", stack.Count);

            //Console.WriteLine(stack.Count);

            //object peek = stack.Peek();
            //Console.WriteLine(peek);

            //object pop = stack.Pop();
            //Console.WriteLine(pop);
            //Console.WriteLine("after: {0}", stack.Count);

            //bool found = stack.Contains("hong");
            //Console.WriteLine(found);

            foreach (object element in stack) //스택의 요소는 object 형식. 값형식 값을 넣었다면 박싱 됨
            {
               Console.WriteLine(element);
            }
        }
    }
}
