using System.Text.RegularExpressions;

namespace N28_HT_Task1;

public class UserService
{
    private List<User> _users = new List<User>()
    {
        new User("toshmurodovj13@gmail.com", "fedya_2006"),
        new User("G'ishmat@gmail.com", "gishmat1232"),
        new User("Bekzodjon4334@gmail.com", "bekzodjon0201")
    };
    
    public void Add(string email, string password)
    {
        const string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        Regex regex = new Regex(pattern);
        if (!regex.IsMatch(email) && string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("Invalid email");
        }

        const string passwordpattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
        Regex regexpassword = new Regex(passwordpattern);
        if (!regexpassword.IsMatch(password) && string.IsNullOrWhiteSpace(password))
        {
            throw new ArgumentException("Invalid password");
        }

        _users.Add(new User(email, password));
    }

    public List<User> GetUser()
    {
        return _users;
    }

    public void EnsureAdmin(List<User> users)
    {
        if (_users.Any(x => x.isAdmin == true))
            return;
        if (!_users.Any(x => x.isAdmin == true))
        {
            _users.Prepend(new User("firdavsasadov1234@gmail.com", "firdavsasad",true));
        }

       
        
    }
}