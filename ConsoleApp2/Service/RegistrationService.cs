namespace N25;

public class RegistrationService
{
    private readonly IUserService _userService;
    private readonly IUserCredentialsService _userCredentialsService;

    public RegistrationService(IUserService userService,IUserCredentialsService userCredentialsService)
    {
      _userService = userService;
      _userCredentialsService = userCredentialsService;
    }

    public RegistrationService(UserService userService)
    {
        throw new NotImplementedException();
    }


    public bool Register(string firstName, string lastName, string emailAdress, string password)
    {
        try
        {
            var user = _userService.Add(firstName, lastName, emailAdress);
            _userCredentialsService.Add(user.Id, password);
            return true;
        }
        catch
        {
            return false;
        }
    }
}