public class Temperature
{
    public int Expected { get; set; }
    public int Current { get; set; }
}

public class SmartHomeService
{
    private bool _isActivated = false;
    public bool IsActivated { get => _isActivated; }
    public string DeviceName { get; init; }

    private Temperature temperature = new Temperature();

    public SmartHomeService(string deviceName)
    {
        DeviceName = deviceName;
    }

    public void Activate()
    {
        _isActivated = t
            rue;
        Console.WriteLine($"SmartHome is activated. Device name: {DeviceName}");
    }

    public int CurrentTemperature
    {
        set
        {
            if (IsActivated)
            {
                temperature.Current = value;
            }
            else
            {
                Console.WriteLine("SmartHome is not activated yet. Please activate first.");
            }
        }
    }

    public int ExpectedTemperature
    {
        get { return temperature.Expected; }
        set
        {
            temperature.Expected = value;
        }
    }

    public void DisplayHomeTemperature()
    {
        Console.WriteLine($"Expected - {ExpectedTemperature}, Current - {temperature.Current}");
    }
}

public class Program
{
    public static void Main()
    {
        SmartHomeService smartHome = new SmartHomeService("MyHome");

        smartHome.Activate();

        smartHome.ExpectedTemperature = 20;
        smartHome.CurrentTemperature = 22;
        smartHome.DisplayHomeTemperature();

        smartHome.CurrentTemperature = 23;
        smartHome.DisplayHomeTemperature();

        smartHome.CurrentTemperature = 21;
        smartHome.DisplayHomeTemperature();

        smartHome.CurrentTemperature = 20;
        smartHome.DisplayHomeTemperature();

        smartHome.ExpectedTemperature = 25;
        smartHome.DisplayHomeTemperature();

        smartHome.CurrentTemperature = 21;
        smartHome.DisplayHomeTemperature();

        smartHome.CurrentTemperature = 22;
        smartHome.DisplayHomeTemperature();

        smartHome.CurrentTemperature = 23;
        smartHome.DisplayHomeTemperature();


    }
}