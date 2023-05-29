using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0525
{
    internal class test20230529
    {
        public static void main()
        {
            /*int num = 5;
            switch(num)
            {
                case 3:
                    Console.WriteLine("numの値は3です");
                    break;

                case 4:
                    Console.WriteLine("numの値は4です");
                    break;

                default:
                    Console.WriteLine("numの値はそれ以外です！");
                    break;
            }
            */

            Random rnd = new Random();
            int dice = rnd.Next(1, 7);
            Console.WriteLine(dice);

        }
    }
}
