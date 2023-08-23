using N30_HT_Task2;

public class Program
{
    static async Task Main(string[] args)
    {
        var employeService = new EmplayeeService();
        Console.WriteLine("Input The FirstName: ");
        var firstName = Console.ReadLine();
        Console.WriteLine("Input The LastName: ");
        var lastName = Console.ReadLine();
        Console.WriteLine("Input The Email: ");
        var email = Console.ReadLine();
        await employeService.HireAsync(firstName, lastName,email);
        Console.WriteLine("Hiring process completed successfully");
    }
}
