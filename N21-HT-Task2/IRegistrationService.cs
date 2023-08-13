using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT_Task2
{
    internal interface IRegistrationService
    {
        void Register(string _firstName, string _lastName, string _midleName, string _emailAddres, string userName);
    }
}
