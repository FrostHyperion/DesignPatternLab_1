using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Lab1 {
    public abstract class Calculator {
        public double basePrice = Convert.ToDouble(ConfigurationManager.AppSettings["BasePrice"]);
        public Discount Discount;
        public Calculator(Discount discount) {
            Discount = discount;
        }

        public string GetDescription() {
            return Discount.GetDescription();
        }

        public double GetDiscount() {
            return Discount.GetDiscount() * basePrice;
        }

        public void SetDiscount(Discount discount)
        {
            Discount = discount;
        }
    }
}
