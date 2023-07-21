    /*
     * 
     * 

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                CalculateFullName();

            }
        }

        public string LastName
        {
            get { return lastName; }
            set 
            { 
                lastName = value;
                CalculateFullName();
            }
        }

        public string Patronimyc
        {
            get { return patronimyc; }
            set 
            { 
                patronimyc = value;
                CalculateFullName();
            }
        }


        public User(string firstName, string lastName, string patronymic)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronimyc = patronymic;

        }

        private void CalculateFullName()
        {
            if(!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                FullName = $"{lastName} {firstName} {patronimyc}";
            }

            else
            {
                FullName = $"________________________________";
            }
        }*/


public static class Program
{
    public static void Main(string[] args)
    {
        var user1 = new User();
        var user2 = new User();

        user1.firstName = "Jasur";
        user1.lastName = "boyka";
        user1.patronimyc = "qosimovich";
        user2.firstName = "John";
        user2.lastName = "johns";
        user2.patronimyc = "johnatan";

        Console.WriteLine("User1: " + user1.FullName);
        Console.WriteLine("User2: " + user2.FullName);
        Console.WriteLine(user1.Equals(user2));
    }
}
public class User
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string patronimyc { get; set; }
    public string FullName => $"{firstName} {lastName} {patronimyc}";

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        User boshqa = (User)obj;

        return this.GetHashCode() == boshqa.GetHashCode();
    }

    public override int GetHashCode()
    {
        return FullName.GetHashCode();
            
    }

}