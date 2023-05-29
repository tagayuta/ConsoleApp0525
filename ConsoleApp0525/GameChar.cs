using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0525
{
    internal class GameChar
    {
        private string name;
        private int hp;

        public GameChar(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        public string Name { get { return name; } }
        public int HP {
            get { return hp; } 
        }

        public void Attack(int atk)
        {
            Random random = new Random();
            atk = random.Next(1, 5);
            hp -= atk;
            Console.WriteLine(this.name + "は" + atk + "の攻撃を受けた");
            if (hp < 0)
            {
                Console.WriteLine(this.name + "のHPは0になりました。");
                Console.WriteLine(this.name + "は倒れた");
                this.hp = 0;
            }
        }

        public void showHP()
        {
            Console.WriteLine("HPは" + this.hp);
        }

        public void resulection(int num)
        {
            this.hp += num;
            if(this.hp > 10)
            {
                this.hp = 10;
            }
            Console.WriteLine(this.name + "は回復魔法を使用した");
            Console.WriteLine("HPが" + num + "回復した");
        }
    }
}
