using System.Security.Cryptography.X509Certificates;


struct DataTable
{
    public int memory;
    public int [] array;
}


class A
{
    public A()
    {
        Console.WriteLine("A 클래스");

    }
}

class B
{
    public B(string name)
    {
        Console.WriteLine("B 클래스" + name);
    }
}


namespace Action0331
{
    
    class Language<T> where T: struct    //값 타입만 받고 싶으면 where T : struct (null을 허용하지 않는 값 형식이어야 함.)
        // where T:class 는 참조형식이어야 함. 
        // where T: new() 매개변수가 없는 public 생성자가 있어야 함.
        // where T: unmanaged 는 struct 안에 참조타입을 포함하지 않음. T는 null이 아닌 비관리형 형식(char, byte, double 등)이어야 함.
        // where T:<base class name> 지정된 기본 클래스 이거나 파생된 클래스여야 함.
    {
        private T data;
        public T Data
        {
            get { return data; }

            set { data = value; }

        }
    }
    internal class Program
    {
        Action action;

        static void Close()
        {
            Console.WriteLine("Close");
        }

        static void Open(int power)
        {
            Console.WriteLine("문을 여는 힘: " + power);
        }

        static int Score()
        {
            return 100;
        }

        static int Result(int value)
        {
            return value;
        }

       

        static void Main(string[] args)
        {
            #region 액션
            //Action action = Close;
            //Action<int> intAction;

            //Func<int> func;


            //action = Close;
            //action();

            //action = () => { Console.WriteLine("로그인 되었습니다."); };
            //action();

            //intAction = Open;
            //intAction(100);
            //intAction = (x) => { Console.WriteLine("로그인 실패횟수" + x); };
            //intAction(3);
            #endregion

            #region Func
            //Func<int> func;     //Func는 <반환형, 매개변수>
            //Func<int, int> intFunc;

            //func = Score;
            //Console.WriteLine("Score : " + func());

            //func = () => { return 999; };
            //Console.WriteLine("Score : " + func());

            //intFunc = Result;
            //Console.WriteLine("Result : " + intFunc(1000));

            //intFunc = (x) => { return x; };
            //Console.WriteLine("Result : " + intFunc(222));

            #endregion

            #region 제약조건(where)

            Language<int> language = new Language<int>();
            language.Data = 100;
            Console.WriteLine(language.Data);

            //Language<DataTable> language1 = new Language<DataTable>(); //unmanaged 는 struct 안에 참조타입을 포함하지 않음.

            //Language<A> language2 = new Language<A>();    // new()타입일때 에러 안뜸.
            //Language<B> language3 = new Language<B>("s"); // 디폴트값이 없어서 에러뜸.

            #endregion


        }
    }
}