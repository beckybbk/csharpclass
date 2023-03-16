using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Class0316
{
    class Dog
    {
        //접근지정자 
        // public : 클래스 외부로부터 접근 허용.
        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set 
            { 
                age = value;
                if (value >=18)
                {
                    value = 18;
                }     
            }
        }
        protected char grade;
        private float health;

        // protected : 자신과 상속하는 클래스만 접근 허용
        // private : 클래스 내부만 접근 허용. (자신만 - 기본 접근지정자)

        //void Sound()
        //{
        //    Console.WriteLine("멍멍!");
        //}
    }

    class Maltese : Dog
    {
        public void Information()
        {
            grade = 'A';
            Console.WriteLine("등급:" + grade);
        }
    }
    internal class Program
    {
        #region 클래스
        //static void Main(string[] args)
        //{
        //    Dog dog = new Dog(); // 메모리 할당
        //    dog.Age = 5;
        //    Console.WriteLine("dog.Age의 값은:" + dog.Age);

        //    Maltese maltese= new Maltese();
        //    maltese.Information();


        //}
        #endregion

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(input.Length);

            //int count = 0;
            //for(int i = 0; int< input.Length; i++)
            //{
            //  count++;
            //}
        }
    }


}