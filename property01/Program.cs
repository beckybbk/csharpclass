using System;
using System.Xml.Schema;

namespace property01
{

    internal class Program
    {// Child 클래스가 Parent 클래스를 상속함.
     //    class Child : Parent
     //    {
     //        // 기본 생성자: 생성자가 없을때 컴파일러가 자동으로 생성해주는 생성자. 

        //        public Child() : base("Parent") //base()는 상위클래스 생성자 호출 메소드.

        //        {
        //            Console.WriteLine("Chlid Class 생성");
        //        }

        //        // int age 
        //        int money;

        //        public void Function()
        //        {
        //            // base는 상위클래스를 가리키는 포인터
        //            //this는 자기자신을 가리키는 포인터
        //            base.money += 1; // 상위클래스의 money 변수 
        //            this.money += 10;  // 하위클래스의 money 변수 
        //            // base 키워드, this 키워드를 사용않고 이름이 겹치는 멤버변수 호출하면 this 포인터가 우선권 가짐.
        //            money = 10;
        //            Console.WriteLine("money의 값은 : " + money);
        //        }
        //    }

        //    // 메소드의 오버로딩 
        //    // 같은 이름의 함수를 매개변수의 자료형과 매겨변수의 수로 구분해 여러개를 선언할 수 있는 기능 

        //    class Vector
        //    {
        //        public void Coordinate(int x, int y)
        //        {
        //            Console.WriteLine("int x의 값 :" + x + "int y의 값 : " + y);
        //        }

        //        public void Coordinate(float x, float y)
        //        {
        //            Console.WriteLine("x의 값 :" + x + "y의 값 : " + y);

        //        }
        //        public void Coordinate(float x, float y, float z)
        //        {
        //            Console.WriteLine("x의 값 :" + x + "y의 값 : " + y + "z의 값: " + z);
        //        }
        //    }


        //    static void Main(string[] args)
        //    {

        //        // 상속
        //        // 상위클랙스 속성을 하위 클래스가 사용할 수 있도록 설정 

        //        Parent parent = new Parent();

        //        Child child = new Child();
        //        child.Function();

        //        //메소드의 오버로딩
        //        Vector vector = new Vector();
        //        vector.Coordinate(10.5f, 20.5f);
        //        vector.Coordinate(10, 20);
        //    }
        //}
    }
}
