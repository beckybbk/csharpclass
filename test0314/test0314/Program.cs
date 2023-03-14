namespace ConsoleApp_0314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("c# programming!");

            //Console.Write("LOL"); // 줄 바꿈 없음
            //Console.Write("Hello");

            #region 값 타입
            // 값 타입
            byte value = 10;            // 1 byte
            bool check = false;         // 1 byte
            double helath = 16.75;      // 8 byte
            int data = 100;             // 4 byte
            char alphabet = 'A';        // 1 byte
            float pi = 3.14f;           // 4 byte

            Console.WriteLine(alphabet);
            Console.WriteLine("alphabet 변수는" + alphabet);
            Console.WriteLine(data);
            Console.WriteLine(pi);

            // 참조타입 : string, class, object, delegate... 
            string name;
            int[] array = new int[3];
            array[0] = 100;
            array[1] = 200;
            array[2] = 300;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            #endregion
        }
    }
}