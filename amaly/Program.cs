public class Program
{
    static void Main(string[] args)
    {
        EmailTemplateService emailTemplateService = new EmailTemplateService();
        emailTemplateService.Add($"Account Registration", "Hurmatli {{User}}, ushbu xabar sizni muvafaqqiyatl");
        emailTemplateService.Add($"Account Blocked", "Hurmatli {{User}}, ushbu xabar sizni akkountingiz bloklanganini bildirish uchun yuborildi");
        string userName = "Firdavs";
        string registrationemail = emailTemplateService.GetRegistrationTemplate(userName);
        string blokedemail = emailTemplateService.GetAccountBlockedTemplate(userName);
        Console.WriteLine(blokedemail);
        Console.WriteLine(registrationemail);
    }
}
public static class MessageConstants
{
    public const string UserName = "{{User}}";
}
public class EmailTemplate
{
    public string Subject { get; set; }
    public string Content { get; set; }
    public EmailTemplate(string subject, string content)
    {
        if (string.IsNullOrWhiteSpace(subject) && string.IsNullOrWhiteSpace(content))
        {
            throw new ArgumentNullException("subject va content bosh bolmasligi kerak: ");
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
        string userToken = MessageConstants.UserName;
        EmailTemplate registratsiyaqilingan = Templates.Find(t => t.Subject.Equals("Account Registration", StringComparison.OrdinalIgnoreCase));
        if (registratsiyaqilingan != null)
            return registratsiyaqilingan.Content.Replace(userToken, userName);
        else
            return null;
    }
    public string GetAccountBlockedTemplate(string userName)
    {
        string userToken = MessageConstants.UserName;
        EmailTemplate bloklangan = Templates.Find(t => t.Subject.Equals("Account Blocked", StringComparison.OrdinalIgnoreCase));
        if (bloklangan == null)
            return bloklangan.Content.Replace(userToken, userName);
        else
            return "good";
    }
}

