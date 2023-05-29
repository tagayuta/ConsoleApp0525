using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0525
{
    internal class Peson
    {
        private string name;
        private int age;

        public Peson(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        public void Show()
        {
            Console.WriteLine("名前：" + this.name + "年齢：" + this.age);
        }
    }
}
