using System.Text.RegularExpressions;

var Emails = new List<string>();
Emails.Add("john.doe@example.com");
Emails.Add("jane.smith@company.co.uk");
Emails.Add("info@domain");
Emails.Add("invalid-email");
Emails.Add("missing@domain.");
var emailadress = new Regex("^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$");
foreach (var email in Emails)
{
    if (emailadress.IsMatch(email))
    {
        Console.WriteLine(email + " \nValid");
    }
    else 
    {
        Console.WriteLine(email + " \nInvalid");
    }
}