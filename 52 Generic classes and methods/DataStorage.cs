using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_Generic_classes_and_methods
{
    internal class DataStorage <T> // 형식 매개변수 정의
    {
        public T Data {  get; set; } //int 형 data 속성 정의 -> T 속성으로 변경

        public DataStorage()
        {

        }
    }
}
