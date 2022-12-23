namespace Anonymous01
{
    delegate void Delegate();

    class IPhone
    {
        public int price;
        public int version;

        //얕은복사
        /*
        public IPhone(int price, int version)
        {
            this.price = price;
            this.version = version; 
        }
        */

        // 깊은복사

        public IPhone DeepCopy()
        {
            IPhone newIPhone = new IPhone();
            newIPhone.price = this.price;
            newIPhone.version = this.version;

            return newIPhone;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 무명형식
            // 무명형식 : 이름이 없는 데이터 형식. 임시변수(임시로 생성해 사용하고 더 이상 사용되지 않음) 가 필요할 때 사용하는 형식.

            //var temp = new { age = 40, name = "KIM" };

            //// temp.age = 30; => 에러, 무명형식으로 생성된 인스턴스는 읽기 전용(출력용)이기 때문에 값을 수정할 수 없음. 

            //Console.WriteLine("temp의 age : " +temp.age + "temp의 name : " + temp.name);
            #endregion

            #region 무명메소드
            // 무명메소드 : 단순한 명령어 구문으로 구성된 메소드를 정의하지 않고 델리게이트를 사용해 1회용으로 사용하는 메소드. 
            Delegate value;

            value = () =>
            { Console.WriteLine("로그인을 실패하였음"); };

            value();
            #endregion

            // 얕은복사 : 객체를 복사할 때 주소값을 복사하여 같은 메모리를 가리키는 복사.
            IPhone se1 = new IPhone();
            se1.price = 20000;
            se1.version = 1;
            IPhone se2 = se1.DeepCopy();

            se2.version = 2;
            se2.price = 100000;

            Console.WriteLine("se1의 버젼: " + se1.version);
            Console.WriteLine("se1의 가격: " + se1.price);

            Console.WriteLine("se2의 버젼: " + se2.version);
            Console.WriteLine("se2의 가격: " + se2.price);


            // 깊은복사 : 객체를 복사할 때 참조값이 아닌, 인스턴스 자체를 새로 복사해 서로 다른 메모리를 생성하는 복사.
        }
    }
}  
           
       