using N26_HT_Task1.Model;

namespace N26_HT_Task1.Interfeys;

public interface IPaymentService
{
    public bool Checkout(decimal amount, DebitCard debitCard);
}