using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_2_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for문에서 continue 문

            for (int i = 0; i<3; i++)
            {
                if (i == 1)
                {
                    continue;
                }
                Console.WriteLine(i); //output 0,2
            }

            //while 문에서 continue 문
            int i = 0;

            while (i < 3)
            {
                i++;

                if(i == 1)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
