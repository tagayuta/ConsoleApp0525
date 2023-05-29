using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0525
{
    internal class Calc
    {
    
        private int num1 = 0;
        private int num2 = 0;
        
        public Calc(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public int Add()
        {
            return this.num1 + this.num2;
        }
        public void setNum1(int num1)
        {
            this.num1 = num1;
        }

        public int getNum1()
        {
            return this.num1;
        }
        public void setNum2(int num2)
        {
            this.num2 = num2;
        }

        public int getNum2()
        {
            return this.num2;
        }

        public int sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public int mul(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
