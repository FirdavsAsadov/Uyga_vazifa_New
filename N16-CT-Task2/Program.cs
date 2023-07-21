using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main()
    {
       TemperatureSensorService temperatureSensorService = new TemperatureSensorService();
        temperatureSensorService.Temperature = "gbjh";
        temperatureSensorService.Temperature = "gajh";
        temperatureSensorService.Temperature = "gbaaaaaajh";
        temperatureSensorService.Display();

    }
}
public class TemperatureSensorService
{
    private string _temperature;
    private List<string> lsits = new List<string>();
    public string Temperature
    {
        
        set
        {
             _temperature = value;
            lsits.Add(value);
        }
    }
    public void Display()
    {
        Console.WriteLine("Tempraturelar : ");
        foreach(var item in lsits)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("yuq");
    }
}

    
