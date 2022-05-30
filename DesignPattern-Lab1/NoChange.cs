using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Lab1
{
    internal class NoChange : Calculator
    {
        public Calculator Calculator;


        public string GetDescription()
        {
            return "basePrice";
        }

        public double GetDiscount()
        {
            return Calculator.basePrice ;
        }
    }
}
