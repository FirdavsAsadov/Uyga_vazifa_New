public class BankAccount
{

    public BankAccount(string _accountHolderName, int _accountNumber, double _balance)
    {
        if (string.IsNullOrWhiteSpace(_accountHolderName) || _accountHolderName.Length < 3)
        {
            throw new ArgumentException("invalid!!!");
        };


        AccountHolderName = _accountHolderName;
        AccountNumber = _accountNumber;
        Balance = _balance;

    }
    public string AccountHolderName { get; set; }
    public int AccountNumber { get; set; }

    public double Balance { get; set; }

    public virtual void Deposit()
    {

    }

    public virtual void WithDraw()
    {

    }
}