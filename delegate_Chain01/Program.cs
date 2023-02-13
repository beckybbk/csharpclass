namespace interface01
{
    // 인터페이스 : 클래스들이 구현해야 하는 동작을 지정하는 용도로 사용되는 추상 자료형. 

    //네이밍 컨벤션 : 이름을 규칙적으로 맞춰줌.
    interface IMonitor // interface는 I를 넣어 이름을 만듦. 메소드를 선언만 할 수 있음. 멤버 변수를 가질 수 없음. but, 프로퍼티는 가질 수 있음.
    {
        // int value;=> 에러뜸.
        // int Damage { set; get; } //but, 프로퍼티는 가질 수 있음.

        // 인터페이스의 기본 접근 지정자는 public으로 설정됨.
        void Power();
    }

    interface IMouse
    {
        void Click();
    }
    //c샵은 다중상속이 지원되지 않음.
    class Computer : IMonitor, IMouse
    {

        public void Click()
        {
            Console.WriteLine("마우스 클릭");
        }

        public void Power()
        {
            Console.WriteLine("모니터 전원 On");
        }
    }

    interface IObject
    {
        void HealthManager();
    }

    class Player : IObject
    {
        public int hp;

        public void HealthManager()
        {
            hp -= 50;
            Console.WriteLine("Player의 체력이 감소했음. 현재 hp: " + hp);
        }
    }

    class Monster : IObject
    {
        public int hp;
        public void HealthManager()
        {
            hp -= 25;
            Console.WriteLine("Monster의 체력이 감소했음. 현재 hp: " + hp);
        }
    }

    class Damage // <- 데미지를 처리하는 클래스.
    {
        public void DecreaseHP(IObject iobject)
        {
            iobject.HealthManager();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 인터페이스
            Computer computer = new Computer();
            computer.Power();
            computer.Click();

            //IMouse mouse = new IMouse();   => 에러발생: 인터페이스는 객체로 인스턴스 할 수 없음.단, 참조용 변수로는 사용가능.
            //IMouse lg = new Computer();
            //lg.Click();
            #endregion

            Monster goblin = new Monster();    // 고블린이란 몬스터가 생김 
            goblin.hp = 100;                   // 고블린 체력 100 설정

            Monster slime = new Monster();     // 슬라임 몬스터 생성

            Player player = new Player();      // 플레이어 생성
            player.hp = 100;                   // 플레이어 체력 100 설정

            Damage damage = new Damage();
            damage.DecreaseHP(goblin);
            damage.DecreaseHP(player);
        }
    }
}