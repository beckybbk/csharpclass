namespace Casting0322
{
    class Unit
    {
        protected int health = 100;
        protected int attack = 10;

        virtual public int AttackDamage()
        {
            return attack;
        }
        public void Skill() 
        {
            Console.WriteLine("Unit의 스킬 : ");        
        }

        public void Recovery(Unit obj) 
        {
            obj.health += 100; 
        }

        public void Damage(Unit obj) 
        { 
            obj.health -= obj.AttackDamage();  
        }
    }

    class Marine : Unit 
    {
        public Marine() 
        { 
            health= 50;
            attack= 5;
        }

        override public int AttackDamage()
        {
            Console.WriteLine("Marine Attck");
            return attack;
        }
        new public void Skill() // 부모 메소드 숨기기(자식 메소드로 덮기) 
        {
            Console.WriteLine("Steam  Pack");
        }
    }

    class Ghost : Unit
    {
        public Ghost()
        {
            health = 75;
            attack = 15;
        }

        override public int AttackDamage()
        {
            Console.WriteLine("Ghost attack");
            return attack;
        }
        new public void Skill()
        {
            Console.WriteLine("Lock Down");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Marine marine= new Marine();
            //marine.Skill(); 

            Ghost ghost= new Ghost();
            //ghost.Skill();

            Unit unit= new Marine(); // 부모(상위클래스)와 자식(하위클래스)간에 자동 업캐스팅(형 변환)이 됨. 이게 재정의와 다른점.
            
            //unit.Recovery(marine);
            //unit.Recovery(ghost);

            unit.Damage(marine);
            unit.Damage(ghost); 
        
        }

    }
}