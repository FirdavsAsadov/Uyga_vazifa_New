using N21_HT_task1.DebitCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT_task1.IPaymentProvider
{
    internal interface IPaymentProvider2
    {
        void Transefer(IDebitCard sourceCard, IDebitCard destinationCard, decimal amount)
        {
            decimal totalAmount = amount + amount * TransferInterest;
            if (sourceCard.Balance >= totalAmount)
            {
                sourceCard.Balance -= totalAmount;
                destinationCard.Balance += amount;
            }
        }
        decimal TransferInterest { get; init; }
    }
}
