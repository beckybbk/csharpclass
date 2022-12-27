using System;
using System.Collections;           // 컬렉션 네임스페이스 
using System.Collections.Generic;

namespace class01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 컬렉션 : 데이터를 저장하는 자료구조와 데이터를 처리하는 알고리즘을 구조화하여 클래스로 나타낸 형태. 

            #region List
            /*
            // List
            List<int> list = new List<int>();

            // Add()
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            // Insert() : (저장하고 싶은 index), (저장할 값)
            list.Insert(4, 66);

            // Remove()
            list.Remove(3);

            // RemoveAt()
            list.RemoveAt(1);

            // size 
            int size = list.Count;


            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            */
            #endregion


            #region ArrayList
            /*
            // ArrayList
            ArrayList arrayList = new ArrayList();

            // Add()
            // 0    1       2       3       4
            //[1] [64.5f] ['V'] ["under"] [false]
            arrayList.Add(1);
            arrayList.Add(64.5f);
            arrayList.Add('V');
            arrayList.Add("under");
            arrayList.Add(false);

            // Insert() : (저장하고 싶은 index), (저장할 값)
            arrayList.Insert(4, 33.987);

            // Remove()
            arrayList.Remove(64.5f);

            // RemoveAt()
            arrayList.RemoveAt(0);

            // size 
            int size = arrayList.Count; 


            foreach(var element in arrayList)
            {
                Console.WriteLine(element);
            }
            */
            #endregion

            #region Dictionary
            /*
            // Dictionary
            Dictionary<string, int> item = new Dictionary<string, int>();

            // Add()
            item.Add("Sword", 10000);
            item.Add("Hat", 1000);
            item.Add("Shoes", 5000);
            item.Add("Gloves", 3000);

            // Remove()
            item.Remove("Shoes"); 

            // 키 정보탐색 
            bool findKey = item.ContainsKey("Hat");

            // value 정보탐색
            bool findValue = item.ContainsValue(2000);

            Console.WriteLine(item["Sword"]);
            // Console.WriteLine(item["Riven"]); //  => 에러: 딕셔너리에 존재하지 않는 Key 값을 출력하면 오류. 
            */
            #endregion

            // Stack
            // Queue
        }

    }
}
