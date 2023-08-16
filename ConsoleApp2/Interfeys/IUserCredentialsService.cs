using N25;

public interface IUserCredentialsService
{
    UserCredentials Add(Guid userId, string password);
    UserCredentials GetByUserId(Guid userId);
}