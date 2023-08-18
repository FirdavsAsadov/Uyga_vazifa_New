using N26_HT_Task1.Interfeys;
using N26_HT_Task1.Model;

namespace N26_HT_Task1.Service;

public class PaymentService : IPaymentService
{
    public bool Checkout(decimal amount, DebitCard debitCard)
    {
        if (amount <= debitCard.Balance)
        {
            debitCard.Balance -= amount;
            return true;
        }
        return false;
    }
}