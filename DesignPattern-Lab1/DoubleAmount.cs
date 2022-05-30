using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Lab1
{

    public class DoubleAmount : Discount
    {
        public string GetDescription()
        {
            return "doublePrice";
        }

        public double GetDiscount()
        {
            return 2;
        }
    }
}
