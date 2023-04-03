using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial0403
{
    //partial 클래스로 선언한 클래스는 접근 지정자가 다 똑같이 설정되어야 함.
    internal partial class Player
    {
        public void Movement()
        {
            Console.WriteLine("플레이어 이동");
        }

        public void Attack()
        {
            Console.WriteLine("플레이어 공격");
        }
    }
}
