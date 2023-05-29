using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0525
{
    internal class Buy
    {
        public int unit_price;

        public int Price(int number, int tax_rate)
        {
            int price = this.unit_price * number;
            price += (price * tax_rate /100);
            return price;
        }
    }
}
