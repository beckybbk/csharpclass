using System.Linq.Expressions;

namespace Anonymous0328     
{

    class Vector<T>
    {
        private T[] element = new T[10];

        public Vector()
        {
            for (int i = 0; i < element.Count(); i++) ;
            {
                Console.WriteLine(element.Count());
            }
        }
        public T Index(int index)
        {
            return element[index];
        }

    }
    internal class Program
    {
        delegate int Caculator(int x, int y);

        // <T> 형식 매개변수: 호출시 <>에 형식명을 넣으면 컴파일러가 나머지 부분도 같은 형식 매개변수로 치환함.
        static void Resolution<T>(T x, T y)
        {
            Console.WriteLine("x 해상도 : " + x + " " + "y 해상도 : " + y);
        }
        

        static void Main(string[] args)
        {
            #region 무명형식
            //무명메소드: 이름이없는 형식,선언과 동시에 인스턴스 할당.
            //instance.name="John"; 무명형식은 값을 참조해서 수정할 수 없음(일회용)

            //var instance = new { name = "James", age = 19 };

            //Console.WriteLine(instance.name);
            //Console.WriteLine(instance.age);
            #endregion

            #region 무명메소드
            //Caculator calculator;

            //calculator = delegate (int x, int y)
            //{
            //    return x + y;
            //};

            ////calculator = delegate(float x, float y) //무명 메소드도 delegate 타입과 일치해야 함.
            ////{
            ////    return x - y;
            ////}

            //Console.WriteLine(calculator(10, 20));

            ////람다식(Lamda Expression): 무명형식을 더 간소화 해서 사용하는 방식
            //calculator = (x, y) => x * y;

            //Console.WriteLine(calculator(5, 5));
            #endregion

            //일반화 프로그래밍: 데이터 형식을 정해놓는게 아닌, 특수형식을 사용하는 코드의 데이터 형식을 일반화 해 모든 형식을 지원.
            Resolution<int>(10, 20);        //<int>, <float> 등 타입을 설정 안해줘도 자동으로 처리 됨.
            Resolution<float>(1925.5f, 1300.5f);


            Vector<int> vector = new Vector<int>();
            Console.WriteLine(vector.Index(0));
            



        }
    }
}