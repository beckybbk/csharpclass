using System.Collections;
using System.Collections.Generic;

namespace Indexer0329
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 콜렉션(Queue)
            //Queue queue =new Queue();   // Enqueue : 데이터 저장 멤버 함수
            //queue.Enqueue(10);   
            //queue.Enqueue("Game");

            //Console.WriteLine("queue의 사이즈: "+queue.Count);

            //Console.WriteLine(queue.Dequeue());

            #endregion

            #region 콜렉션 일반화 (Queue)
            //Queue<int> genericQueue= new Queue<int>();
            //genericQueue.Enqueue(99);
            //genericQueue.Enqueue(100);
            //genericQueue.Enqueue(111);

            ////Peek(): 맨 앞의 데이터(원소)를 출력하는 함수

            //Console.WriteLine(genericQueue.Peek());

            //genericQueue.Clear();   //empty
            //genericQueue.Dequeue();

            #endregion

            #region 콜렉션 일반화 (Stack)
            //Stack<string> stack = new Stack<string>();  

            //stack.Push("Earth");
            //stack.Push("Sun");
            //stack.Push("Moon");

            //Console.WriteLine(stack.Contains("Sun"));   //Contains(): 특정값이 존재하는지 확인하는 함수.불리언. 

            //Console.WriteLine(stack.Pop()); //1개 빼는 함수: 마지막에 넣은거부터 뺌.
            #endregion

            #region 콜렉션 일반화 (List)

            List<float> list= new List<float>();
            list.Add(10.9f);
            list.Add(20.7f);
            list.Add(30.0f);
            list.Add(40.0f);

            for(int i=0; i<list.Count; i++) 
            {
                Console.WriteLine(list[i]); 
            }

            list.Remove(list[0]);     // 데이터 삭제함수
            Console.WriteLine(list[0]);

            list.Insert(2,63.825f);   //특정 인덱스에 데이터 추가하는 함수.
            Console.WriteLine(list[2]);



            #endregion
        }
    }
}