using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Struct
{
    internal class Marine
    {
        public Position position;

        public Marine(Position position)
        {
            Position aaa = new Position(1, 3);
            position = aaa;
        }

        public Marine(int a)
        {
            a = 3;
        }

        public void Move(Position targetPosition)
        {
            Console.WriteLine("{0},{1}로 이동합니다. ", targetPosition.x, targetPosition.y);
            this.position = targetPosition;
        }

        public Position GetPosition()
        {
            Console.Write("PR Test");
            return this.position;
        }
    }
}
