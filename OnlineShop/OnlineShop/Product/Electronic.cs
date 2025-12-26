using OnlineShop.Discount;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Product
{
    public class Electronic : Product,IDiscountable
    {
        public int WarrantyPeriod { get; set; }
        public Electronic(string name, double price, int warranty)
      : base(name, price)
        {
            WarrantyPeriod = warranty;
        }

        public override string GetProductDetails()
        {
            return base.GetProductDetails() +
                   $" | WarrantyPeriod: {WarrantyPeriod} months ";

        }
        public void ApplyDiscount(double percent)
        {
            Price -= Price * (percent / 100);
        }
    }
}
