using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT_task1.OnlineMarketService
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name) || price == null)
                throw new Exception("Productga nom ber va uni narxini yoz!!");
            Name = name;
            Price = price;
        }
    }
}
