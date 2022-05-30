using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Lab1
{
    public class TwentyFivePercentDiscount :  Discount
    {

        public string GetDescription()
        {
            return "25%";
        }

        public double GetDiscount()
        {
            return 0.75;
        }
    }
}
