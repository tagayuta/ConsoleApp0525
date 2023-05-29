using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0525
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int num1 = 10;
            int num2 = 20;
            Console.WriteLine("演習問題１");
            Console.WriteLine(num1 + num2);

            Console.WriteLine("演習問題2");
            for (int i = 2; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("演習問題3");
            String[] sports = new String[] { "soccer", "tennis", "basketball" };
            for(int i = 0; i < sports.Length; i++)
            {
                Console.WriteLine(sports[i]);
            }

            Console.WriteLine("演習問題4");
            String[] fruits = new String[] { "apple", "orange", "banana" };
            for (int i = 0; i < sports.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
            Console.WriteLine(fruits.Length + "種類");


            Console.WriteLine("演習問題5");
            int[] dice = new int[] { 1, 6, 3 };
            for(int i = 0; i < dice.Length; i++)
            {
                Console.WriteLine(7 - dice[i]);
            }
            */

            /*Peson p = new Peson();
            p.name = "太郎";
            p.age = 18;
            p.Show();

            Peson p2 = new Peson();
            p2.name = "花子";
            p2.age = 16;
            p2.Show();


            Student s = new Student();
            s.name = "鈴木ひまり";
            s.grade = 3;
            Console.WriteLine("名前：" + s.name + "年齢:" + s.grade);

            Product pt = new Product();
            pt.price = 1000;
            pt.tax_rate = 10;
            Console.WriteLine(pt.CalcPrice());

            EMoney m = new EMoney();
            m.Charge(5000);
            m.Spend("ラーメン", 1000);

            Buy b = new Buy();
            b.unit_price = 100;
            int price = b.Price(50, 10);
            Console.WriteLine("購入価格：" + price); */

            Peson p = new Peson("太郎", 18);
            p.Show();
            
            Car car = new Car();
            car.segFuel(10);
            Console.WriteLine("燃料：" + car.getFuel());

            Console.WriteLine("演習問題１");
            Calc calc = new Calc(10, 20);
            Console.WriteLine(calc.Add());


            GameChar gc = new GameChar("勇者", 10);
            gc.showHP();
            while(gc.HP > 0)
            {
                Random random = new Random();
                int luck = random.Next(1, 3);
                if (luck < 2)
                {
                    gc.resulection(1);
                }
                gc.Attack(0);
                gc.showHP();
            }
            Console.WriteLine("**ゲームオーバー**");
        }
    }
}
