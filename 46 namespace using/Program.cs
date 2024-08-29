using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcraft.Unit;
// using StarCraftUnitMarine = StarCraft.Unit.Marine; //StarCraftUnitMarine 별칭 가능 

namespace _46_namespace_using
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //namespace 사용자 정의 타입들의 공간을 만들기 위한 키워드. 형식을 그룹화 가능
            //중첩으로 사용가능
            //namespace Starcraft
            //{
            //    namespace Unit
            //    {

            //    }

            //}

            //using
            //해당 형식의 정규화된 네임스페이스를 지정하지 않고도 사용할 수 있음
            //using 지시문을 사용해 네임스페이스 멤버에 액세스
            //console 클래스의 네임 스페이스는 System 으로 using system 이 없으면 사용 불가

            //Starcraft.Marine marine = new Starcraft.Marine(); //명시적 가능
        }   Marine marine = new Marine();
    }
}
