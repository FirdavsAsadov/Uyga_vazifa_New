using System.Dynamic;
using N25;


public interface IUserService
{
   List<User> Get(int pageSize, int pageToken);
   List<User> Search(string searchkeyword, int pageSize, int pageToken);
   List<User> Filter(UserFilterModel userFilterModel);
   User Add(string firstName, string lastName, string emailAddress);
   User Update(User user);
   void Delete(Guid id);
}