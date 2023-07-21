public class Program
{
    static void Main()
    {
        User user = new User();
        User user1 = new person();
        User user2 = new jack();

        user.Speak();
        user1.Speak();
        user2.Speak();
    }
}





public class User
{
    public  sealed void Speak()
    {
        Console.WriteLine("wowo");
    }
}

public class person : User
{
    public  override void Speak()
    {
        Console.WriteLine("haha");
    }
}

public class jack : person
{
    public override void Speak()
    {
        Console.WriteLine("salom");
    }
}
