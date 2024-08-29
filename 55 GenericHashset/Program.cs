using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _55_GenericHashset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //정렬되지 않고 중복요소를 포함하지 않음
            //매핑하기 전 입력 데이터의 값을 키(Key), 매핑 후 출력 데이터의 값을 해시코드(HashCode), 매핑하는 과정을 해싱(Hashing)이라고 함

            //컬렉션 이니셜라이저를 사용하여 요소 저장 가능
            //HashSet<string> nameSet = new HashSet<string>() { "Hong", "Lim" };

            //foreach 및 while 키워드를 사용하여 HashSet을 반복

            //IsSubsetOf()와 IsProperSubsetOf()의 차이점
            //a가 b의 적절한 부분집합이면 b는 a 집합에 없는 요소가 하나 이상 있어야 함
            //c가 b와 동일한 요소를 포함하는 경우 c는 여전히 b의 하위 집합으로 간주됨

            //HashSet<string> nameSet = new HashSet<string>();
            //bool added = nameSet.Add("Marine");
            //Console.WriteLine(added);
            //added = nameSet.Add("Marine");
            //Console.WriteLine(added);

            //bool contains = nameSet.Contains("Marine");
            //Console.WriteLine(contains);
            //contains = nameSet.Contains("Medic");
            //Console.WriteLine(contains);

            //int count = nameSet.Count;
            //Console.WriteLine(count); //복수의 동일한 매개변수를 추가하더라고 요소수는 1임 

            HashSet<string> setA = new HashSet<string> { "Marine", "Medic", "Firebat"}; //컬렉션 이니셜라이저로 요소 추가
            HashSet<string> setB = new HashSet<string> { "Marine", "Medic", "Firebat", "Ghost", "Tank", "vurture" };

            //setA.UnionWith(setB);

            //int count = setA.Count;
            //Console.WriteLine(count);

            //foreach (string name in setA)
            //{
            //    Console.WriteLine(name);
            //}

            //setA.IntersectWith(setB);
            //int count = setA.Count();
            //Console.WriteLine(count);

            //foreach(string name in setA)
            //{
            //    Console.WriteLine(name);
            //}

            setA.Remove("Marine");

            int count = setA.Count;
            Console.WriteLine(count);

            foreach (var name in setA)
            {
                Console.WriteLine(name);
            }
        }
    }
}
