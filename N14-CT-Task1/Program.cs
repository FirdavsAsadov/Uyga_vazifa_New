public class Program
{
    static void Main()
    {
        Animal sparrowA = new Animal();
        Animal sparrowB = new Bird();
        Animal sparrowC = new Tiger();

        sparrowA.FunFact();
        sparrowB.FunFact();
        sparrowC.FunFact();
    }
}
public class Animal
{
    public virtual void FunFact()
    {
        Console.WriteLine("Football is being sold for money");
    }
};
public class Bird : Animal
{
    public override void FunFact()
    {
        Console.WriteLine(" ROONALDOO King of the Footbal ");
    }
};

public class Tiger : Animal
{
    public override void FunFact()
    {
        Console.WriteLine("Life is short");
    }
}



