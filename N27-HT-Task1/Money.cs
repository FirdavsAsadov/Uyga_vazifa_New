namespace N27_HT_Task1;

public class Money
{
    public decimal Amount { get; set; }
    public Currency Currency { get; set; }
    public MoneyType Type { get; set; }

    public Money(decimal amount, MoneyType type, Currency currency = Currency.UZS)
    {
        Amount = amount;
        Type = type;
        Currency = currency;
    }

    public Money()
    {
        
    }

    public static Money operator +(Money first, Money second)
    {
        if(first.Type == first.Type )
            return new Money(first.Convert(first) + second.Convert(second), first.Type);
        if(first.Type == MoneyType.InBalance && second.Type == MoneyType.Loan)
            return new Money(first.Convert(first) - second.Convert(second),first.Type);
        if(second.Type == MoneyType.Loan && second.Type == MoneyType.InBalance)
     
            return new Money(second.Convert(second) - first.Convert(first),first.Type);
        return null;
    }

    public decimal Convert(Money money)
    {
        if (money.Currency.ToString() == "UZS")
            return money.Amount;
        if (money.Currency.ToString() == "USD")
            return money.Amount * 12000;
        if (money.Currency.ToString() == "RUB")
            return money.Amount * 129;
        else return 0;
    }
}