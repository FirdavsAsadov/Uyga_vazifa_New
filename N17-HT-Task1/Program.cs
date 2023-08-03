using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        CarRentalManagementservice carRentalManager = new CarRentalManagementservice();
        CarRental bmw1 = new Bmw("X5");
        CarRental bmw2 = new Bmw("X6");
        CarRental bmw3 = new Bmw("X7");
        carRentalManager.Add(bmw1);
        carRentalManager.Add(bmw2);
        carRentalManager.Add(bmw3);
        CarRental audi1 = new Audi("Q6");
        CarRental audi2 = new Audi("Q7");
        CarRental audi3 = new Audi("T5");
        carRentalManager.Add(audi1);
        carRentalManager.Add(audi2);
        carRentalManager.Add(audi3);

        // Rent BMW X5 for 5 seconds
        //carRentalManager.Rent("Audi");
        //await Task.Delay(5000);
        //carRentalManager.Return(audi1.id, audi1.RentPricePerHour);


        var s = carRentalManager.Rent("BMW");
        await Task.Delay(4000);
        carRentalManager.Return(s);
        var b = carRentalManager.Rent("Audi");
        await Task.Delay(1000);
        carRentalManager.Return(b);

        // Calculate the balance
        carRentalManager.CalculateBalance();
    }
}

// The rest of your classes remain unchanged...

public abstract class CarRental
    {
        public CarRental(string brandName)
        {
            this.BrandName = brandName;
            this.id = Guid.NewGuid();
        }
        public bool IsRented { get; set; }
        public DateTime RentStartTime { get; set; }
        public decimal Balance { get; set; }

        public string BrandName { get; set; }
        public Guid id { get; set; }
        

}

public sealed class Bmw : CarRental
{
    public Bmw(string modelName) : base("BMW")
    {
        this.ModelName = modelName;
    }

    public static int RentPricePerHour { get; } = 30;
    public  string ModelName { get; }
}

public sealed class Audi : CarRental
{
    public Audi(string modelName) : base("Audi")
    {
        this.ModelName = modelName;
    }

    public static int RentPricePerHour { get; } = 20;
    public  string ModelName { get; }
}



public class CarRentalManagementservice
{
    public List<CarRental> Cars { get; private set; }

    public CarRentalManagementservice()
    {
         Cars = new List<CarRental>();

    }
    public void Add(CarRental Car) 
    {
        Cars.Add(Car);
    }
    

    public CarRental Rent(string brandName)
    {
        foreach (CarRental Car in Cars)
        {
            
            if (Car.BrandName == brandName)
            {
                Car.RentStartTime = DateTime.Now;
                Car.IsRented = true;
                return Car;
            }

        }
        Console.WriteLine("Mashina yo'q");
        return null;
    } 

    public void Return(CarRental car)
    {
        /*CarRental carId = Cars.Find(car => car.id == id);*/
        foreach (CarRental Car in Cars)
        {
            if (Car.id == car.id)
            {
                if (car.BrandName == "BMW")
                {
                    Car.IsRented = false;
                    var rentduration = (DateTime.Now - car.RentStartTime).TotalSeconds;
                    var seconds = (int)(rentduration);
                    Car.Balance += Bmw.RentPricePerHour * seconds;

                }
                else if (car is Audi)
                {
                    Car.IsRented = false;
                    var rentduration = (DateTime.Now - car.RentStartTime).TotalSeconds;
                    var seconds = (int)(rentduration);
                    Car.Balance += Audi.RentPricePerHour * seconds;
                }
                /*TimeSpan rentDuration = DateTime.Now - carId.RentStartTime;
                int seconds = (int) rentDuration.TotalSeconds;
                carId.Balance += renPrice * seconds;
                carId.IsRented = false;
                carId.RentStartTime = default(DateTime);*/
            }
            
        }
        
         
    }

    public void CalculateBalance()
    {
        decimal totalbalance = 0;
        foreach(var car in Cars)
        {
            totalbalance += car.Balance;
        }
        Console.WriteLine($"Barcha moshinlarning jami Balance miqdori {totalbalance}");
    }
}