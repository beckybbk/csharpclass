
using System.Collections;

namespace Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 박싱 언박싱
            /*
            int data = 100; // => 값 타입을 참조타입에 넣어 형식을 변환해주는 것: 박싱 boxing 
            object obj = data; 
            // boxing 과정은 암묵적 형 변환 발생 
            
            Console.WriteLine(obj);

            // 언박싱: 박싱되어 있는 참조 형식을 값 형식으로 변환해주는 것. 

            int result = (int)obj;  // 명시적형변환 필요. 

            // 정리하면 : 값 -> 참조 (박싱, 메모리 할당 20배)  vs 참조-> 값 (언박싱, 메모리 할당 4배)
             */
            #endregion


            //ArrayList
            /*
            // <T> 제네릭을 사용하게 됨  
            ArrayList arrayList = new ArrayList(); // 참조타입. 메모리 할당. 연속적 메모리할당 - 배열기반.
            arrayList.Add(100);        // 값 타입
            arrayList.Add(3.56);       // 값 타입
            arrayList.Add('T');        // 값 타입
            arrayList.Add("string");   // 참조 타입

            Console.WriteLine(arrayList.Capacity);

            for (int i= 0; i<arrayList.Count; i++);
            {
                Console.WriteLine(arrayList[i]);
            }
            */

            //string 
            /*
            String name = "Kim";

            Console.WriteLine(name);

            name = " Bo ";
            Console.WriteLine(name);
            */

            //입력
            string input = Console.ReadLine();
            Console.WriteLine(input);   


        }
    }
}