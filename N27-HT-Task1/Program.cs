using System.Threading.Channels;
using N27_HT_Task1;

List<Money> moneyList = new List<Money>
{
    new Money { Amount = 100.00m, Type = MoneyType.InBalance, Currency = Currency.UZS },
    new Money { Amount = 50.00m, Type = MoneyType.InBalance, Currency =Currency.USD },
    new Money { Amount = 200.00m, Type = MoneyType.Loan, Currency = Currency.RUB},
    new Money { Amount = 75.00m, Type = MoneyType.InBalance, Currency =Currency.UZS },
    new Money { Amount = 150.00m, Type = MoneyType.Loan, Currency =Currency.USD },
    new Money { Amount = 25.00m, Type = MoneyType.InBalance, Currency =Currency.RUB },
    new Money { Amount = 50.00m, Type = MoneyType.InBalance, Currency =Currency.USD },
    new Money { Amount = 10.00m, Type = MoneyType.Loan, Currency = Currency.UZS },
    new Money { Amount = 5.00m, Type = MoneyType.Loan, Currency = Currency.RUB },
    new Money { Amount = 100.00m, Type = MoneyType.InBalance, Currency = Currency.USD}
};
var totalMoney = new Money(0,MoneyType.InBalance,Currency.UZS);

foreach (var money in moneyList)
{
    totalMoney=totalMoney += money;
}
Console.WriteLine($"Total money: {totalMoney.Amount} - {totalMoney.Currency}");