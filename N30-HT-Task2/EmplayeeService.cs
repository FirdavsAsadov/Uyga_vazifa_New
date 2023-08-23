using System.Net;
using System.Net.Mail;
using System.Text;
namespace N30_HT_Task2;

public class EmplayeeService
{
    List<string> emailAddresses = new List<string>
    {
        "jasurabdulxaev@gmail.com",
        "abdura52.uz@gmail.com",
        "toshmurodovj13@gmail.com",
        "kbunyod3011@gmail.com",
        "azamamonov555@gmail.com",
        "abdurahmonsadriddinov0412@gmail.com",
    };

    public async Task HireAsync(string firstName, string lastName, string email)
    {
        var emailService = new EmailService();
        var emplyee = new Employee
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            LastName = lastName,
            Email = email
        };
        //Priority1
        await SendEmailAsync(emplyee);
        //Priority2
        await CreateFile(emplyee);
        //Priority3
        await SendWelcomeOnboard(emplyee);
        //Priority4
        await SendPoliceOfficeEmail(emplyee);
        
    }
    private async Task CreateFile(Employee employee)
    {
        string contractText = GenerateContractText(employee);
        string contractFilename = $"{employee.FirstName} {employee.LastName}'s empliement contract.docs";
        using (StreamWriter writer = new StreamWriter(contractFilename))
        {
            await writer.WriteAsync(contractText);
        }
    }
    private string GenerateContractText(Employee employee)
    {
        string contractText = $"Employment Contract for {employee.FirstName} {employee.LastName}\n...";
        return contractText;
    }

    private async Task SendWelcomeOnboard(Employee employee)
    {
        var emailService = new EmailService();
        var emailAddress = emailAddresses.Select(emailAddresses => Task.Run(() =>
        {
            var result = emailService.SendAsync(emailAddresses, "Welcome to G'ishtmat Books", $"Dear {employee.FirstName} {employee.LastName}: We are thrilled to welcome you! " +
                $"We are excited to have you on board " +
                $"and look forward to working with you.As a new member of our team, we want to make " +
                $"sure you have everything you need to get started. Please let us " +
                $"know if you have any questions or need any assistance.We wish you all the best in your new role and look forward to " +
                $"your contributions to our team");
            Console.WriteLine($"{emailAddresses} ga Welcome on board email yuborildi - {result}");
            return result;
        }));
        await Task.WhenAll(emailAddress);
    }

    private async Task SendPoliceOfficeEmail(Employee employee)
    {
        var emailService = new EmailService();
        var emailAddress = emailAddresses.Select(emailAddresses => Task.Run(() =>
        {
            var result = emailService.SendAsync(emailAddresses, "Office Policies and Guidelines", $"Dear {employee.FirstName} {employee.LastName}: As a member of our team, it is important that " +
                $"you are aware of our office policies and guidelines. " +
                $"These policies are designed to ensure a safe and productive work environment for everyone.Please take a moment to review the attached " +
                $"document, which outlines " +
                $"our policies and guidelines. If you have any questions or concerns, " +
                $"please do not hesitate to reach out to us.Thank you for your cooperation " +
                $"and adherence to our policies.Best regards ");
            Console.WriteLine($"{emailAddresses} Police email yuborildi - {result}");
            return result;
        }));
        await Task.WhenAll(emailAddress);
    }

    private async Task SendEmailAsync(Employee employee)
    {
        var emailService = new EmailService();
        var emailAddress = emailAddresses.Select(emailAddresses => Task.Run(() =>
        {
            var result = emailService.SendAsync(emailAddresses, "Salom Garry", $"{employee.FirstName} {employee.LastName}: HI BARBE");
            Console.WriteLine($"{emailAddresses} ga email yuborildi - {result}");
            return result;
        }));
        await Task.WhenAll(emailAddress);
    }

}