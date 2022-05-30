using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Lab1
{
    public  interface Discount
    {
        public string GetDescription();
        public double GetDiscount();
    }
}
