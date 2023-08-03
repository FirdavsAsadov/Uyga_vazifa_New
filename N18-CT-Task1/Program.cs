using System.Diagnostics;

public class Program
{
    static void Main()
    {
        var obj = new Malibu("Jack", 2023, 5, "Black", 260);
        obj.Show();
        var obj2 = new Captiva("Premier", 2023, 7, "Red", 260);
        obj2.Show();

        Thread tread1 = new Thread(obj.Drive);
        Thread tread2 = new Thread(obj2.Drive);

        tread1.Start();
        tread2.Start();

        tread1.Join();
        tread2.Join();
    }
}


public abstract class Car
{
    public Car(string brand, int year, string color)
    {
        Brand = brand;
        Year = year;
        Color = color;
    }
    public string Brand { get; init; }
    public int Year { get; init; }
    public string Color { get; set; }

    public virtual void Show()
    {

    }
    public abstract void Drive();
    
}

public class Malibu : Car
{
    public byte Passengers;

    public int MaxSpeed;

    public Malibu(string brand, int year,byte passengers,string color, int maxspeed) : base(brand, year, color)
    {

        Passengers = passengers;
        MaxSpeed = maxspeed;
    }
    public override void Show()
    {
        Console.WriteLine( $"Color: {Color} \nBrand: {Brand} \nYear {Year} \nPassengers: {Passengers} \nMaxSpeed: {MaxSpeed}");
    }
    public override void Drive()
    {
        Stopwatch sw = Stopwatch.StartNew();
        int startSpeed = 0;
        int maxSpeed = 100;
        var rd = new Random();
        sw.Start();
        while(startSpeed < maxSpeed)
        {
            startSpeed += rd.Next(0,10);
            Thread.Sleep(500);
            Console.WriteLine($"Malibu {startSpeed}");
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds / 1000);
    }


}

public class Captiva : Car
{
    public byte Passengers;

    public int MaxSpeed;

    public Captiva(string brand, int year,byte passengers, string color, int maxspeed) : base(brand, year, color)
    {
        Passengers= passengers;
        MaxSpeed = maxspeed;
    }
    public override void Show()
    {
        Console.WriteLine($"Color: {Color} \nBrand: {Brand} \nYear {Year} Passengers: {Passengers} MaxSpeed: {MaxSpeed}");
    }
    public override void Drive()
    {
        Stopwatch sw = new Stopwatch();
        int startSpeed = 0;
        int maxSpeed = 100;
        var rd = new Random();
        sw.Start();
        while (startSpeed < maxSpeed)
        {
            startSpeed += rd.Next(0,10);
            Thread.Sleep(500);
            Console.WriteLine($"Captiva {startSpeed}");
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds / 1000);

    }
}

