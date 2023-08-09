using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_CT_task1.Modul
{


    internal class Developer : User
    {
        public Developer(string username, string password, string emailAddres) : base((int)UserRole.ProjectManager, username, password, emailAddres)
        {
            
        }
    }
}
