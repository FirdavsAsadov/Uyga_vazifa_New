namespace N25;

public class UserService : IUserService
{
    private readonly List<User> _users = new List<User>();
    private int nextUserId = 1;
    private readonly IUserCredentialsService _userCredentials;

    public UserService(IUserCredentialsService userCredentials)
    {
        _userCredentials = userCredentials;
    }
    public List<User> Get(int pageSize, int pageToken)
    {
        if (pageToken <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(pageToken), "Page token must be a positive integer.");
        }

        int startIndex = (pageToken - 1) * pageSize;
        return _users.Skip(startIndex).Take(pageSize).ToList();
    }

    public List<User> Search(string keyword, int pageSize, int pageToken)
    {
        int startIndex = (pageToken - 1) * pageSize;
        var filteredusers = _users.Where(x =>
            x.FirstName.Contains(keyword, StringComparison.OrdinalIgnoreCase) || x.LastName.Contains(keyword, StringComparison.OrdinalIgnoreCase) || x.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase)).Skip(startIndex).Take(pageSize).ToList();
        return filteredusers;
    }

    public List<User> Filter(UserFilterModel filter)
    {
        var userfilters = _users.Where(x => !x.IsDeleted);
        var filteredusers = userfilters.Where(itemfilter =>
        {
            return (filter.Firstname is null || filter.Firstname == itemfilter.FirstName) &&
                   (filter.Lastname is null || filter.Lastname == itemfilter.LastName);
        }).ToList();
        return filteredusers;
    }

    public User Add(string firstname, string lastName, string email)
    {
        if (_users.Any(x => x.Email == email))
        {
            throw new ArgumentException("Email already exists.");
        }
        var user = new User
        {
            Id = Guid.NewGuid(),
            FirstName = firstname,
            LastName = lastName,
            Email = email
        };
        _users.Add(user);
        return user;
    }

    public User Update(User user)
    {
        var existing = _users.FirstOrDefault(x => x.Id == user.Id);
        
        if (existing == null)
        {
            throw new ArgumentException("User not found");
        }

        existing.FirstName = user.FirstName;
        existing.LastName = user.LastName;
        existing.Email = user.Email;
        return existing;
    }

    public void Delete(Guid id)
    {
        var isdelete = _users.FirstOrDefault(u => u.Id == id);
        if (isdelete == null)
        {
            throw new ArgumentException("User not found");
        }

        isdelete.IsDeleted = true;
    }

}

