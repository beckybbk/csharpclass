using System;

namespace class01
{
    internal class Program
    {
        static void Main(string[] args) // Main 은 프로그램 실행 진입점, main 함수 안에서 실행해야 프로그램이 돌아감 
        {
            Console.WriteLine("Hello World!"+"This is me!");//문자열 출력함수, 쌍따옴표 안에 반드시.이어서 출력하고 싶은 문자가 있다면 +로 연결
            Console.WriteLine("유니티를 배우고 싶어요.");
            Console.Write("안녕");//line 이 없는 write는 줄바꿈(개행)을 안함.
            Console.Write(100);

            //값 타입 
            bool check=true; //1 byte
            byte bit = 1; //1 byte
            char alphabet = 'A'; //1 byte 
            short data = 10; //2 byte
            ushort uData = 22; //2 byte 양수값만 표현할 수 있는 자료형
            int integer = 300; //4 byte
            uint uInteger = 200; //4 byte 양수값만 표현할 수 있는 자료형
            long signal = 15; //4 byte
           
            float sign = 16.5f; // 4 byte
            double count = 176.8; // 8 byte
            //구조체, 열거형
            decimal value = 3058; //16 byte
                                
        }
    }
}
