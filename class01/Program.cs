using System;
using System.Collections;           
using System.Collections.Generic;

namespace class01
{
    class Shop
    {
       virtual public void Purchase()
        {
            Console.WriteLine("구매");
        }

        virtual public void Sale()
        {
            Console.WriteLine("판매");
        }
    }

    class Equipment : Shop
    {
        public override void Purchase()
        {
            Console.WriteLine("장비구매");
        }
        public override void Sale()
        {
            Console.WriteLine("장비판매");
        }

    }

    class CashShop : Shop
    {
        public override void Purchase()
        {
            Console.WriteLine("캐쉬구매");
        }

        public sealed override void Sale()
        {
            Console.WriteLine("캐쉬판매");
        }
    }

    class EventShop : CashShop
    {
        public override void Purchase()
        {
            Console.WriteLine("이벤트구매");
        }

        //public sealed override void Sale() // => 에러뜸
        //{
        //    Console.WriteLine("캐쉬판매");
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           // sealed : class 또는 method가 다른 클래스에서 상속되지 않도록 막아주는 키워드.

           EventShop eventshop = new EventShop();
           eventshop.Purchase();
           eventshop.Sale();

        }

    }
}
