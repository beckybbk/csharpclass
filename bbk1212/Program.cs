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
            #region 매개변수 한정자 
            /*
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
            // out 키워드는 값이 초기화하지 않아도 사용할 수 있다. 
            int data;

            int item = 10;

            //ref 키워드: 매개변수가 참조로 전달할 수 있고, 호출된 메소드로 읽거나 쓸 수 있는 한정자.

            Function function = new Function();

            //ref 키워드는 인수로 전달하는 변수의 값이 초기화가 되어 있어야 

            function.Change(ref value1, ref value2);

            Console.WriteLine("value1의 값 : " + value1)

                //out 키워드 (출력용 매개변수) 매개 변수가 참ㅁ조로 전달할 수 있고 호출된 메소드에 의해서 기록하도록 지정하는 한정자

            function.Output(out data);

            Console.WriteLine("데이터의 값" + data);

            // in 키워드 : 매개변수를 참조로 전달할 수 있지만, 호출된 메소드에서 읽기만 가능한 한정자.

            function.ItemList(item int x);

            Console.WriteLine("item의 값 : " + item);

            Solution solution = new Solution();
            solution.Function();


            // solution.Swap(); => 에러뜸 (위에 int value1,2 필요) 
            // call by pass : 값에 의한 전달 (swap을 했어도 값이 바뀌지 않음) 
            solution.Swap(value1,value2);
            Console.WriteLine("value1의 값 : " + value1);
            Console.WriteLine("value2의 값 : " + value2);

            Solution.Post(); // class이름으로 바로 접근해 Post를 호출? 

            Console.WriteLine(solution.Calculator());





            public void Output(out int x)

                // out은 함수 내부에서 메소드 외부로 전달하는 방향입니다. 

            public void Itemlist(in Int x)

                // in은 메소드 내부에서 값을 수정할 수 없음. 
                //x = 500;
            int variable = x;
            Console.WriteLine("variable의 값: " + variable);
        }

        // params 키워드: 매개변수가 가변개수의 인수를 사용할 수 있도록 지정해주는 한정자. 
        public void StatList(params int[] list)
        {
            //params 키워드는 하나만 사용 가능함.
            for(int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("list의 값 : " + list[i]);
            }
        }
            function.StatList(1,2,3,4,5);
            // 인수를 전달하지 않으면 배열의 길이는 0으로 설정됨.
            function.StatList();
            */
            #endregion


            var name = "BBK";
            var age = 1;
        var health = 100.0;
        var alphabet = 'A';
        //var는 스택 메모리에 저장, object와 같지만 object는 박싱이 일어남. 

        Console.WriteLine("name의 값 : " + name);
        Console.WriteLine("age의 값 : " + age);
        Console.WriteLine("health의 값 : " + health);
        Console.WriteLine("alphabet의 값 : " + alphabet);
    }
}
