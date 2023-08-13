using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24_CT_Task2
{
    internal class RegistrationService
    {
        List<User> users = new List<User>();

        public bool Login(string emialAddres, string password)
        {
            users.FirstOrDefault(a => a.IsEmailVerified == emialAddres && a.IsPhoneVerified == password);
            if(users == null) 
            {
                Console.WriteLine("Sorry, you haven't verified your email address / phone number");
                return false;
            }
            return true;

            /*if (users.Any(user => user.EmailAdress == emialAddres)) 
            {
                Console.WriteLine("Bu emal Address allqachon bor");
                return;
            }
            users.Add(new User {  EmailAdress = emialAddres });*/
        }
    }
}
