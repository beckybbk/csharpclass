using System.ComponentModel;

namespace Override0321
{
    class Weapon
    {
        
        private string name;
        //private int itemType;

        public enum itemType
        {
            Sword,
            Gun,
            Arrow

        }

        public Weapon()
        {
            Console.WriteLine("매개변수 없는 생성자 호출");
        }

        public Weapon(string name)
        {
            this.name = name;
            Console.WriteLine("매개 변수가 있는 생성자");
        }

        public void Select(itemType item)
        {
            //itemType = count;
            switch (item)
            {
                case itemType.Sword: Console.WriteLine("Sword");
                    break;
                case itemType.Gun: Console.WriteLine("Gun");
                    break;
                case itemType.Arrow: Console.WriteLine("Arrow");
                    break;
            }
        }

        public void Attack(int damage) //함수의 오버로딩
        {
            Console.WriteLine("int Damage : " + damage);
        }

        public void Attack(int damage, int poison) // 매개변수 갯수 2개
        {

        }

        public void Attack(float damage)
        {
            Console.WriteLine("float Damage : " + damage);
        }
    }

    class Monster
    {
        virtual public void Attack()
        {
            Console.WriteLine("Monster 공격");

        }
    }

    class Goblin : Monster
    {
        override public void Attack()
        {
            Console.WriteLine("Goblin 공격");

        }
    }

    // 함수의 오버로딩은 타입 갯수에 따라 함수를 여러개 만들 수 있다. 
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 함수오버로딩
            //  Weapon weapon = new Weapon("Gun");
            //  weapon.Attack(100);     //Attack(int)
            //  weapon.Attack(50.5f);   //Attack(float)
            #endregion

            #region Enum
            //Weapon weapon = new Weapon();
            //weapon.Select(Weapon.itemType.Gun);
            //weapon.Select(Weapon.itemType.Sword);
            //weapon.Select(Weapon.itemType.Arrow);
            #endregion

            Monster monster = new Goblin();
            monster.Attack();
        }
    }
}