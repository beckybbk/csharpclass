using System;
using System.Collections;           
using System.Collections.Generic;

namespace class01
{

    internal class NPC
    {
        //delegate void CallBack(); // 델리게이트 선언
        static void Main(string[] args)
        {
            #region 분할클래스 
            /*
            // 분할클래스 : 클래스 구현이 길어질 경우 2개 이상의 소스 파일로 분할하여 동시에 작업을 수행하거나 관리의 편의를 위해 분할하는 클래스. 

            NPC01 npc = new NPC01();
            npc.health = 100;
            npc.Dialogue();
            */
            #endregion


            //CallBack callback = () => Console.WriteLine("안녕"); // 람다식 무명메소드 
            //callback();

            // action : 반환형 메소드가 없는 메소드를 저장할 수 있는 delegate (고급문법), 매개변수를 최대 16개까지 지정할 수 있다.
            //Action<int> action = (int a) => Console.WriteLine("Action 입니다");
            //action(10);

            //// Func : 반환형이 존재하는 메소드를 저장할 수 있는 delegate (고급문법), Func<매개변수, 반환형>

            //Func<int, int> func = (int a) => 10;
            //Console.WriteLine("Func의 값: " + func(10));
            

        }

    }
}

