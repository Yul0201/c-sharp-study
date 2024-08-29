using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_Indexer
{
    internal class NameCollection
    {
        private string[] names; //문자열 배열 

        public string this[int i] //인덱스. this 키워드는 현재 객체를 가리키는 참조형 키워드로 해당 class 내부에 있는 변수를 일컬음
        {
            get { return this.names[i]; }

            set { this.names[i] = value; }

            }

        public NameCollection(int capacity) //생성자
        {
            this.names = new string[capacity];
        }
    }
}
