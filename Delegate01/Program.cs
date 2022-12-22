using System;

namespace Delegate
{
    class Watch
    {
        // readonly : 런타임 시점에 결정되는 상수 (class 안에 만들어야). 초기화 하지 않아도 사용가능.
        readonly int count = 50;

        public Watch() // 생성자 : 생성자에서 단 한번만 값을 초기화 할 수 있음.
        {
            count = 100;
            Console.WriteLine("count의 값 : " + count);
        }
    }

    //델리게이트 선언
    //delegate [반환형] [델리게이트 이름] (매개변수)
    delegate void Calculator(int x, int y);

    // 델리게이트는 메소드의 반환형과 매개변수의 타입이 일치해야 사용가능.

    class Weapon
    {
        public void Stat(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("Stat 메소드의 값 : " + result);
        }
        public void Price(int x, int y)
        {
            int result = x - y;
            Console.WriteLine("Price 메소드의 값 : " + result);
        }

        public void Damage(int x, int y)
        {
            int result = x * y;
            Console.WriteLine("Damage 메소드의 값 : " + result);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 상수 : 프로그램이 실행되는 동안 변하지 않는 값.
            // const : 컴파일 시점에 결정되는 상수. 상수를 선언과 동시에 초기화 해주어야 함.
            // const int value; => 에러
            // const int data =10; 라고 입력했다가 20, 30 등으로 자꾸 바꾸면 재컴파일 한다. 
            //const int value = 10;

            //Console.WriteLine("value의 값 : "+value);
            //Watch watch = new Watch();
            #endregion

            #region 델리게이트(대리자)
            //델리게이트 : 대리자. 메소드를 대신해 호출하는 기법. (참조타입)
            //Weapon weapon = new Weapon();

            //// 델리게이트 정의
            //Calculator calculator;

            //// 델리게이트 변수에 Stat의 주소를 저장.
            //calculator = weapon.Stat;

            //calculator(10,20);

            //calculator= weapon.Price;
            //calculator(20,5);

            //calculator= weapon.Damage;
            //calculator(5,10);

            #endregion

            //델리게이트체인: 하나의 델리게이트에 여러개의 메소드를 연결시키는 기법. (한번에 계산가능)
            Weapon weapon = new Weapon();

            Calculator calculator;
            //델리게이트는 비어있는 상태에서 메소드를 추가할 수 없음. 먼저 등록시킨 뒤 추가. (+)
            calculator = weapon.Stat;
            calculator += weapon.Price;
            calculator += weapon.Damage;

            calculator(10, 20);

            // 델리게이트에 등록된 메소드를 뺄때는 (-) 
            calculator -= weapon.Price;
            calculator(10, 20);

        }
    }
}