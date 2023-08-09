using N21_CT_task1.Modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_CT_task1
{
    internal interface IUser
    {
        void Add(User user);
        User AuthenticateUser(string login, string password, User user);
    }
}
