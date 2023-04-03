using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial0403   //partial 클래스는 계속 분리해서 클래스를 생성할 수 있음.
{
    internal partial class Player
    {
        public int health;

        public void Talk()
        {
            Console.WriteLine("Player 가 대화를 시도합니다");
        }
    }
}
