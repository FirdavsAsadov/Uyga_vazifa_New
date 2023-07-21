// Relational Pattern Matching
/*Console.WriteLine("Relational pattern matching : ");

var grade = 80;
var gradeLevel = grade switch
{
    >= 90 => "Top",
    >= 80 and < 90 => "Good",
    >= 70 and < 80 => "Normal",
    _ => "Bad"
};*/








/*using System.Linq.Expressions;
try
{

    Console.WriteLine("Yosh kiriting: ");
    var age = int.Parse(Console.ReadLine());
    var gradeLevel = age switch
    {
        <= 18 => throw new ArgumentOutOfRangeException("Sorry, you're too young"),
        >= 90 => throw new ArgumentOutOfRangeException("Sorry, you're too old"),
        >= 18 and <= 90 => "Valid Age"
    };
}
catch (ArgumentOutOfRangeException arg)
{
    Console.WriteLine(arg);
}*/
Random rand = new Random();
int rnd = rand.Next(1, 10);
Console.WriteLine(rnd);
while (true) 
{

    try
    {
        /*Random rand = new Random();
        int rnd = rand.Next(1, 10);
        Console.WriteLine(rnd);*/
        Console.WriteLine("Son kiriting: ");
        var son = Console.ReadLine();
        if (int.TryParse(son, out int result))
        {
            if (result == rnd)
            {
                Console.WriteLine("Congrats! You Guessed");
            }
            else throw new ArgumentOutOfRangeException("You couldn't guess it");
        }
        else throw new FormatException("Not a number");
    }
    catch (ArgumentOutOfRangeException ar)
    {
        Console.WriteLine(ar.Message);
    }
    catch(FormatException forr)
    {
        Console.WriteLine(forr.Message);
    }
}