using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //키를 값에 매핑할 수 있는 자료 구조. 키와 값 한 쌍으로 데이터를 저장
            //배열을 사용하기 때문에 내부적으로 키에 해당하는 인텍스를 만들어 해당 인덱스에 값을 저장. 키에 해당하는 인덱스는 해시함수 알고리즘을 통해 생성
            //Hashtable table = new Hashtable();
            table.Add("Hong", "010-1234-5678");
            table.Add("Lim", "010-5678-1234");
            Console.WriteLine(table.Count);

            //bool has = table.Contains("Hong");
            //Console.WriteLine(has);

            //table.Remove("Hong");
            //Console.WriteLine(table.Count);

            //foreach (DictionaryEntry de in table)  //foreach(요소 변수명 in 순회할 자료형)
            //{
            //    Console.WriteLine("{0}, {1}", de.Key, de.Value);
            //}

            //object phonenumber = table["Hong"]; // 단일요소에 접근하려면 대괄호 안에 키 값을 넣어줌
            //Console.WriteLine(phonenumber);


        }
    }
}

