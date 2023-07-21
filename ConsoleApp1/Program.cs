using System.ComponentModel;
public class Program
{
    static void Main()
    {
        SpaceShip spaceShip = new SpaceShip()
        {
            speed = "100k/mh",
            Trajectory = "gayrat"
        };

        Console.WriteLine($"{spaceShip.speed} ");
    }
}

public class SpaceShip
{
    public string Name { get; init; } = "";
    public SpaceShip()
    {
        
    }

    private readonly string _fuel;
    public string Fuel { get => _fuel; }

    public string speed { get; set; }

    private string _trajectory;
    public string Trajectory
    {
        set => _trajectory = value;
    }
}



      /*  Spaceship modelidan foydalaning
        
        unda quyidagi propertylar bo'lsin
        - Name - nomi ( init-only )
        -Fuel - yoqilg'i miqdori ( read-only )
        - Speed - tezligi(read - write)
        - Trajectory - trayektoriyasi(write - only)
        
        - bitta object yarating, speed va trajectory ni har xil qiymatlarga
            o'zgartirib ekranga chiqaring*/