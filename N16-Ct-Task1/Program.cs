/*-email jo'natish uchun EmailService dan foydalaning 
- unda CredentialAddress va CredentialPassword init only propertylar bo'lsin
- methodlardan SendEmail( to ) methodi bo'lsin
- foydalanuvchidan email addresini so'rang
- kiritilgan email addressga "Siz muvaffaqiyatli registratsiyadan o'tdingiz" nomli email borsin

Example 

subject - Siz muvaffaqiyatli registratsiyadan o'tdingiz
body - "Hurmatli {{User}}, siz sistemadan muvaffaqiyatli o'tdingiz"*/

using System.Net.Mail;
using System.Net;
public class Program {
    static void Main()
    {
        emailService obj = new emailService("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
        Console.WriteLine("Ismingizni kiriting: ");
        var ism = Console.ReadLine();
        Console.WriteLine("Emailingizni kriting: ");
        var email = Console.ReadLine();
        obj.SendEmail(email, ism);
    }

}

public class emailService
{
    private string CredentialAddress { get; init; }
    private string CredentialPassword { get; init; }

    public emailService(string credentialAddres, string credintailPasword)
    {
        CredentialAddress = credentialAddres;
        CredentialPassword = credintailPasword;
    
    }

    public void SendEmail(string receiverEmail, string UserName)
    {
        var mail = new MailMessage(CredentialAddress, receiverEmail);
        mail.Subject = "Siz muvaffaqiyatli registratsiyadan o'tdingiz";
        mail.Body = "Hurmatli {{User}}, siz sistemadan muvaffaqiyatli o'tdingiz".Replace("{{User}}", UserName);

        var smtpClient = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server address and port
        smtpClient.Credentials = new NetworkCredential(CredentialAddress, CredentialPassword);
        smtpClient.EnableSsl = true;

        smtpClient.Send(mail);
    }

    
}

