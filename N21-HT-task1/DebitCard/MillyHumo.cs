using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT_task1.DebitCard
{
    internal class MillyHumo : IDebitCard
    {
        public string CardNumber { get; set; }
        public string BankName { get; init; }
        public decimal Balance { get; set; }

        public MillyHumo(string cardNumber, string name, decimal initialBalance)
        {
            if(string.IsNullOrWhiteSpace(cardNumber) || string.IsNullOrWhiteSpace(name) || initialBalance == null)
                throw new Exception("Error!!!");
            
            CardNumber = cardNumber;
            BankName = name;
            Balance = initialBalance;
        }
    }
}
