using System.Collections;

namespace Indexer0330
{
    class Car
    {
        private string [] name;
        private float speed;

        public Car(int size)
        {
            name = new string[size];                    
         
        }

        //인덱서 선언: 접근 지정자 - 자료형 - this[int index] 
        public string this[int index]   //게터만 구현해줘도 에러 안남. 
        {
            get 
            { 
                return name[index]; 
            }
            set 
            {
                name[index]= value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 콜렉션(linkedlist)

            //List<int> list =new List<int>();
            //ArrayList arrayList = new ArrayList();            
            //LinkedList<int> linkedList = new LinkedList<int>(); 

            //linkedList.AddFirst(10);
            //linkedList.AddFirst(5);
            //linkedList.AddLast(20);
            //linkedList.AddLast(30);

            //linkedList.Remove(20);       //삭제하고 싶은 값을 ()안에 넣어줘야 함.      

            ////linkedList.Find(5);         // 잘 안되노.... 

            //foreach(var element in linkedList) 
            //{
            //    Console.WriteLine(element);
            //}

            //list[0] = 10;               // generic
            //arrayList[0] = 10;
            //arrayList[1] = "Academy";   // object
            // list와 arrayList의 차이: arrayList는 오브젝트 이므로 모든 데이터를 받을 수 있다. 

            #endregion

            #region 콜렉션(Dictionary)
            //Dictionary<string, int> dictionary = new Dictionary<string, int>();
            //dictionary.Add("Sword", 10000);
            //dictionary.Add("Axe", 5000);
            //dictionary.Add("Knife", 3000);

            //foreach(var item in dictionary.Keys)    //그냥 dictionary만 넣으면 뒤에 가격까지 같이 출력됨.
            //{ 
            //    Console.WriteLine(item);
            //}

            //if (dictionary.ContainsKey("Sword"))
            //{
            //    Console.WriteLine("존재합니다");
            //}

            ////TryGetValue : 키를 통해 값을 반환하는 함수.

            //int name;
            //                          //Key     value
            //if(dictionary.TryGetValue("Sword", out name))
            //{
            //    Console.WriteLine("Sword의 가격: " + name);
            //}
            //else
            //{
            //    Console.WriteLine("Key가 없음.");
            //}




            #endregion

            #region 인덱서
            //클래스의 멤버로 클래스의 값을 배열처럼 접근할 수 있도록 설정하는 문법.
            Car car= new Car(10);
            car[0] = "BMW";
            Console.WriteLine("car의 이름 : " + car[0]);

            car[1] = "Jaguar";
            Console.WriteLine("car의 이름 : " + car[1]);
            Console.WriteLine("car의 이름 : " + car[0]); // Jaguar 가 출력됨... 최종값으로 반환되기 때문. index 넣어줘야 댐.



            #endregion 

        }
    }
}