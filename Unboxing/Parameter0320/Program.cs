namespace Parameter0320
{
    internal class Program
    {
        //함수(c언어, c++) = 메소드(c샵, 자바)

       static void Calculator(ref int x)// 참조점
        {
            x -= 100; // x는 900이지만, 아래 data 출력시 걍 1000이 나옴.
        }


        // in: 참조형 매개변수 이면서 상수화가 이뤄진 변수. 따라서 변경할 수 없음. 출력용도
        static void Function(in int x)
        {
            // x = 3000; (못씀, 에러뜸)

            Console.WriteLine("매개변수 x의 값 :" + x);
        }

        static void RayCast(out int x)
        {
            x = 300; //out이 붙으면 값을 무조건 넣어 줘야함. 
            // out 매개변수는 외부의 변수가 값을 초기화 하지 않아도 사용할 수 있음
            // 함수의 반환형 int RayCast() <- return 100 
        }

        //static int RayCastHit(out int x, out int y) 
        //{
        //    return 10;        
        //}

        //가변길이매개변수
        static void Information(params int[] list)
        {
            int result = 0;
            foreach(int element in list) 
            {
                result+= element;
            }

            Console.WriteLine("result 값: " + result);
        }
        static void Main(string[] args)
        {
            #region 매개변수한정
            int data = 1000;
            //int data1 = 2000;
            //int data2;

            ////ref keyword
            //Calculator(ref data); // ref는 외부의 변수 값이 초기화 되어 있어야 함.
            //Console.WriteLine(data);

            //// in 키워드
            //Function(data1);

            ////out keyword
            //RayCast(out data2);

            //Console.WriteLine(" data2의 값 : "+ data2);
            #endregion

            // 가변길이 매개변수
            //Information(10,20);
            //Information(10,20,30, 45);

            int count = int.Parse(Console.ReadLine());

            for(int i=count; i>0; i-=4 )
            {
                if(count >=4)
                {
                    Console.WriteLine("long ");
                }

            }

            if(count>=4)
            {
                Console.WriteLine("int");
            }
        }
    }
}