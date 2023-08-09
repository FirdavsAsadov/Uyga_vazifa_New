using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT_task1.DebitCard
{
    internal interface IDebitCard
    {
        string CardNumber { get; set; }
        string BankName { get; init; }
        decimal Balance { get; set; }
    }
}
