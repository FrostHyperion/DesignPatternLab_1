using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Lab1 {
    internal class CalculatorFare : Calculator
    {
        public CalculatorFare(Discount discount) : base(discount)
        {
        }
    }
}
