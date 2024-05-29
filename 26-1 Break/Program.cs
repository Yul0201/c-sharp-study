using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_1_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배치된 지점에서 가장 가까운 바깥쪽 루프 또는 switch 문을 종료함. 제어는 종료된 문 뒤의 문으로 전달됨(있는 경우)

            //for 문
            /*
             for (int i = 0; i<5; i++)
            { // 가장 가까운 바깥쪽 루프 종료
                if (i == 1)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            */

            //이중 for 문에서 break 문
            for (int i = 0; i<2; i++)
            { // i==1 일 경우 break 이므로 가장 가까운 바깥쪽 루프 종료
                for(int j =0; j<5; j++)
                { if (j == 1)
                    {
                        break;
                    }
                    Console.WriteLine(j);
                }
            }
            Console.WriteLine("Hello world");

            //while 문에서 break 문
            int i = 0;

            while (i < 10)
            {
                if (i == 1)
                {
                    break;
                }

                Console.WriteLine(i);
                
                1++;
            }

            //switch 문에서 break 문
            string name = "jack";

            switch (name)
            {
                case "jack":
                    Console.WriteLine("hello jack");
                    break;

                case "tom":
                    Console.WriteLine("Hi tom");
                    break;
            }
        }
    }
}
