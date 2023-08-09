using N21_HT_task1.DebitCard;
using N21_HT_task1.IPaymentProvider;
using N21_HT_task1.OnlineMarketService;

public partial class Program
{
    static void Main(string[] args)
    {
        var kapitalUzcard = new KapitalUzcard("123456789", "AgroBank", 10000);
        /*       IDebitCard millyHumo = new MillyHumo("987654321", "TuronBank", 20000);*/

        IPaymentProvider2 paymeProvider = new PaymePaymentProvider();
        IPaymentProvider2 uzumProvider = new UzumPaymentProvider();

        OnlineMarket marketWithPayme = new OnlineMarket(paymeProvider, new MillyHumo("987654321", "TuronBank", 20000));
       /* OnlineMarket marketWithUzum = new OnlineMarket(uzumProvider, new MillyHumo("987654321", "TuronBank", 20000));
*/
        Product laptop = new Product("Asus", 1000);
        Product smartphone = new Product("Iphone", 1000);

        marketWithPayme.Add(laptop);
        marketWithPayme.Add(smartphone);

        /*marketWithUzum.Add(laptop);
        marketWithUzum.Add(smartphone);
*/
      /*  marketWithPayme.Buy("Laptop", 1, kapitalUzcard, millyHumo);*/
        marketWithPayme.Buy("Asus", 2, kapitalUzcard);
        
        Console.WriteLine($"My card balance {kapitalUzcard.Balance}");

    }
}





