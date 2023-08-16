using System.Dynamic;
using N25;

public class Program
{
    public static void Main(string[] args)
    {
        var userCredintialss = new UserCredentialsService();
        var userService = new UserService(userCredintialss);
        RegistrationService user = new RegistrationService(userService, userCredintialss);
        user.Register("Jasur", "G'aniyev", "jasur123@gmail.com", "jasur001");
        user.Register("QodirAli", "Jayhunov", "john.doe@example.com", "john002");
        user.Register("Jasur", "G'aniyev", "sarah.smith@emailprovider.com", "sarah003");
        user.Register("Jasur", "G'aniyev", "mike1234@example.net", "mike004");
        user.Register("Jasur", "G'aniyev", "emily.jones@emailservice.org", "emily006");
        user.Register("Jasur", "G'aniyev", "alexander.brown@example.org", "alexander007");
        user.Register("Jasur", "G'aniyev", "lisa.miller@emaildomain.com", "lisa008");
        user.Register("Jasur", "G'aniyev", "robert.wilson@examplemail.net", "robert009");
        user.Register("Jasur", "G'aniyev", "olivia.johnson@emailhost.org", "olivia010");
        user.Register("Jasur", "G'aniyev", "ethan.johnson@example.net", "ethan011");
// Get
        /*var ususers = userService.Get(6, 2);
        ususers.ForEach(u => Console.WriteLine($"{u.FirstName} - {u.LastName} - {u.Email}"));*/
        //Search
        /*Console.Write("Eneter keyWord for Search: ");
        var keyWord = Console.ReadLine();
        if (keyWord != null)
        {
            userService.Search(keyWord, 6, 2)
                .ForEach(u => Console.WriteLine($"{u.FirstName} - {u.LastName} - {u.Email}"));
        }*/
        // Update
        /*Console.WriteLine("Enter Your Name: ");
        var name = Console.ReadLine();
        Console.WriteLine("Enter your last name: ");
        var lastName = Console.ReadLine();
        Console.WriteLine("Enter Your Email: ");
        var email = Console.ReadLine();*/
        
    }
}