using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_Collection_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //개체를 그룹화하는 방법에는 개체 배열을 만들거나 개체 컬렉션을 만드는 두 가지 방법이 있음
            //배열은 고정된 개수의 강력한 형식 개체를 만들고 작업하는 데 가장 유용

            //컬렉션은 개체 그룹에 대해 작업하는 보다 유연한 방법을 제공. 애플리케이션의 요구가 변경됨에 따라 작업하는 개체 그룹이 동적으로 확장되거나 축소될 수 있음
            //일부 컬렉션의 경우 키를 사용하여 개체를 신속하게 검색할 수 있도록 컬렉션에 추가하는 모든 개체에 키를 할당할 수 있음
            //컬렉션의 종류
            //System.Collections클래스-구체적 형식의 개체가 아니라 Object 형식의 개체로 요소를 저장
            //ArrayList - 필요에 따라 크기가 동적으로 증가하는 배열, 컬렉션은 클래스이므로 해당 컬렉션에 요소를 추가하려면 먼저 인스턴스화 해야 함
            //ArrayList list = new ArrayList();
            //list.Add("Hong"); //매개변수의 타입은 Object 이며 어떠한 값도 넣을 수 있음. 개체를 ArrayList의 끝 부분에 추가
            //list.Add(100);
            //list.Add(true);
            //list.Add(null); //null 허용
            //list.Add("Hong"); //중복 가능
            //Console.WriteLine(list.Count); //Count 속성으로 요소의 수를 출력할 수 있음
            //for(int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]); //i 값을 인덱스로 사용
            //}
            //Console.WriteLine(list[0]); //index를 사용해 요소에 접근할 수 있음
            //foreach(object element in list)
            //{
            //    Console.WriteLine(element); //다양한 타입이 리스트에 존재하기 때문에 object 타입 변수로 작성
            //}    
            //foreach(string element in list)
            //{
            //    Console.WriteLine(element); // string 타입으로 오류발생
            //}

            //bool has = list.Contains("Hong"); // Contains 함수로 요소가 있는지 체크하고 true, false 로 반환
            //Console.WriteLine(has);

            //list.Remove(100); //Remove 로 요소를 리스트에서 제거 가능
            //Console.WriteLine(list.Count);
            //for(int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            ArrayList list = new ArrayList();
            //Console.WriteLine(list.Add("홍길동")); //index0
            //Console.WriteLine(list.Add("임꺽정")); //index1
            //Console.WriteLine(list[0]);
            //int index = list.Add("홍길동");
            //Console.WriteLine(index);
            //Console.WriteLine(list[index]);




            //System.Collections.Generic클래스

        }
    }
}
