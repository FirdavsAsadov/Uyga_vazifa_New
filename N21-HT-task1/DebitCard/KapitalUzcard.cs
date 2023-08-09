using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT_task1.DebitCard
{

    internal class KapitalUzcard : IDebitCard
    {
        public string CardNumber { get; set; }
        public string BankName { get; init; }
        public decimal Balance { get; set; }

        public KapitalUzcard(string cardNumber,string bankname,  decimal initialBalance)
        {
            if(string.IsNullOrWhiteSpace(cardNumber) || string.IsNullOrWhiteSpace(bankname) || initialBalance == null)
                throw new ArgumentNullException("Error");
            CardNumber = cardNumber;
            BankName = bankname;
            Balance = initialBalance;
        }

    }


}
