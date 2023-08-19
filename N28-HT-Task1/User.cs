namespace N28_HT_Task1;

public class User
{
    public Guid Id { get; set; }
    public string EmailAdress { get; set; }
    public string Password { get; set; }
    public bool isAdmin { get; set;}

    public User(string email, string password, bool isAdmin = false)
    {
        Id = Guid.NewGuid();
        EmailAdress = email;
        Password = password;
        this.isAdmin = isAdmin;
    }
}