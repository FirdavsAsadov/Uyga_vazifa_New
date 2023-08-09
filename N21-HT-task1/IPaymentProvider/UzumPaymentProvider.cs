using N21_HT_task1.DebitCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT_task1.IPaymentProvider
{
    internal class UzumPaymentProvider : IPaymentProvider2
    {
        public decimal TransferInterest { get; init; }
        public UzumPaymentProvider()
        {
            TransferInterest = 1;
        }
        public void Transefer(IDebitCard sourceCard, IDebitCard destinationCard, decimal amount)
        {
            decimal totalAmount = amount + (amount / 100 * TransferInterest);
            if (sourceCard.Balance >= totalAmount)
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
