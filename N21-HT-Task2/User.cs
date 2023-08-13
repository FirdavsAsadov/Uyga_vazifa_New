using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMTIHON
{
    internal class User
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string MidleName { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public bool IsActive { get; set; }

        public User() { }
        public User(string _firstName, string _lastName, string _midleName, string _emailAddres, string userName)
        {
            FirstName = _firstName;
            LastName = _lastName;
            MidleName = _midleName;
            Email = _emailAddres;
            UserName = userName;
        }
        public override string ToString()
        {
            return $"Ism: {FirstName}, \nFamilya: {LastName}, \nSharif: {MidleName}, \nEmail: {Email}, \nUsername: {UserName}, \nAktiv: {IsActive}";
        }
    }

    
    
}
