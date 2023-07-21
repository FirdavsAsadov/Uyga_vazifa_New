using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Program
{
    public static void Main()
    {
    PasswordGenerate passwordGenerate = new PasswordGenerate(length: 10, hasletters: true, hasdigit: true);
    string paswordgnerator = passwordGenerate.Generate();
    Console.WriteLine("Generated Password: " + paswordgnerator);

        SecurePasswordGenerate securePasswordGenerate = new SecurePasswordGenerate(length: 12, hasletters: true, hasdigit: true, hassymbols: true);
        string generatedpassword = securePasswordGenerate.Generate(hassymbols: true);
        Console.WriteLine("Secure Generated Passwor: " + generatedpassword);

        UniquePasswordGenerate uniquePasswordGenerate = new UniquePasswordGenerate(12, true, true, true);
        for(var i = 0; i < 5; i++)
        {
            string generateduniquepassword = uniquePasswordGenerate.GenerateUniquePassword();
            Console.WriteLine("Generated unique password: " + generatedpassword);
        }
    }
}




public class PasswordGenerate
{
    public const string Letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public const string digits = "0123456789";

    public int Length { get; set; }
    public bool Hasletters { get; set; }
    public bool Hasdigit { get; set; }

    public bool Hassymbols { get; set; }


    
    public PasswordGenerate(int length, bool hasletters, bool hasdigit = false)
    {
        Length = length;
        Hasletters = hasletters;
        Hasdigit = hasdigit;
        
    }
    public string Generate()
    {
        if(!Hasletters && !Hasdigit)
        {
            throw new ArgumentException("HasLetters yoki Hasdigits kamida bittasi to'g'ri bo'lishi kerak!!!");
        }
        string validchars = Hasletters ? Letters : string.Empty;
        validchars += Hasdigit ? digits : string.Empty;
        if(validchars.Length == 0)
        {
            throw new ArgumentException("HasLetters yoki Hasdigits kamida bittasi to'g'ri bo'lishi kerak!!!");
        }
        Random random = new Random();
        StringBuilder stringBuilder = new StringBuilder();

        for(int i = 0; i < Length; i++)
        {
            int index = random.Next(validchars.Length);
            stringBuilder.Append(validchars[index]);
        }
        return stringBuilder.ToString();
    }
}

public class SecurePasswordGenerate : PasswordGenerate
{
    public const string Symbols = "!@#$%^&*()-_=+[]{}|;:,.<>?";
    public SecurePasswordGenerate(int length, bool hasletters, bool hasdigit , bool hassymbols) 
        : base(length, hasletters, hasdigit )
    {
        Hassymbols = hassymbols;
        
    }



    public string Generate(bool hassymbols)
    {
        if(!Hasletters && !Hasdigit && !hassymbols)
        {
            throw new ArgumentException("HasLetters yoki Hasdigits  yoki Hassymbols kamida bittasi to'g'ri bo'lishi kerak!!!");
        }
        string validchars = Hasletters ? Letters : string.Empty;
        validchars += Hasdigit ? digits : string.Empty;
        validchars += Hassymbols ? Symbols : string.Empty;
        if (validchars.Length == 0)
            
        if (validchars.Length == 0)
        {
            Console.WriteLine("HasLetters yoki Hasdigits yoki HasSymbols kamida bittasi to'g'ri bo'lishi kerak!!!");
        }
        Random random = new Random();
        StringBuilder stringBuilder = new StringBuilder();
        for(int i = 0; i < Length; i++)
        {
            int index = random.Next(validchars.Length);
            stringBuilder.Append(validchars[index]);
        }

        
        return stringBuilder.ToString();

    }
}

public class UniquePasswordGenerate : SecurePasswordGenerate
{
    public List<string> passwords = new List<string>();
    

    public UniquePasswordGenerate(int length, bool hasletters, bool hasdigit, bool hassymbols) : base(length, hasletters, hasdigit, hassymbols)
    {
    }
    public string GenerateUniquePassword()
    {
        
        while (true)
        {
            var pass = Generate();
            if (passwords.Contains(pass))
            {
                passwords.Add(pass);
                return pass;
            }
        }
    }
}

