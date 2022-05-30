using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Lab1
{
    internal class NoChange : Discount
    {


        public string GetDescription()
        {
            return "no change";
        }

        public double GetDiscount()
        {
            return 0;
        }
    }
}
