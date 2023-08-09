using N21_HT_task1.DebitCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT_task1.IPaymentProvider
{
    internal class PaymePaymentProvider : IPaymentProvider2
    {
        public decimal TransferInterest { get; init; }
        public PaymePaymentProvider()
        {
            TransferInterest = 1;
        }
        public void Transefer(IDebitCard sourceCard, IDebitCard destinationCard, decimal amount)
        {
            
            decimal totalAmount = amount + (amount / 100 * TransferInterest);
            if(sourceCard.Balance >= amount)
            {
                sourceCard.Balance -= totalAmount;
                destinationCard.Balance += amount;
            }
            else
            {
                throw new InvalidOperationException("Balanceda pul kam!!");
            }
        }
    }
}
