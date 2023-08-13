using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace IMTIHON
{
    internal class RegistrationService
    {
   
        private List<User> Users ;
        List<string> errors = new List<string>();

        public RegistrationService()
        {
            Users = new List<User>();
            
        }
        public bool CheckName(string _firstName, string _lastName, string _midleName)
        {
            bool checking = true;
            const string pattern = "^[a-zA-Z'-]+$";
            Regex regex = new Regex(pattern);
            if(string.IsNullOrWhiteSpace(_firstName) || !regex.IsMatch(_firstName))
            {
                errors.Add("Ism Xato kiritdingiz qaytadan ro'yxatdan o'tishingizni so'raymiz");
                checking =  false;
            }

            if(string.IsNullOrWhiteSpace(_lastName) || !regex.IsMatch(_lastName))
            {
                errors.Add("Familya Xato kiritdingiz qaytadan ro'yxatdan o'tishingizni so'raymiz");
                checking =  false;
            }

            if(string.IsNullOrWhiteSpace(_midleName) || !regex
                
                
                .IsMatch(_midleName))
            {
                checking = false;
                errors.Add("Sharfingizni Xato kiritdingiz qaytadan ro'yxatdan o'tishingizni so'raymiz");               
            }
            return checking;
        }

        public bool CheckEmailAddres(string _emailAddres)
        {
            var check1 = true;
            const string pattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(_emailAddres))
            {
                errors.Add("Email Xato kiritdingiz qaytadan ro'yxatdan o'tishingizni so'raymiz");
                check1 =  false;
            }
            return check1;
        }


        public string GenerateUserName(string _firstName, string _lastName)
        {
            Random rnd = new Random();
            return  $"{_firstName.ToLower()}_{_lastName.ToLower()}.{rnd.Next(10,1000)}";
        }


        public bool Add(string _firstName, string _lastName, string _midleName, string _emailAddres, ref string userName)
        {
            bool check = true;
            bool checkemail = true;
            if(!CheckName(_firstName, _lastName, _midleName))
            {
                check = false;
            }

            if (!CheckEmailAddres(_emailAddres)) { checkemail = false; }

            foreach (var item in Users)
            {
                if (item.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase))
                {
                    userName = GenerateUserName(_firstName, _lastName);
                }
            }
            var returntyeee = true;
            if(check == true && checkemail == true)
            {
                return true;
            }
            else
            {
                return false;
            }
       }
        


        public void Register(string _firstName, string _lastName, string _midleName, string _emailAddres, string userName)
        {
            var USERS = Add(_firstName, _lastName, _midleName, _emailAddres, ref userName);
            if (USERS)
            {
                var newUser = new User(_firstName, _lastName, _midleName, _emailAddres, userName);
                if(SenEmail(_emailAddres, userName) == true)
                {
                    newUser.IsActive = true;
                }
                Users.Add(newUser);
                
            }
            else
            {
                foreach(var item in errors)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public bool SenEmail(string receiverEmail, string userName)
        {
            try
            {
                var CredintialAddress = "firdavsasadov200613@gmail.com";
                var CredintialPassword = "xvkfqnexvsnoqwdh";
                var mail = new MailMessage(CredintialAddress, receiverEmail);
                mail.Subject = "Siz muvaffaqyatli ro'yxatdan o'tdingiz";
                mail.Body = "Hurmatli {{User}}, siz sistemadan muvaffaqiyatli o'tdingiz Tabriklaymiz".Replace("{{User}}",userName);
                var smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new NetworkCredential(CredintialAddress, CredintialPassword);
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);
                
                return true;
            }
            catch
            {
                return false;
            }            
        }

        public void Display()
        {
            foreach (var user in Users)
            {
                Console.WriteLine(user);
            }
        }


    }


}
