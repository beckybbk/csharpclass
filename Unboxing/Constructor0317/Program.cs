namespace Constructor0317
{
    class Monster
    {
        private int health;
        private float attack;
        public Monster(int health, float attack)
        {
            this.health = health;
            this.attack = attack;
            //    Console.WriteLine("Monster 공격력" + this.attack);
            //    Console.WriteLine("Monster 체력" + this.health);
        }

        // 깊은 복사
        public Monster Clone() 
        {
            Monster temp =new Monster(health, attack);
            
            return temp;
        }
        public void DataSetting(int x, int y)
        {
            health = x;
            attack = y;
        }

        public void Information(string name)
        {
            Console.WriteLine(name + " 의 공격력" + this.attack);
            Console.WriteLine(name + " 의 체력" + this.health);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 얕은 복사 
            /*
            // 기본 생성자
            Monster monster1 = new Monster(100,20);
            monster1.Information("monster1");
            Monster monster2 = monster1.Clone();

            monster2.DataSetting(300, 50);

            monster1.Information("monster1");
            monster2.Information("monster2");

            */
            #endregion

            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a);

            string content;

            for(int i=0; i<a; i++) 
            { 
                content = Console.ReadLine();
                Console.Write(content[0]);
                Console.Write(content[content.Length - 1]);
            }

        }
    }
}