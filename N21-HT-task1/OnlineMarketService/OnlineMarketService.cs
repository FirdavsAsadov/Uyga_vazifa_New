using N21_HT_task1.DebitCard;
using N21_HT_task1.IPaymentProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT_task1.OnlineMarketService
{
    internal class OnlineMarket
    {
        private IDebitCard _debitCard = new KapitalUzcard("8600042319602578","AgroBank",1 );
        List<Product> Product = new List<Product>();
        private readonly IPaymentProvider2 _paymentProvider;
        private readonly IDebitCard _marketCard;
        public OnlineMarket(IPaymentProvider2 provider, IDebitCard marketCard)
        {
            _paymentProvider = provider;
            _marketCard = marketCard;
        }

        public void Add(Product product)
        {
            Product.Add(product);
        }

        public void Buy(string name, int number, IDebitCard MyCard)
        {
            foreach (var item in Product)
            {
                if(item.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    if(item != null)
                    {
                        decimal totalAmount = item.Price * number;
                        _paymentProvider.Transefer(MyCard,_marketCard, totalAmount);
                    }
                    else
                    {
                        Console.WriteLine($"Product {name} is not found");
                    }
                }
            }
        }
      


    }
}
