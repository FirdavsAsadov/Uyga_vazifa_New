using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_CT_task1.Modul
{
    public enum UserRole
    {
        ProjectManager,
        Developer
    }
    internal class User : IUser
    {
       /* private static User _defaultAdmin;
         public static User GetDefaultAdmin()
         {
             if (_defaultAdmin == null)
                 _defaultAdmin = new User();
             return _defaultAdmin;
         }*/
        public User(byte roleID, string username, string password, string emailAddres, string rating)
        {
            Username = username;
            Password = password;
            Email = emailAddres;
            RoleId = roleID;
            Rating = rating;
        }
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Login { get; set; }
        public byte RoleId { get; set; }
        public string Password { get; set; }
        public string Rating { get; set; }


        public string Email { get; set; }

        public readonly List<Project> AssignedProjects;
        public readonly List<string> Comments;

        public void Add(User user)
        {
            Add(user);
        }

        public User AuthenticateUser(string login, string password, User user)
        {
            return null;
        }
    }
}
