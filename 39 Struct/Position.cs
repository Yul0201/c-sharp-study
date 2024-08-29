using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Struct
{
    struct Position //구조체 정의
    {
        public int x;
        public int y;

        public Position(int x, int y) //매개변수 정의 필요
        {
            this.x = x;
            this.y = y;
        }

        public void SetOrigin()
        {
            this.x = 0;
            this.y = 0;
        }
    }
}
