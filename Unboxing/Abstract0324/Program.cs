namespace Abstract0324
{
    abstract class Item         // 추상클래스(기본 접근자는 public)
    {
        protected int price = 1000;
        
        abstract public void Function();        // 하나 이상의 추상 메소드(함수)가 포함되어야 함.

        abstract public void WaitTime();
        

        public void Information()
        {
            Console.WriteLine("Item의 가격: " + price);
        }
    
    }

    class Potion : Item
    {
        const string type = "포션류";


        public readonly int itemCode;

        public Potion()
        {
            itemCode = 10546;
            Console.WriteLine("itemCode : " + itemCode);
        }

        new public void Information()
        {
            base.Information();         // 부모클래스에 있는것을 접근해서 쓸수있다.
            Console.WriteLine("포션가격 : " + price);
        }
        public override void Function()
        {
            Console.WriteLine("능력치 증가: ");
        }

        public override void WaitTime()
        {
            throw new NotImplementedException();
        }
    }

    class HealthPotion : Potion
    {
        public override void Function()
        {
            Console.WriteLine("캐릭터 체력회복: ");
        }

        sealed override public void WaitTime() // 자식에게 상속되지 않도록 봉인.
        {
            Console.WriteLine("몇 초 대기");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Item item = new item();

            #region 추상클래스
            /*
            Item item = new Potion();
            item.Function();
            item.Information();
            */
            #endregion

            #region 베이스키워드

            //Potion potion = new Potion();
            //potion.Information();

            #endregion

            //문자열 보간 
            int year = 2023;
            var date = DateTime.Now;    // auto 자료형 (자동으로 데이터를 처리)

            Console.WriteLine("{0}년 {1:HH:mm}분", year, date);
        }
    }
}