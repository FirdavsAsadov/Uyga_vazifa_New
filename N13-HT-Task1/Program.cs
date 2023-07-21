using System.Xml.Serialization;

public class Program
{
    public static void Main()
    {
        var animal = new Animal();
        animal.MakeSound();
        var greatwhiteshark = new GreatWhiteShark();
        var tiger = new Tiger();
        var sparrow = new Sparrow();
        var fish = new Fish();
        fish.Swim();
        var mammal = new Mammal();
        mammal.Run();
        var bird = new Bird();
        bird.Fly();
        

    }
}

public class Animal
{
    public void MakeSound()
    {
        Console.WriteLine("...");
    }
}
public class Bird : Animal
{
    public void Fly()
    {
        Console.WriteLine("Fly");
    }
}

public class Mammal : Animal
{
    public void Run()
    {
        Console.WriteLine("Run");
    }
}

public class Fish : Animal
{
    public void Swim()
    {
        Console.WriteLine("Swim");
    }
}

public class Sparrow : Bird
{

}

public class Tiger : Mammal
{

}

public class GreatWhiteShark : Fish
{

}
