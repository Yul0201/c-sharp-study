using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //버퍼 - 데이터를 한 곳에서 다른 한 곳으로 전송하는 동안 일시적으로 그 데이터를 보관하는 메모리 영역
            //스트림 - 데이터가 순서대로 전송되도록 보장하는 데이터의 흐름
            //Console.Write("input here");
            //string input = Console.ReadLine();
            //Console.WriteLine(input);

            //int key = Console.Read();
            //Console.WriteLine(key);
            //Console.WriteLine((char)key); // 형식 변환

            ConsoleKeyInfo info = Console.ReadKey(false); //누른키를 표시하지 않으려면  true 입력
            Console.WriteLine(info);
            Console.WriteLine(info.KeyChar);
            Console.WriteLine(info.Key);


        }
    }
}
