using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0525
{
    internal class EMoney
    {
        public int money = 0;

        public void Charge(int money)
        {
            this.money += money;
            Console.WriteLine("残高：" + this.money);
        }

        public void Spend(string product, int price)
        {
            this.money -= price;
            Console.WriteLine("商品:" + product + "価格" + price + "円");
            Console.WriteLine("残高:" + this.money + "円");
        }
    }
}
