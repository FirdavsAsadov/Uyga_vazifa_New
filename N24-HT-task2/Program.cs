using N24_HT_task2;

var users = new List<User>
{
    new User("John", "Doe", "johndoe@example.com"),
    new User("Jane", "Doe", "janedoe@example.com"),
    new User("Bob", "Smith", "bobsmith@example.com"),
    new User("Alice", "Johnson", "alicejohnson@example.com"),
    new User("Mike", "Brown", "mikebrown@example.com"),
    new User("Emily", "Davis", "emilydavis@example.com"),
    new User("David", "Wilson", "davidwilson@example.com"),
    new User("Sarah", "Taylor", "sarahtaylor@example.com"),
    new User("Tom", "Anderson", "tomanderson@example.com"),
    new User("Lisa", "Thomas", "lisathomas@example.com")
};
Console.WriteLine("So'z kiriting: ");
var keyword = Console.ReadLine();
users.Where(a => a.FirstName.Contains(keyword, StringComparison.OrdinalIgnoreCase) || a.LastName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||a.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase))
    .ToList().ForEach(a => Console
    .WriteLine( $"{a.FirstName.PadRight(15)}{a.LastName.PadRight(15)}{ a.Email}"));
    