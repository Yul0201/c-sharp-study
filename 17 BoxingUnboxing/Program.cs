using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boxing 은 값형식을 object 형식으로 변환하는 프로세스(내부에 래핑하고 힙에 저장,암시적)/Unboxing 은 object형식에서 값 형식으로 변환하는 프로세스(명시적)
            //boxing
            //int i = 123;
            //object obj = i; //암시적

            int i = 123; //값형식
            object obj; //명시적 //참조형식
            obj = i; //암시적 박싱
            //Unboxing
            int j = (int)obj; //obj 로 변수 초기화 //명시적 언박싱
            
            Console.WriteLine(i);
            Console.WriteLine(obj);
            Console.WriteLine(j);
        }
    }
}
