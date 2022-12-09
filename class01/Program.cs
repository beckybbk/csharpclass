using System;

namespace class01
{
    internal class Program
    {
        static void Main(string[] args) // Main 은 프로그램 실행 진입점, main 함수 안에서 실행해야 프로그램이 돌아감 
        {
            //값 타입: 변수 선언과 동시에 값 할당할 수 있고 스택 메모리에 생성됨. 

            //참조 타입
            //int 자료형을 가진 변수를 한공간에 방 형태로 5개 저장하는 구조. 
            //new 키워드 사용해서 객체 초기화 한 후 힙에 할당된 메모리를 스택에서 참조해 사용하는 타입. 

            // int array[5];  => 에러
            string name = "BBK";
            int[] array = new int[5];

            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;

            Console.WriteLine(name);
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);


        }
    }
}
