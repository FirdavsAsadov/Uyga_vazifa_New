using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_HT_task2
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public User(string firstName, string lastName, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = emailAddress;
        }
    }
}
