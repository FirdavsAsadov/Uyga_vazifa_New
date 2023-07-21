public class Program
{
    static void Main()
    {
        EmailTemplateService emailTemplateService = new EmailTemplateService();
        emailTemplateService.Add($"Account Registration", " Hurmatli {{User}}, ushbu xabar sizni muvafaqqiyatli ro'yxatdan o'tganligingizni bildirish uchun yuborildi");
        emailTemplateService.Add($"Account Blocked", "Hurmatli {{User}}, ushbu xabar sizni akkountingiz bloklanganini bildirish uchun yuborildi");
        string username = "Firdavs";
        string registrationMessage = emailTemplateService.GetRegistrationTemplate(username);
        Console.WriteLine("Account Registration email: ");
        Console.WriteLine(registrationMessage);
    }
}

public static class MessageConstants
{
    public const string UserToken = "{{User}}";
}

public class EmailTemplate
{
    public string Subject { get; set; }
    public string Content { get; set; }


    public EmailTemplate(string subject, string content)
    {
        if (string.IsNullOrWhiteSpace(subject) && string.IsNullOrWhiteSpace(content))
        {
            throw new ArgumentException("subject va content bosh bo'lmasligi kerak!!");
        }
        Subject = subject;
        Content = content;

    }
}



public class EmailTemplateService
{
    List<EmailTemplate> Templates = new List<EmailTemplate>();


    public void Add(string subject, string content)
    {
        Templates.Add(new EmailTemplate(subject, content));
    }

    public string GetRegistrationTemplate(string userName)
    {
        string userToken = MessageConstants.UserToken;
        EmailTemplate registrationemail = Templates.Find(t => t.Subject.Equals("Account Registration", StringComparison.OrdinalIgnoreCase));
        if (registrationemail != null)
        {
            return registrationemail.Content.Replace(userToken, userName);
        }
        else
            return null;
            
    }
}

