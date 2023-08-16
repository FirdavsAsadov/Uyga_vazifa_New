using System.Text.RegularExpressions;

namespace N25;

public class UserCredentialsService : IUserCredentialsService
{
    private List<UserCredentials> _credentials = new List<UserCredentials>();

    public UserCredentials Add(Guid userId, string password)
    {
        const string pattern = @"(?i)^(?=[a-z])(?=.*[0-9])([a-z0-9!@#$%\^&*()_?+\-=]){8,15}$";
        Regex regex = new Regex(pattern);
        if (regex.IsMatch(password))
        {
            var userCredentials = new UserCredentials
            {
                UserId = userId,
                Password = password
            };
            _credentials.Add(userCredentials);
            return userCredentials;
        }
        else
        {
            throw new ArgumentException(
                "Password must be at least 8 characters long and contain at least one number and one uppercase letter");
        }
    }

    public UserCredentials GetByUserId(Guid userId)
    {
        return (_credentials.Any(x => x.UserId == userId)
            ? _credentials.Find(x => x.UserId == userId)
            : null) ?? throw new ArgumentException();
    }

}         