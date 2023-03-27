namespace Delegate0327
{
    delegate void Delegate();

    class Player
    {
        public void Damage(Enemy enemy)
        {
            Delegate callback = State;
            enemy.Attack(callback);
        }
        public void State()
        {
            Console.WriteLine("공격 당했다");
        }
    }

    class Enemy
    {
        public void Attack(Delegate callback)
        {
            Console.WriteLine("공격");
            callback();
        }
    }

    internal class Program
    {
        // delegate int Function(int x,int y);     // delegate는 보관용 메소드와 반환형이 일치해야 함.
        //  delegate void Function(int x);         // 매개변수 갯수도 일치해야 함.
        delegate void Function(int x, int y);
        static void Plus(int x, int y)
        {
            Console.WriteLine("x + y : " + (x + y));
        }

        static void Minus(int x, int y)
        {
            Console.WriteLine("x - y : " + (x - y));
        }
        static void Main(string[] args)
        {
            #region 델리게이트
            //Function function;
            //function = Plus;
            //function(10,20);
            //function = Minus;
            //function(10, 25);

            ////Plus(10, 20);
            ////Minus(10, 25);
            #endregion

            #region 델리게이트 체인

            //Function function;
            //// function += Plus;    //델리게이트 체인을 하려면 등록부터 하고 추가해야.
            //function = Plus;
            //function += Minus;      //누적

            //function(10, 35);

            //function -= Minus;      // 빼고 싶은 메소드
            //function(1, 9);
            #endregion

            Player player= new Player();
            Enemy enemy= new Enemy();

            player.Damage(enemy);
        }
    }
}