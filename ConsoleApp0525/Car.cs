using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0525
{
    internal class Car
    {
        private int fuel;
        
        public void segFuel(int fuel) 
        {
            this.fuel = fuel;
        } 

        public int getFuel()
        {
            return this.fuel;
        }
    }
}
