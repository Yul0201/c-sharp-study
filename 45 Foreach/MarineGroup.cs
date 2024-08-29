using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_Foreach
{
    class MarineEnumerator : IEnumerator
    {
        Marine[] marines;
        int index = -1; //배열에 접근하기 위한 맴버 변수 index를 정의하고 -1로 초기화 함
        public MarineEnumerator(Marine[] marines)
        {
            this.marines = marines;
        }
        public object Current
        {
            get { return this.marines[this.index];  } //속성으로 정의하고 배열의 인덱스에 해당하는 요소를 반환 
        }

        public bool MoveNext()
        {
            this.index++;
            return this.index < this.marines.Length; //배열의 길이보다 작은 경우 true를 아닐경우 flase 를 반환
        }

        public void Reset()
        {
            this.index = -1; //index 초기화
        }
    }

    class MarineGroup : IEnumerable
    {
        Marine[] marines;
        public MarineGroup(Marine[] marines) 
        {
            this.marines = marines;
        }

        public IEnumerator GetEnumerator()
        {
            return new MarineEnumerator(this.marines);
        }
    }

}
