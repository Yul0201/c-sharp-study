using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_Indexer
{
    internal class MarineEnumerator : IEnumerator
    {
        public Marine[] marines; //필드에 마린배열 정의
        private int pointer = -1;


        public MarineEnumerator(Marine[] marines)
        {
            this.marines = marines;
        }

        public object Current => this.marines[this.pointer];

        public bool MoveNext()
        {
            this.pointer++;
            return this.pointer < this.marines.Length;
        }

        public void Reset()
        {
            this. pointer = -1;
        }
    }
}
