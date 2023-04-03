using Partial0403.BBK;
using System.Formats.Asn1;

namespace Partial0403
{
    
    public class Base
    {
        int itemNumber;

        public void Construct()
        {
            Console.WriteLine("건물을 지었습니다");
        }
        public class B
        {
            Base aclass = new Base();
            int bNumber;

            public void Information()
            {
                bNumber = aclass.itemNumber;
            }
        }
    }

 
    namespace KGS
    {
        class Function
        {
            public Function()
            {
                Console.WriteLine("KGS 시스템 개발");
            }

        }
    }

    namespace BBK
    {
        class Function
        {
            public Function()
            {
                Console.WriteLine("BBK 시스템 개발즁");
            }
        }
        
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Partial Class

            //Player player = new Player();
            //player.Talk();
            //player.Movement();
            //player.Attack();

            #endregion

            #region 중첩클래스

            //Base aclass = new Base();

            //Base.B nestedClass = new Base.B();
            //nestedClass.Information();

            #endregion

            BBK.Function BBK = new BBK.Function();
            KGS.Function kGS = new KGS.Function();  
        }
    }
}