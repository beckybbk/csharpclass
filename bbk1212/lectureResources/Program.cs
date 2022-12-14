using System;
using OtherGame; // 이름공간 value를 가져와 출력하려면 필요.

namespace OtherGame
{
    // int value; 하면 에러뜸, 반드시 클래스 먼저 

    class Data
    {
        public int value = 100;

    }

}



namespace lectureResources
{
  
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 반복문
            /*
            //foreach 
            int[] item = new int[5];
            // for
            for(int i = 0; i<5;i++)
            {
                item[i] = i;
            }

            //배열, 리스트 등 데이터테이블이 옴. 유저 데이터를 그대로 읽어올 때 사용. 
            foreach(int element in item)
            {
                //foreach문 내부에서는 element=100; 이런식으로 값을 변경할 수 없음. 

                Console.WriteLine(element);
            }
            */
            #endregion

            #region 이름공간
            /*
            // namespace(이름공간)이란 :내부 식별자의 범위를 제공해주는 선언적 영역. 
            Data data = new Data(); // 공적할당과정 필요.
            data.value = 100;
            Console.WriteLine("OtherGame의 value :" + data.value);


            //같은 이름의 변수를 동시에 선언했기 때문에 컴파일 에러 발생.
            int value = 10;
            //int value = 20;
            Console.WriteLine("ConsoleGame의 value :" +value);   

        */
            #endregion
        }
    }
}
