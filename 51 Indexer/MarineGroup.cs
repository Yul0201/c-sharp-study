using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_Indexer
{
    internal class MarineGroup : IEnumerable 
    {
        private Marine[] marines; //필드에 마린 배열 변수를 정의
        public Marine this[int i]
        {
            get { return this.marines[i]; }
            set { this.marines[i] = value; }
        }
        public MarineGroup(Marine[] marines) //생성자. 매개변수로 마린 배열을 받음
        {
            this.marines = new marines[marines.Length]; //배열인스턴스를 생성
            for (int i = 0; i < marines.Length; i++)
            {
                this.marines[i] = marines[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new MarineEnumerator(this.marines);
        }
    }
}
