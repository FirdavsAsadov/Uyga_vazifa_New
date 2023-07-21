using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class Email
{
    public string _to;
    public string _from;
    public string _subject;
    public string _email;

    public string _from_to
    {
        get { return _to; }
        set
        {
            string pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
            var rgex1 = new Regex(pattern);
            if (rgex1.IsMatch(value))
                _to = value;
            else
                throw new FormatException("To dagi email xato !!!");
        }
    }

    public string _from_from
    {
        get { return _from; }
        set
        {
            string pattern2 = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
            var rgex = new Regex(pattern2);
            if (rgex.IsMatch(value))
                _from = value;
            else
                throw new FormatException("From dagi email xato !!!");
            
        }
    }

    public string _from_subject
    {
        get { return _subject; }
        set
        {
            _subject = value;
            if (string.IsNullOrEmpty(value))
                throw new FormatException("Xato bosh kiritmang!!!");
            if (value.Length < 4)
                throw new FormatException("Kamida 4 ta harf yoz !!!");
        }
    }

    public string _from_email
    {
        get { return _email; }
        set
        {
            if (string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                throw new FormatException("Xato!!!");
            if (value.Length < 4)
                throw new FormatException("4 Tadan kop soz yoz ey inson");
            _email = value;
        }
    }
    public override string ToString()
    {
        return $"To: {_to}\nFrom: {_from}\nYuborigan Yozuv: {_subject}\nQaytarilgan Yozuv: {_email}";
    }
}
public static class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Email too = new Email();
            too._from_to = "mansurovj13@gmail.com";
            too._from_from = "toshmurodovj13@gmail.com";
            too._from_subject = "Hey you bro what's up";
            too._from_email = "I am very good how are you";
            Console.WriteLine(too);
        } catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
 