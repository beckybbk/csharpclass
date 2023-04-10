using System.Collections.Generic;

namespace TryCatch0410
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 예외처리 

            //int[] array = new int[3] { 1, 2, 3 };
            //int data = 0;
            //int value =100;
            //int result = 0;



            //try     // <- Error가 발생할 거 같은 코드 넣는 자리
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine(array[i]);
            //    }

            //    result = value / 0;
            //}



            //catch (IndexOutOfRangeException error)   //<- try에서 예외가 발생할때 예외를 알려줌. (IndexOut... 대신 Exeption으로 대체가능)
            //{
            //    Console.WriteLine(error);
            //}

            //catch(DivideByZeroException error) 
            //{
            //    Console.WriteLine(error);
            //}
            #endregion

            #region 열거자

            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);

            foreach(var element in linkedList) // iEnumerator 반복 출력 대신 간단하게 처리. 
            {
                Console.WriteLine(element);                
            }

            IEnumerator<int> iEnumerator = linkedList.GetEnumerator();

            Console.WriteLine(iEnumerator.Current);
            iEnumerator.MoveNext();
            Console.WriteLine(iEnumerator.Current);
            iEnumerator.MoveNext();
            Console.WriteLine(iEnumerator.Current);
            iEnumerator.MoveNext();
            Console.WriteLine(iEnumerator.Current);
            iEnumerator.MoveNext();


            // Current: 읽기 전용 프로퍼티. 현재 위치의 데이터를 object 타입으로 반환하는 함수.
            // MoveNext: 다음 위치로 이동하는데 위치에 데이터가 있으면 true를 반환, 없으면 false 반환.
            // Reset: 인덱스를 초기 상태로 돌리는 함수. 
            #endregion


        }
    }
}