using System;

namespace bbk1212
{

    class Solution
    {

        public void Function()
        {
            Console.WriteLine("Function");
        }

        public int Calculator()
        {
            // 반환하는 메소드의 자료형과 반환하는 값의 자료형이 일치해야 함. 
            return 0; //=> string 같은게 올수없음...?
        }

        public void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp; //(값을 바꾸는 메소드
        }

        public static void Post()
        {
            Console.WriteLine("Static Post");
        }
    }

    internal class Program
    {

        // 이런 식으로 Program 메모리 할당 해줘야.

        static void Main(string[] args) // static을 붙이면 데이터 영역에 올라가므로 할당 굳이 필요없음.
        {
            #region 박싱(Boxing) : 값 형식을 참조 형식으로 변환해주는 과정.
            /*
             int value = 10;
             // 참조   값
             // [] <- 10이란 값을 넣는것 
             // 암묵적인 형 변환이 일어남. : object가 값타입(value)보다 상위의 자료형이기 때문에 암묵적으로 형 변환이 가능함.
             // ex) double a =10; 하면 10.00 으로 나타냄. 
             object obj = value; //참조형변수

             obj = 300;
             // 박싱을 하는 과정에서 추가적인 메모리가 발생. 

             Console.WriteLine("obj의 값: "+obj);
             Console.WriteLine("value의 값 :" + value);

             // 언박싱( UnBoxing): 참조 타입을 값 타입으로 변환하는 과정

             // int data=obj;=> 에러 (data 변수가 값 타입이므로, obj 참조 타입보다 하위 자료형이기 때문에 명시적으로 형 변환을 해주어야 함.
             int data=(int)obj;

             // 언박싱 변환 시 스택메모리에 언박싱된 무명객체가 생성되며, 이 무명객체를 다시 해당 객체에 대입하는 원리. 
             Console.WriteLine("data의 값 : " + data);

             // int []dataTable = new int[5]; => sword 문자 넣으면 에러뜸
             object [] dataTable = new object[5];
             dataTable[0] = 10;
             dataTable[1] = "Sword"; // 문자를 넣어서 호환이 안댐. 그래서 int 대신 object[5]를 넣어줌. 
            */
            #endregion

            int value1 = 10;
            int value2 = 20;


            Solution solution = new Solution();
            solution.Function();


            // solution.Swap(); => 에러뜸 (위에 int value1,2 필요) 
            // call by pass : 값에 의한 전달 (swap을 했어도 값이 바뀌지 않음) 
            solution.Swap(value1,value2);
            Console.WriteLine("value1의 값 : " + value1);
            Console.WriteLine("value2의 값 : " + value2);

            Solution.Post(); // class이름으로 바로 접근해 Post를 호출? 

            Console.WriteLine(solution.Calculator());
        }
    }
}
