using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Product
{
    public class Clothing:Product
    {
        public string Size { get; set; }
        public string? Material { get; set; }

        public Clothing(string name, double price, string material, string size)
            : base(name, price)
        {
            Material = material;
            Size = size;
        }
        public override string GetProductDetails()
        {
            return $"{Name} with {Price}$ and with  Material: {Material} and  Size : {Size}";
        }
    }
}
