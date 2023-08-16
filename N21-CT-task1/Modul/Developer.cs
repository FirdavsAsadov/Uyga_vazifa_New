using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_CT_task1.Modul
{



    internal class Developer : User
    {
        public Developer(string username, string password, string emailAddres, string rating) : base((int)UserRole.Developer, username, password, emailAddres, rating)
        {
            
        }
        public override string ToString()
        {
            return $"User Name - {Username}\nDeveloper Password - {Password}\nDeveloper Email - {Email}\nDeveloper Rating - {Rating}";
        }
    }
}
