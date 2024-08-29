using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_GenericDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //데이터의 키와 값 쌍의 일반 컬렉션. 키는 고유하며 null 일 수 없음. 값은 null이거나 중복될 수 있음
            //인덱서에 연결된 키를 전달하여 값에 액세스 할 수 있음

            //Dictionary<TKey. TValue> 사용법 (Dictionary를 사용해 사용자 이름과 전화번호를 저장하는 경우)
            //Dictionary<string, string> dic;  //변수 선언. 첫번째 string은 키에 해당하는 데이터 타입. 두번째 string 은 값에 해당하는 데이터 타입. dic 는 변수
            //public void Add(TKey key. TValue value); //지정한 키와 값을 사전에 추가

            Dictionary<string, string> phoneNumbers;
            phoneNumbers = new Dictionary<string, string>();
            phoneNumbers.Add("Hong", "010-1234-5678");
            phoneNumbers.Add("Lim", "010-1111-2222");

            phoneNumbers["Jang"] = "010-2222-3333"; //set 접근자를 사용하는 인덱서에서는 요소가 생성
            // Console.WriteLine(phoneNumbers.Count);

            foreach (KeyValuePair<string, string> pair in phoneNumbers)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }

            //phoneNumbers["Hong"] = "010-1111-5678";
            //Console.WriteLine(phoneNumbers["Hong"]);

            //Console.WriteLine(phoneNumbers[Hong]);//인텍서를 황용해 value 값을 가지고 옴

            //bool hasNumber = phoneNumbers.ContainsKey("Hong");
            //Console.WriteLine(hasNumber);

            //Console.WriteLine(phoneNumbers.Count);
        }
    }
}