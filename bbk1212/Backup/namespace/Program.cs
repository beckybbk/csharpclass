using System;
using System.Text;

namespace NameSpace
{
    class Unit

    {
        private int data;//<- 어디에서나 접근이 가능

        

        //프로퍼티
        public int Data
        {
            set
            { //data <- (value) Data 프로퍼티에서 받은 값
                if (value > 18)
                {
                    Console.WriteLine("Error value");
                    return;
                }

                data = value;
            }
            get
            {
                return data;
            }
        }

        // 자동구현 프로퍼티: 선언을 했을 때 컴파일러가 자동으로 private 필드를 생성.
        public int Health
        {
            set;
            get;
        } = 200;
    
        //프로퍼티는 get만 사용해서 선언할 수 도 있음.
        public int Attack
        {
            get;
        }
    
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            #region 프로퍼티
            /*
            Unit factory = new Unit();
            factory.Data = 100;
            factory.Health = 100;

            Console.WriteLine("unit의 health값은 : " + factory.Health);
            Console.WriteLine("unit의 데이터 값: " + factory.Data);

            */
            #endregion

            // OOP 4대 특징: 추상화, 상속, 다형성, 캡슐화  

            //StringBuilder
            
            string count = "100";
            StringBuilder score = new StringBuilder(count);

            Console.WriteLine("score 변수의 값 : " + score);

            //score ="200" x => replace 해줘야 됨. (첫번째 매개변수에 있는 문자열을 두번째 매개변수에 있는 문자열로 변경하는 메소드)
            score.Replace("100", "200");

            Console.WriteLine("score 변수의 값 : " + score);

            //append
            
            score.Append("의 값을 가지고 있음.");

            Console.WriteLine("score 변수의 값 :"+ score);
            // 가변 -> 객체가 인스턴스 된 후에 변할 수 있는 객체
            // 불변 ->         "            변할 수 없는 객체

            string name = "BB";
            name = "LEE";

        }
    }

}